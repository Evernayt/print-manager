using System;
using System.IO;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_Manager
{
    public partial class fmRename : Form
    {
        private string currentPrinterFullName = "";
        private string currentPrinterShortName = "";
        private string networkPath = "";

        public fmRename(string printerFullName)
        {
            currentPrinterFullName = printerFullName;
            currentPrinterShortName = GetPrinterShortName(printerFullName);
            networkPath = printerFullName.Replace(currentPrinterShortName, "");
            InitializeComponent();
            lblCurrentName.Text = "Текущее имя: " + currentPrinterShortName;
            tbxName.Text = currentPrinterShortName;
        }

        private string GetPrinterShortName(string printerFullName)
        {
            return Path.GetFileName(printerFullName);
        }

        private async void RenamePrinter(string sPrinterName, string newName)
        {
            try
            {
                Loader(true);

                await Task.Run(() =>
                {
                    ManagementScope oManagementScope = new ManagementScope(ManagementPath.DefaultPath);
                    oManagementScope.Connect();

                    SelectQuery oSelectQuery = new SelectQuery();
                    oSelectQuery.QueryString = @"SELECT * FROM Win32_Printer WHERE Name = '" + sPrinterName.Replace("\\", "\\\\") + "'";

                    ManagementObjectSearcher oObjectSearcher =
                       new ManagementObjectSearcher(oManagementScope, oSelectQuery);
                    ManagementObjectCollection oObjectCollection = oObjectSearcher.Get();

                    if (oObjectCollection.Count != 0)
                    {
                        foreach (ManagementObject oItem in oObjectCollection)
                        {
                            oItem.InvokeMethod("RenamePrinter", new object[] { newName });
                            return;
                        }
                    }
                });

                Loader(false);
                Close();
            }
            catch
            {
                Loader(false);
                MessageBox.Show("Не удалось переименовать принтер!", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string newPrinterName = tbxName.Text;
            if (newPrinterName == currentPrinterShortName)
            {
                Close();
            }
            else if (newPrinterName != "")
            {
                string fullPrinterName = networkPath + newPrinterName;
                RenamePrinter(currentPrinterFullName, fullPrinterName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loader(bool isShowing)
        {
            lblNewName.Text = "Новое имя: " + tbxName.Text;
            pInfo.Visible = isShowing;
        }
    }
}
