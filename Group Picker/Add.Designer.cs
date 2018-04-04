namespace Group_Picker
{
    partial class Add
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
            this.CmboE1 = new System.Windows.Forms.ComboBox();
            this.CmboE2 = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnHelp0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmboE1
            // 
            this.CmboE1.FormattingEnabled = true;
            this.CmboE1.Location = new System.Drawing.Point(12, 12);
            this.CmboE1.Name = "CmboE1";
            this.CmboE1.Size = new System.Drawing.Size(124, 21);
            this.CmboE1.TabIndex = 0;
            // 
            // CmboE2
            // 
            this.CmboE2.FormattingEnabled = true;
            this.CmboE2.Location = new System.Drawing.Point(146, 12);
            this.CmboE2.Name = "CmboE2";
            this.CmboE2.Size = new System.Drawing.Size(124, 21);
            this.CmboE2.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(43, 39);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHelp0
            // 
            this.BtnHelp0.Location = new System.Drawing.Point(12, 39);
            this.BtnHelp0.Name = "BtnHelp0";
            this.BtnHelp0.Size = new System.Drawing.Size(25, 23);
            this.BtnHelp0.TabIndex = 4;
            this.BtnHelp0.Text = "?";
            this.BtnHelp0.UseVisualStyleBackColor = true;
            this.BtnHelp0.Click += new System.EventHandler(this.BtnHelp0_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 64);
            this.ControlBox = false;
            this.Controls.Add(this.BtnHelp0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmboE2);
            this.Controls.Add(this.CmboE1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Exception";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmboE1;
        private System.Windows.Forms.ComboBox CmboE2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnHelp0;
    }
}