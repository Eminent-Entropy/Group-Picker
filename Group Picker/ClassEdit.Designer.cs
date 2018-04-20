namespace Group_Picker
{
    partial class ClassEdit
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
            this.TxtNames = new System.Windows.Forms.TextBox();
            this.BtnHelp0 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNames
            // 
            this.TxtNames.Location = new System.Drawing.Point(12, 12);
            this.TxtNames.Multiline = true;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(373, 551);
            this.TxtNames.TabIndex = 0;
            // 
            // BtnHelp0
            // 
            this.BtnHelp0.Location = new System.Drawing.Point(360, 12);
            this.BtnHelp0.Name = "BtnHelp0";
            this.BtnHelp0.Size = new System.Drawing.Size(25, 23);
            this.BtnHelp0.TabIndex = 2;
            this.BtnHelp0.Text = "?";
            this.BtnHelp0.UseVisualStyleBackColor = true;
            this.BtnHelp0.Click += new System.EventHandler(this.BtnHelp0_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 569);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(164, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCan
            // 
            this.BtnCan.Location = new System.Drawing.Point(221, 569);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(164, 23);
            this.BtnCan.TabIndex = 4;
            this.BtnCan.Text = "Cancel";
            this.BtnCan.UseVisualStyleBackColor = true;
            this.BtnCan.Click += new System.EventHandler(this.BtnCan_Click);
            // 
            // ClassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 604);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCan);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnHelp0);
            this.Controls.Add(this.TxtNames);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ClassEdit";
            this.Load += new System.EventHandler(this.ClassEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.Button BtnHelp0;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCan;
    }
}