namespace ngay10_6_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHoSo = new TextBox();
            txtMaBenhNhan = new TextBox();
            dtpTuNgay = new DateTimePicker();
            txtLoaBenh = new TextBox();
            chkCapCuu = new CheckBox();
            btnLoad = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            dtpDenNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(594, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã hồ sơ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã bệnh nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 89);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Ngày Khám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 122);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Loại bệnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 154);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 5;
            label5.Text = "Tình trạng cấp cứu";
            // 
            // txtMaHoSo
            // 
            txtMaHoSo.Location = new Point(114, 6);
            txtMaHoSo.Name = "txtMaHoSo";
            txtMaHoSo.Size = new Size(100, 23);
            txtMaHoSo.TabIndex = 6;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.Location = new Point(114, 45);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.Size = new Size(100, 23);
            txtMaBenhNhan.TabIndex = 7;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(114, 83);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(200, 23);
            dtpTuNgay.TabIndex = 8;
            // 
            // txtLoaBenh
            // 
            txtLoaBenh.Location = new Point(114, 122);
            txtLoaBenh.Name = "txtLoaBenh";
            txtLoaBenh.Size = new Size(100, 23);
            txtLoaBenh.TabIndex = 9;
            // 
            // chkCapCuu
            // 
            chkCapCuu.AutoSize = true;
            chkCapCuu.Location = new Point(133, 154);
            chkCapCuu.Name = "chkCapCuu";
            chkCapCuu.Size = new Size(68, 19);
            chkCapCuu.TabIndex = 10;
            chkCapCuu.Text = "cấp cứu";
            chkCapCuu.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(360, 9);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(459, 9);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 24);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(393, 83);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(200, 23);
            dtpDenNgay.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 348);
            Controls.Add(dtpDenNgay);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLoad);
            Controls.Add(chkCapCuu);
            Controls.Add(txtLoaBenh);
            Controls.Add(dtpTuNgay);
            Controls.Add(txtMaBenhNhan);
            Controls.Add(txtMaHoSo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHoSo;
        private TextBox txtMaBenhNhan;
        private DateTimePicker dtpTuNgay;
        private TextBox txtLoaBenh;
        private CheckBox chkCapCuu;
        private Button btnLoad;
        private Button btnTimKiem;
        private Button btnXoa;
        private DateTimePicker dtpDenNgay;
    }
}
