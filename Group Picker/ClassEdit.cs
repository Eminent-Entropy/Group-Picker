using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group_Picker
{
    public partial class ClassEdit : Form
    {
        remeber rem;
        string file;

        public ClassEdit(remeber inputC, string inputF)
        {
            InitializeComponent();
            rem = inputC;
            file = inputF;
        }

        private void ClassEdit_Load(object sender, EventArgs e)
        {
            TxtNames.Text = File.ReadAllText(file);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file, TxtNames.Text);
            Close();
        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnHelp0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Put in class names here to remember" + Environment.NewLine + Environment.NewLine +
                            "-Each name gets it's own line");
        }
    }
}
