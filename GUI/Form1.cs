using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _11d;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISolvable solvable;
            if (polynomialTabs.SelectedIndex == 0)
            {
                double a1 = double.Parse(binomialA1.Text);
                double a0 = double.Parse(binomialA0.Text);
                double a = double.Parse(binomialA.Text);
                solvable = new Binomial(a1, a0 - a);
            }
            else // if(polynomialTabs.SelectedIndex == 1)
            {
                double a2 = double.Parse(trinomialA2.Text);
                double a1 = double.Parse(trinomialA1.Text);
                double a0 = double.Parse(trinomialA0.Text);
                double a = double.Parse(trinomialA.Text);
                solvable = new Trinomial(a2, a0 - a, a1);
            }
            List<double> solutions = solvable.Solve();
            rootsListBox.Items.Clear();
            if (solutions == null)
                rootsListBox.Items.Add("Infinitely many solutions!");
            else if (solutions.Count == 0)
                rootsListBox.Items.Add("No reals roots!");
            else
            {
                for (int i = 0; i < solutions.Count; i++)
                    rootsListBox.Items.Add(solutions[i]);
            }
        }
    }
}
