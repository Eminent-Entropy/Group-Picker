namespace Group_Picker
{
    partial class resaults
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
            this.TxtGroups = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtGroups
            // 
            this.TxtGroups.Location = new System.Drawing.Point(12, 12);
            this.TxtGroups.Multiline = true;
            this.TxtGroups.Name = "TxtGroups";
            this.TxtGroups.ReadOnly = true;
            this.TxtGroups.Size = new System.Drawing.Size(461, 453);
            this.TxtGroups.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 506);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtGroups);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resaults";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.resaults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGroups;
        private System.Windows.Forms.Button button1;
    }
}