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
    public partial class remeber : Form
    {
        Setup setup;
        string mainDir;
        List<string> files = new List<string>();

        public remeber(Setup inputF)
        {
            InitializeComponent();
            setup = inputF;
            mainDir = setup.mainPath;
        }

        private void BtnAddN_Click(object sender, EventArgs e)
        {
            string name = TxtNewName.Text;
            if (!File.Exists(Path.Combine(mainDir, name)))
            {
                File.Create(Path.Combine(mainDir, name)).Close();
                LstNames.Items.Add(name);
            }
        }

        private void remeber_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(mainDir).ToList();
            for (int i = 0; i != files.Count(); i++)
            {
                LstNames.Items.Add(files[i].Substring(16, files[i].Length - 16));
            }
        }

        private void BtnAddT_Click(object sender, EventArgs e)
        {
            int sel = LstNames.SelectedIndex;
            string name = LstNames.Items[sel].ToString();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path.Combine(mainDir, name));
            while ((line = file.ReadLine()) != null)
            {
                setup.addName(line);
            }
            file.Close();
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int sel = LstNames.SelectedIndex;
            string name = LstNames.Items[sel].ToString();
            ClassEdit clEt = new ClassEdit(this, Path.Combine(mainDir, name));
            clEt.Show();
        }

        private void BtnHelp0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Use the textbox and create button to make a new class" + Environment.NewLine + Environment.NewLine +
                            "-To add a class to the active list select it by clicking it and click the add selected class button" + Environment.NewLine + Environment.NewLine +
                            "-To add/remove names from a class select the class and click the edit button");
        }

        private void BtnKill_Click(object sender, EventArgs e)
        {
            int sel = LstNames.SelectedIndex;
            string name = LstNames.Items[sel].ToString();
            LstNames.Items.RemoveAt(sel);
            File.Delete(Path.Combine(mainDir, name));
        }
    }
}
