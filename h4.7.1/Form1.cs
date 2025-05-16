using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h4._7._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1, so2, tong;
            //Nhập dữ liệu 
            so1 = Convert.ToDouble(textBox1.Text);
            so2 = Convert.ToDouble(textBox2.Text);
            tong = so1 + so2;
            //In kết quả 
            textBox3.Text = "Tổng hai số là:" + tong;
        }
    }
}
