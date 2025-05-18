using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngay18_5
{
    public partial class Form1: Form
    {
        string strCon = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=baitap;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM QuanLySV";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon == null|| sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                }
                string query = "SELECT * FROM QuanLySV";
                using(SqlDataAdapter da =new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtKhoa.Clear();
            txtQueQuan.Clear();
            txtMaSV.Focus();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection sqlCon= new SqlConnection(strCon))
                {
                    if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtQueQuan.Text) || string.IsNullOrWhiteSpace(txtQueQuan.Text))
                    {
                        MessageBox.Show("Vui lòng nhập trước khi thêm ");
                        return;
                    }
                    sqlCon.Open();
                    string query = "INSERT INTO QuanLySV(MaSV,TenSV,Khoa,QueQuan) VALUES (@MaSV,@TenSV,@Khoa,@QueQuan)";
                    using(SqlCommand cmd=new SqlCommand(query, sqlCon))
                    {

                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                        cmd.Parameters.AddWithValue("@Khoa", txtKhoa.Text);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Thành công");
                        LoadData();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "UPDATE QuanLySV SET MaSV=@MaSV,TenSV=@TenSV,Khoa=@Khoa,QueQuan=@QueQuan  WHERE MaSV = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                        cmd.Parameters.AddWithValue("@Khoa", txtKhoa.Text);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Sửa thành công!");
                        else
                            MessageBox.Show("Không tìm thấy sinh viên để sửa.");

                        LoadData(); 
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng nhập MaSV cần xóa!");
                    return;
                }
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM QuanLySV WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM QuanLySV WHERE MaSV = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaSv", txtMaSV.Text.Trim());

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên có MaSV: " + txtMaSV.Text);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
