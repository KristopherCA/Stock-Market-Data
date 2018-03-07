namespace Assignment_3
{
    partial class stkHlp
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
            this.ysBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.hlpLbl = new System.Windows.Forms.Label();
            this.addLnkLbl = new System.Windows.Forms.LinkLabel();
            this.dltLnkLbl = new System.Windows.Forms.LinkLabel();
            this.updteLnkLbl = new System.Windows.Forms.LinkLabel();
            this.abtLnkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ysBtn
            // 
            this.ysBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ysBtn.Location = new System.Drawing.Point(109, 346);
            this.ysBtn.Name = "ysBtn";
            this.ysBtn.Size = new System.Drawing.Size(75, 23);
            this.ysBtn.TabIndex = 0;
            this.ysBtn.Text = "Yes";
            this.ysBtn.UseVisualStyleBackColor = true;
            this.ysBtn.Click += new System.EventHandler(this.ysBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.noBtn.Location = new System.Drawing.Point(233, 346);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // hlpLbl
            // 
            this.hlpLbl.AutoSize = true;
            this.hlpLbl.Location = new System.Drawing.Point(150, 291);
            this.hlpLbl.Name = "hlpLbl";
            this.hlpLbl.Size = new System.Drawing.Size(116, 17);
            this.hlpLbl.TabIndex = 2;
            this.hlpLbl.Text = "Was this helpful?";
            this.hlpLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // addLnkLbl
            // 
            this.addLnkLbl.AutoSize = true;
            this.addLnkLbl.Location = new System.Drawing.Point(84, 62);
            this.addLnkLbl.Name = "addLnkLbl";
            this.addLnkLbl.Size = new System.Drawing.Size(208, 17);
            this.addLnkLbl.TabIndex = 3;
            this.addLnkLbl.TabStop = true;
            this.addLnkLbl.Text = "How do I add a stock to the list?";
            // 
            // dltLnkLbl
            // 
            this.dltLnkLbl.AutoSize = true;
            this.dltLnkLbl.Location = new System.Drawing.Point(84, 109);
            this.dltLnkLbl.Name = "dltLnkLbl";
            this.dltLnkLbl.Size = new System.Drawing.Size(239, 17);
            this.dltLnkLbl.TabIndex = 4;
            this.dltLnkLbl.TabStop = true;
            this.dltLnkLbl.Text = "How do I delete a stock from the list?";
            this.dltLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dltLnkLbl_LinkClicked);
            // 
            // updteLnkLbl
            // 
            this.updteLnkLbl.AutoSize = true;
            this.updteLnkLbl.Location = new System.Drawing.Point(81, 157);
            this.updteLnkLbl.Name = "updteLnkLbl";
            this.updteLnkLbl.Size = new System.Drawing.Size(235, 17);
            this.updteLnkLbl.TabIndex = 5;
            this.updteLnkLbl.TabStop = true;
            this.updteLnkLbl.Text = "How do II update a stock on the list?";
            // 
            // abtLnkLbl
            // 
            this.abtLnkLbl.AutoSize = true;
            this.abtLnkLbl.Location = new System.Drawing.Point(81, 204);
            this.abtLnkLbl.Name = "abtLnkLbl";
            this.abtLnkLbl.Size = new System.Drawing.Size(352, 17);
            this.abtLnkLbl.TabIndex = 6;
            this.abtLnkLbl.TabStop = true;
            this.abtLnkLbl.Text = "Where can I find more information about this program?";
            // 
            // stkHlp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noBtn;
            this.ClientSize = new System.Drawing.Size(451, 409);
            this.Controls.Add(this.abtLnkLbl);
            this.Controls.Add(this.updteLnkLbl);
            this.Controls.Add(this.dltLnkLbl);
            this.Controls.Add(this.addLnkLbl);
            this.Controls.Add(this.hlpLbl);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.ysBtn);
            this.Name = "stkHlp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ysBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label hlpLbl;
        private System.Windows.Forms.LinkLabel addLnkLbl;
        private System.Windows.Forms.LinkLabel dltLnkLbl;
        private System.Windows.Forms.LinkLabel updteLnkLbl;
        private System.Windows.Forms.LinkLabel abtLnkLbl;
    }
}