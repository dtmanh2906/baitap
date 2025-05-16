using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h4._7._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true && radioButton8.Checked == true) || (radioButton2.Checked == true && radioButton10.Checked == true) ||
 (radioButton3.Checked == true && radioButton6.Checked == true) || (radioButton4.Checked == true && radioButton7.Checked == true) ||
 (radioButton5.Checked == true && radioButton9.Checked == true))
            {
                textBox1.Text = "Bạn trả lời trúng phóc!";
            }
            else
            {
                textBox1.Text = "Bạn trả lời sai bét!";
            }
        }
    }
}
