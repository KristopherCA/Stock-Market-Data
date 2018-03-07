namespace Assignment_3
{
    partial class stkDlg
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
            this.okBtn = new System.Windows.Forms.Button();
            this.clsBtn = new System.Windows.Forms.Button();
            this.stkabrvTxtBox = new System.Windows.Forms.TextBox();
            this.opnprceTxtBox = new System.Windows.Forms.TextBox();
            this.lwprceTxtBox = new System.Windows.Forms.TextBox();
            this.cmpnynmeTextBox = new System.Windows.Forms.TextBox();
            this.hghprceTxtBox = new System.Windows.Forms.TextBox();
            this.clseprceTxtBox = new System.Windows.Forms.TextBox();
            this.stckabrvLbl = new System.Windows.Forms.Label();
            this.opnprceLbl = new System.Windows.Forms.Label();
            this.lwprceLbl = new System.Windows.Forms.Label();
            this.dteLbl = new System.Windows.Forms.Label();
            this.cmpnynmeLbl = new System.Windows.Forms.Label();
            this.hghprceLbl = new System.Windows.Forms.Label();
            this.clsprceLbl = new System.Windows.Forms.Label();
            this.dtePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Silver;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(75, 334);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.Color.Silver;
            this.clsBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clsBtn.Location = new System.Drawing.Point(171, 334);
            this.clsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(75, 23);
            this.clsBtn.TabIndex = 1;
            this.clsBtn.Text = "Close";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // stkabrvTxtBox
            // 
            this.stkabrvTxtBox.Location = new System.Drawing.Point(23, 44);
            this.stkabrvTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stkabrvTxtBox.Name = "stkabrvTxtBox";
            this.stkabrvTxtBox.Size = new System.Drawing.Size(128, 22);
            this.stkabrvTxtBox.TabIndex = 2;
            this.stkabrvTxtBox.TextChanged += new System.EventHandler(this.stkabrvTxtBox_TextChanged);
            // 
            // opnprceTxtBox
            // 
            this.opnprceTxtBox.Location = new System.Drawing.Point(23, 114);
            this.opnprceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opnprceTxtBox.Name = "opnprceTxtBox";
            this.opnprceTxtBox.Size = new System.Drawing.Size(128, 22);
            this.opnprceTxtBox.TabIndex = 4;
            // 
            // lwprceTxtBox
            // 
            this.lwprceTxtBox.Location = new System.Drawing.Point(23, 188);
            this.lwprceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwprceTxtBox.Name = "lwprceTxtBox";
            this.lwprceTxtBox.Size = new System.Drawing.Size(128, 22);
            this.lwprceTxtBox.TabIndex = 6;
            // 
            // cmpnynmeTextBox
            // 
            this.cmpnynmeTextBox.Location = new System.Drawing.Point(171, 44);
            this.cmpnynmeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmpnynmeTextBox.Name = "cmpnynmeTextBox";
            this.cmpnynmeTextBox.Size = new System.Drawing.Size(128, 22);
            this.cmpnynmeTextBox.TabIndex = 3;
            // 
            // hghprceTxtBox
            // 
            this.hghprceTxtBox.Location = new System.Drawing.Point(171, 114);
            this.hghprceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hghprceTxtBox.Name = "hghprceTxtBox";
            this.hghprceTxtBox.Size = new System.Drawing.Size(128, 22);
            this.hghprceTxtBox.TabIndex = 5;
            // 
            // clseprceTxtBox
            // 
            this.clseprceTxtBox.Location = new System.Drawing.Point(171, 188);
            this.clseprceTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clseprceTxtBox.Name = "clseprceTxtBox";
            this.clseprceTxtBox.Size = new System.Drawing.Size(128, 22);
            this.clseprceTxtBox.TabIndex = 7;
            // 
            // stckabrvLbl
            // 
            this.stckabrvLbl.AutoSize = true;
            this.stckabrvLbl.Location = new System.Drawing.Point(19, 14);
            this.stckabrvLbl.Name = "stckabrvLbl";
            this.stckabrvLbl.Size = new System.Drawing.Size(126, 17);
            this.stckabrvLbl.TabIndex = 9;
            this.stckabrvLbl.Text = "Stock Abbreviation";
            // 
            // opnprceLbl
            // 
            this.opnprceLbl.AutoSize = true;
            this.opnprceLbl.Location = new System.Drawing.Point(20, 82);
            this.opnprceLbl.Name = "opnprceLbl";
            this.opnprceLbl.Size = new System.Drawing.Size(98, 17);
            this.opnprceLbl.TabIndex = 10;
            this.opnprceLbl.Text = "Opening Price";
            // 
            // lwprceLbl
            // 
            this.lwprceLbl.AutoSize = true;
            this.lwprceLbl.Location = new System.Drawing.Point(20, 158);
            this.lwprceLbl.Name = "lwprceLbl";
            this.lwprceLbl.Size = new System.Drawing.Size(69, 17);
            this.lwprceLbl.TabIndex = 11;
            this.lwprceLbl.Text = "Low Price";
            // 
            // dteLbl
            // 
            this.dteLbl.AutoSize = true;
            this.dteLbl.Location = new System.Drawing.Point(20, 229);
            this.dteLbl.Name = "dteLbl";
            this.dteLbl.Size = new System.Drawing.Size(38, 17);
            this.dteLbl.TabIndex = 12;
            this.dteLbl.Text = "Date";
            // 
            // cmpnynmeLbl
            // 
            this.cmpnynmeLbl.AutoSize = true;
            this.cmpnynmeLbl.Location = new System.Drawing.Point(167, 9);
            this.cmpnynmeLbl.Name = "cmpnynmeLbl";
            this.cmpnynmeLbl.Size = new System.Drawing.Size(112, 17);
            this.cmpnynmeLbl.TabIndex = 13;
            this.cmpnynmeLbl.Text = "Company  Name";
            // 
            // hghprceLbl
            // 
            this.hghprceLbl.AutoSize = true;
            this.hghprceLbl.Location = new System.Drawing.Point(167, 82);
            this.hghprceLbl.Name = "hghprceLbl";
            this.hghprceLbl.Size = new System.Drawing.Size(73, 17);
            this.hghprceLbl.TabIndex = 14;
            this.hghprceLbl.Text = "High Price";
            // 
            // clsprceLbl
            // 
            this.clsprceLbl.AutoSize = true;
            this.clsprceLbl.Location = new System.Drawing.Point(167, 158);
            this.clsprceLbl.Name = "clsprceLbl";
            this.clsprceLbl.Size = new System.Drawing.Size(90, 17);
            this.clsprceLbl.TabIndex = 15;
            this.clsprceLbl.Text = "Closing Price";
            // 
            // dtePicker
            // 
            this.dtePicker.Location = new System.Drawing.Point(67, 229);
            this.dtePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dtePicker.Name = "dtePicker";
            this.dtePicker.RightToLeftLayout = true;
            this.dtePicker.Size = new System.Drawing.Size(232, 22);
            this.dtePicker.TabIndex = 16;
            // 
            // stkDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.dtePicker);
            this.Controls.Add(this.clsprceLbl);
            this.Controls.Add(this.hghprceLbl);
            this.Controls.Add(this.cmpnynmeLbl);
            this.Controls.Add(this.dteLbl);
            this.Controls.Add(this.lwprceLbl);
            this.Controls.Add(this.opnprceLbl);
            this.Controls.Add(this.stckabrvLbl);
            this.Controls.Add(this.clseprceTxtBox);
            this.Controls.Add(this.hghprceTxtBox);
            this.Controls.Add(this.cmpnynmeTextBox);
            this.Controls.Add(this.lwprceTxtBox);
            this.Controls.Add(this.opnprceTxtBox);
            this.Controls.Add(this.stkabrvTxtBox);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 403);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 403);
            this.Name = "stkDlg";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Information";
            this.Load += new System.EventHandler(this.stkDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button clsBtn;
        private System.Windows.Forms.TextBox stkabrvTxtBox;
        private System.Windows.Forms.TextBox opnprceTxtBox;
        private System.Windows.Forms.TextBox lwprceTxtBox;
        private System.Windows.Forms.TextBox cmpnynmeTextBox;
        private System.Windows.Forms.TextBox hghprceTxtBox;
        private System.Windows.Forms.TextBox clseprceTxtBox;
        private System.Windows.Forms.Label stckabrvLbl;
        private System.Windows.Forms.Label opnprceLbl;
        private System.Windows.Forms.Label lwprceLbl;
        private System.Windows.Forms.Label dteLbl;
        private System.Windows.Forms.Label cmpnynmeLbl;
        private System.Windows.Forms.Label hghprceLbl;
        private System.Windows.Forms.Label clsprceLbl;
        private System.Windows.Forms.DateTimePicker dtePicker;
    }
}