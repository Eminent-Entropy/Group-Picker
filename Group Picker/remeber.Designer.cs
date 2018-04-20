namespace Group_Picker
{
    partial class remeber
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
            this.LstNames = new System.Windows.Forms.ListBox();
            this.BtnAddN = new System.Windows.Forms.Button();
            this.BtnAddT = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtNewName = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnHelp0 = new System.Windows.Forms.Button();
            this.BtnKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstNames
            // 
            this.LstNames.FormattingEnabled = true;
            this.LstNames.Location = new System.Drawing.Point(12, 35);
            this.LstNames.Name = "LstNames";
            this.LstNames.Size = new System.Drawing.Size(356, 550);
            this.LstNames.TabIndex = 0;
            // 
            // BtnAddN
            // 
            this.BtnAddN.Location = new System.Drawing.Point(193, 7);
            this.BtnAddN.Name = "BtnAddN";
            this.BtnAddN.Size = new System.Drawing.Size(141, 23);
            this.BtnAddN.TabIndex = 1;
            this.BtnAddN.Text = "Create class";
            this.BtnAddN.UseVisualStyleBackColor = true;
            this.BtnAddN.Click += new System.EventHandler(this.BtnAddN_Click);
            // 
            // BtnAddT
            // 
            this.BtnAddT.Location = new System.Drawing.Point(12, 594);
            this.BtnAddT.Name = "BtnAddT";
            this.BtnAddT.Size = new System.Drawing.Size(159, 23);
            this.BtnAddT.TabIndex = 2;
            this.BtnAddT.Text = "Add selected class to list";
            this.BtnAddT.UseVisualStyleBackColor = true;
            this.BtnAddT.Click += new System.EventHandler(this.BtnAddT_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 623);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(159, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtNewName
            // 
            this.TxtNewName.Location = new System.Drawing.Point(12, 9);
            this.TxtNewName.Name = "TxtNewName";
            this.TxtNewName.Size = new System.Drawing.Size(175, 20);
            this.TxtNewName.TabIndex = 4;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(209, 594);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(159, 23);
            this.BtnDel.TabIndex = 5;
            this.BtnDel.Text = "Edit selected class";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnHelp0
            // 
            this.BtnHelp0.Location = new System.Drawing.Point(340, 7);
            this.BtnHelp0.Name = "BtnHelp0";
            this.BtnHelp0.Size = new System.Drawing.Size(25, 23);
            this.BtnHelp0.TabIndex = 6;
            this.BtnHelp0.Text = "?";
            this.BtnHelp0.UseVisualStyleBackColor = true;
            this.BtnHelp0.Click += new System.EventHandler(this.BtnHelp0_Click);
            // 
            // BtnKill
            // 
            this.BtnKill.Location = new System.Drawing.Point(209, 620);
            this.BtnKill.Name = "BtnKill";
            this.BtnKill.Size = new System.Drawing.Size(159, 23);
            this.BtnKill.TabIndex = 7;
            this.BtnKill.Text = "Delete selected class";
            this.BtnKill.UseVisualStyleBackColor = true;
            this.BtnKill.Click += new System.EventHandler(this.BtnKill_Click);
            // 
            // remeber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 655);
            this.ControlBox = false;
            this.Controls.Add(this.BtnKill);
            this.Controls.Add(this.BtnHelp0);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.TxtNewName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddT);
            this.Controls.Add(this.BtnAddN);
            this.Controls.Add(this.LstNames);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "remeber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "remeber";
            this.Load += new System.EventHandler(this.remeber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstNames;
        private System.Windows.Forms.Button BtnAddN;
        private System.Windows.Forms.Button BtnAddT;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtNewName;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnHelp0;
        private System.Windows.Forms.Button BtnKill;
    }
}