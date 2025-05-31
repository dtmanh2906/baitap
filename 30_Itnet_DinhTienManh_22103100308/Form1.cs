using _30_Itnet_DinhTienManh_22103100308.model;

namespace _30_Itnet_DinhTienManh_22103100308
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                dataGridView1.DataSource = context.PhongThucHanhs.ToList();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int sucChuaMin = int.Parse(txtSucChua.Text);
            using (var context = new AppDBContext())
            {
                var result = context.PhongThucHanhs.Where(p => p.SucChua >= sucChuaMin).ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                txtSucChua.Text = row.Cells["SucChua"].Value.ToString();
                if ((bool)row.Cells["CoMayChieu"].Value)
                {
                    rdoCo.Checked = true;
                }
                else
                {
                    rdoKhong.Checked = true;
                }
                dtpNgayDuaVaoSuDung.Value = DateTime.Parse(row.Cells["NgayDuaVaoSuDung"].Value.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("vui l?ng ch?n ph?ng t? danh sách ");
                return;
            }
            using (var context = new AppDBContext())
            {
                var phong = context.PhongThucHanhs.Find(txtMaPhong.Text);
                if (phong != null)
                {
                    phong.TenPhong = txtTenPhong.Text;
                    phong.SucChua = int.Parse(txtSucChua.Text);
                    phong.CoMayChieu = rdoCo.Checked;
                    phong.NgayDuaVaoSuDung = dtpNgayDuaVaoSuDung.Value;

                    context.SaveChanges();

                    dataGridView1.DataSource = context.PhongThucHanhs.ToList();
                    MessageBox.Show("ð? s?a thông tin ph?ng thành công ");
                }
                else
                {
                    MessageBox.Show("Không t?m th?y ph?ng ð? s?a ");
                }
            }
        }
    }
}
