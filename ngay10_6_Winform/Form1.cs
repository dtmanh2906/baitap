using ngay10_6_Winform.model;
using System;

namespace ngay10_6_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var dsHoso = db.HoSoKhamBenhs.ToList();
                dataGridView1.DataSource = dsHoso;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            // Ki?m tra ği?u ki?n
            if (tuNgay > denNgay)
            {
                MessageBox.Show("T? ngày ph?i nh? hõn ho?c b?ng ğ?n ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DataContext())
            {
                var ketQua = db.HoSoKhamBenhs
                    .Where(h => h.NgayKham.Date >= tuNgay && h.NgayKham.Date <= denNgay)
                    .ToList();

                dataGridView1.DataSource = ketQua;
            }
        }
        private void LoadData()
        {
            using (var db = new DataContext())
            {
                dataGridView1.DataSource = db.HoSoKhamBenhs.ToList();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Ki?m tra có ch?n d?ng nào chıa
            if(dataGridView1.CurrentRow != null)
            {
                // L?y m? h? sõ t? d?ng ğang ch?n
                int maHoSo = (int)dataGridView1.CurrentRow.Cells["MaHoSo"].Value;

                // H?p tho?i xác nh?n
                DialogResult result = MessageBox.Show("B?n có ch?c mu?n xóa h? sõ này?",
                                                      "Xác nh?n xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DataContext())
                    {
                        var hoSo = db.HoSoKhamBenhs.Find(maHoSo);
                        if (hoSo != null)
                        {
                            db.HoSoKhamBenhs.Remove(hoSo);
                            db.SaveChanges();
                            MessageBox.Show("Ğ? xóa thành công!", "Thông báo");

                            // T?i l?i d? li?u
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không t?m th?y h? sõ trong CSDL!", "L?i");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui l?ng ch?n h? sõ c?n xóa!", "Thông báo");
            }
        }
    }
}
