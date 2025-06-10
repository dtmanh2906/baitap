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

            // Ki?m tra �i?u ki?n
            if (tuNgay > denNgay)
            {
                MessageBox.Show("T? ng�y ph?i nh? h�n ho?c b?ng �?n ng�y!", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Ki?m tra c� ch?n d?ng n�o ch�a
            if(dataGridView1.CurrentRow != null)
            {
                // L?y m? h? s� t? d?ng �ang ch?n
                int maHoSo = (int)dataGridView1.CurrentRow.Cells["MaHoSo"].Value;

                // H?p tho?i x�c nh?n
                DialogResult result = MessageBox.Show("B?n c� ch?c mu?n x�a h? s� n�y?",
                                                      "X�c nh?n x�a",
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
                            MessageBox.Show("�? x�a th�nh c�ng!", "Th�ng b�o");

                            // T?i l?i d? li?u
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Kh�ng t?m th?y h? s� trong CSDL!", "L?i");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui l?ng ch?n h? s� c?n x�a!", "Th�ng b�o");
            }
        }
    }
}
