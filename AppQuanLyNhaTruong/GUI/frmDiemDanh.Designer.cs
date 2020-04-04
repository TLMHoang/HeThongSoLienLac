namespace GUI
{
    partial class frmDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDanh));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vangp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VangK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVangP = new System.Windows.Forms.DataGridView();
            this.IDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvVangK = new System.Windows.Forms.DataGridView();
            this.IDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSHSC = new System.Windows.Forms.DataGridView();
            this.IDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindC = new System.Windows.Forms.TextBox();
            this.cbxLopC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numTu = new System.Windows.Forms.NumericUpDown();
            this.numDen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCupHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangK)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCupHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vắng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnChiTiet, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvVangP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvVangK, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 557);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbxLop
            // 
            this.cbxLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Items.AddRange(new object[] {
            "-----------Lớp-----------"});
            this.cbxLop.Location = new System.Drawing.Point(3, 3);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(144, 28);
            this.cbxLop.TabIndex = 0;
            this.cbxLop.Text = "-----------Lớp-----------";
            this.cbxLop.SelectedValueChanged += new System.EventHandler(this.cbxLop_SelectedValueChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(153, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(372, 26);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập ID hoặc Tên học sinh";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(843, 499);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(3, 499);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(144, 54);
            this.btnChiTiet.TabIndex = 4;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AllowUserToAddRows = false;
            this.dgvDSHS.AutoGenerateColumns = false;
            this.dgvDSHS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.NgaySinh,
            this.Vangp,
            this.VangK});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSHS, 2);
            this.dgvDSHS.DataSource = this.bsHocSinh;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(3, 28);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSHS, 3);
            this.dgvDSHS.Size = new System.Drawing.Size(522, 465);
            this.dgvDSHS.TabIndex = 5;
            this.dgvDSHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHS_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã HS";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Họ tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 103;
            // 
            // Vangp
            // 
            this.Vangp.HeaderText = "Vắng (P)";
            this.Vangp.Name = "Vangp";
            this.Vangp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vangp.Text = "Phép";
            this.Vangp.UseColumnTextForButtonValue = true;
            this.Vangp.Width = 80;
            // 
            // VangK
            // 
            this.VangK.HeaderText = "Vắng (KP)";
            this.VangK.Name = "VangK";
            this.VangK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VangK.Text = "Không";
            this.VangK.UseColumnTextForButtonValue = true;
            this.VangK.Width = 80;
            // 
            // bsHocSinh
            // 
            this.bsHocSinh.DataSource = typeof(DTO.ThongTinHS);
            // 
            // dgvVangP
            // 
            this.dgvVangP.AllowUserToAddRows = false;
            this.dgvVangP.AllowUserToDeleteRows = false;
            this.dgvVangP.BackgroundColor = System.Drawing.Color.White;
            this.dgvVangP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVangP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDP,
            this.TenP,
            this.LopP,
            this.XoaP});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVangP, 3);
            this.dgvVangP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVangP.Location = new System.Drawing.Point(531, 28);
            this.dgvVangP.Name = "dgvVangP";
            this.dgvVangP.ReadOnly = true;
            this.dgvVangP.RowHeadersVisible = false;
            this.dgvVangP.Size = new System.Drawing.Size(460, 217);
            this.dgvVangP.TabIndex = 7;
            this.dgvVangP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVangP_CellContentClick);
            // 
            // IDP
            // 
            this.IDP.HeaderText = "Mã";
            this.IDP.Name = "IDP";
            this.IDP.ReadOnly = true;
            this.IDP.Width = 50;
            // 
            // TenP
            // 
            this.TenP.HeaderText = "Tên Học Sinh";
            this.TenP.Name = "TenP";
            this.TenP.ReadOnly = true;
            this.TenP.Width = 210;
            // 
            // LopP
            // 
            this.LopP.HeaderText = "Lớp";
            this.LopP.Name = "LopP";
            this.LopP.ReadOnly = true;
            // 
            // XoaP
            // 
            this.XoaP.HeaderText = "Xóa";
            this.XoaP.Name = "XoaP";
            this.XoaP.ReadOnly = true;
            this.XoaP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XoaP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XoaP.Text = "Xóa";
            this.XoaP.UseColumnTextForButtonValue = true;
            this.XoaP.Width = 80;
            // 
            // dgvVangK
            // 
            this.dgvVangK.AllowUserToAddRows = false;
            this.dgvVangK.AllowUserToDeleteRows = false;
            this.dgvVangK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVangK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDK,
            this.TenK,
            this.LopK,
            this.XoaK});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVangK, 3);
            this.dgvVangK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVangK.Location = new System.Drawing.Point(531, 276);
            this.dgvVangK.Name = "dgvVangK";
            this.dgvVangK.ReadOnly = true;
            this.dgvVangK.RowHeadersVisible = false;
            this.dgvVangK.Size = new System.Drawing.Size(460, 217);
            this.dgvVangK.TabIndex = 7;
            this.dgvVangK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVangP_CellContentClick);
            // 
            // IDK
            // 
            this.IDK.HeaderText = "Mã";
            this.IDK.Name = "IDK";
            this.IDK.ReadOnly = true;
            this.IDK.Width = 50;
            // 
            // TenK
            // 
            this.TenK.HeaderText = "Tên học sinh";
            this.TenK.Name = "TenK";
            this.TenK.ReadOnly = true;
            this.TenK.Width = 210;
            // 
            // LopK
            // 
            this.LopK.HeaderText = "Lớp";
            this.LopK.Name = "LopK";
            this.LopK.ReadOnly = true;
            // 
            // XoaK
            // 
            this.XoaK.HeaderText = "Xóa";
            this.XoaK.Name = "XoaK";
            this.XoaK.ReadOnly = true;
            this.XoaK.Text = "Xóa";
            this.XoaK.UseColumnTextForButtonValue = true;
            this.XoaK.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(531, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách vắng có phép";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(531, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh sách vắng không phép";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cúp học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.dgvDSHSC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFindC, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxLopC, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCapNhap, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnXemChiTiet, 3, 9);
            this.tableLayoutPanel3.Controls.Add(this.btnBack1, 4, 9);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.numTu, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.numDen, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtLop, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTen, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtID, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.dgvChiTiet, 2, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(994, 557);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvDSHSC
            // 
            this.dgvDSHSC.AllowUserToAddRows = false;
            this.dgvDSHSC.AllowUserToDeleteRows = false;
            this.dgvDSHSC.AutoGenerateColumns = false;
            this.dgvDSHSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDC,
            this.TenC,
            this.NgaySinhC});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvDSHSC, 2);
            this.dgvDSHSC.DataSource = this.bsHocSinh;
            this.dgvDSHSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHSC.Location = new System.Drawing.Point(3, 28);
            this.dgvDSHSC.Name = "dgvDSHSC";
            this.dgvDSHSC.ReadOnly = true;
            this.dgvDSHSC.RowHeadersVisible = false;
            this.tableLayoutPanel3.SetRowSpan(this.dgvDSHSC, 8);
            this.dgvDSHSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHSC.Size = new System.Drawing.Size(538, 465);
            this.dgvDSHSC.TabIndex = 5;
            this.dgvDSHSC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHSC_CellClick);
            // 
            // IDC
            // 
            this.IDC.DataPropertyName = "ID";
            this.IDC.HeaderText = "Mã HS";
            this.IDC.Name = "IDC";
            this.IDC.ReadOnly = true;
            // 
            // TenC
            // 
            this.TenC.DataPropertyName = "Ten";
            this.TenC.HeaderText = "Tên";
            this.TenC.Name = "TenC";
            this.TenC.ReadOnly = true;
            this.TenC.Width = 250;
            // 
            // NgaySinhC
            // 
            this.NgaySinhC.DataPropertyName = "NgaySinh";
            this.NgaySinhC.HeaderText = "Ngày Sinh";
            this.NgaySinhC.Name = "NgaySinhC";
            this.NgaySinhC.ReadOnly = true;
            this.NgaySinhC.Width = 150;
            // 
            // txtFindC
            // 
            this.txtFindC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFindC.ForeColor = System.Drawing.Color.Gray;
            this.txtFindC.Location = new System.Drawing.Point(153, 3);
            this.txtFindC.Name = "txtFindC";
            this.txtFindC.Size = new System.Drawing.Size(388, 26);
            this.txtFindC.TabIndex = 4;
            this.txtFindC.Text = "Nhập ID hoặc Tên học sinh";
            this.txtFindC.TextChanged += new System.EventHandler(this.txtFindC_TextChanged);
            this.txtFindC.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtFindC.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // cbxLopC
            // 
            this.cbxLopC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLopC.FormattingEnabled = true;
            this.cbxLopC.Items.AddRange(new object[] {
            "-----------Lớp-----------"});
            this.cbxLopC.Location = new System.Drawing.Point(3, 3);
            this.cbxLopC.Name = "cbxLopC";
            this.cbxLopC.Size = new System.Drawing.Size(144, 28);
            this.cbxLopC.TabIndex = 3;
            this.cbxLopC.Text = "-----------Lớp-----------";
            this.cbxLopC.SelectedValueChanged += new System.EventHandler(this.cbxLop_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 3);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(547, 0);
            this.label5.Name = "label5";
            this.tableLayoutPanel3.SetRowSpan(this.label5, 2);
            this.label5.Size = new System.Drawing.Size(444, 77);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông tin học sinh cúp học";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhap.Location = new System.Drawing.Point(847, 185);
            this.btnCapNhap.Name = "btnCapNhap";
            this.tableLayoutPanel3.SetRowSpan(this.btnCapNhap, 2);
            this.btnCapNhap.Size = new System.Drawing.Size(144, 64);
            this.btnCapNhap.TabIndex = 8;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXemChiTiet.Location = new System.Drawing.Point(697, 499);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(144, 55);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack1.Location = new System.Drawing.Point(847, 499);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(144, 55);
            this.btnBack1.TabIndex = 8;
            this.btnBack1.Text = "Quay lại";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(547, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nghỉ từ tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTu
            // 
            this.numTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTu.Location = new System.Drawing.Point(697, 192);
            this.numTu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numTu.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numTu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTu.Name = "numTu";
            this.numTu.Size = new System.Drawing.Size(144, 26);
            this.numTu.TabIndex = 10;
            this.numTu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTu.ValueChanged += new System.EventHandler(this.numtTu_ValueChanged);
            // 
            // numDen
            // 
            this.numDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDen.Location = new System.Drawing.Point(697, 227);
            this.numDen.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numDen.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDen.Name = "numDen";
            this.numDen.Size = new System.Drawing.Size(144, 26);
            this.numDen.TabIndex = 11;
            this.numDen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(547, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nghỉ đến tiêt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLop
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtLop, 2);
            this.txtLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLop.Location = new System.Drawing.Point(697, 157);
            this.txtLop.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(294, 26);
            this.txtLop.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(547, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lớp";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(547, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên học sinh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTen
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTen, 2);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Location = new System.Drawing.Point(697, 122);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(294, 26);
            this.txtTen.TabIndex = 15;
            // 
            // txtID
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtID, 2);
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(697, 87);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(294, 26);
            this.txtID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(547, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã học sinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label9, 3);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(547, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(444, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bảng chi tiết cúp học của học sinh";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AutoGenerateColumns = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tiet,
            this.Ngay});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvChiTiet, 3);
            this.dgvChiTiet.DataSource = this.bsCupHoc;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(547, 290);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.Size = new System.Drawing.Size(444, 203);
            this.dgvChiTiet.TabIndex = 17;
            this.dgvChiTiet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellEndEdit);
            this.dgvChiTiet.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvChiTiet_UserDeletingRow);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Mã";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tiet";
            this.Tiet.HeaderText = "Tiết số";
            this.Tiet.Name = "Tiet";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // bsCupHoc
            // 
            this.bsCupHoc.DataSource = typeof(DTO.CupHoc);
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 596);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiemDanh";
            this.Text = "Chuyên cần";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.Resize += new System.EventHandler(this.frmDiemDanh_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangK)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCupHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbxLopC;
        private System.Windows.Forms.TextBox txtFindC;
        private System.Windows.Forms.DataGridView dgvDSHSC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.BindingSource bsHocSinh;
        private System.Windows.Forms.DataGridView dgvVangP;
        private System.Windows.Forms.DataGridView dgvVangK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopP;
        private System.Windows.Forms.DataGridViewButtonColumn XoaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopK;
        private System.Windows.Forms.DataGridViewButtonColumn XoaK;
        private System.Windows.Forms.NumericUpDown numTu;
        private System.Windows.Forms.NumericUpDown numDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewButtonColumn Vangp;
        private System.Windows.Forms.DataGridViewButtonColumn VangK;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.BindingSource bsCupHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
    }
}