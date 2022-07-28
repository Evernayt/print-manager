namespace Print_Manager
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Printer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Default = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPrintQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.useAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printATestPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.renamePrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbxPrinterName = new System.Windows.Forms.ToolStripTextBox();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.printServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReloadPrintServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearPrintServerFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevicesAndPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.installPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHideLaserPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHidePlotters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHideVirtualPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblNotifications = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Printer,
            this.PrintQueue,
            this.Status,
            this.Default,
            this.PrinterFullName});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 504);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Printer
            // 
            this.Printer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printer.HeaderText = "Принтер";
            this.Printer.Name = "Printer";
            this.Printer.ReadOnly = true;
            // 
            // PrintQueue
            // 
            this.PrintQueue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrintQueue.HeaderText = "Очередь печати";
            this.PrintQueue.Name = "PrintQueue";
            this.PrintQueue.ReadOnly = true;
            this.PrintQueue.Width = 147;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Default
            // 
            this.Default.HeaderText = "Default";
            this.Default.Name = "Default";
            this.Default.ReadOnly = true;
            this.Default.Visible = false;
            this.Default.Width = 98;
            // 
            // PrinterFullName
            // 
            this.PrinterFullName.HeaderText = "PrinterFullName";
            this.PrinterFullName.Name = "PrinterFullName";
            this.PrinterFullName.ReadOnly = true;
            this.PrinterFullName.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPrintQueueToolStripMenuItem,
            this.toolStripSeparator1,
            this.useAsDefaultToolStripMenuItem,
            this.printATestPageToolStripMenuItem,
            this.toolStripSeparator2,
            this.renamePrinterToolStripMenuItem,
            this.deletePrinterToolStripMenuItem,
            this.toolStripSeparator3,
            this.printSettingsToolStripMenuItem,
            this.printerPropertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 176);
            // 
            // openPrintQueueToolStripMenuItem
            // 
            this.openPrintQueueToolStripMenuItem.Name = "openPrintQueueToolStripMenuItem";
            this.openPrintQueueToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.openPrintQueueToolStripMenuItem.Text = "Открыть очередь печати";
            this.openPrintQueueToolStripMenuItem.Click += new System.EventHandler(this.openPrintQueueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // useAsDefaultToolStripMenuItem
            // 
            this.useAsDefaultToolStripMenuItem.Name = "useAsDefaultToolStripMenuItem";
            this.useAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.useAsDefaultToolStripMenuItem.Text = "Использовать по умолчанию";
            this.useAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.useAsDefaultToolStripMenuItem_Click);
            // 
            // printATestPageToolStripMenuItem
            // 
            this.printATestPageToolStripMenuItem.Name = "printATestPageToolStripMenuItem";
            this.printATestPageToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.printATestPageToolStripMenuItem.Text = "Распечатать тестовую страницу";
            this.printATestPageToolStripMenuItem.Click += new System.EventHandler(this.printATestPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // renamePrinterToolStripMenuItem
            // 
            this.renamePrinterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbxPrinterName,
            this.renameToolStripMenuItem});
            this.renamePrinterToolStripMenuItem.Name = "renamePrinterToolStripMenuItem";
            this.renamePrinterToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.renamePrinterToolStripMenuItem.Text = "Переименовать принтер";
            // 
            // tstbxPrinterName
            // 
            this.tstbxPrinterName.ForeColor = System.Drawing.Color.Gray;
            this.tstbxPrinterName.Name = "tstbxPrinterName";
            this.tstbxPrinterName.Size = new System.Drawing.Size(200, 22);
            this.tstbxPrinterName.Text = "Введите имя";
            this.tstbxPrinterName.MouseEnter += new System.EventHandler(this.tstbxPrinterName_MouseEnter);
            this.tstbxPrinterName.MouseLeave += new System.EventHandler(this.tstbxPrinterName_MouseLeave);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.renameToolStripMenuItem.Text = "Переименовать";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deletePrinterToolStripMenuItem
            // 
            this.deletePrinterToolStripMenuItem.Name = "deletePrinterToolStripMenuItem";
            this.deletePrinterToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.deletePrinterToolStripMenuItem.Text = "Удалить принтер";
            this.deletePrinterToolStripMenuItem.Click += new System.EventHandler(this.deletePrinterToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // printSettingsToolStripMenuItem
            // 
            this.printSettingsToolStripMenuItem.Name = "printSettingsToolStripMenuItem";
            this.printSettingsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.printSettingsToolStripMenuItem.Text = "Настройка печати";
            this.printSettingsToolStripMenuItem.Click += new System.EventHandler(this.printSettingsToolStripMenuItem_Click);
            // 
            // printerPropertiesToolStripMenuItem
            // 
            this.printerPropertiesToolStripMenuItem.Name = "printerPropertiesToolStripMenuItem";
            this.printerPropertiesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.printerPropertiesToolStripMenuItem.Text = "Свойства принтера";
            this.printerPropertiesToolStripMenuItem.Click += new System.EventHandler(this.printerPropertiesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh,
            this.printServerToolStripMenuItem,
            this.tsmiDevicesAndPrinters,
            this.installPrinterToolStripMenuItem,
            this.filtresToolStripMenuItem,
            this.settingsToolStripMenuItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefresh.Image")));
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(89, 26);
            this.tsmiRefresh.Text = "Обновить";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // printServerToolStripMenuItem
            // 
            this.printServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReloadPrintServer,
            this.tsmiClearPrintServerFolder});
            this.printServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printServerToolStripMenuItem.Image")));
            this.printServerToolStripMenuItem.Name = "printServerToolStripMenuItem";
            this.printServerToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.printServerToolStripMenuItem.Text = "Сервер печати";
            // 
            // tsmiReloadPrintServer
            // 
            this.tsmiReloadPrintServer.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReloadPrintServer.Image")));
            this.tsmiReloadPrintServer.Name = "tsmiReloadPrintServer";
            this.tsmiReloadPrintServer.Size = new System.Drawing.Size(246, 22);
            this.tsmiReloadPrintServer.Text = "Перезагрузить сервер печати";
            this.tsmiReloadPrintServer.Click += new System.EventHandler(this.tsmiReloadPrintServer_Click);
            // 
            // tsmiClearPrintServerFolder
            // 
            this.tsmiClearPrintServerFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearPrintServerFolder.Image")));
            this.tsmiClearPrintServerFolder.Name = "tsmiClearPrintServerFolder";
            this.tsmiClearPrintServerFolder.Size = new System.Drawing.Size(246, 22);
            this.tsmiClearPrintServerFolder.Text = "Очистить папку сервера печати";
            this.tsmiClearPrintServerFolder.Click += new System.EventHandler(this.tsmiClearPrintServerFolder_Click);
            // 
            // tsmiDevicesAndPrinters
            // 
            this.tsmiDevicesAndPrinters.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDevicesAndPrinters.Image")));
            this.tsmiDevicesAndPrinters.Name = "tsmiDevicesAndPrinters";
            this.tsmiDevicesAndPrinters.Size = new System.Drawing.Size(161, 26);
            this.tsmiDevicesAndPrinters.Text = "Устройства и принтеры";
            this.tsmiDevicesAndPrinters.Click += new System.EventHandler(this.tsmiDevicesAndPrinters_Click);
            // 
            // installPrinterToolStripMenuItem
            // 
            this.installPrinterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("installPrinterToolStripMenuItem.Image")));
            this.installPrinterToolStripMenuItem.Name = "installPrinterToolStripMenuItem";
            this.installPrinterToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.installPrinterToolStripMenuItem.Text = "Установка принтера";
            this.installPrinterToolStripMenuItem.Click += new System.EventHandler(this.installPrinterToolStripMenuItem_Click);
            // 
            // filtresToolStripMenuItem
            // 
            this.filtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHideLaserPrinters,
            this.tsmiHidePlotters,
            this.tsmiHideVirtualPrinters});
            this.filtresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtresToolStripMenuItem.Image")));
            this.filtresToolStripMenuItem.Name = "filtresToolStripMenuItem";
            this.filtresToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.filtresToolStripMenuItem.Text = "Фильтры";
            // 
            // tsmiHideLaserPrinters
            // 
            this.tsmiHideLaserPrinters.Name = "tsmiHideLaserPrinters";
            this.tsmiHideLaserPrinters.Size = new System.Drawing.Size(242, 22);
            this.tsmiHideLaserPrinters.Text = "Скрыть лазерные принтеры";
            this.tsmiHideLaserPrinters.Click += new System.EventHandler(this.tsmiHideLaserPrinters_Click);
            // 
            // tsmiHidePlotters
            // 
            this.tsmiHidePlotters.Name = "tsmiHidePlotters";
            this.tsmiHidePlotters.Size = new System.Drawing.Size(242, 22);
            this.tsmiHidePlotters.Text = "Скрыть плоттеры";
            this.tsmiHidePlotters.Click += new System.EventHandler(this.tsmiHidePlotters_Click);
            // 
            // tsmiHideVirtualPrinters
            // 
            this.tsmiHideVirtualPrinters.Name = "tsmiHideVirtualPrinters";
            this.tsmiHideVirtualPrinters.Size = new System.Drawing.Size(242, 22);
            this.tsmiHideVirtualPrinters.Text = "Скрыть виртуальные принтеры";
            this.tsmiHideVirtualPrinters.Click += new System.EventHandler(this.tsmiHideVirtualPrinters_Click);
            // 
            // settingsToolStripMenuItemToolStripMenuItem
            // 
            this.settingsToolStripMenuItemToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItemToolStripMenuItem.Name = "settingsToolStripMenuItemToolStripMenuItem";
            this.settingsToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.settingsToolStripMenuItemToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItemToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblNotifications});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblNotifications
            // 
            this.tslblNotifications.Name = "tslblNotifications";
            this.tslblNotifications.Size = new System.Drawing.Size(0, 17);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дирижер принтеров";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.SizeChanged += new System.EventHandler(this.fmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openPrintQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem useAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printATestPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem renamePrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printerPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tstbxPrinterName;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem printServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiReloadPrintServer;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearPrintServerFolder;
        private System.Windows.Forms.ToolStripMenuItem filtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHideLaserPrinters;
        private System.Windows.Forms.ToolStripMenuItem tsmiHidePlotters;
        private System.Windows.Forms.ToolStripMenuItem tsmiHideVirtualPrinters;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevicesAndPrinters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Default;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterFullName;
        private System.Windows.Forms.ToolStripMenuItem printSettingsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem installPrinterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblNotifications;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItemToolStripMenuItem;
    }
}

