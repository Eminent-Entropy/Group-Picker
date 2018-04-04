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
    public partial class resaults : Form
    {
        List<string> names = new List<string>();
        List<string[]> noSits = new List<string[]>();
        int GSize;
        Random rnd = new Random();

        public resaults(List<string> inputN, List<string[]> inputE, int InputS)
        {
            InitializeComponent();

            names = inputN;
            noSits = inputE;
            GSize = InputS;
        }

        public bool ExCheck(string name1, string name2)
        {
            for (int i = 0; i < noSits.Count(); i++)
            {
                if (name1 == name2) return false;
                if (noSits[i][0] == name1 && noSits[i][1] == name2) return true;
                if (noSits[i][0] == name2 && noSits[i][1] == name1) return true;
            }
            return false;
        }

        private void resaults_Load(object sender, EventArgs e)
        {
            string[] currectG = new string[GSize];
            int next = 0;

            int count = 0;
            while (names.Count() >= GSize)
            {
                TxtGroups.Text = TxtGroups.Text + "Group " + (count + 1) + ":" + Environment.NewLine;
                for (int i = 0; i < GSize; i++)
                {
                    bool done = false;
                    while (!done)
                    {
                        next = rnd.Next(names.Count());
                        currectG[i] = names[next];
                        for (int a = 0; a < GSize; a++)
                        {
                            if (ExCheck(currectG[i], currectG[a])) break;
                            done = true;
                        }
                    }
                    TxtGroups.Text = TxtGroups.Text + names[next] + Environment.NewLine;
                    names.Remove(names[next]);
                }
                TxtGroups.Text = TxtGroups.Text + Environment.NewLine;
                count++;
            }
            if (names.Count() > 0)
            {
                TxtGroups.Text = TxtGroups.Text + "Group " + (count + 1) + ":" + " (leftover people)" + Environment.NewLine;
                for (int i = 0; i < names.Count; i++)
                {
                    TxtGroups.Text = TxtGroups.Text + names[i] + Environment.NewLine;
                }
                names = new List<string>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
