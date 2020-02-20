namespace GUI
{
    partial class frmAccountManager
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
            this.tabPageQLTK = new System.Windows.Forms.TabControl();
            this.tabPageTaiKhoanPH = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSTKPH = new System.Windows.Forms.DataGridView();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTaoTaiKhoan = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.tlpAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSTKAdmin = new System.Windows.Forms.DataGridView();
            this.lblTimKiemAdmin = new System.Windows.Forms.Label();
            this.txtTimKiemAdmin = new System.Windows.Forms.TextBox();
            this.tlpTaoTKAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenTKAdmin = new System.Windows.Forms.Label();
            this.lblMatKhauAdmin = new System.Windows.Forms.Label();
            this.lblQuyenAdmin = new System.Windows.Forms.Label();
            this.chkQuyenAdmin = new System.Windows.Forms.CheckBox();
            this.txtNhapMatKhauAdmin = new System.Windows.Forms.TextBox();
            this.txtNhapTenAdmin = new System.Windows.Forms.TextBox();
            this.btnSuaAdmin = new System.Windows.Forms.Button();
            this.btnXoaAdmin = new System.Windows.Forms.Button();
            this.btnThemAdmin = new System.Windows.Forms.Button();
            this.lblTaoTKAdmin = new System.Windows.Forms.Label();
            this.tabPageTaiKhoanGiaoVien = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.lblNhapTenGV = new System.Windows.Forms.Label();
            this.txtNhapTenGVCanTim = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboLopPhuTrach = new System.Windows.Forms.ComboBox();
            this.lblIDLop = new System.Windows.Forms.Label();
            this.lblIDMon = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtNhapTenGV = new System.Windows.Forms.TextBox();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblIDTKT = new System.Windows.Forms.Label();
            this.txtNhapID = new System.Windows.Forms.TextBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.tabPageQLTK.SuspendLayout();
            this.tabPageTaiKhoanPH.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKPH)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tlpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKAdmin)).BeginInit();
            this.tlpTaoTKAdmin.SuspendLayout();
            this.tabPageTaiKhoanGiaoVien.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageQLTK
            // 
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanPH);
            this.tabPageQLTK.Controls.Add(this.tabPageAdmin);
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanGiaoVien);
            this.tabPageQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabPageQLTK.Name = "tabPageQLTK";
            this.tabPageQLTK.SelectedIndex = 0;
            this.tabPageQLTK.Size = new System.Drawing.Size(1266, 724);
            this.tabPageQLTK.TabIndex = 0;
            // 
            // tabPageTaiKhoanPH
            // 
            this.tabPageTaiKhoanPH.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTaiKhoanPH.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanPH.Name = "tabPageTaiKhoanPH";
            this.tabPageTaiKhoanPH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaiKhoanPH.Size = new System.Drawing.Size(1258, 695);
            this.tabPageTaiKhoanPH.TabIndex = 0;
            this.tabPageTaiKhoanPH.Text = "Tài Khoản Phụ Huynh";
            this.tabPageTaiKhoanPH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSTKPH, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTimKiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimkiem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTaoTaiKhoan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 585F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDSTKPH
            // 
            this.dgvDSTKPH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTKPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTKPH.Location = new System.Drawing.Point(3, 106);
            this.dgvDSTKPH.Name = "dgvDSTKPH";
            this.dgvDSTKPH.RowTemplate.Height = 24;
            this.dgvDSTKPH.Size = new System.Drawing.Size(620, 580);
            this.dgvDSTKPH.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(3, 42);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(254, 20);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Nhập ID Hoặc Tên Tài Khoản";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimkiem.Location = new System.Drawing.Point(3, 76);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(620, 22);
            this.txtTimkiem.TabIndex = 2;
            // 
            // lblTaoTaiKhoan
            // 
            this.lblTaoTaiKhoan.AutoSize = true;
            this.lblTaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoTaiKhoan.Location = new System.Drawing.Point(629, 42);
            this.lblTaoTaiKhoan.Name = "lblTaoTaiKhoan";
            this.lblTaoTaiKhoan.Size = new System.Drawing.Size(166, 20);
            this.lblTaoTaiKhoan.TabIndex = 3;
            this.lblTaoTaiKhoan.Text = "Tạo Tài Khoản Mới";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.02913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.97087F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel2.Controls.Add(this.lblMatKhau, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTenTK, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNhapTen, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMatKhau, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnDatLaiMK, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 2, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(629, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.37838F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 610);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(3, 178);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(194, 30);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Nhập Mật Khẩu";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(3, 124);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(194, 28);
            this.lblTenTK.TabIndex = 4;
            this.lblTenTK.Text = "Nhập Tên Tài Khoản";
            // 
            // txtNhapTen
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtNhapTen, 2);
            this.txtNhapTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTen.Location = new System.Drawing.Point(203, 127);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(414, 22);
            this.txtNhapTen.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtMatKhau, 2);
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Location = new System.Drawing.Point(203, 181);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(414, 22);
            this.txtMatKhau.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(194, 60);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Tài Khoản";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatLaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLaiMK.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMK.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMK.Location = new System.Drawing.Point(203, 272);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(202, 60);
            this.btnDatLaiMK.TabIndex = 9;
            this.btnDatLaiMK.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(411, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(206, 60);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa Tài Khoản";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.tlpAdmin);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(1258, 695);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // tlpAdmin
            // 
            this.tlpAdmin.ColumnCount = 2;
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.30671F));
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.69329F));
            this.tlpAdmin.Controls.Add(this.dgvDSTKAdmin, 0, 3);
            this.tlpAdmin.Controls.Add(this.lblTimKiemAdmin, 0, 1);
            this.tlpAdmin.Controls.Add(this.txtTimKiemAdmin, 0, 2);
            this.tlpAdmin.Controls.Add(this.tlpTaoTKAdmin, 1, 2);
            this.tlpAdmin.Controls.Add(this.lblTaoTKAdmin, 1, 1);
            this.tlpAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdmin.Location = new System.Drawing.Point(3, 3);
            this.tlpAdmin.Name = "tlpAdmin";
            this.tlpAdmin.RowCount = 4;
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.565863F));
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.43414F));
            this.tlpAdmin.Size = new System.Drawing.Size(1252, 689);
            this.tlpAdmin.TabIndex = 0;
            // 
            // dgvDSTKAdmin
            // 
            this.dgvDSTKAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTKAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTKAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTKAdmin.Location = new System.Drawing.Point(3, 132);
            this.dgvDSTKAdmin.Name = "dgvDSTKAdmin";
            this.dgvDSTKAdmin.RowTemplate.Height = 24;
            this.dgvDSTKAdmin.Size = new System.Drawing.Size(724, 554);
            this.dgvDSTKAdmin.TabIndex = 0;
            // 
            // lblTimKiemAdmin
            // 
            this.lblTimKiemAdmin.AutoSize = true;
            this.lblTimKiemAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemAdmin.Location = new System.Drawing.Point(3, 68);
            this.lblTimKiemAdmin.Name = "lblTimKiemAdmin";
            this.lblTimKiemAdmin.Size = new System.Drawing.Size(254, 20);
            this.lblTimKiemAdmin.TabIndex = 2;
            this.lblTimKiemAdmin.Text = "Nhập ID Hoặc Tên Tài Khoản";
            // 
            // txtTimKiemAdmin
            // 
            this.txtTimKiemAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemAdmin.Location = new System.Drawing.Point(3, 99);
            this.txtTimKiemAdmin.Name = "txtTimKiemAdmin";
            this.txtTimKiemAdmin.Size = new System.Drawing.Size(724, 27);
            this.txtTimKiemAdmin.TabIndex = 3;
            // 
            // tlpTaoTKAdmin
            // 
            this.tlpTaoTKAdmin.ColumnCount = 3;
            this.tlpTaoTKAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2907F));
            this.tlpTaoTKAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7093F));
            this.tlpTaoTKAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpTaoTKAdmin.Controls.Add(this.lblTenTKAdmin, 0, 1);
            this.tlpTaoTKAdmin.Controls.Add(this.lblMatKhauAdmin, 0, 2);
            this.tlpTaoTKAdmin.Controls.Add(this.lblQuyenAdmin, 0, 3);
            this.tlpTaoTKAdmin.Controls.Add(this.chkQuyenAdmin, 1, 3);
            this.tlpTaoTKAdmin.Controls.Add(this.txtNhapMatKhauAdmin, 1, 2);
            this.tlpTaoTKAdmin.Controls.Add(this.txtNhapTenAdmin, 1, 1);
            this.tlpTaoTKAdmin.Controls.Add(this.btnSuaAdmin, 1, 6);
            this.tlpTaoTKAdmin.Controls.Add(this.btnXoaAdmin, 2, 6);
            this.tlpTaoTKAdmin.Controls.Add(this.btnThemAdmin, 0, 6);
            this.tlpTaoTKAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTaoTKAdmin.Location = new System.Drawing.Point(733, 99);
            this.tlpTaoTKAdmin.Name = "tlpTaoTKAdmin";
            this.tlpTaoTKAdmin.RowCount = 8;
            this.tlpAdmin.SetRowSpan(this.tlpTaoTKAdmin, 2);
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.53968F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46032F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpTaoTKAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tlpTaoTKAdmin.Size = new System.Drawing.Size(516, 587);
            this.tlpTaoTKAdmin.TabIndex = 4;
            // 
            // lblTenTKAdmin
            // 
            this.lblTenTKAdmin.AutoSize = true;
            this.lblTenTKAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTKAdmin.Location = new System.Drawing.Point(3, 156);
            this.lblTenTKAdmin.Name = "lblTenTKAdmin";
            this.lblTenTKAdmin.Size = new System.Drawing.Size(90, 20);
            this.lblTenTKAdmin.TabIndex = 6;
            this.lblTenTKAdmin.Text = "Nhập tên ";
            // 
            // lblMatKhauAdmin
            // 
            this.lblMatKhauAdmin.AutoSize = true;
            this.lblMatKhauAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauAdmin.Location = new System.Drawing.Point(3, 189);
            this.lblMatKhauAdmin.Name = "lblMatKhauAdmin";
            this.lblMatKhauAdmin.Size = new System.Drawing.Size(137, 20);
            this.lblMatKhauAdmin.TabIndex = 7;
            this.lblMatKhauAdmin.Text = "Nhập Mật Khẩu";
            // 
            // lblQuyenAdmin
            // 
            this.lblQuyenAdmin.AutoSize = true;
            this.lblQuyenAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenAdmin.Location = new System.Drawing.Point(3, 221);
            this.lblQuyenAdmin.Name = "lblQuyenAdmin";
            this.lblQuyenAdmin.Size = new System.Drawing.Size(138, 20);
            this.lblQuyenAdmin.TabIndex = 8;
            this.lblQuyenAdmin.Text = "Quyền Quản Lý";
            // 
            // chkQuyenAdmin
            // 
            this.chkQuyenAdmin.AutoSize = true;
            this.chkQuyenAdmin.Location = new System.Drawing.Point(177, 224);
            this.chkQuyenAdmin.Name = "chkQuyenAdmin";
            this.chkQuyenAdmin.Size = new System.Drawing.Size(47, 21);
            this.chkQuyenAdmin.TabIndex = 9;
            this.chkQuyenAdmin.Text = "Có";
            this.chkQuyenAdmin.UseVisualStyleBackColor = true;
            // 
            // txtNhapMatKhauAdmin
            // 
            this.tlpTaoTKAdmin.SetColumnSpan(this.txtNhapMatKhauAdmin, 2);
            this.txtNhapMatKhauAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapMatKhauAdmin.Location = new System.Drawing.Point(177, 192);
            this.txtNhapMatKhauAdmin.Name = "txtNhapMatKhauAdmin";
            this.txtNhapMatKhauAdmin.Size = new System.Drawing.Size(336, 22);
            this.txtNhapMatKhauAdmin.TabIndex = 10;
            // 
            // txtNhapTenAdmin
            // 
            this.tlpTaoTKAdmin.SetColumnSpan(this.txtNhapTenAdmin, 2);
            this.txtNhapTenAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTenAdmin.Location = new System.Drawing.Point(177, 159);
            this.txtNhapTenAdmin.Name = "txtNhapTenAdmin";
            this.txtNhapTenAdmin.Size = new System.Drawing.Size(336, 22);
            this.txtNhapTenAdmin.TabIndex = 11;
            // 
            // btnSuaAdmin
            // 
            this.btnSuaAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuaAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaAdmin.FlatAppearance.BorderSize = 0;
            this.btnSuaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSuaAdmin.Location = new System.Drawing.Point(177, 368);
            this.btnSuaAdmin.Name = "btnSuaAdmin";
            this.btnSuaAdmin.Size = new System.Drawing.Size(165, 62);
            this.btnSuaAdmin.TabIndex = 13;
            this.btnSuaAdmin.Text = "Sửa";
            this.btnSuaAdmin.UseVisualStyleBackColor = false;
            // 
            // btnXoaAdmin
            // 
            this.btnXoaAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaAdmin.FlatAppearance.BorderSize = 0;
            this.btnXoaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAdmin.ForeColor = System.Drawing.Color.White;
            this.btnXoaAdmin.Location = new System.Drawing.Point(348, 368);
            this.btnXoaAdmin.Name = "btnXoaAdmin";
            this.btnXoaAdmin.Size = new System.Drawing.Size(165, 62);
            this.btnXoaAdmin.TabIndex = 14;
            this.btnXoaAdmin.Text = "Xóa";
            this.btnXoaAdmin.UseVisualStyleBackColor = false;
            // 
            // btnThemAdmin
            // 
            this.btnThemAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemAdmin.FlatAppearance.BorderSize = 0;
            this.btnThemAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAdmin.ForeColor = System.Drawing.Color.White;
            this.btnThemAdmin.Location = new System.Drawing.Point(3, 368);
            this.btnThemAdmin.Name = "btnThemAdmin";
            this.btnThemAdmin.Size = new System.Drawing.Size(168, 62);
            this.btnThemAdmin.TabIndex = 12;
            this.btnThemAdmin.Text = "Thêm";
            this.btnThemAdmin.UseVisualStyleBackColor = false;
            // 
            // lblTaoTKAdmin
            // 
            this.lblTaoTKAdmin.AutoSize = true;
            this.lblTaoTKAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoTKAdmin.Location = new System.Drawing.Point(733, 68);
            this.lblTaoTKAdmin.Name = "lblTaoTKAdmin";
            this.lblTaoTKAdmin.Size = new System.Drawing.Size(166, 20);
            this.lblTaoTKAdmin.TabIndex = 5;
            this.lblTaoTKAdmin.Text = "Tạo Tài Khoản Mới";
            // 
            // tabPageTaiKhoanGiaoVien
            // 
            this.tabPageTaiKhoanGiaoVien.Controls.Add(this.tableLayoutPanel5);
            this.tabPageTaiKhoanGiaoVien.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanGiaoVien.Name = "tabPageTaiKhoanGiaoVien";
            this.tabPageTaiKhoanGiaoVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaiKhoanGiaoVien.Size = new System.Drawing.Size(1258, 695);
            this.tabPageTaiKhoanGiaoVien.TabIndex = 2;
            this.tabPageTaiKhoanGiaoVien.Text = "Tài Khoản Giáo Viên";
            this.tabPageTaiKhoanGiaoVien.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.dgvDSGV, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblNhapTenGV, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtNhapTenGVCanTim, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.728539F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.27146F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1252, 689);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AutoGenerateColumns = false;
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn});
            this.dgvDSGV.DataSource = this.bsDSGV;
            this.dgvDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSGV.Location = new System.Drawing.Point(3, 64);
            this.dgvDSGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSGV.Name = "dgvDSGV";
            this.tableLayoutPanel5.SetRowSpan(this.dgvDSGV, 3);
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.Size = new System.Drawing.Size(620, 623);
            this.dgvDSGV.TabIndex = 0;
            // 
            // iDTKTDataGridViewTextBoxColumn
            // 
            this.iDTKTDataGridViewTextBoxColumn.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.HeaderText = "ID Giáo Viên";
            this.iDTKTDataGridViewTextBoxColumn.Name = "iDTKTDataGridViewTextBoxColumn";
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên Giáo Viên";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // iDMonHocDataGridViewTextBoxColumn
            // 
            this.iDMonHocDataGridViewTextBoxColumn.DataPropertyName = "IDMonHoc";
            this.iDMonHocDataGridViewTextBoxColumn.HeaderText = "Môn Phụ Trách";
            this.iDMonHocDataGridViewTextBoxColumn.Name = "iDMonHocDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "Lớp Phụ Trách";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // lblNhapTenGV
            // 
            this.lblNhapTenGV.AutoSize = true;
            this.lblNhapTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhapTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTenGV.Location = new System.Drawing.Point(3, 0);
            this.lblNhapTenGV.Name = "lblNhapTenGV";
            this.lblNhapTenGV.Size = new System.Drawing.Size(620, 38);
            this.lblNhapTenGV.TabIndex = 1;
            this.lblNhapTenGV.Text = "Nhập Tên Cần Tìm";
            // 
            // txtNhapTenGVCanTim
            // 
            this.txtNhapTenGVCanTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTenGVCanTim.Location = new System.Drawing.Point(3, 40);
            this.txtNhapTenGVCanTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapTenGVCanTim.Name = "txtNhapTenGVCanTim";
            this.txtNhapTenGVCanTim.Size = new System.Drawing.Size(620, 22);
            this.txtNhapTenGVCanTim.TabIndex = 2;
            this.txtNhapTenGVCanTim.TextChanged += new System.EventHandler(this.txtNhapTenGVCanTim_TextChanged);
            this.txtNhapTenGVCanTim.Enter += new System.EventHandler(this.txtNhapTenGVCanTim_Enter);
            this.txtNhapTenGVCanTim.Leave += new System.EventHandler(this.txtNhapTenGVCanTim_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.37558F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.62442F));
            this.tableLayoutPanel4.Controls.Add(this.cboLopPhuTrach, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblIDLop, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblIDMon, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtSDT, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblSDT, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtNhapTenGV, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTenGV, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblIDTKT, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtNhapID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboMonHoc, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(629, 64);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(620, 328);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // cboLopPhuTrach
            // 
            this.cboLopPhuTrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopPhuTrach.FormattingEnabled = true;
            this.cboLopPhuTrach.Location = new System.Drawing.Point(197, 218);
            this.cboLopPhuTrach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLopPhuTrach.Name = "cboLopPhuTrach";
            this.cboLopPhuTrach.Size = new System.Drawing.Size(420, 28);
            this.cboLopPhuTrach.TabIndex = 9;
            // 
            // lblIDLop
            // 
            this.lblIDLop.AutoSize = true;
            this.lblIDLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIDLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLop.Location = new System.Drawing.Point(3, 216);
            this.lblIDLop.Name = "lblIDLop";
            this.lblIDLop.Size = new System.Drawing.Size(188, 54);
            this.lblIDLop.TabIndex = 8;
            this.lblIDLop.Text = "Lớp Phụ Trách";
            // 
            // lblIDMon
            // 
            this.lblIDMon.AutoSize = true;
            this.lblIDMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIDMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMon.Location = new System.Drawing.Point(3, 162);
            this.lblIDMon.Name = "lblIDMon";
            this.lblIDMon.Size = new System.Drawing.Size(188, 54);
            this.lblIDMon.TabIndex = 6;
            this.lblIDMon.Text = "Môn Dạy Phụ Trách";
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(197, 110);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(420, 27);
            this.txtSDT.TabIndex = 5;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(3, 108);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(188, 54);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SĐT";
            // 
            // txtNhapTenGV
            // 
            this.txtNhapTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenGV.Location = new System.Drawing.Point(197, 56);
            this.txtNhapTenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapTenGV.Name = "txtNhapTenGV";
            this.txtNhapTenGV.Size = new System.Drawing.Size(420, 27);
            this.txtNhapTenGV.TabIndex = 3;
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(3, 54);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(188, 54);
            this.lblTenGV.TabIndex = 2;
            this.lblTenGV.Text = "Nhập Tên";
            // 
            // lblIDTKT
            // 
            this.lblIDTKT.AutoSize = true;
            this.lblIDTKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTKT.Location = new System.Drawing.Point(3, 0);
            this.lblIDTKT.Name = "lblIDTKT";
            this.lblIDTKT.Size = new System.Drawing.Size(77, 20);
            this.lblIDTKT.TabIndex = 0;
            this.lblIDTKT.Text = "Nhập ID";
            // 
            // txtNhapID
            // 
            this.txtNhapID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapID.Location = new System.Drawing.Point(197, 2);
            this.txtNhapID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapID.Name = "txtNhapID";
            this.txtNhapID.Size = new System.Drawing.Size(420, 27);
            this.txtNhapID.TabIndex = 1;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(197, 164);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(420, 28);
            this.cboMonHoc.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnXoaGV, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSuaGV, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnThemGV, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(629, 396);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 88);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaGV.FlatAppearance.BorderSize = 0;
            this.btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.Location = new System.Drawing.Point(415, 2);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(202, 84);
            this.btnXoaGV.TabIndex = 2;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuaGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaGV.FlatAppearance.BorderSize = 0;
            this.btnSuaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGV.ForeColor = System.Drawing.Color.White;
            this.btnSuaGV.Location = new System.Drawing.Point(209, 2);
            this.btnSuaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(200, 84);
            this.btnSuaGV.TabIndex = 1;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = false;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemGV.FlatAppearance.BorderSize = 0;
            this.btnThemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGV.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.Location = new System.Drawing.Point(3, 2);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(200, 84);
            this.btnThemGV.TabIndex = 0;
            this.btnThemGV.Text = "Thêm ";
            this.btnThemGV.UseVisualStyleBackColor = false;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1266, 724);
            this.Controls.Add(this.tabPageQLTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            this.tabPageQLTK.ResumeLayout(false);
            this.tabPageTaiKhoanPH.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKPH)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageAdmin.ResumeLayout(false);
            this.tlpAdmin.ResumeLayout(false);
            this.tlpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKAdmin)).EndInit();
            this.tlpTaoTKAdmin.ResumeLayout(false);
            this.tlpTaoTKAdmin.PerformLayout();
            this.tabPageTaiKhoanGiaoVien.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageQLTK;
        private System.Windows.Forms.TabPage tabPageTaiKhoanPH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.DataGridView dgvDSTKPH;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTaoTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDatLaiMK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TableLayoutPanel tlpAdmin;
        private System.Windows.Forms.DataGridView dgvDSTKAdmin;
        private System.Windows.Forms.Label lblTimKiemAdmin;
        private System.Windows.Forms.TextBox txtTimKiemAdmin;
        private System.Windows.Forms.TableLayoutPanel tlpTaoTKAdmin;
        private System.Windows.Forms.Label lblTenTKAdmin;
        private System.Windows.Forms.Label lblMatKhauAdmin;
        private System.Windows.Forms.Label lblQuyenAdmin;
        private System.Windows.Forms.CheckBox chkQuyenAdmin;
        private System.Windows.Forms.TextBox txtNhapMatKhauAdmin;
        private System.Windows.Forms.TextBox txtNhapTenAdmin;
        private System.Windows.Forms.Button btnSuaAdmin;
        private System.Windows.Forms.Button btnXoaAdmin;
        private System.Windows.Forms.Button btnThemAdmin;
        private System.Windows.Forms.Label lblTaoTKAdmin;
        private System.Windows.Forms.TabPage tabPageTaiKhoanGiaoVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.Label lblNhapTenGV;
        private System.Windows.Forms.TextBox txtNhapTenGVCanTim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cboLopPhuTrach;
        private System.Windows.Forms.Label lblIDLop;
        private System.Windows.Forms.Label lblIDMon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtNhapTenGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblIDTKT;
        private System.Windows.Forms.TextBox txtNhapID;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnThemGV;
    }
}