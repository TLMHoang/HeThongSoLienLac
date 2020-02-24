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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsView = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tabMon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.Col_IDMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Loai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMon = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimMoi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhanCongMon);
            this.tabControl1.Controls.Add(this.tabMon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 689);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhanCongMon
            // 
            this.tabPhanCongMon.Controls.Add(this.tableLayoutPanel1);
            this.tabPhanCongMon.Location = new System.Drawing.Point(4, 29);
            this.tabPhanCongMon.Margin = new System.Windows.Forms.Padding(0);
            this.tabPhanCongMon.Name = "tabPhanCongMon";
            this.tabPhanCongMon.Size = new System.Drawing.Size(568, 656);
            this.tabPhanCongMon.TabIndex = 0;
            this.tabPhanCongMon.Text = "Phân công giáo viên";
            this.tabPhanCongMon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiemGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSLop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 656);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTimKiemGV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiemGV, 3);
            this.txtTimKiemGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemGV.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemGV.Location = new System.Drawing.Point(3, 2);
            this.txtTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(363, 27);
            this.txtTimKiemGV.TabIndex = 1;
            this.txtTimKiemGV.Text = "Nhập ID hoặc Tên GV";
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
            this.dgvDSGV.Size = new System.Drawing.Size(363, 167);
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
            this.dgvDSLop.Location = new System.Drawing.Point(372, 28);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.RowHeadersVisible = false;
            this.dgvDSLop.Size = new System.Drawing.Size(193, 165);
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
            this.btnBack.Location = new System.Drawing.Point(418, 198);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(372, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvView
            // 
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.iDGiaoVienDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn,
            this.iDMonDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvView, 5);
            this.dgvView.DataSource = this.bsView;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.Location = new System.Drawing.Point(3, 259);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(562, 394);
            this.dgvView.TabIndex = 8;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // iDGiaoVienDataGridViewTextBoxColumn
            // 
            this.iDGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "IDGiaoVien";
            this.iDGiaoVienDataGridViewTextBoxColumn.HeaderText = "ID Giáo Viên";
            this.iDGiaoVienDataGridViewTextBoxColumn.Name = "iDGiaoVienDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "ID Lớp";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // iDMonDataGridViewTextBoxColumn
            // 
            this.iDMonDataGridViewTextBoxColumn.DataPropertyName = "IDMon";
            this.iDMonDataGridViewTextBoxColumn.HeaderText = "Môn Dạy";
            this.iDMonDataGridViewTextBoxColumn.Name = "iDMonDataGridViewTextBoxColumn";
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
            this.btnSua.Location = new System.Drawing.Point(153, 198);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 56);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(3, 198);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(144, 56);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tabMon
            // 
            this.tabMon.Controls.Add(this.tableLayoutPanel2);
            this.tabMon.Location = new System.Drawing.Point(4, 29);
            this.tabMon.Margin = new System.Windows.Forms.Padding(0);
            this.tabMon.Name = "tabMon";
            this.tabMon.Size = new System.Drawing.Size(568, 656);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 656);
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
            this.dgvMon.Size = new System.Drawing.Size(562, 625);
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
            this.txtTimMoi.Size = new System.Drawing.Size(562, 26);
            this.txtTimMoi.TabIndex = 0;
            this.txtTimMoi.Text = "Nhập ID hoặc Tên môn học";
            this.txtTimMoi.TextChanged += new System.EventHandler(this.txtTimMoi_TextChanged);
            this.txtTimMoi.Enter += new System.EventHandler(this.txtTimMoi_Enter);
            this.txtTimMoi.Leave += new System.EventHandler(this.txtTimMoi_Leave);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 689);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Công";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanCong_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.tabControl1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhanCongMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabMon;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Day;
    }
}