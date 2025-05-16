using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h4._13
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hoten = this.textBox1.Text.Trim();
            if (this.radioButton1.Checked == true)
                textBox2.Text = hoten.ToLower();
            if (this.radioButton2.Checked == true)
                textBox2.Text = hoten.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.radioButton1.Checked = true;
            this.textBox1.Focus();
        }
    }
}
