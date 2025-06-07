namespace _30_Itnet_DinhTienManh_22103100308
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaPhong = new TextBox();
            txtTenPhong = new TextBox();
            txtSucChua = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            rdoCo = new RadioButton();
            rdoKhong = new RadioButton();
            dtpNgayDuaVaoSuDung = new DateTimePicker();
            btnSua = new Button();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "MaPhong";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "TenPhong";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "SucChua";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(77, 9);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(100, 23);
            txtMaPhong.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(77, 40);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(100, 23);
            txtTenPhong.TabIndex = 4;
            // 
            // txtSucChua
            // 
            txtSucChua.Location = new Point(77, 71);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(100, 23);
            txtSucChua.TabIndex = 5;
            txtSucChua.TextChanged += txtSucChua_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 7;
            label5.Text = "Ngày đưa vào sử dụng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(572, 150);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "Có máy chiếu";
            // 
            // rdoCo
            // 
            rdoCo.AutoSize = true;
            rdoCo.Location = new Point(106, 105);
            rdoCo.Name = "rdoCo";
            rdoCo.Size = new Size(40, 19);
            rdoCo.TabIndex = 10;
            rdoCo.TabStop = true;
            rdoCo.Text = "Có";
            rdoCo.UseVisualStyleBackColor = true;
            // 
            // rdoKhong
            // 
            rdoKhong.AutoSize = true;
            rdoKhong.Location = new Point(152, 105);
            rdoKhong.Name = "rdoKhong";
            rdoKhong.Size = new Size(59, 19);
            rdoKhong.TabIndex = 11;
            rdoKhong.TabStop = true;
            rdoKhong.Text = "không";
            rdoKhong.UseVisualStyleBackColor = true;
            // 
            // dtpNgayDuaVaoSuDung
            // 
            dtpNgayDuaVaoSuDung.Location = new Point(144, 130);
            dtpNgayDuaVaoSuDung.Name = "dtpNgayDuaVaoSuDung";
            dtpNgayDuaVaoSuDung.Size = new Size(200, 23);
            dtpNgayDuaVaoSuDung.TabIndex = 12;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(308, 41);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(308, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 344);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(dtpNgayDuaVaoSuDung);
            Controls.Add(rdoKhong);
            Controls.Add(rdoCo);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtSucChua);
            Controls.Add(txtTenPhong);
            Controls.Add(txtMaPhong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaPhong;
        private TextBox txtTenPhong;
        private TextBox txtSucChua;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private RadioButton rdoCo;
        private RadioButton rdoKhong;
        private DateTimePicker dtpNgayDuaVaoSuDung;
        private Button btnSua;
        private Button btnTimKiem;
    }
}
