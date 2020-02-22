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
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTaiKhoanTruong = new System.Windows.Forms.TabPage();
            this.tlpTKT = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTaiKhoanTruong = new System.Windows.Forms.DataGridView();
            this.txtTimTKTruong = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tabPageTaiKhoanPH = new System.Windows.Forms.TabPage();
            this.tlpTKPH = new System.Windows.Forms.TableLayoutPanel();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.txtTimHocSinh = new System.Windows.Forms.TextBox();
            this.dgvTKPH = new System.Windows.Forms.DataGridView();
            this.txtTimTK = new System.Windows.Forms.TextBox();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.tabPageQLTK = new System.Windows.Forms.TabControl();
            this.bsTKPH = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTTHS = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bsTaiKhoanTruong = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimGV = new System.Windows.Forms.TextBox();
            this.dgvThongTinGV = new System.Windows.Forms.DataGridView();
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            this.tabPageTaiKhoanTruong.SuspendLayout();
            this.tlpTKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanTruong)).BeginInit();
            this.tabPageTaiKhoanPH.SuspendLayout();
            this.tlpTKPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            this.tabPageQLTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTKPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoanTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // tabPageTaiKhoanTruong
            // 
            this.tabPageTaiKhoanTruong.Controls.Add(this.tlpTKT);
            this.tabPageTaiKhoanTruong.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanTruong.Name = "tabPageTaiKhoanTruong";
            this.tabPageTaiKhoanTruong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanTruong.Size = new System.Drawing.Size(1110, 599);
            this.tabPageTaiKhoanTruong.TabIndex = 1;
            this.tabPageTaiKhoanTruong.Text = "Tài Khoản Trường";
            this.tabPageTaiKhoanTruong.UseVisualStyleBackColor = true;
            // 
            // tlpTKT
            // 
            this.tlpTKT.ColumnCount = 3;
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.61473F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.38527F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpTKT.Controls.Add(this.dgvTaiKhoanTruong, 0, 1);
            this.tlpTKT.Controls.Add(this.txtTimTKTruong, 0, 0);
            this.tlpTKT.Controls.Add(this.btnLuu, 2, 2);
            this.tlpTKT.Controls.Add(this.txtTimGV, 1, 0);
            this.tlpTKT.Controls.Add(this.dgvThongTinGV, 1, 1);
            this.tlpTKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKT.Location = new System.Drawing.Point(3, 2);
            this.tlpTKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTKT.Name = "tlpTKT";
            this.tlpTKT.RowCount = 3;
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.372681F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92437F));
            this.tlpTKT.Size = new System.Drawing.Size(1104, 595);
            this.tlpTKT.TabIndex = 0;
            // 
            // dgvTaiKhoanTruong
            // 
            this.dgvTaiKhoanTruong.AutoGenerateColumns = false;
            this.dgvTaiKhoanTruong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanTruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanTruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.taiKhoanDataGridViewTextBoxColumn1,
            this.matKhauDataGridViewTextBoxColumn1,
            this.loaiDataGridViewTextBoxColumn});
            this.dgvTaiKhoanTruong.DataSource = this.bsTaiKhoanTruong;
            this.dgvTaiKhoanTruong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanTruong.Location = new System.Drawing.Point(3, 22);
            this.dgvTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoanTruong.Name = "dgvTaiKhoanTruong";
            this.tlpTKT.SetRowSpan(this.dgvTaiKhoanTruong, 2);
            this.dgvTaiKhoanTruong.RowTemplate.Height = 24;
            this.dgvTaiKhoanTruong.Size = new System.Drawing.Size(487, 571);
            this.dgvTaiKhoanTruong.TabIndex = 0;
            // 
            // txtTimTKTruong
            // 
            this.txtTimTKTruong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTKTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTKTruong.Location = new System.Drawing.Point(3, 2);
            this.txtTimTKTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimTKTruong.Name = "txtTimTKTruong";
            this.txtTimTKTruong.Size = new System.Drawing.Size(487, 27);
            this.txtTimTKTruong.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(940, 532);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(161, 60);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // tabPageTaiKhoanPH
            // 
            this.tabPageTaiKhoanPH.Controls.Add(this.tlpTKPH);
            this.tabPageTaiKhoanPH.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanPH.Name = "tabPageTaiKhoanPH";
            this.tabPageTaiKhoanPH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanPH.Size = new System.Drawing.Size(1110, 599);
            this.tabPageTaiKhoanPH.TabIndex = 0;
            this.tabPageTaiKhoanPH.Text = "Tài Khoản Phụ Huynh";
            this.tabPageTaiKhoanPH.UseVisualStyleBackColor = true;
            // 
            // tlpTKPH
            // 
            this.tlpTKPH.ColumnCount = 4;
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24619F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlpTKPH.Controls.Add(this.txtTimHocSinh, 1, 0);
            this.tlpTKPH.Controls.Add(this.dgvTKPH, 0, 1);
            this.tlpTKPH.Controls.Add(this.txtTimTK, 0, 0);
            this.tlpTKPH.Controls.Add(this.dgvDSHS, 1, 1);
            this.tlpTKPH.Controls.Add(this.btnDatLaiMK, 3, 2);
            this.tlpTKPH.Controls.Add(this.btnThemTK, 2, 2);
            this.tlpTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKPH.Location = new System.Drawing.Point(3, 2);
            this.tlpTKPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTKPH.Name = "tlpTKPH";
            this.tlpTKPH.RowCount = 3;
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.753199F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.2468F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpTKPH.Size = new System.Drawing.Size(1104, 595);
            this.tlpTKPH.TabIndex = 0;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatLaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLaiMK.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMK.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMK.Location = new System.Drawing.Point(944, 536);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(157, 56);
            this.btnDatLaiMK.TabIndex = 7;
            this.btnDatLaiMK.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            // 
            // txtTimHocSinh
            // 
            this.tlpTKPH.SetColumnSpan(this.txtTimHocSinh, 3);
            this.txtTimHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimHocSinh.Location = new System.Drawing.Point(332, 2);
            this.txtTimHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimHocSinh.Name = "txtTimHocSinh";
            this.txtTimHocSinh.Size = new System.Drawing.Size(769, 22);
            this.txtTimHocSinh.TabIndex = 3;
            // 
            // dgvTKPH
            // 
            this.dgvTKPH.AutoGenerateColumns = false;
            this.dgvTKPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKPH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dgvTKPH.DataSource = this.bsTKPH;
            this.dgvTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKPH.Location = new System.Drawing.Point(3, 27);
            this.dgvTKPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTKPH.Name = "dgvTKPH";
            this.tlpTKPH.SetRowSpan(this.dgvTKPH, 2);
            this.dgvTKPH.RowTemplate.Height = 24;
            this.dgvTKPH.Size = new System.Drawing.Size(323, 566);
            this.dgvTKPH.TabIndex = 0;
            // 
            // txtTimTK
            // 
            this.txtTimTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTK.Location = new System.Drawing.Point(3, 2);
            this.txtTimTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimTK.Name = "txtTimTK";
            this.txtTimTK.Size = new System.Drawing.Size(323, 22);
            this.txtTimTK.TabIndex = 1;
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AutoGenerateColumns = false;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
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
            this.tlpTKPH.SetColumnSpan(this.dgvDSHS, 3);
            this.dgvDSHS.DataSource = this.bsTTHS;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(332, 27);
            this.dgvDSHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.RowTemplate.Height = 24;
            this.dgvDSHS.Size = new System.Drawing.Size(769, 504);
            this.dgvDSHS.TabIndex = 2;
            // 
            // tabPageQLTK
            // 
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanPH);
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanTruong);
            this.tabPageQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabPageQLTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageQLTK.Name = "tabPageQLTK";
            this.tabPageQLTK.SelectedIndex = 0;
            this.tabPageQLTK.Size = new System.Drawing.Size(1118, 628);
            this.tabPageQLTK.TabIndex = 0;
            // 
            // bsTKPH
            // 
            this.bsTKPH.DataSource = typeof(DTO.TaiKhoanPH);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // bsTTHS
            // 
            this.bsTTHS.DataSource = typeof(DTO.ThongTinHS);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            // 
            // danTocDataGridViewTextBoxColumn
            // 
            this.danTocDataGridViewTextBoxColumn.DataPropertyName = "DanToc";
            this.danTocDataGridViewTextBoxColumn.HeaderText = "DanToc";
            this.danTocDataGridViewTextBoxColumn.Name = "danTocDataGridViewTextBoxColumn";
            // 
            // tonGiaoDataGridViewTextBoxColumn
            // 
            this.tonGiaoDataGridViewTextBoxColumn.DataPropertyName = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.HeaderText = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.Name = "tonGiaoDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // iDTaiKhoanDataGridViewTextBoxColumn
            // 
            this.iDTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "IDTaiKhoan";
            this.iDTaiKhoanDataGridViewTextBoxColumn.HeaderText = "IDTaiKhoan";
            this.iDTaiKhoanDataGridViewTextBoxColumn.Name = "iDTaiKhoanDataGridViewTextBoxColumn";
            // 
            // tenMeDataGridViewTextBoxColumn
            // 
            this.tenMeDataGridViewTextBoxColumn.DataPropertyName = "TenMe";
            this.tenMeDataGridViewTextBoxColumn.HeaderText = "TenMe";
            this.tenMeDataGridViewTextBoxColumn.Name = "tenMeDataGridViewTextBoxColumn";
            // 
            // sDTMeDataGridViewTextBoxColumn
            // 
            this.sDTMeDataGridViewTextBoxColumn.DataPropertyName = "SDTMe";
            this.sDTMeDataGridViewTextBoxColumn.HeaderText = "SDTMe";
            this.sDTMeDataGridViewTextBoxColumn.Name = "sDTMeDataGridViewTextBoxColumn";
            // 
            // tenBoDataGridViewTextBoxColumn
            // 
            this.tenBoDataGridViewTextBoxColumn.DataPropertyName = "TenBo";
            this.tenBoDataGridViewTextBoxColumn.HeaderText = "TenBo";
            this.tenBoDataGridViewTextBoxColumn.Name = "tenBoDataGridViewTextBoxColumn";
            // 
            // sDTBoDataGridViewTextBoxColumn
            // 
            this.sDTBoDataGridViewTextBoxColumn.DataPropertyName = "SDTBo";
            this.sDTBoDataGridViewTextBoxColumn.HeaderText = "SDTBo";
            this.sDTBoDataGridViewTextBoxColumn.Name = "sDTBoDataGridViewTextBoxColumn";
            // 
            // bsTaiKhoanTruong
            // 
            this.bsTaiKhoanTruong.DataSource = typeof(DTO.TaiKhoanTruong);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // taiKhoanDataGridViewTextBoxColumn1
            // 
            this.taiKhoanDataGridViewTextBoxColumn1.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn1.HeaderText = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn1.Name = "taiKhoanDataGridViewTextBoxColumn1";
            // 
            // matKhauDataGridViewTextBoxColumn1
            // 
            this.matKhauDataGridViewTextBoxColumn1.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn1.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn1.Name = "matKhauDataGridViewTextBoxColumn1";
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loai";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            // 
            // txtTimGV
            // 
            this.tlpTKT.SetColumnSpan(this.txtTimGV, 2);
            this.txtTimGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimGV.Location = new System.Drawing.Point(496, 3);
            this.txtTimGV.Name = "txtTimGV";
            this.txtTimGV.Size = new System.Drawing.Size(605, 22);
            this.txtTimGV.TabIndex = 10;
            // 
            // dgvThongTinGV
            // 
            this.dgvThongTinGV.AutoGenerateColumns = false;
            this.dgvThongTinGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn1});
            this.tlpTKT.SetColumnSpan(this.dgvThongTinGV, 2);
            this.dgvThongTinGV.DataSource = this.bsDSGV;
            this.dgvThongTinGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinGV.Location = new System.Drawing.Point(496, 23);
            this.dgvThongTinGV.Name = "dgvThongTinGV";
            this.dgvThongTinGV.RowTemplate.Height = 24;
            this.dgvThongTinGV.Size = new System.Drawing.Size(605, 503);
            this.dgvThongTinGV.TabIndex = 11;
            // 
            // iDTKTDataGridViewTextBoxColumn
            // 
            this.iDTKTDataGridViewTextBoxColumn.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.HeaderText = "ID Tài Khoản";
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
            this.iDMonHocDataGridViewTextBoxColumn.HeaderText = "Môn Dạy";
            this.iDMonHocDataGridViewTextBoxColumn.Name = "iDMonHocDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn1
            // 
            this.iDLopDataGridViewTextBoxColumn1.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn1.HeaderText = "Lớp Dạy";
            this.iDLopDataGridViewTextBoxColumn1.Name = "iDLopDataGridViewTextBoxColumn1";
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemTK.FlatAppearance.BorderSize = 0;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.White;
            this.btnThemTK.Location = new System.Drawing.Point(776, 536);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(162, 56);
            this.btnThemTK.TabIndex = 8;
            this.btnThemTK.Text = "Lưu";
            this.btnThemTK.UseVisualStyleBackColor = false;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1118, 628);
            this.Controls.Add(this.tabPageQLTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            this.tabPageTaiKhoanTruong.ResumeLayout(false);
            this.tlpTKT.ResumeLayout(false);
            this.tlpTKT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanTruong)).EndInit();
            this.tabPageTaiKhoanPH.ResumeLayout(false);
            this.tlpTKPH.ResumeLayout(false);
            this.tlpTKPH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            this.tabPageQLTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTKPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoanTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.TabPage tabPageTaiKhoanTruong;
        private System.Windows.Forms.TabPage tabPageTaiKhoanPH;
        private System.Windows.Forms.TableLayoutPanel tlpTKPH;
        private System.Windows.Forms.TextBox txtTimHocSinh;
        private System.Windows.Forms.DataGridView dgvTKPH;
        private System.Windows.Forms.TextBox txtTimTK;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.TabControl tabPageQLTK;
        private System.Windows.Forms.TableLayoutPanel tlpTKT;
        private System.Windows.Forms.DataGridView dgvTaiKhoanTruong;
        private System.Windows.Forms.TextBox txtTimTKTruong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDatLaiMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTaiKhoanTruong;
        private System.Windows.Forms.TextBox txtTimGV;
        private System.Windows.Forms.DataGridView dgvThongTinGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTKPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource bsTTHS;
        private System.Windows.Forms.Button btnThemTK;
    }
}