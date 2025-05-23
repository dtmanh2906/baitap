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

namespace ngay23_5
{
    public partial class Form1: Form
    {
        string strCon = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=QLNV;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon==null || sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                }
                string query = "SELECT * FROM nhanvien";
                using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : "+ ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "SELECT *FROM nhanvien";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    if (string.IsNullOrWhiteSpace(txtMaNV.Text)|| string.IsNullOrWhiteSpace(txtTenNV.Text)||
                        string.IsNullOrWhiteSpace(txtPhong.Text)|| string.IsNullOrWhiteSpace(txtLuong.Text))
                    {
                        MessageBox.Show("Vui lòng nhập thông tin trươc khi thêm ");
                        return;
                    }
                    sqlCon.Open();
                    string query = "INSERT INTO nhanvien (MaNV,TenNV,Phong,Luong) VALUES(@MaNV,@TenNV,@Phong,@Luong)";
                    using(SqlCommand cmd=new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@Phong", txtPhong.Text);
                        cmd.Parameters.AddWithValue("@Luong", txtLuong.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        LoadData();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : "+ ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("vui lòng nhập mã nhân viên cần xóa");
                    return;
                }
             
                using(SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM nhanvien WHERE MaNV =@MaNV";
                    using(SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                 using(SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM nhanvien WHERE Phong=@Phong";
                    using(SqlCommand cmd=new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Phong", txtPhong.Text.Trim());
                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                dataGridView2.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("không có nhân viên nào thuộc phòng " + txtPhong.Text);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtPhong.Clear();
            txtLuong.Clear();
            txtMaNV.Focus();
        }
    }
}
