using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;
using System.Printing;
using System.Management;
using System.ServiceProcess;
using System.ComponentModel;
using Print_Manager.Properties;

namespace Print_Manager
{
    public partial class fmMain : Form
    {
        private string printerNameValue;
        private string[] virtualPrinters;
        private string[] laserPrinters;
        private string[] plotters;

        public fmMain()
        {
            InitializeComponent();
        }

        private void PrintUI(string arg, string printerName)
        {
            Process.Start("RunDll32.exe", $"Printui.dll,PrintUIEntry /{ arg } /n \"{ printerName }\"");
        }

        private bool DeleteLocalPrinter(string PrinterName)
        {
            try
            {
                PrintUI("dl /n", PrinterName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static void SpotTroubleUsingQueueAttributes(ref string statusReport, PrintQueue pq)
        {
            if ((pq.QueueStatus & PrintQueueStatus.PaperProblem) == PrintQueueStatus.PaperProblem)
                statusReport += "Проблемы с бумагой";
            else if ((pq.QueueStatus & PrintQueueStatus.NoToner) == PrintQueueStatus.NoToner)
                statusReport += "Закончился тонер (краска)";
            else if ((pq.QueueStatus & PrintQueueStatus.DoorOpen) == PrintQueueStatus.DoorOpen)
                statusReport += "Открыта крышка";
            else if ((pq.QueueStatus & PrintQueueStatus.Error) == PrintQueueStatus.Error)
                statusReport += "В состоянии ошибки";
            else if ((pq.QueueStatus & PrintQueueStatus.ServerUnknown) == PrintQueueStatus.ServerUnknown)
                statusReport += "В состоянии ошибки";
            else if ((pq.QueueStatus & PrintQueueStatus.NotAvailable) == PrintQueueStatus.NotAvailable)
                statusReport += "Недоступен";
            else if ((pq.QueueStatus & PrintQueueStatus.Offline) == PrintQueueStatus.Offline)
                statusReport += "Отключен";
            else if ((pq.QueueStatus & PrintQueueStatus.OutOfMemory) == PrintQueueStatus.OutOfMemory)
                statusReport += "Недостаточно памяти";
            else if ((pq.QueueStatus & PrintQueueStatus.PaperOut) == PrintQueueStatus.PaperOut)
                statusReport += "Закончилась бумага";
            else if ((pq.QueueStatus & PrintQueueStatus.OutputBinFull) == PrintQueueStatus.OutputBinFull)
                statusReport += "Выходной лоток заполнен";
            else if ((pq.QueueStatus & PrintQueueStatus.PaperJam) == PrintQueueStatus.PaperJam)
                statusReport += "Замятие бумаги";
            else if ((pq.QueueStatus & PrintQueueStatus.Paused) == PrintQueueStatus.Paused)
                statusReport += "Приостановлен";
            else if ((pq.QueueStatus & PrintQueueStatus.TonerLow) == PrintQueueStatus.TonerLow)
                statusReport += "Мало тонера (краски)";
            else if ((pq.QueueStatus & PrintQueueStatus.UserIntervention) == PrintQueueStatus.UserIntervention)
                statusReport += "Требуется вмешательство пользователя";
            else if ((pq.QueueStatus & PrintQueueStatus.Busy) == PrintQueueStatus.Busy)
                statusReport += "Занят";
            else if ((pq.QueueStatus & PrintQueueStatus.Printing) == PrintQueueStatus.Printing)
                statusReport += "Печатает";
            else if ((pq.QueueStatus & PrintQueueStatus.Waiting) == PrintQueueStatus.Waiting)
                statusReport += "Ожидает задания на печать";
            else if ((pq.QueueStatus & PrintQueueStatus.PowerSave) == PrintQueueStatus.PowerSave)
                statusReport += "Находится в режиме энергосбережения";
            else if ((pq.QueueStatus & PrintQueueStatus.IOActive) == PrintQueueStatus.IOActive)
                statusReport += "Обменивается данными с сервером печати";
            else if ((pq.QueueStatus & PrintQueueStatus.Initializing) == PrintQueueStatus.Initializing)
                statusReport += "Инициализация";
            else if ((pq.QueueStatus & PrintQueueStatus.PagePunt) == PrintQueueStatus.PagePunt)
                statusReport += "Не удается напечатать текущую страницу";
            else if ((pq.QueueStatus & PrintQueueStatus.PendingDeletion) == PrintQueueStatus.PendingDeletion)
                statusReport += "Идет удаление задания из очереди печати";
            else if ((pq.QueueStatus & PrintQueueStatus.None) == PrintQueueStatus.None)
                statusReport += "Готов";
        }

        private void CellColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "Отключен")
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                else if (row.Cells["Status"].Value.ToString() == "В состоянии ошибки")
                    row.DefaultCellStyle.ForeColor = Color.Maroon;
                else
                    row.Cells["Status"].Style.BackColor = Color.Empty;
            }
        }

