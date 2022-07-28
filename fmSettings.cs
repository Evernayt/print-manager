using Print_Manager.Properties;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Print_Manager
{
    public partial class fmSettings : Form
    {
        private string[] virtualPrinters;
        private string[] laserPrinters;
        private string[] plotters;

        public fmSettings()
        {
            InitializeComponent();
        }

        private void fmSettings_Load(object sender, EventArgs e)
        {
            ReadPrinters();
        }

        private void ReadPrinters()
        {
            dataGridView1.Rows.Clear();
            laserPrinters = Settings.Default.LaserPrinters.Split(',');
            virtualPrinters = Settings.Default.VirtualPrinters.Split(',');
            plotters = Settings.Default.Plotters.Split(',');

            int[] arr = { laserPrinters.Length, virtualPrinters.Length, plotters.Length };
            int maxIndex = arr.Max();

            for (int i = 0; i < maxIndex; i++)
            {
                string lp = null;
                string vp = null;
                string p = null;

                if (laserPrinters.Length > i)
                {
                    lp = laserPrinters[i];
                }

                if (virtualPrinters.Length > i)
                {
                    vp = virtualPrinters[i];
                }

                if (plotters.Length > i)
                {
                    p = plotters[i];
                }

                dataGridView1.Rows.Add(lp, vp, p);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string lp = "";
            string vp = "";
            string p = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    lp += row.Cells[0].Value + ",";
                }

                if (row.Cells[1].Value != null)
                {
                    vp += row.Cells[1].Value + ",";
                }

                if (row.Cells[2].Value != null)
                {
                    p += row.Cells[2].Value + ",";
                }
            }

            Settings.Default.LaserPrinters = lp.ToLower().Trim(',');
            Settings.Default.VirtualPrinters = vp.ToLower().Trim(',');
            Settings.Default.Plotters = p.ToLower().Trim(',');
            Settings.Default.Save();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string file = $"\\PrintManager Settings";

            using (StreamWriter streamWriter = new StreamWriter(path + file))
            {
                streamWriter.WriteLine(Settings.Default.LaserPrinters);
                streamWriter.WriteLine(Settings.Default.VirtualPrinters);
                streamWriter.WriteLine(Settings.Default.Plotters);
            }

            MessageBox.Show($"Экспорт завершен.\nФайл \"PrintManager Settings\" сохранен на рабочем столе.", Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string lp = "0";
            string vp = "1";
            string p = "2";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;
                    int index = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (index.ToString() == lp)
                        {
                            lp = line;
                            index++;
                        }
                        else if (index.ToString() == vp)
                        {
                            vp = line;
                            index++;
                        }
                        else
                        {
                            p = line;
                            index++;
                        }
                    }
                }

                Settings.Default.LaserPrinters = lp;
                Settings.Default.VirtualPrinters = vp;
                Settings.Default.Plotters = p;
                Settings.Default.Save();

                ReadPrinters();

                MessageBox.Show("Импорт завершен.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
