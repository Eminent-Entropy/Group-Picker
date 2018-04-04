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
    public partial class Setup : Form
    {
        public List<string> names = new List<string>();
        public List<string[]> noSits = new List<string[]>();

        public string drivePath;
        public string mainPath;
        public string nameFile;

        public Setup()
        {
            InitializeComponent();
            drivePath = "C://";
            mainPath = Path.Combine(drivePath, "GroupPicker");
            nameFile = Path.Combine(mainPath, "names");
        }

        public void getNames()
        {
            names = new List<string>();
            for (int i = 0; i < TxtNames.Lines.Length; i++) names.Add(TxtNames.Lines[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getNames();
            if (NumSize.Value <= names.Count())
            {
                resaults res = new resaults(names, noSits, Convert.ToInt32(NumSize.Value));
                res.Show();
            }
            else MessageBox.Show("group size is too big");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            getNames();
            Add add = new Add(names, this);
            add.Show();
        }

        public void addEx(string[] input)
        {
            LblEx.Text = LblEx.Text + input[0] + " and " + input[1] + Environment.NewLine;
            noSits.Add(input);
        }

        private void BtnHelp0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List all students names " + Environment.NewLine + "Each name on it's own line");
        }

        private void BtnHelp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of students that wont be placed togeather");
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(mainPath)) Directory.CreateDirectory(mainPath);
            if (!File.Exists(nameFile)) File.Create(nameFile);
        }

        public void addName(string name)
        {
            getNames();
            if (!names.Contains(name)) TxtNames.Text = TxtNames.Text + name + Environment.NewLine;
            else MessageBox.Show("That name is already in the list");
            getNames();
        }

        private void BtnRe_Click(object sender, EventArgs e)
        {
            remeber re = new remeber(this);
            re.Show();
        }

        private void BtnClearE_Click(object sender, EventArgs e)
        {
            noSits = new List<string[]>();
            LblEx.Text = "";
        }
    }
}
