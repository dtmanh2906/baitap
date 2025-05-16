namespace h4._12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bộ môn Hệ Thống Thông Tin");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bộ môn Mạng Máy Tính &TDl");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Khoa Công Nghệ Thông Tin", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Khoa Cơ Khí");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bộ môn Kinh Doanh ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bộ môn Thương mại điện tử");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Khoa Quản Trị Kinh Doanh ", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Khoa Kế Toán");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(116, 79);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Bộ môn Hệ Thống Thông Tin";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Bộ môn Mạng Máy Tính &TDl";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Khoa Công Nghệ Thông Tin";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Khoa Cơ Khí";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Bộ môn Kinh Doanh ";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Bộ môn Thương mại điện tử";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Khoa Quản Trị Kinh Doanh ";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Khoa Kế Toán";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(266, 139);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 323);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Minh họa treeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

