namespace GUI
{
    partial class frmHocSinh
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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTMeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTBoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsThongTinHS = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTenMe = new System.Windows.Forms.Label();
            this.txtTenBa = new System.Windows.Forms.TextBox();
            this.txtSDTBa = new System.Windows.Forms.TextBox();
            this.txtTenMe = new System.Windows.Forms.TextBox();
            this.txtSDTMe = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongTinHS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoGenerateColumns = false;
            this.dgvHocSinh.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn,
            this.DanToc,
            this.tonGiaoDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn,
            this.iDTaiKhoanDataGridViewTextBoxColumn,
            this.tenMeDataGridViewTextBoxColumn,
            this.sDTMeDataGridViewTextBoxColumn,
            this.tenBoDataGridViewTextBoxColumn,
            this.sDTBoDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvHocSinh, 2);
            this.dgvHocSinh.DataSource = this.bsThongTinHS;
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 150);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(0);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(1245, 404);
            this.dgvHocSinh.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "Nơi sinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "DanToc";
            this.DanToc.Name = "DanToc";
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
            // bsThongTinHS
            // 
            this.bsThongTinHS.DataSource = typeof(DTO.ThongTinHS);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHocSinh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1245, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.66853F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.329067F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.329067F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.66853F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66813F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.66853F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66813F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButton1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTen, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNoiSinh, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtNgaySinh, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDanToc, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTonGiao, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTenMe, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTenBa, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSDTBa, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenMe, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSDTMe, 6, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1201, 144);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giới Tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(292, 76);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 28);
            this.radioButton2.TabIndex = 49;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(180, 76);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 28);
            this.radioButton1.TabIndex = 48;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtMa, 2);
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.Location = new System.Drawing.Point(180, 4);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(216, 22);
            this.txtMa.TabIndex = 33;
            // 
            // txtTen
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtTen, 2);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Location = new System.Drawing.Point(180, 40);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(216, 22);
            this.txtTen.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Học Sinh:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Học Sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(404, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 36);
            this.label6.TabIndex = 52;
            this.label6.Text = "Dân Tộc:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(404, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 36);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tôn Giáo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(404, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ngày Sinh:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNoiSinh
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtNoiSinh, 2);
            this.txtNoiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiSinh.Location = new System.Drawing.Point(180, 112);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(216, 22);
            this.txtNoiSinh.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nơi Sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgaySinh.Location = new System.Drawing.Point(580, 4);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(216, 22);
            this.txtNgaySinh.TabIndex = 54;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDanToc.Location = new System.Drawing.Point(580, 40);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(216, 22);
            this.txtDanToc.TabIndex = 55;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTonGiao.Location = new System.Drawing.Point(580, 76);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(216, 22);
            this.txtTonGiao.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(804, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 36);
            this.label8.TabIndex = 57;
            this.label8.Text = "Họ Tên Ba:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(804, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 36);
            this.label9.TabIndex = 58;
            this.label9.Text = "SDT:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(804, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 36);
            this.label11.TabIndex = 60;
            this.label11.Text = "SDT:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTenMe
            // 
            this.lblTenMe.AutoSize = true;
            this.lblTenMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMe.Location = new System.Drawing.Point(804, 72);
            this.lblTenMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenMe.Name = "lblTenMe";
            this.lblTenMe.Size = new System.Drawing.Size(168, 36);
            this.lblTenMe.TabIndex = 59;
            this.lblTenMe.Text = "Họ Tên Mẹ:";
            this.lblTenMe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenBa
            // 
            this.txtTenBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenBa.Location = new System.Drawing.Point(980, 4);
            this.txtTenBa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBa.Name = "txtTenBa";
            this.txtTenBa.Size = new System.Drawing.Size(217, 22);
            this.txtTenBa.TabIndex = 61;
            // 
            // txtSDTBa
            // 
            this.txtSDTBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTBa.Location = new System.Drawing.Point(980, 40);
            this.txtSDTBa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTBa.Name = "txtSDTBa";
            this.txtSDTBa.Size = new System.Drawing.Size(217, 22);
            this.txtSDTBa.TabIndex = 62;
            // 
            // txtTenMe
            // 
            this.txtTenMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenMe.Location = new System.Drawing.Point(980, 76);
            this.txtTenMe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMe.Name = "txtTenMe";
            this.txtTenMe.Size = new System.Drawing.Size(217, 22);
            this.txtTenMe.TabIndex = 63;
            // 
            // txtSDTMe
            // 
            this.txtSDTMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTMe.Location = new System.Drawing.Point(980, 112);
            this.txtSDTMe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTMe.Name = "txtSDTMe";
            this.txtSDTMe.Size = new System.Drawing.Size(217, 22);
            this.txtSDTMe.TabIndex = 64;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnLuu,
            this.btnLamMoi,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(1221, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 150);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThem.Image = global::GUI.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(21, 20);
            this.btnThem.Text = "&New";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoa.Image = global::GUI.Properties.Resources.bin;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(21, 20);
            this.btnXoa.Text = "toolStripButton2";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuu.Image = global::GUI.Properties.Resources.floppy_disk;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(21, 20);
            this.btnLuu.Text = "toolStripButton3";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLamMoi.Image = global::GUI.Properties.Resources.refresh;
            this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(21, 20);
            this.btnLamMoi.Text = "toolStripButton4";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThoat.Image = global::GUI.Properties.Resources.exit;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(21, 20);
            this.btnThoat.Text = "toolStripButton5";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1245, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHocSinh_FormClosing);
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongTinHS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTenMe;
        private System.Windows.Forms.TextBox txtTenBa;
        private System.Windows.Forms.TextBox txtSDTBa;
        private System.Windows.Forms.TextBox txtTenMe;
        private System.Windows.Forms.TextBox txtSDTMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTMeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTBoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsThongTinHS;
    }
}