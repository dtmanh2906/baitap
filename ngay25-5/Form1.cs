using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Đề bài :Thiết kế cơ sở dữ liệu gồm: MONHOC(MSMonHoc, TenMonHoc, SOTINCHI, 
TINHCHAT), SV(MaSV, HOTEN, NGAYSINH, LOP), DIEM(MaSV, MSMonHoc,
DIEMTHI). 
-Thiết kế form Thêm gắn với chức năng Bổ sung của bài toán cho phép bổ sung 
sinh viên mới vào CSDL
- Thiết kế form xóa gắn với chức năng cập nhật của bài cho phép xóa bản ghi hiện thời.
- Thiết kế form HienThi gắn với chức năng hiển thị dữ liệu cho phép chọn tên môn 
học  và hiển thị các thông tin về sinh viên tham gia môn học đó. */

namespace ngay25_5
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=Ngay25-5;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDanhSachMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                }
                string query = "SELECT * FROM MONHOC";
                using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnDanhSachSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                }
                string query = "SELECT * FROM SV";
                using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnDanhSachDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                }
                string query = " SELECT * FROM DIEM";
                using (SqlDataAdapter da = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    if (string.IsNullOrWhiteSpace(txtMaSoMonHoc.Text) || string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                        string.IsNullOrWhiteSpace(txtSoTinChi.Text) || string.IsNullOrWhiteSpace(txtTinhChat.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin trước khi thêm");
                        return;
                    }
                    sqlCon.Open();
                    string query = " INSERT INTO MONHOC(MSMonHoc,TenMonHoc,SoTinChi,TinhChat) VALUES (@MSMonHoc,@TenMonHoc,@SoTinChi,@TinhChat)";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MSMonHoc", txtMaSoMonHoc.Text);
                        cmd.Parameters.AddWithValue("@TenMonHoc", txtTenMonHoc.Text);
                        cmd.Parameters.AddWithValue("@SoTinChi", txtSoTinChi.Text);
                        cmd.Parameters.AddWithValue("@TinhChat", txtTinhChat.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnSuaMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "UPDATE MONHOC SET MSMonHoc=@MSMonHoc,TenMonHoc=@TenMonHoc,SoTinChi=@SoTinChi,TinhChat=@TinhChat WHERE MSMonHoc=@MSMonHoc";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MSMonHoc", txtMaSoMonHoc.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenMonHoc", txtTenMonHoc.Text);
                        cmd.Parameters.AddWithValue("@SoTinChi", txtSoTinChi.Text);
                        cmd.Parameters.AddWithValue("@TinhChat", txtTinhChat.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không tim thấy môn học để sửa");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    if (string.IsNullOrWhiteSpace(txtMaSV.Text)
                        || string.IsNullOrWhiteSpace(txtHoTen.Text)
                        || string.IsNullOrWhiteSpace(txtNgaySinh.Text)
                        || string.IsNullOrWhiteSpace(txtLop.Text))
                    {
                        MessageBox.Show("vui lòng nhập đủ thông tin sinh viên");
                        return;
                    }
                    sqlCon.Open();
                    string query = "INSERT INTO SV(MaSV,HoTen,NgaySinh,Lop)VALUES(@MaSV,@HoTen,@NgaySinh,@Lop)";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text);
                        cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("thêm thành công");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }

        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    if (string.IsNullOrWhiteSpace(txtMaSoMonHoc.Text)
                        || string.IsNullOrWhiteSpace(txtMaSV.Text)
                        || string.IsNullOrWhiteSpace(txtDiem.Text))
                    {
                        MessageBox.Show("vui lòng nhập đủ thông tin : MaMonHoc,MaSV,Diem");
                        return;
                    }
                    sqlCon.Open();
                    string query = "INSERT INTO DIEM(MaSV,MSMonHoc,DiemThi) VALUES (@MaSV,@MSMonHoc,@DiemThi)";
                    using(SqlCommand cmd=new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@MSMonHoc", txtMaSoMonHoc.Text);
                        cmd.Parameters.AddWithValue("@DiemThi", txtDiem.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("thêm thành công");
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
            txtMaSoMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtSoTinChi.Clear();
            txtTinhChat.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtLop.Clear();
            txtDiem.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSoMonHoc.Text))
                {
                    MessageBox.Show("vui lòng nhập mã số môn học");
                    return;
                }
                using(SqlConnection sqlCon=new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM MONHOC WHERE MSMonHoc=@MSMonHoc";
                    using(SqlCommand cmd =new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@MSMonHoc", txtMaSoMonHoc.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("xóa thành công");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }  */
    }
}
