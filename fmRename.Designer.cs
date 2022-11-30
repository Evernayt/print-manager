namespace Print_Manager
{
    partial class fmRename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRename));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.lblCurrentName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLoaderMsg = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lblNewName = new System.Windows.Forms.Label();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxName.Location = new System.Drawing.Point(12, 58);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(382, 33);
            this.tbxName.TabIndex = 0;
            this.tbxName.TabStop = false;
            // 
            // btnRename
            // 
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnRename.FlatAppearance.BorderSize = 2;
            this.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(131)))));
            this.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Location = new System.Drawing.Point(12, 97);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(257, 34);
            this.btnRename.TabIndex = 13;
            this.btnRename.Text = "Переименовать";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.AutoSize = true;
            this.lblCurrentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentName.Location = new System.Drawing.Point(8, 9);
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(110, 21);
            this.lblCurrentName.TabIndex = 14;
            this.lblCurrentName.Text = "Текущее имя: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(275, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLoaderMsg
            // 
            this.lblLoaderMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoaderMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoaderMsg.Location = new System.Drawing.Point(60, 30);
            this.lblLoaderMsg.Name = "lblLoaderMsg";
            this.lblLoaderMsg.Size = new System.Drawing.Size(287, 25);
            this.lblLoaderMsg.TabIndex = 12;
            this.lblLoaderMsg.Text = "Переименование";
            this.lblLoaderMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.lblNewName);
            this.pInfo.Controls.Add(this.lblLoaderMsg);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Location = new System.Drawing.Point(0, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(406, 144);
            this.pInfo.TabIndex = 16;
            this.pInfo.Visible = false;
            // 
            // lblNewName
            // 
            this.lblNewName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewName.ForeColor = System.Drawing.Color.DimGray;
            this.lblNewName.Location = new System.Drawing.Point(24, 66);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(359, 53);
            this.lblNewName.TabIndex = 13;
            this.lblNewName.Text = "Новое имя:";
            this.lblNewName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 144);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCurrentName);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "fmRename";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переименовать принтер";
            this.pInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label lblCurrentName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLoaderMsg;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label lblNewName;
    }
}