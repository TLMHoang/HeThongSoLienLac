namespace GUI
{
    partial class frmPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.tabControlPhanCong = new System.Windows.Forms.TabControl();
            this.tabPhanCongMon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Day = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsLop = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsView = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtTimLop = new System.Windows.Forms.TextBox();
            this.tabMon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.Col_IDMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Loai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMon = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimMoi = new System.Windows.Forms.TextBox();
            this.tabPageGVCN = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSuaGVCN = new System.Windows.Forms.Button();
            this.txtTimGVCN = new System.Windows.Forms.TextBox();
            this.dgvGVCN = new System.Windows.Forms.DataGridView();
            this.iDGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGVCN = new System.Windows.Forms.BindingSource(this.components);
            this.dgvChonGVCN = new System.Windows.Forms.DataGridView();
            this.iDTKTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDSGVCN = new System.Windows.Forms.BindingSource(this.components);
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.btnLuuGVCN = new System.Windows.Forms.Button();
            this.tabControlPhanCong.SuspendLayout();
            this.tabPhanCongMon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).BeginInit();
            this.tabMon.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMon)).BeginInit();
            this.tabPageGVCN.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGVCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGVCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGVCN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPhanCong
            // 
            this.tabControlPhanCong.Controls.Add(this.tabPhanCongMon);
            this.tabControlPhanCong.Controls.Add(this.tabMon);
            this.tabControlPhanCong.Controls.Add(this.tabPageGVCN);
            this.tabControlPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPhanCong.Location = new System.Drawing.Point(0, 0);
            this.tabControlPhanCong.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlPhanCong.Name = "tabControlPhanCong";
            this.tabControlPhanCong.SelectedIndex = 0;
            this.tabControlPhanCong.Size = new System.Drawing.Size(576, 689);
            this.tabControlPhanCong.TabIndex = 0;
            // 
            // tabPhanCongMon
            // 
            this.tabPhanCongMon.Controls.Add(this.tableLayoutPanel1);
            this.tabPhanCongMon.Location = new System.Drawing.Point(4, 25);
            this.tabPhanCongMon.Margin = new System.Windows.Forms.Padding(0);
            this.tabPhanCongMon.Name = "tabPhanCongMon";
            this.tabPhanCongMon.Size = new System.Drawing.Size(568, 660);
            this.tabPhanCongMon.TabIndex = 0;
            this.tabPhanCongMon.Text = "Phân công giáo viên";
            this.tabPhanCongMon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiemGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSLop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTimLop, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 660);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTimKiemGV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiemGV, 3);
            this.txtTimKiemGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemGV.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemGV.Location = new System.Drawing.Point(3, 2);
            this.txtTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(357, 23);
            this.txtTimKiemGV.TabIndex = 1;
            this.txtTimKiemGV.Text = "Nhập ID hoặc Tên GV";
            this.txtTimKiemGV.TextChanged += new System.EventHandler(this.txtTimKiemGV_TextChanged);
            this.txtTimKiemGV.Enter += new System.EventHandler(this.txtTimKiemGV_Enter);
            this.txtTimKiemGV.Leave += new System.EventHandler(this.txtTimKiemGV_Leave);
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AutoGenerateColumns = false;
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSGV, 3);
            this.dgvDSGV.DataSource = this.bsDSGV;
            this.dgvDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSGV.Location = new System.Drawing.Point(3, 27);
            this.dgvDSGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.ReadOnly = true;
            this.dgvDSGV.RowHeadersVisible = false;
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.Size = new System.Drawing.Size(357, 158);
            this.dgvDSGV.TabIndex = 2;
            this.dgvDSGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellClick);
            // 
            // iDTKTDataGridViewTextBoxColumn
            // 
            this.iDTKTDataGridViewTextBoxColumn.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDTKTDataGridViewTextBoxColumn.Name = "iDTKTDataGridViewTextBoxColumn";
            this.iDTKTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên GV";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMonHocDataGridViewTextBoxColumn
            // 
            this.iDMonHocDataGridViewTextBoxColumn.DataPropertyName = "IDMonHoc";
            this.iDMonHocDataGridViewTextBoxColumn.HeaderText = "Môn Dạy";
            this.iDMonHocDataGridViewTextBoxColumn.Name = "iDMonHocDataGridViewTextBoxColumn";
            this.iDMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.AutoGenerateColumns = false;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.col_Day});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSLop, 2);
            this.dgvDSLop.DataSource = this.bsLop;
            this.dgvDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLop.Location = new System.Drawing.Point(366, 28);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.RowHeadersVisible = false;
            this.dgvDSLop.Size = new System.Drawing.Size(199, 156);
            this.dgvDSLop.TabIndex = 6;
            this.dgvDSLop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLop_CellEndEdit);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 63;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 64;
            // 
            // col_Day
            // 
            this.col_Day.HeaderText = "Dạy";
            this.col_Day.Name = "col_Day";
            this.col_Day.Width = 63;
            // 
            // bsLop
            // 
            this.bsLop.DataSource = typeof(DTO.Lop);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(422, 189);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.col_IDGV,
            this.col_IDLop,
            this.col_IDMonHoc});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvView, 5);
            this.dgvView.DataSource = this.bsView;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.Location = new System.Drawing.Point(3, 250);
            this.dgvView.Name = "dgvView";
            this.tableLayoutPanel1.SetRowSpan(this.dgvView, 2);
            this.dgvView.Size = new System.Drawing.Size(562, 407);
            this.dgvView.TabIndex = 8;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            this.dgvView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvView_UserDeletingRow);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // col_IDGV
            // 
            this.col_IDGV.DataPropertyName = "IDGiaoVien";
            this.col_IDGV.HeaderText = "ID Giáo Viên";
            this.col_IDGV.Name = "col_IDGV";
            // 
            // col_IDLop
            // 
            this.col_IDLop.DataPropertyName = "IDLop";
            this.col_IDLop.HeaderText = "ID Lớp";
            this.col_IDLop.Name = "col_IDLop";
            // 
            // col_IDMonHoc
            // 
            this.col_IDMonHoc.DataPropertyName = "IDMon";
            this.col_IDMonHoc.HeaderText = "Môn Dạy";
            this.col_IDMonHoc.Name = "col_IDMonHoc";
            // 
            // bsView
            // 
            this.bsView.DataSource = typeof(DTO.PhanCong);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(143, 189);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 56);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(3, 189);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 56);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtTimLop
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimLop, 2);
            this.txtTimLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimLop.ForeColor = System.Drawing.Color.Gray;
            this.txtTimLop.Location = new System.Drawing.Point(366, 3);
            this.txtTimLop.Name = "txtTimLop";
            this.txtTimLop.Size = new System.Drawing.Size(199, 23);
            this.txtTimLop.TabIndex = 9;
            this.txtTimLop.Text = "Nhập ID hoặc Tên Lớp";
            this.txtTimLop.TextChanged += new System.EventHandler(this.txtTimLop_TextChanged);
            this.txtTimLop.Enter += new System.EventHandler(this.txtTimLop_Enter);
            this.txtTimLop.Leave += new System.EventHandler(this.txtTimLop_Leave);
            // 
            // tabMon
            // 
            this.tabMon.Controls.Add(this.tableLayoutPanel2);
            this.tabMon.Location = new System.Drawing.Point(4, 25);
            this.tabMon.Margin = new System.Windows.Forms.Padding(0);
            this.tabMon.Name = "tabMon";
            this.tabMon.Size = new System.Drawing.Size(568, 660);
            this.tabMon.TabIndex = 1;
            this.tabMon.Text = "Quản lý môn";
            this.tabMon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvMon, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTimMoi, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 660);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvMon
            // 
            this.dgvMon.AutoGenerateColumns = false;
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IDMon,
            this.Col_TenMon,
            this.Col_Loai});
            this.dgvMon.DataSource = this.bsMon;
            this.dgvMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMon.Location = new System.Drawing.Point(3, 28);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.Size = new System.Drawing.Size(562, 629);
            this.dgvMon.TabIndex = 1;
            this.dgvMon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellEndEdit);
            this.dgvMon.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMon_UserAddedRow);
            // 
            // Col_IDMon
            // 
            this.Col_IDMon.DataPropertyName = "ID";
            this.Col_IDMon.FillWeight = 21.12743F;
            this.Col_IDMon.HeaderText = "Mã";
            this.Col_IDMon.Name = "Col_IDMon";
            this.Col_IDMon.ReadOnly = true;
            // 
            // Col_TenMon
            // 
            this.Col_TenMon.DataPropertyName = "TenMon";
            this.Col_TenMon.FillWeight = 187.502F;
            this.Col_TenMon.HeaderText = "Tên Môn học";
            this.Col_TenMon.Name = "Col_TenMon";
            // 
            // Col_Loai
            // 
            this.Col_Loai.DataPropertyName = "LoaiDiem";
            this.Col_Loai.FillWeight = 91.37056F;
            this.Col_Loai.HeaderText = "Loại điểm hệ số 10";
            this.Col_Loai.Name = "Col_Loai";
            this.Col_Loai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Loai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsMon
            // 
            this.bsMon.DataSource = typeof(DTO.MonHoc);
            // 
            // txtTimMoi
            // 
            this.txtTimMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimMoi.ForeColor = System.Drawing.Color.Gray;
            this.txtTimMoi.Location = new System.Drawing.Point(3, 3);
            this.txtTimMoi.Name = "txtTimMoi";
            this.txtTimMoi.Size = new System.Drawing.Size(562, 22);
            this.txtTimMoi.TabIndex = 0;
            this.txtTimMoi.Text = "Nhập ID hoặc Tên môn học";
            this.txtTimMoi.TextChanged += new System.EventHandler(this.txtTimMoi_TextChanged);
            this.txtTimMoi.Enter += new System.EventHandler(this.txtTimMoi_Enter);
            this.txtTimMoi.Leave += new System.EventHandler(this.txtTimMoi_Leave);
            // 
            // tabPageGVCN
            // 
            this.tabPageGVCN.Controls.Add(this.tableLayoutPanel3);
            this.tabPageGVCN.Location = new System.Drawing.Point(4, 25);
            this.tabPageGVCN.Name = "tabPageGVCN";
            this.tabPageGVCN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGVCN.Size = new System.Drawing.Size(568, 660);
            this.tabPageGVCN.TabIndex = 2;
            this.tabPageGVCN.Text = "Giáo Viên Chủ Nhiệm";
            this.tabPageGVCN.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.19929F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80071F));
            this.tableLayoutPanel3.Controls.Add(this.btnSuaGVCN, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTimGVCN, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvGVCN, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.dgvChonGVCN, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboChonLop, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblChonLop, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLuuGVCN, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.769231F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.153846F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.23077F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84615F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.61538F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 654);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnSuaGVCN
            // 
            this.btnSuaGVCN.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuaGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaGVCN.FlatAppearance.BorderSize = 0;
            this.btnSuaGVCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaGVCN.ForeColor = System.Drawing.Color.White;
            this.btnSuaGVCN.Location = new System.Drawing.Point(419, 146);
            this.btnSuaGVCN.Name = "btnSuaGVCN";
            this.btnSuaGVCN.Size = new System.Drawing.Size(140, 67);
            this.btnSuaGVCN.TabIndex = 6;
            this.btnSuaGVCN.Text = "Sửa";
            this.btnSuaGVCN.UseVisualStyleBackColor = false;
            this.btnSuaGVCN.Click += new System.EventHandler(this.btnSuaGVCN_Click);
            // 
            // txtTimGVCN
            // 
            this.txtTimGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimGVCN.ForeColor = System.Drawing.Color.Gray;
            this.txtTimGVCN.Location = new System.Drawing.Point(3, 3);
            this.txtTimGVCN.Name = "txtTimGVCN";
            this.txtTimGVCN.Size = new System.Drawing.Size(410, 23);
            this.txtTimGVCN.TabIndex = 0;
            this.txtTimGVCN.Text = "Nhập ID hoặc Tên GV";
            this.txtTimGVCN.TextChanged += new System.EventHandler(this.txtTimGVCN_TextChanged);
            this.txtTimGVCN.Enter += new System.EventHandler(this.txtTimGVCN_Enter);
            this.txtTimGVCN.Leave += new System.EventHandler(this.txtTimGVCN_Leave);
            // 
            // dgvGVCN
            // 
            this.dgvGVCN.AutoGenerateColumns = false;
            this.dgvGVCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGiaoVienDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvGVCN, 2);
            this.dgvGVCN.DataSource = this.bsGVCN;
            this.dgvGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGVCN.Location = new System.Drawing.Point(3, 309);
            this.dgvGVCN.Name = "dgvGVCN";
            this.dgvGVCN.RowTemplate.Height = 24;
            this.dgvGVCN.Size = new System.Drawing.Size(556, 342);
            this.dgvGVCN.TabIndex = 2;
            this.dgvGVCN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGVCN_CellDoubleClick);
            this.dgvGVCN.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvGVCN_UserDeletingRow);
            // 
            // iDGiaoVienDataGridViewTextBoxColumn
            // 
            this.iDGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "IDGiaoVien";
            this.iDGiaoVienDataGridViewTextBoxColumn.HeaderText = "Mã GV";
            this.iDGiaoVienDataGridViewTextBoxColumn.Name = "iDGiaoVienDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // bsGVCN
            // 
            this.bsGVCN.DataSource = typeof(DTO.GVCN);
            // 
            // dgvChonGVCN
            // 
            this.dgvChonGVCN.AllowUserToAddRows = false;
            this.dgvChonGVCN.AutoGenerateColumns = false;
            this.dgvChonGVCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonGVCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn1,
            this.tenGVDataGridViewTextBoxColumn1,
            this.sDTDataGridViewTextBoxColumn1});
            this.dgvChonGVCN.DataSource = this.bsDSGVCN;
            this.dgvChonGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonGVCN.Location = new System.Drawing.Point(3, 34);
            this.dgvChonGVCN.Name = "dgvChonGVCN";
            this.tableLayoutPanel3.SetRowSpan(this.dgvChonGVCN, 4);
            this.dgvChonGVCN.RowTemplate.Height = 24;
            this.dgvChonGVCN.Size = new System.Drawing.Size(410, 269);
            this.dgvChonGVCN.TabIndex = 1;
            this.dgvChonGVCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonGVCN_CellClick);
            // 
            // iDTKTDataGridViewTextBoxColumn1
            // 
            this.iDTKTDataGridViewTextBoxColumn1.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn1.HeaderText = "Mã GV";
            this.iDTKTDataGridViewTextBoxColumn1.Name = "iDTKTDataGridViewTextBoxColumn1";
            this.iDTKTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDTKTDataGridViewTextBoxColumn1.Width = 122;
            // 
            // tenGVDataGridViewTextBoxColumn1
            // 
            this.tenGVDataGridViewTextBoxColumn1.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn1.HeaderText = "Tên Giáo Viên";
            this.tenGVDataGridViewTextBoxColumn1.Name = "tenGVDataGridViewTextBoxColumn1";
            this.tenGVDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tenGVDataGridViewTextBoxColumn1.Width = 122;
            // 
            // sDTDataGridViewTextBoxColumn1
            // 
            this.sDTDataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn1.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn1.Name = "sDTDataGridViewTextBoxColumn1";
            this.sDTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn1.Width = 123;
            // 
            // bsDSGVCN
            // 
            this.bsDSGVCN.DataSource = typeof(DTO.ThongTinGV);
            // 
            // cboChonLop
            // 
            this.cboChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(419, 34);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(140, 24);
            this.cboChonLop.TabIndex = 3;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChonLop.Location = new System.Drawing.Point(419, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(77, 17);
            this.lblChonLop.TabIndex = 4;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // btnLuuGVCN
            // 
            this.btnLuuGVCN.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuuGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuGVCN.FlatAppearance.BorderSize = 0;
            this.btnLuuGVCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuGVCN.ForeColor = System.Drawing.Color.White;
            this.btnLuuGVCN.Location = new System.Drawing.Point(419, 74);
            this.btnLuuGVCN.Name = "btnLuuGVCN";
            this.btnLuuGVCN.Size = new System.Drawing.Size(140, 66);
            this.btnLuuGVCN.TabIndex = 5;
            this.btnLuuGVCN.Text = "Lưu";
            this.btnLuuGVCN.UseVisualStyleBackColor = false;
            this.btnLuuGVCN.Click += new System.EventHandler(this.btnLuuGVCN_Click);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 689);
            this.Controls.Add(this.tabControlPhanCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Công";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanCong_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.tabControlPhanCong.ResumeLayout(false);
            this.tabPhanCongMon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).EndInit();
            this.tabMon.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMon)).EndInit();
            this.tabPageGVCN.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGVCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGVCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGVCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPhanCong;
        private System.Windows.Forms.TabPage tabPhanCongMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabMon;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.BindingSource bsView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.BindingSource bsMon;
        private System.Windows.Forms.TextBox txtTimMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IDMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenMon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Loai;
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLop;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDMonHoc;
        private System.Windows.Forms.TextBox txtTimLop;
        private System.Windows.Forms.TabPage tabPageGVCN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtTimGVCN;
        private System.Windows.Forms.DataGridView dgvChonGVCN;
        private System.Windows.Forms.DataGridView dgvGVCN;
        private System.Windows.Forms.BindingSource bsGVCN;
        private System.Windows.Forms.BindingSource bsDSGVCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSuaGVCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Button btnLuuGVCN;
    }
}