        private void LoadPrintersToDVG()
        {
            dataGridView1.Rows.Clear();

            //List<PrinterSettings> printerSettings = new List<PrinterSettings>();
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printer = new PrinterSettings();
                printer.PrinterName = printerName;

                if (printer.IsValid)
                {
                    string printerIsDefault = "";
                    string PrinterJobsCount = "";
                    string PrinterStatus = "";
                    string statusReport = "";
                    string pName = Path.GetFileName(printerName); // очистка от сетевого пути

                    PrintQueueCollection myPrintQueues = new PrintServer().GetPrintQueues();
                    foreach (PrintQueue pq in myPrintQueues)
                    {
                        if (printerName == pq.Name)
                        {
                            if (printer.IsDefaultPrinter)
                                printerIsDefault = "✔";

                            PrinterJobsCount = pq.NumberOfJobs.ToString();

                            SpotTroubleUsingQueueAttributes(ref statusReport, pq);
                            PrinterStatus = statusReport;

                            string PrinterHost = pq.HostingPrintServer.Name;
                        }
                    }

                    bool isLaserPrinter = false;
                    if (tsmiHideLaserPrinters.Checked)
                    {
                        foreach (string laserPrinter in laserPrinters)
                        {
                            if (pName.ToLower().Contains(laserPrinter))
                                isLaserPrinter = true;
                        }
                    }

                    bool isPlotter = false;
                    if (tsmiHidePlotters.Checked)
                    {
                        foreach (string plotter in plotters)
                        {
                            if (pName.ToLower().Contains(plotter))
                                isPlotter = true;
                        }
                    }

                    bool isVirtualPrinter = false;
                    if (tsmiHideVirtualPrinters.Checked)
                    {
                        foreach (string virtualPrinter in virtualPrinters)
                        {
                            if (pName.ToLower().Contains(virtualPrinter))
                                isVirtualPrinter = true;
                        }
                    }

                    if ((!tsmiHidePlotters.Checked || !isPlotter) && (!tsmiHideLaserPrinters.Checked || !isLaserPrinter) && (!tsmiHideVirtualPrinters.Checked || !isVirtualPrinter))
                    {
                        int rowNum = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowNum].Cells[0].Value = pName;
                        dataGridView1.Rows[rowNum].Cells[1].Value = PrinterJobsCount;
                        dataGridView1.Rows[rowNum].Cells[2].Value = PrinterStatus;
                        dataGridView1.Rows[rowNum].Cells[3].Value = printerName;
                        dataGridView1.Rows[rowNum].Cells[4].Value = printerIsDefault;
                    }

                    CellColor();
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                }
            }
        }

        public static void RenamePrinter(string sPrinterName, string newName)
        {
            ManagementScope oManagementScope = new ManagementScope(ManagementPath.DefaultPath);
            oManagementScope.Connect();

            SelectQuery oSelectQuery = new SelectQuery
            {
                QueryString = @"SELECT * FROM Win32_Printer WHERE Name = '" + sPrinterName.Replace("\\", "\\\\") + "'"
            };

            ManagementObjectSearcher oObjectSearcher =
                new ManagementObjectSearcher(oManagementScope, oSelectQuery);
            ManagementObjectCollection oObjectCollection = oObjectSearcher.Get();

            if (oObjectCollection.Count == 0)
                return;

            foreach (ManagementObject oItem in oObjectCollection)
            {
                int state = (int)oItem.InvokeMethod("RenamePrinter", new object[] { newName });
                switch (state)
                {
                    case 0:
                        return;
                    case 1:
                        throw new AccessViolationException("Access Denied");
                    case 1801:
                        throw new ArgumentException("Invalid Printer Name");
                    default:
                        break;
                }
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            tsmiHideLaserPrinters.Checked = Settings.Default.HideLaserPrinters;
            tsmiHidePlotters.Checked = Settings.Default.HidePlotters;
            tsmiHideVirtualPrinters.Checked = Settings.Default.HideVirtualPrinters;

            ReadPrinters();
            LoadPrintersToDVG();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                PrintUI("o", dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void openPrintQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                PrintUI("o", printerNameValue);
        }

        private void useAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                PrintUI("y", printerNameValue);
                LoadPrintersToDVG();
            }
        }

        private void printATestPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                PrintUI("k", printerNameValue);
        }

        private void Notification(string message, Color color)
        {
            tslblNotifications.Text = message;
            tslblNotifications.ForeColor = color;
            timer1.Start();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                if (tstbxPrinterName.Text != "" && tstbxPrinterName.Text != "Введите имя")
                {
                    RenamePrinter(printerNameValue, tstbxPrinterName.Text);
                    LoadPrintersToDVG();
                    tstbxPrinterName.Text = "Введите имя";

                    Notification("Принтер успешно переименован", Color.Green);
                }
                else
                {
                    Notification("Введите имя", Color.Red);
                }
            }
        }

        private void tstbxPrinterName_MouseEnter(object sender, EventArgs e)
        {
            if (tstbxPrinterName.Text == "Введите имя")
            {
                tstbxPrinterName.Text = "";
                tstbxPrinterName.ForeColor = Color.Black;
            }
        }

        private void tstbxPrinterName_MouseLeave(object sender, EventArgs e)
        {
            if (tstbxPrinterName.Text == "")
            {
                tstbxPrinterName.Text = "Введите имя";
                tstbxPrinterName.ForeColor = Color.Gray;
            }
        }

        private void deletePrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                string message = "Вы действительно хотите удалить этот принтер?" + Environment.NewLine + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var result = MessageBox.Show(message, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    if (DeleteLocalPrinter(printerNameValue))
                        LoadPrintersToDVG();
                }
            }
        }

        private void printerPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                PrintUI("p", printerNameValue);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;
                printerNameValue = dataGridView1[3, e.RowIndex].Value.ToString();
                string printerDefaultValue = dataGridView1[4, e.RowIndex].Value.ToString();

                useAsDefaultToolStripMenuItem.Checked = printerDefaultValue != "";
            }
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            LoadPrintersToDVG();
        }

        private void tsmiReloadPrintServer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите перезагрузить сервер печати?", 
                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;

                Notification("Перезапуск сервера печати", Color.Blue);

                ServiceController service = new ServiceController("Spooler");
                if ((!service.Status.Equals(ServiceControllerStatus.Stopped)) &&
                    (!service.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                }

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running);

                Notification("Сервер печати перезагружен", Color.Green);

                Cursor = Cursors.Default;
            }
        }

        private void tsmiHideLaserPrinters_Click(object sender, EventArgs e)
        {
            if (tsmiHideLaserPrinters.Checked)
            {
                tsmiHideLaserPrinters.Checked = false;
                Settings.Default.HideLaserPrinters = false;
            }
            else
            {
                tsmiHideLaserPrinters.Checked = true;
                Settings.Default.HideLaserPrinters = true;
            }

            LoadPrintersToDVG();
            Settings.Default.Save();
        }

        private void tsmiHidePlotters_Click(object sender, EventArgs e)
        {
            if (tsmiHidePlotters.Checked)
            {
                tsmiHidePlotters.Checked = false;
                Settings.Default.HidePlotters = false;
            }
            else
            {
                tsmiHidePlotters.Checked = true;
                Settings.Default.HidePlotters = true;
            }

            LoadPrintersToDVG();
            Settings.Default.Save();
        }

        private void tsmiHideVirtualPrinters_Click(object sender, EventArgs e)
        {
            if (tsmiHideVirtualPrinters.Checked)
            {
                tsmiHideVirtualPrinters.Checked = false;
                Settings.Default.HideVirtualPrinters = false;
            }
            else
            {
                tsmiHideVirtualPrinters.Checked = true;
                Settings.Default.HideVirtualPrinters = true;
            }

            LoadPrintersToDVG();
            Settings.Default.Save();
        }

        private void tsmiClearPrintServerFolder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите очистить папку?\nЭто очистит очередь печати у всех принтеров!", 
                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    using (ServiceController service = new ServiceController("Spooler"))
                    {
                        if ((!service.Status.Equals(ServiceControllerStatus.Stopped)) &&
                            (!service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            service.Stop();
                            service.WaitForStatus(ServiceControllerStatus.Stopped);
                        }

                        string path = @"C:\Windows\system32\spool\PRINTERS";
                        Directory.Delete(path, true);
                        Directory.CreateDirectory(path);

                        Notification("Папка сервера очищена", Color.Green);

                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                    }

                    Cursor = Cursors.Default;
                }
                catch
                {
                    Notification("Не удалось очистить папку сервера", Color.Red);
                }
            }
        }

        private void tsmiDevicesAndPrinters_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe"); 
            Process.Start(controlpath, "/name Microsoft.DevicesAndPrinters");
        }

        private void printSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                PrintUI("e", printerNameValue);

        }

        private void fmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                LoadPrintersToDVG();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Notification("", Color.Empty);
        }

        private void installPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintUI("il", null);
        }

        private void ReadPrinters()
        {
            virtualPrinters = Settings.Default.VirtualPrinters.Split(',');
            plotters = Settings.Default.Plotters.Split(',');
            laserPrinters = Settings.Default.LaserPrinters.Split(',');
        }

        private void settingsToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fmSettings().ShowDialog();
            ReadPrinters();
            LoadPrintersToDVG();
        }
    }
}
