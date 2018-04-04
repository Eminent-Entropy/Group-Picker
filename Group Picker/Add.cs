using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Picker
{
    public partial class Add : Form
    {
        public List<string> names;
        public Setup setup;

        public Add(List<string> inputN, Setup inputF)
        {
            names = inputN;
            setup = inputF;
            InitializeComponent();
            CmboE1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmboE2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (names.Contains(CmboE1.Text) && names.Contains(CmboE2.Text))
            {
                setup.addEx(new string[] { CmboE1.Text, CmboE2.Text });
                Close();
            }
            else MessageBox.Show("Chosen name is not in name list");
        }

        private void Add_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Count(); i++)
            {
                CmboE1.Items.Add(names[i]);
                CmboE2.Items.Add(names[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
