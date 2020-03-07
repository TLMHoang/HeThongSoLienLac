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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManager));
            this.tabPageTaiKhoanTruong = new System.Windows.Forms.TabPage();
            this.tlpTKT = new System.Windows.Forms.TableLayoutPanel();
            this.dgvThongTinGV = new System.Windows.Forms.DataGridView();
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTaiKhoanTruong = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Loai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsTaiKhoanTruong = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimTKTruong = new System.Windows.Forms.TextBox();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.txtTimGV = new System.Windows.Forms.TextBox();
            this.btnLuuTTGV = new System.Windows.Forms.Button();
            this.tabPageTaiKhoanPH = new System.Windows.Forms.TabPage();
            this.tlpTKPH = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimHocSinh = new System.Windows.Forms.TextBox();
            this.dgvTKPH = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTKPH = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimTK = new System.Windows.Forms.TextBox();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.btnChonTK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTTHS = new System.Windows.Forms.BindingSource(this.components);
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.tabPageQLTK = new System.Windows.Forms.TabControl();
            this.tabPageTaiKhoanTruong.SuspendLayout();
            this.tlpTKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoanTruong)).BeginInit();
            this.tabPageTaiKhoanPH.SuspendLayout();
            this.tlpTKPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTKPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTHS)).BeginInit();
            this.tabPageQLTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageTaiKhoanTruong
            // 
            this.tabPageTaiKhoanTruong.Controls.Add(this.tlpTKT);
            this.tabPageTaiKhoanTruong.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTaiKhoanTruong.Name = "tabPageTaiKhoanTruong";
            this.tabPageTaiKhoanTruong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTaiKhoanTruong.Size = new System.Drawing.Size(830, 484);
            this.tabPageTaiKhoanTruong.TabIndex = 1;
            this.tabPageTaiKhoanTruong.Text = "Tài Khoản Trường";
            this.tabPageTaiKhoanTruong.UseVisualStyleBackColor = true;
            // 
            // tlpTKT
            // 
            this.tlpTKT.ColumnCount = 4;
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81123F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.18877F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tlpTKT.Controls.Add(this.dgvThongTinGV, 1, 1);
            this.tlpTKT.Controls.Add(this.dgvTaiKhoanTruong, 0, 1);
            this.tlpTKT.Controls.Add(this.txtTimTKTruong, 0, 0);
            this.tlpTKT.Controls.Add(this.btnThemTaiKhoan, 2, 2);
            this.tlpTKT.Controls.Add(this.txtTimGV, 1, 0);
            this.tlpTKT.Controls.Add(this.btnLuuTTGV, 3, 2);
            this.tlpTKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKT.Location = new System.Drawing.Point(2, 2);
            this.tlpTKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpTKT.Name = "tlpTKT";
            this.tlpTKT.RowCount = 3;
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.511811F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.48819F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpTKT.Size = new System.Drawing.Size(826, 480);
            this.tlpTKT.TabIndex = 0;
            // 
            // dgvThongTinGV
            // 
            this.dgvThongTinGV.AutoGenerateColumns = false;
            this.dgvThongTinGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn});
            this.tlpTKT.SetColumnSpan(this.dgvThongTinGV, 3);
            this.dgvThongTinGV.DataSource = this.bsDSGV;
            this.dgvThongTinGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinGV.Location = new System.Drawing.Point(271, 25);
            this.dgvThongTinGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThongTinGV.Name = "dgvThongTinGV";
            this.dgvThongTinGV.RowTemplate.Height = 24;
            this.dgvThongTinGV.Size = new System.Drawing.Size(553, 399);
            this.dgvThongTinGV.TabIndex = 11;
            // 
            // iDTKTDataGridViewTextBoxColumn
            // 
            this.iDTKTDataGridViewTextBoxColumn.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.iDTKTDataGridViewTextBoxColumn.HeaderText = "ID Tài Khoản";
            this.iDTKTDataGridViewTextBoxColumn.Name = "iDTKTDataGridViewTextBoxColumn";
            this.iDTKTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên Giáo Viên";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // iDMonHocDataGridViewTextBoxColumn
            // 
            this.iDMonHocDataGridViewTextBoxColumn.DataPropertyName = "IDMonHoc";
            this.iDMonHocDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.iDMonHocDataGridViewTextBoxColumn.HeaderText = "Môn Dạy";
            this.iDMonHocDataGridViewTextBoxColumn.Name = "iDMonHocDataGridViewTextBoxColumn";
            this.iDMonHocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDMonHocDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // dgvTaiKhoanTruong
            // 
            this.dgvTaiKhoanTruong.AutoGenerateColumns = false;
            this.dgvTaiKhoanTruong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanTruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanTruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.taiKhoanDataGridViewTextBoxColumn1,
            this.col_Loai});
            this.dgvTaiKhoanTruong.DataSource = this.bsTaiKhoanTruong;
            this.dgvTaiKhoanTruong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanTruong.Location = new System.Drawing.Point(2, 25);
            this.dgvTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTaiKhoanTruong.Name = "dgvTaiKhoanTruong";
            this.tlpTKT.SetRowSpan(this.dgvTaiKhoanTruong, 2);
            this.dgvTaiKhoanTruong.RowTemplate.Height = 24;
            this.dgvTaiKhoanTruong.Size = new System.Drawing.Size(265, 453);
            this.dgvTaiKhoanTruong.TabIndex = 0;
            this.dgvTaiKhoanTruong.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanTruong_CellEndEdit);
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // taiKhoanDataGridViewTextBoxColumn1
            // 
            this.taiKhoanDataGridViewTextBoxColumn1.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn1.HeaderText = "Tài Khoản";
            this.taiKhoanDataGridViewTextBoxColumn1.Name = "taiKhoanDataGridViewTextBoxColumn1";
            // 
            // col_Loai
            // 
            this.col_Loai.DataPropertyName = "Loai";
            this.col_Loai.HeaderText = "Loại";
            this.col_Loai.Name = "col_Loai";
            this.col_Loai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Loai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsTaiKhoanTruong
            // 
            this.bsTaiKhoanTruong.DataSource = typeof(DTO.TaiKhoanTruong);
            // 
            // txtTimTKTruong
            // 
            this.txtTimTKTruong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTKTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTKTruong.Location = new System.Drawing.Point(2, 2);
            this.txtTimTKTruong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTKTruong.Name = "txtTimTKTruong";
            this.txtTimTKTruong.Size = new System.Drawing.Size(265, 23);
            this.txtTimTKTruong.TabIndex = 1;
            this.txtTimTKTruong.TextChanged += new System.EventHandler(this.txtTimTKTruong_TextChanged);
            this.txtTimTKTruong.Enter += new System.EventHandler(this.txtTimTKTruong_Enter);
            this.txtTimTKTruong.Leave += new System.EventHandler(this.txtTimTKTruong_Leave);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(577, 428);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(115, 50);
            this.btnThemTaiKhoan.TabIndex = 9;
            this.btnThemTaiKhoan.Text = "Thêm Tài Khoản Trường";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimGV
            // 
            this.tlpTKT.SetColumnSpan(this.txtTimGV, 3);
            this.txtTimGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimGV.Location = new System.Drawing.Point(271, 2);
            this.txtTimGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimGV.Name = "txtTimGV";
            this.txtTimGV.Size = new System.Drawing.Size(553, 23);
            this.txtTimGV.TabIndex = 10;
            this.txtTimGV.TextChanged += new System.EventHandler(this.txtTimGV_TextChanged);
            this.txtTimGV.Enter += new System.EventHandler(this.txtTimGV_Enter);
            this.txtTimGV.Leave += new System.EventHandler(this.txtTimGV_Leave);
            // 
            // btnLuuTTGV
            // 
            this.btnLuuTTGV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuuTTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuTTGV.FlatAppearance.BorderSize = 0;
            this.btnLuuTTGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTGV.ForeColor = System.Drawing.Color.White;
            this.btnLuuTTGV.Location = new System.Drawing.Point(696, 428);
            this.btnLuuTTGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuTTGV.Name = "btnLuuTTGV";
            this.btnLuuTTGV.Size = new System.Drawing.Size(128, 50);
            this.btnLuuTTGV.TabIndex = 12;
            this.btnLuuTTGV.Text = "Lưu Thông Tin GV";
            this.btnLuuTTGV.UseVisualStyleBackColor = false;
            this.btnLuuTTGV.Click += new System.EventHandler(this.btnLuuTTGV_Click);
            // 
            // tabPageTaiKhoanPH
            // 
            this.tabPageTaiKhoanPH.Controls.Add(this.tlpTKPH);
            this.tabPageTaiKhoanPH.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaiKhoanPH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTaiKhoanPH.Name = "tabPageTaiKhoanPH";
            this.tabPageTaiKhoanPH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTaiKhoanPH.Size = new System.Drawing.Size(830, 484);
            this.tabPageTaiKhoanPH.TabIndex = 0;
            this.tabPageTaiKhoanPH.Text = "Tài Khoản Phụ Huynh";
            this.tabPageTaiKhoanPH.UseVisualStyleBackColor = true;
            // 
            // tlpTKPH
            // 
            this.tlpTKPH.ColumnCount = 4;
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24619F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpTKPH.Controls.Add(this.txtTimHocSinh, 1, 0);
            this.tlpTKPH.Controls.Add(this.dgvTKPH, 0, 1);
            this.tlpTKPH.Controls.Add(this.txtTimTK, 0, 0);
            this.tlpTKPH.Controls.Add(this.dgvDSHS, 1, 1);
            this.tlpTKPH.Controls.Add(this.btnDatLaiMK, 3, 2);
            this.tlpTKPH.Controls.Add(this.btnThemTK, 2, 2);
            this.tlpTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKPH.Location = new System.Drawing.Point(2, 2);
            this.tlpTKPH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpTKPH.Name = "tlpTKPH";
            this.tlpTKPH.RowCount = 3;
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.753199F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.2468F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpTKPH.Size = new System.Drawing.Size(826, 480);
            this.tlpTKPH.TabIndex = 0;
            // 
            // txtTimHocSinh
            // 
            this.tlpTKPH.SetColumnSpan(this.txtTimHocSinh, 3);
            this.txtTimHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimHocSinh.Location = new System.Drawing.Point(247, 2);
            this.txtTimHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimHocSinh.Name = "txtTimHocSinh";
            this.txtTimHocSinh.Size = new System.Drawing.Size(577, 20);
            this.txtTimHocSinh.TabIndex = 3;
            this.txtTimHocSinh.TextChanged += new System.EventHandler(this.txtTimHocSinh_TextChanged);
            this.txtTimHocSinh.Enter += new System.EventHandler(this.txtTimHocSinh_Enter);
            this.txtTimHocSinh.Leave += new System.EventHandler(this.txtTimHocSinh_Leave);
            // 
            // dgvTKPH
            // 
            this.dgvTKPH.AutoGenerateColumns = false;
            this.dgvTKPH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKPH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn});
            this.dgvTKPH.DataSource = this.bsTKPH;
            this.dgvTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKPH.Location = new System.Drawing.Point(2, 22);
            this.dgvTKPH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTKPH.Name = "dgvTKPH";
            this.tlpTKPH.SetRowSpan(this.dgvTKPH, 2);
            this.dgvTKPH.RowTemplate.Height = 24;
            this.dgvTKPH.Size = new System.Drawing.Size(241, 456);
            this.dgvTKPH.TabIndex = 0;
            this.dgvTKPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKPH_CellClick);
            this.dgvTKPH.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKPH_CellEndEdit);
            this.dgvTKPH.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTKPH_UserAddedRow);
            this.dgvTKPH.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTKPH_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            // 
            // bsTKPH
            // 
            this.bsTKPH.DataSource = typeof(DTO.TaiKhoanPH);
            // 
            // txtTimTK
            // 
            this.txtTimTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTK.Location = new System.Drawing.Point(2, 2);
            this.txtTimTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTK.Name = "txtTimTK";
            this.txtTimTK.Size = new System.Drawing.Size(241, 20);
            this.txtTimTK.TabIndex = 1;
            this.txtTimTK.TextChanged += new System.EventHandler(this.txtTimTK_TextChanged);
            this.txtTimTK.Enter += new System.EventHandler(this.txtTimTK_Enter);
            this.txtTimTK.Leave += new System.EventHandler(this.txtTimTK_Leave);
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AutoGenerateColumns = false;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnChonTK,
            this.iDDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn});
            this.tlpTKPH.SetColumnSpan(this.dgvDSHS, 3);
            this.dgvDSHS.DataSource = this.bsTTHS;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(247, 22);
            this.dgvDSHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.ReadOnly = true;
            this.dgvDSHS.RowTemplate.Height = 24;
            this.dgvDSHS.Size = new System.Drawing.Size(577, 402);
            this.dgvDSHS.TabIndex = 2;
            this.dgvDSHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHS_CellContentClick);
            // 
            // btnChonTK
            // 
            this.btnChonTK.HeaderText = "Chọn";
            this.btnChonTK.Name = "btnChonTK";
            this.btnChonTK.ReadOnly = true;
            this.btnChonTK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnChonTK.Text = "";
            this.btnChonTK.Width = 50;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID Học Sinh";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "Nơi Sinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            this.noiSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "ID Lớp";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            this.iDLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTTHS
            // 
            this.bsTTHS.DataSource = typeof(DTO.ThongTinHS);
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatLaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLaiMK.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMK.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMK.Location = new System.Drawing.Point(706, 428);
            this.btnDatLaiMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(118, 50);
            this.btnDatLaiMK.TabIndex = 7;
            this.btnDatLaiMK.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            this.btnDatLaiMK.Click += new System.EventHandler(this.btnDatLaiMK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemTK.FlatAppearance.BorderSize = 0;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.White;
            this.btnThemTK.Location = new System.Drawing.Point(587, 428);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(115, 50);
            this.btnThemTK.TabIndex = 8;
            this.btnThemTK.Text = "Lưu";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // tabPageQLTK
            // 
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanPH);
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanTruong);
            this.tabPageQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabPageQLTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageQLTK.Name = "tabPageQLTK";
            this.tabPageQLTK.SelectedIndex = 0;
            this.tabPageQLTK.Size = new System.Drawing.Size(838, 510);
            this.tabPageQLTK.TabIndex = 0;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(838, 510);
            this.Controls.Add(this.tabPageQLTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            this.tabPageTaiKhoanTruong.ResumeLayout(false);
            this.tlpTKT.ResumeLayout(false);
            this.tlpTKT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoanTruong)).EndInit();
            this.tabPageTaiKhoanPH.ResumeLayout(false);
            this.tlpTKPH.ResumeLayout(false);
            this.tlpTKPH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTKPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTHS)).EndInit();
            this.tabPageQLTK.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnDatLaiMK;
        private System.Windows.Forms.TextBox txtTimGV;
        private System.Windows.Forms.DataGridView dgvThongTinGV;
        private System.Windows.Forms.BindingSource bsTKPH;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTTHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLuuTTGV;
        private System.Windows.Forms.DataGridViewButtonColumn btnChonTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTaiKhoanTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Loai;
    }
}