namespace GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLopHoc = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLop = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnThongBaoHS = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnThoiKhoaBieu = new System.Windows.Forms.Button();
            this.btnPCMonHoc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiemDanh.FlatAppearance.BorderSize = 0;
            this.btnDiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemDanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.ForeColor = System.Drawing.Color.White;
            this.btnDiemDanh.Location = new System.Drawing.Point(248, 82);
            this.btnDiemDanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(238, 76);
            this.btnDiemDanh.TabIndex = 2;
            this.btnDiemDanh.Text = "Điểm danh";
            this.btnDiemDanh.UseVisualStyleBackColor = false;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountManagement.FlatAppearance.BorderSize = 0;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountManagement.ForeColor = System.Drawing.Color.White;
            this.btnAccountManagement.Location = new System.Drawing.Point(248, 482);
            this.btnAccountManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(238, 76);
            this.btnAccountManagement.TabIndex = 1;
            this.btnAccountManagement.Text = "Quản Lý Tài Khoản";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStudentManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentManagement.FlatAppearance.BorderSize = 0;
            this.btnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManagement.ForeColor = System.Drawing.Color.White;
            this.btnStudentManagement.Location = new System.Drawing.Point(248, 2);
            this.btnStudentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.tableLayoutPanel1.SetRowSpan(this.btnStudentManagement, 2);
            this.btnStudentManagement.Size = new System.Drawing.Size(238, 76);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "Quản Lý Học Sinh";
            this.btnStudentManagement.UseVisualStyleBackColor = false;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menuToolStripMenuItem.Text = "Xin chào ";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem.Text = "Đổi mật khẩu";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.LogOutToolStripMenuItem.Text = "Đăng Xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // txtLopHoc
            // 
            this.txtLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLopHoc.ForeColor = System.Drawing.Color.Gray;
            this.txtLopHoc.Location = new System.Drawing.Point(2, 57);
            this.txtLopHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtLopHoc.Name = "txtLopHoc";
            this.txtLopHoc.Size = new System.Drawing.Size(242, 26);
            this.txtLopHoc.TabIndex = 4;
            this.txtLopHoc.Text = "Nhập ID hoặc Tên lớp";
            this.txtLopHoc.TextChanged += new System.EventHandler(this.txtLopHoc_TextChanged);
            this.txtLopHoc.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtLopHoc.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40618F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachLop, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLopHoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStudentManagement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDiem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAccountManagement, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnThongBaoHS, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnThongBao, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDiemDanh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnThoiKhoaBieu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPCMonHoc, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 655);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AutoGenerateColumns = false;
            this.dgvDanhSachLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn});
            this.dgvDanhSachLop.DataSource = this.bsLop;
            this.dgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(2, 82);
            this.dgvDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowHeadersWidth = 30;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDanhSachLop, 7);
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(242, 571);
            this.dgvDanhSachLop.TabIndex = 2;
            this.dgvDanhSachLop.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDanhSachLop_CellBeginEdit);
            this.dgvDanhSachLop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellEndEdit);
            this.dgvDanhSachLop.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDanhSachLop_UserAddedRow);
            this.dgvDanhSachLop.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDanhSachLop_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsLop
            // 
            this.bsLop.DataSource = typeof(DTO.Lop);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiem.FlatAppearance.BorderSize = 0;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.White;
            this.btnDiem.Location = new System.Drawing.Point(248, 242);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(238, 76);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Quản lý điểm";
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnThongBaoHS
            // 
            this.btnThongBaoHS.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongBaoHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongBaoHS.FlatAppearance.BorderSize = 0;
            this.btnThongBaoHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBaoHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBaoHS.ForeColor = System.Drawing.Color.White;
            this.btnThongBaoHS.Location = new System.Drawing.Point(248, 322);
            this.btnThongBaoHS.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongBaoHS.Name = "btnThongBaoHS";
            this.btnThongBaoHS.Size = new System.Drawing.Size(238, 76);
            this.btnThongBaoHS.TabIndex = 3;
            this.btnThongBaoHS.Text = "Thông báo riêng học sinh";
            this.btnThongBaoHS.UseVisualStyleBackColor = false;
            this.btnThongBaoHS.Click += new System.EventHandler(this.btnThongBaoChung_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(248, 402);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(238, 76);
            this.btnThongBao.TabIndex = 3;
            this.btnThongBao.Text = "Thông báo Chung";
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnThoiKhoaBieu
            // 
            this.btnThoiKhoaBieu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThoiKhoaBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoiKhoaBieu.FlatAppearance.BorderSize = 0;
            this.btnThoiKhoaBieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoiKhoaBieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoiKhoaBieu.ForeColor = System.Drawing.Color.White;
            this.btnThoiKhoaBieu.Location = new System.Drawing.Point(248, 162);
            this.btnThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            this.btnThoiKhoaBieu.Size = new System.Drawing.Size(238, 76);
            this.btnThoiKhoaBieu.TabIndex = 6;
            this.btnThoiKhoaBieu.Text = "Thời khóa biểu";
            this.btnThoiKhoaBieu.UseVisualStyleBackColor = false;
            this.btnThoiKhoaBieu.Click += new System.EventHandler(this.btnThoiKhoaBieu_Click);
            // 
            // btnPCMonHoc
            // 
            this.btnPCMonHoc.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPCMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPCMonHoc.FlatAppearance.BorderSize = 0;
            this.btnPCMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnPCMonHoc.Location = new System.Drawing.Point(248, 562);
            this.btnPCMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCMonHoc.Name = "btnPCMonHoc";
            this.btnPCMonHoc.Size = new System.Drawing.Size(238, 91);
            this.btnPCMonHoc.TabIndex = 7;
            this.btnPCMonHoc.Text = "Quản lý dạy";
            this.btnPCMonHoc.UseVisualStyleBackColor = false;
            this.btnPCMonHoc.Click += new System.EventHandler(this.btnPCMonHoc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ  Thống Sổ Liên Lạc Điện Tử ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLopHoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnThongBaoHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsLop;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPCMonHoc;
        private System.Windows.Forms.Button btnThoiKhoaBieu;
    }
}