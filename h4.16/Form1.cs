using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h4._16
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = i.ToString();
            i--;
            if (i < 0)
            {
                this.timer1.Enabled = false;
                this.label1.Text = "Hết giờ!";
            }
        }
    }
}
