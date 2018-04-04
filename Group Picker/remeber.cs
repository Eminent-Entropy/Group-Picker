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
        string nameFile;

        public remeber(Setup inputF)
        {
            InitializeComponent();
            setup = inputF;
            nameFile = setup.nameFile;
        }

        private void BtnAddN_Click(object sender, EventArgs e)
        {
            string newName = TxtNewName.Text;

            if (!LstNames.Items.Contains(newName))
            {
                LstNames.Items.Add(newName);
                string fileWrite = File.ReadAllText(nameFile) + newName + Environment.NewLine;
                File.WriteAllText(nameFile, fileWrite);
            }
        }

        private void remeber_Load(object sender, EventArgs e)
        {
            int fileLines = File.ReadLines(nameFile).Count();
            if (fileLines > 0)
            {
                for (int i = 0; i < fileLines; i++) LstNames.Items.Add(File.ReadAllLines(nameFile)[i]);
            }
        }

        private void BtnAddT_Click(object sender, EventArgs e)
        {
            setup.addName(LstNames.Items[LstNames.SelectedIndex].ToString());
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string delName = LstNames.Items[LstNames.SelectedIndex].ToString();
            List<string> fileList = File.ReadAllLines(nameFile).ToList();
            if (fileList.Contains(delName))
            {
                fileList.Remove(delName);
                File.WriteAllLines(nameFile, fileList.ToArray());
                LstNames.Items.RemoveAt(LstNames.SelectedIndex);
            }
        }

        private void BtnHelp0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Use the textbox and add button to add names to the remember list" + Environment.NewLine + Environment.NewLine +
                            "-To add a name to the active list select it by clicking it and click the add selected name button" + Environment.NewLine + Environment.NewLine +
                            "-Names on the remember list are remebered even after closing the program");
        }
    }
}
