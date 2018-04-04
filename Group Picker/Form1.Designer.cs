namespace Group_Picker
{
    partial class Setup
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblEx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnHelp1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumSize = new System.Windows.Forms.NumericUpDown();
            this.BtnRe = new System.Windows.Forms.Button();
            this.BtnClearE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumSize)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNames
            // 
            this.TxtNames.Location = new System.Drawing.Point(12, 31);
            this.TxtNames.Multiline = true;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(234, 342);
            this.TxtNames.TabIndex = 0;
            // 
            // BtnHelp0
            // 
            this.BtnHelp0.Location = new System.Drawing.Point(91, 5);
            this.BtnHelp0.Name = "BtnHelp0";
            this.BtnHelp0.Size = new System.Drawing.Size(25, 23);
            this.BtnHelp0.TabIndex = 1;
            this.BtnHelp0.Text = "?";
            this.BtnHelp0.UseVisualStyleBackColor = true;
            this.BtnHelp0.Click += new System.EventHandler(this.BtnHelp0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Names";
            // 
            // LblEx
            // 
            this.LblEx.BackColor = System.Drawing.Color.White;
            this.LblEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEx.Location = new System.Drawing.Point(252, 31);
            this.LblEx.Name = "LblEx";
            this.LblEx.Size = new System.Drawing.Size(201, 342);
            this.LblEx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exceptions";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(320, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(89, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add Exception";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnHelp1
            // 
            this.BtnHelp1.Location = new System.Drawing.Point(415, 5);
            this.BtnHelp1.Name = "BtnHelp1";
            this.BtnHelp1.Size = new System.Drawing.Size(25, 23);
            this.BtnHelp1.TabIndex = 6;
            this.BtnHelp1.Text = "?";
            this.BtnHelp1.UseVisualStyleBackColor = true;
            this.BtnHelp1.Click += new System.EventHandler(this.BtnHelp1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size of groups:";
            // 
            // NumSize
            // 
            this.NumSize.Location = new System.Drawing.Point(92, 379);
            this.NumSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSize.Name = "NumSize";
            this.NumSize.Size = new System.Drawing.Size(48, 20);
            this.NumSize.TabIndex = 9;
            this.NumSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnRe
            // 
            this.BtnRe.Location = new System.Drawing.Point(129, 5);
            this.BtnRe.Name = "BtnRe";
            this.BtnRe.Size = new System.Drawing.Size(117, 23);
            this.BtnRe.TabIndex = 10;
            this.BtnRe.Text = "Remember Tool";
            this.BtnRe.UseVisualStyleBackColor = true;
            this.BtnRe.Click += new System.EventHandler(this.BtnRe_Click);
            // 
            // BtnClearE
            // 
            this.BtnClearE.Location = new System.Drawing.Point(255, 376);
            this.BtnClearE.Name = "BtnClearE";
            this.BtnClearE.Size = new System.Drawing.Size(198, 23);
            this.BtnClearE.TabIndex = 11;
            this.BtnClearE.Text = "Clear Exceptions";
            this.BtnClearE.UseVisualStyleBackColor = true;
            this.BtnClearE.Click += new System.EventHandler(this.BtnClearE_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 432);
            this.Controls.Add(this.BtnClearE);
            this.Controls.Add(this.BtnRe);
            this.Controls.Add(this.NumSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnHelp1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHelp0);
            this.Controls.Add(this.TxtNames);
            this.Name = "Setup";
            this.Text = "Group Picker";
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.Button BtnHelp0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnHelp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumSize;
        private System.Windows.Forms.Button BtnRe;
        private System.Windows.Forms.Button BtnClearE;
    }
}

