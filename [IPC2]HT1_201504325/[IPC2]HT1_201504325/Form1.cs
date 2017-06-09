using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IPC2_HT1_201504325
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Funcion1_Click(object sender, EventArgs e)
        {
            double ladoa = 0;
            double ladob = 0;
            double ladoc = 0;

            ladoa = Int32.Parse(Input1.Text);
            ladob = Int32.Parse(Input2.Text);

            ladoc = Math.Sqrt(Math.Pow(ladoa, 2) + Math.Pow(ladob, 2));

            Input3.Text = ladoc.ToString();
        }
    }
}
