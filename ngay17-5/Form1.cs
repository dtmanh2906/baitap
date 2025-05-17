using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngay17_5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=baitap;Integrated Security=True";
               
                using (SqlConnection sqlcon = new SqlConnection(ketnoi))
                {
                    sqlcon.Open();
                }


                MessageBox.Show("Đã kết nối CSDL thành công", "Kết nối");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được CSDL", "Kết nối");
                MessageBox.Show("Nguyên nhân lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }


    }
}
