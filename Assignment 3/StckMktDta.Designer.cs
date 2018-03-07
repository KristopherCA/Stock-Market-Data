namespace Assignment_3
{
    partial class StkMktDta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StkMktDta));
            this.stkBox = new System.Windows.Forms.ListBox();
            this.stkdtaPanl = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.updteBtn = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.opnMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.sveMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.sveasMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.dltMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.updteMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hlpMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abtMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.addTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.DltTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.updteTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.opnFleDlg = new System.Windows.Forms.OpenFileDialog();
            this.sveFleDlg = new System.Windows.Forms.SaveFileDialog();
            this.clrBtn = new System.Windows.Forms.Button();
            this.pltBtn = new System.Windows.Forms.Button();
            this.clrDlg = new System.Windows.Forms.ColorDialog();
            this.clrpkBtn = new System.Windows.Forms.Button();
            this.clrTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.pltTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.clTlTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stkBox
            // 
            this.stkBox.FormattingEnabled = true;
            this.stkBox.HorizontalScrollbar = true;
            this.stkBox.ItemHeight = 16;
            this.stkBox.Location = new System.Drawing.Point(323, 47);
            this.stkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stkBox.Name = "stkBox";
            this.stkBox.ScrollAlwaysVisible = true;
            this.stkBox.Size = new System.Drawing.Size(264, 436);
            this.stkBox.TabIndex = 0;
            this.stkBox.SelectedIndexChanged += new System.EventHandler(this.stkBox_SelectedIndexChanged);
            // 
            // stkdtaPanl
            // 
            this.stkdtaPanl.AutoSize = true;
            this.stkdtaPanl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stkdtaPanl.Location = new System.Drawing.Point(12, 47);
            this.stkdtaPanl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stkdtaPanl.Name = "stkdtaPanl";
            this.stkdtaPanl.Size = new System.Drawing.Size(287, 330);
            this.stkdtaPanl.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.Location = new System.Drawing.Point(12, 460);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addTlTip.SetToolTip(this.addBtn, "Add a stock to the list");
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.Silver;
            this.dltBtn.Location = new System.Drawing.Point(117, 460);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 3;
            this.dltBtn.Text = "Delete";
            this.DltTlTip.SetToolTip(this.dltBtn, "Delete selected stock from lthe list");
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // updteBtn
            // 
            this.updteBtn.BackColor = System.Drawing.Color.Silver;
            this.updteBtn.Location = new System.Drawing.Point(225, 460);
            this.updteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updteBtn.Name = "updteBtn";
            this.updteBtn.Size = new System.Drawing.Size(75, 23);
            this.updteBtn.TabIndex = 4;
            this.updteBtn.Text = "Update";
            this.updteTlTip.SetToolTip(this.updteBtn, "Update selected stock on the list");
            this.updteBtn.UseVisualStyleBackColor = false;
            this.updteBtn.Click += new System.EventHandler(this.updteBtn_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.Color.Silver;
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuStrip.Size = new System.Drawing.Size(603, 28);
            this.mnuStrip.TabIndex = 5;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMnuItm,
            this.opnMnuItm,
            this.sveMnuItm,
            this.sveasMnuItm,
            this.toolStripSeparator1,
            this.exitMnuItm});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMnuItm
            // 
            this.newMnuItm.Name = "newMnuItm";
            this.newMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMnuItm.Size = new System.Drawing.Size(187, 26);
            this.newMnuItm.Text = "New";
            this.newMnuItm.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // opnMnuItm
            // 
            this.opnMnuItm.Name = "opnMnuItm";
            this.opnMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opnMnuItm.Size = new System.Drawing.Size(187, 26);
            this.opnMnuItm.Text = "Open";
            this.opnMnuItm.Click += new System.EventHandler(this.opnMnuItm_Click);
            // 
            // sveMnuItm
            // 
            this.sveMnuItm.Name = "sveMnuItm";
            this.sveMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sveMnuItm.Size = new System.Drawing.Size(187, 26);
            this.sveMnuItm.Text = "Save";
            this.sveMnuItm.Click += new System.EventHandler(this.sveMnuItm_Click);
            // 
            // sveasMnuItm
            // 
            this.sveasMnuItm.Name = "sveasMnuItm";
            this.sveasMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.sveasMnuItm.Size = new System.Drawing.Size(187, 26);
            this.sveasMnuItm.Text = "Save As";
            this.sveasMnuItm.Click += new System.EventHandler(this.sveasMnuItm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitMnuItm
            // 
            this.exitMnuItm.Name = "exitMnuItm";
            this.exitMnuItm.Size = new System.Drawing.Size(187, 26);
            this.exitMnuItm.Text = "Exit";
            this.exitMnuItm.Click += new System.EventHandler(this.exitMnuItm_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMnuItm,
            this.dltMnuItm,
            this.updteMnuItm});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addMnuItm
            // 
            this.addMnuItm.Name = "addMnuItm";
            this.addMnuItm.ShortcutKeyDisplayString = "Ctrl+A";
            this.addMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addMnuItm.Size = new System.Drawing.Size(185, 26);
            this.addMnuItm.Text = "Add";
            this.addMnuItm.Click += new System.EventHandler(this.addMnuItm_Click);
            // 
            // dltMnuItm
            // 
            this.dltMnuItm.Name = "dltMnuItm";
            this.dltMnuItm.ShortcutKeyDisplayString = "Ctrl+D";
            this.dltMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dltMnuItm.Size = new System.Drawing.Size(185, 26);
            this.dltMnuItm.Text = "Delete";
            this.dltMnuItm.Click += new System.EventHandler(this.dltMnuItm_Click);
            // 
            // updteMnuItm
            // 
            this.updteMnuItm.Name = "updteMnuItm";
            this.updteMnuItm.ShortcutKeyDisplayString = "Ctrl+U";
            this.updteMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updteMnuItm.Size = new System.Drawing.Size(185, 26);
            this.updteMnuItm.Text = "Update";
            this.updteMnuItm.Click += new System.EventHandler(this.updteMnuItm_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hlpMnuItm,
            this.toolStripSeparator2,
            this.abtMnuItm});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hlpMnuItm
            // 
            this.hlpMnuItm.Name = "hlpMnuItm";
            this.hlpMnuItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hlpMnuItm.Size = new System.Drawing.Size(215, 26);
            this.hlpMnuItm.Text = "Help Topics";
            this.hlpMnuItm.Click += new System.EventHandler(this.hlpMnuItm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // abtMnuItm
            // 
            this.abtMnuItm.Name = "abtMnuItm";
            this.abtMnuItm.Size = new System.Drawing.Size(215, 26);
            this.abtMnuItm.Text = "About";
            this.abtMnuItm.Click += new System.EventHandler(this.abtMnuItm_Click);
            // 
            // DltTlTip
            // 
            this.DltTlTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // opnFleDlg
            // 
            this.opnFleDlg.Filter = "Text Files (*.txt) |*.txt|Delimited text (*.csv, *.tsv)|*.csv;*.tsv|All files (*." +
    "*)|*.*";
            this.opnFleDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.opnFleDlg_FileOk);
            // 
            // sveFleDlg
            // 
            this.sveFleDlg.Filter = "Text Files (*.txt) |*.txt|Delimited text (*.csv, *.tsv)|*.csv;*.tsv|All files (*." +
    "*)|*.*";
            this.sveFleDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.sveFleDlg_FileOk);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.Silver;
            this.clrBtn.Location = new System.Drawing.Point(225, 408);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 6;
            this.clrBtn.Text = "Clear";
            this.clTlTip.SetToolTip(this.clrBtn, "Clear the stock panel ");
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // pltBtn
            // 
            this.pltBtn.BackColor = System.Drawing.Color.Silver;
            this.pltBtn.Location = new System.Drawing.Point(117, 408);
            this.pltBtn.Name = "pltBtn";
            this.pltBtn.Size = new System.Drawing.Size(75, 23);
            this.pltBtn.TabIndex = 7;
            this.pltBtn.Text = "Plot";
            this.pltTlTip.SetToolTip(this.pltBtn, "Plot the stock price from the stock list onto the panel");
            this.pltBtn.UseVisualStyleBackColor = false;
            this.pltBtn.Click += new System.EventHandler(this.pltBtn_Click);
            // 
            // clrpkBtn
            // 
            this.clrpkBtn.BackColor = System.Drawing.Color.Silver;
            this.clrpkBtn.Location = new System.Drawing.Point(12, 408);
            this.clrpkBtn.Name = "clrpkBtn";
            this.clrpkBtn.Size = new System.Drawing.Size(75, 23);
            this.clrpkBtn.TabIndex = 8;
            this.clrpkBtn.Text = "Color";
            this.clrTlTip.SetToolTip(this.clrpkBtn, "Choose the color of the plotted stock(s)");
            this.clrpkBtn.UseVisualStyleBackColor = false;
            this.clrpkBtn.Click += new System.EventHandler(this.clrpkBtn_Click);
            // 
            // StkMktDta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(603, 505);
            this.Controls.Add(this.clrpkBtn);
            this.Controls.Add(this.pltBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.updteBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.stkdtaPanl);
            this.Controls.Add(this.stkBox);
            this.Controls.Add(this.mnuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StkMktDta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Market Data";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stkBox;
        private System.Windows.Forms.Panel stkdtaPanl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button updteBtn;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMnuItm;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMnuItm;
        private System.Windows.Forms.ToolStripMenuItem dltMnuItm;
        private System.Windows.Forms.ToolStripMenuItem updteMnuItm;
        private System.Windows.Forms.ToolTip addTlTip;
        private System.Windows.Forms.ToolTip DltTlTip;
        private System.Windows.Forms.ToolTip updteTlTip;
        private System.Windows.Forms.ToolStripMenuItem newMnuItm;
        private System.Windows.Forms.ToolStripMenuItem opnMnuItm;
        private System.Windows.Forms.ToolStripMenuItem sveMnuItm;
        private System.Windows.Forms.ToolStripMenuItem sveasMnuItm;
        private System.Windows.Forms.OpenFileDialog opnFleDlg;
        private System.Windows.Forms.SaveFileDialog sveFleDlg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hlpMnuItm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem abtMnuItm;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button pltBtn;
        private System.Windows.Forms.ColorDialog clrDlg;
        private System.Windows.Forms.Button clrpkBtn;
        private System.Windows.Forms.ToolTip clrTlTip;
        private System.Windows.Forms.ToolTip pltTlTip;
        private System.Windows.Forms.ToolTip clTlTip;
    }
}

