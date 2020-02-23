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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vangp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VangK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSHSC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danTocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTMeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTBoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCupTu = new System.Windows.Forms.TextBox();
            this.txtCupDen = new System.Windows.Forms.TextBox();
            this.txtFindC = new System.Windows.Forms.TextBox();
            this.cbxLopC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnKiemTra, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHS, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(742, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiem, 2);
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(153, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(733, 23);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập ID hoặc Tên học sinh";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.btnChiTiet, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 501);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 60);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChiTiet.Location = new System.Drawing.Point(442, 3);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(144, 54);
            this.btnChiTiet.TabIndex = 4;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Location = new System.Drawing.Point(292, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 54);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Luu danh sách";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKiemTra.Location = new System.Drawing.Point(3, 504);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(144, 54);
            this.btnKiemTra.TabIndex = 4;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AllowUserToAddRows = false;
            this.dgvDSHS.AllowUserToDeleteRows = false;
            this.dgvDSHS.AutoGenerateColumns = false;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.Vangp,
            this.VangK});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSHS, 3);
            this.dgvDSHS.DataSource = this.bsHocSinh;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(3, 33);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.RowHeadersVisible = false;
            this.dgvDSHS.Size = new System.Drawing.Size(883, 465);
            this.dgvDSHS.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã HS";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.Controls.Add(this.dgvDSHSC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCupTu, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCupDen, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFindC, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxLopC, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 5, 3);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.iDDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn1,
            this.ngaySinhDataGridViewTextBoxColumn1,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn,
            this.danTocDataGridViewTextBoxColumn,
            this.tonGiaoDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn,
            this.iDTaiKhoanDataGridViewTextBoxColumn,
            this.tenMeDataGridViewTextBoxColumn,
            this.sDTMeDataGridViewTextBoxColumn,
            this.tenBoDataGridViewTextBoxColumn,
            this.sDTBoDataGridViewTextBoxColumn});
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Học Sinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn1
            // 
            this.tenDataGridViewTextBoxColumn1.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn1.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn1.Name = "tenDataGridViewTextBoxColumn1";
            this.tenDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            this.noiSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danTocDataGridViewTextBoxColumn
            // 
            this.danTocDataGridViewTextBoxColumn.DataPropertyName = "DanToc";
            this.danTocDataGridViewTextBoxColumn.HeaderText = "DanToc";
            this.danTocDataGridViewTextBoxColumn.Name = "danTocDataGridViewTextBoxColumn";
            this.danTocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonGiaoDataGridViewTextBoxColumn
            // 
            this.tonGiaoDataGridViewTextBoxColumn.DataPropertyName = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.HeaderText = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.Name = "tonGiaoDataGridViewTextBoxColumn";
            this.tonGiaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            this.iDLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTaiKhoanDataGridViewTextBoxColumn
            // 
            this.iDTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "IDTaiKhoan";
            this.iDTaiKhoanDataGridViewTextBoxColumn.HeaderText = "IDTaiKhoan";
            this.iDTaiKhoanDataGridViewTextBoxColumn.Name = "iDTaiKhoanDataGridViewTextBoxColumn";
            this.iDTaiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMeDataGridViewTextBoxColumn
            // 
            this.tenMeDataGridViewTextBoxColumn.DataPropertyName = "TenMe";
            this.tenMeDataGridViewTextBoxColumn.HeaderText = "TenMe";
            this.tenMeDataGridViewTextBoxColumn.Name = "tenMeDataGridViewTextBoxColumn";
            this.tenMeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTMeDataGridViewTextBoxColumn
            // 
            this.sDTMeDataGridViewTextBoxColumn.DataPropertyName = "SDTMe";
            this.sDTMeDataGridViewTextBoxColumn.HeaderText = "SDTMe";
            this.sDTMeDataGridViewTextBoxColumn.Name = "sDTMeDataGridViewTextBoxColumn";
            this.sDTMeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenBoDataGridViewTextBoxColumn
            // 
            this.tenBoDataGridViewTextBoxColumn.DataPropertyName = "TenBo";
            this.tenBoDataGridViewTextBoxColumn.HeaderText = "TenBo";
            this.tenBoDataGridViewTextBoxColumn.Name = "tenBoDataGridViewTextBoxColumn";
            this.tenBoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTBoDataGridViewTextBoxColumn
            // 
            this.sDTBoDataGridViewTextBoxColumn.DataPropertyName = "SDTBo";
            this.sDTBoDataGridViewTextBoxColumn.HeaderText = "SDTBo";
            this.sDTBoDataGridViewTextBoxColumn.Name = "sDTBoDataGridViewTextBoxColumn";
            this.sDTBoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(447, 466);
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
            this.txtCupTu.Size = new System.Drawing.Size(398, 22);
            this.txtCupTu.TabIndex = 7;
            // 
            // txtCupDen
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtCupDen, 2);
            this.txtCupDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCupDen.Location = new System.Drawing.Point(487, 469);
            this.txtCupDen.Name = "txtCupDen";
            this.txtCupDen.Size = new System.Drawing.Size(399, 22);
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
            this.button1.Location = new System.Drawing.Point(781, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cập nhập";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKiemTra;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vangp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VangK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danTocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTMeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTBoDataGridViewTextBoxColumn;
    }
}