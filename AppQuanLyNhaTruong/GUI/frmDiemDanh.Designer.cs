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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.bsHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSHSC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCupTu = new System.Windows.Forms.TextBox();
            this.txtCupDen = new System.Windows.Forms.TextBox();
            this.txtFindC = new System.Windows.Forms.TextBox();
            this.cbxLopC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvVangP = new System.Windows.Forms.DataGridView();
            this.dgvVangK = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vangp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VangK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.IDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangK)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(903, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vắng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 561);
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
            this.cbxLop.Size = new System.Drawing.Size(144, 24);
            this.cbxLop.TabIndex = 0;
            this.cbxLop.Text = "-----------Lớp-----------";
            this.cbxLop.SelectedValueChanged += new System.EventHandler(this.cbxLop_SelectedValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(741, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(153, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(345, 23);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập ID hoặc Tên học sinh";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(3, 503);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(144, 54);
            this.btnChiTiet.TabIndex = 4;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AllowUserToAddRows = false;
            this.dgvDSHS.AllowUserToDeleteRows = false;
            this.dgvDSHS.AutoGenerateColumns = false;
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
            this.dgvDSHS.Size = new System.Drawing.Size(495, 469);
            this.dgvDSHS.TabIndex = 5;
            this.dgvDSHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHS_CellContentClick);
            // 
            // bsHocSinh
            // 
            this.bsHocSinh.DataSource = typeof(DTO.ThongTinHS);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cúp học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.dgvDSHSC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCupTu, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCupDen, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFindC, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxLopC, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnXemChiTiet, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(889, 561);
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
            this.tableLayoutPanel3.SetColumnSpan(this.dgvDSHSC, 6);
            this.dgvDSHSC.DataSource = this.bsHocSinh;
            this.dgvDSHSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHSC.Location = new System.Drawing.Point(3, 28);
            this.dgvDSHSC.Name = "dgvDSHSC";
            this.dgvDSHSC.ReadOnly = true;
            this.dgvDSHSC.RowHeadersVisible = false;
            this.dgvDSHSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHSC.Size = new System.Drawing.Size(883, 435);
            this.dgvDSHSC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(427, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến";
            // 
            // txtCupTu
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtCupTu, 2);
            this.txtCupTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCupTu.Location = new System.Drawing.Point(43, 469);
            this.txtCupTu.Name = "txtCupTu";
            this.txtCupTu.Size = new System.Drawing.Size(378, 22);
            this.txtCupTu.TabIndex = 7;
            // 
            // txtCupDen
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtCupDen, 2);
            this.txtCupDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCupDen.Location = new System.Drawing.Point(467, 469);
            this.txtCupDen.Name = "txtCupDen";
            this.txtCupDen.Size = new System.Drawing.Size(419, 22);
            this.txtCupDen.TabIndex = 7;
            // 
            // txtFindC
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtFindC, 4);
            this.txtFindC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFindC.ForeColor = System.Drawing.Color.Gray;
            this.txtFindC.Location = new System.Drawing.Point(153, 3);
            this.txtFindC.Name = "txtFindC";
            this.txtFindC.Size = new System.Drawing.Size(733, 23);
            this.txtFindC.TabIndex = 4;
            this.txtFindC.Text = "Nhập ID hoặc Tên học sinh";
            this.txtFindC.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtFindC.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtFindC.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // cbxLopC
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbxLopC, 2);
            this.cbxLopC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLopC.FormattingEnabled = true;
            this.cbxLopC.Items.AddRange(new object[] {
            "-----------Lớp-----------"});
            this.cbxLopC.Location = new System.Drawing.Point(3, 3);
            this.cbxLopC.Name = "cbxLopC";
            this.cbxLopC.Size = new System.Drawing.Size(144, 24);
            this.cbxLopC.TabIndex = 3;
            this.cbxLopC.Text = "-----------Lớp-----------";
            this.cbxLopC.SelectedValueChanged += new System.EventHandler(this.cbxLop_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(741, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cập nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cập nhập";
            this.button2.UseVisualStyleBackColor = true;
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
            this.LopP});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVangP, 3);
            this.dgvVangP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVangP.Location = new System.Drawing.Point(504, 28);
            this.dgvVangP.Name = "dgvVangP";
            this.dgvVangP.ReadOnly = true;
            this.dgvVangP.RowHeadersVisible = false;
            this.dgvVangP.Size = new System.Drawing.Size(382, 219);
            this.dgvVangP.TabIndex = 7;
            // 
            // dgvVangK
            // 
            this.dgvVangK.AllowUserToAddRows = false;
            this.dgvVangK.AllowUserToDeleteRows = false;
            this.dgvVangK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVangK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDK,
            this.TenK,
            this.LopK});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVangK, 3);
            this.dgvVangK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVangK.Location = new System.Drawing.Point(504, 278);
            this.dgvVangK.Name = "dgvVangK";
            this.dgvVangK.ReadOnly = true;
            this.dgvVangK.RowHeadersVisible = false;
            this.dgvVangK.Size = new System.Drawing.Size(382, 219);
            this.dgvVangK.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(504, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 25);
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
            this.label4.Location = new System.Drawing.Point(504, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh sách vắng không phép";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Vangp
            // 
            this.Vangp.HeaderText = "Vắng (P)";
            this.Vangp.Name = "Vangp";
            // 
            // VangK
            // 
            this.VangK.HeaderText = "Vắng (KP)";
            this.VangK.Name = "VangK";
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
            // btnXemChiTiet
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnXemChiTiet, 2);
            this.btnXemChiTiet.Location = new System.Drawing.Point(3, 494);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(144, 54);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
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
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 596);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiemDanh";
            this.Text = "Chuyên cần";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVangK)).EndInit();
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
        private System.Windows.Forms.TextBox txtCupTu;
        private System.Windows.Forms.TextBox txtCupDen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.BindingSource bsHocSinh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vangp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VangK;
        private System.Windows.Forms.DataGridView dgvVangP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopP;
        private System.Windows.Forms.DataGridView dgvVangK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhC;
    }
}