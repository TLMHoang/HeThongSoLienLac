namespace GUI
{
    partial class frmNhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDanhSachHS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDiemHK = new System.Windows.Forms.RadioButton();
            this.radDiemMT = new System.Windows.Forms.RadioButton();
            this.radDiem15 = new System.Windows.Forms.RadioButton();
            this.radDiemMieng = new System.Windows.Forms.RadioButton();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.cbxMon = new System.Windows.Forms.ComboBox();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbxDat = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDiemHeSoMot = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMon1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Diem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DiemMieng1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HocKy1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsDiemHeSoMot = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDiemHeSoHai = new System.Windows.Forms.DataGridView();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMon2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Diem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HocKy2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsDiemHeSoHai = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvDiemHocKy = new System.Windows.Forms.DataGridView();
            this.STTHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMonHK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DiemHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HocKyHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsDiemHocKy = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHeSoMot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHeSoMot)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHeSoHai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHeSoHai)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 715);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbxLop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvDanhSachHS, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 474);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.cbxLop.TabIndex = 1;
            this.cbxLop.Text = "-----------Lớp-----------";
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(153, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(444, 23);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Nhập ID hoặc Tên học sinh";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // dgvDanhSachHS
            // 
            this.dgvDanhSachHS.AllowUserToAddRows = false;
            this.dgvDanhSachHS.AllowUserToDeleteRows = false;
            this.dgvDanhSachHS.AutoGenerateColumns = false;
            this.dgvDanhSachHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.NgaySinh});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvDanhSachHS, 2);
            this.dgvDanhSachHS.DataSource = this.bsHocSinh;
            this.dgvDanhSachHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHS.Location = new System.Drawing.Point(3, 28);
            this.dgvDanhSachHS.Name = "dgvDanhSachHS";
            this.dgvDanhSachHS.ReadOnly = true;
            this.dgvDanhSachHS.RowHeadersVisible = false;
            this.dgvDanhSachHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHS.Size = new System.Drawing.Size(594, 443);
            this.dgvDanhSachHS.TabIndex = 3;
            this.dgvDanhSachHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHS_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 30.99354F;
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.FillWeight = 182.7411F;
            this.Ten.HeaderText = "Tên học sinh";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 86.26535F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // bsHocSinh
            // 
            this.bsHocSinh.DataSource = typeof(DTO.ThongTinHS);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radHK1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxMon, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.radHK2, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnLuu, 3, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 474);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 241);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.radDiemHK);
            this.groupBox1.Controls.Add(this.radDiemMT);
            this.groupBox1.Controls.Add(this.radDiem15);
            this.groupBox1.Controls.Add(this.radDiemMieng);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.SetRowSpan(this.groupBox1, 4);
            this.groupBox1.Size = new System.Drawing.Size(294, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại điểm";
            // 
            // radDiemHK
            // 
            this.radDiemHK.AutoSize = true;
            this.radDiemHK.Location = new System.Drawing.Point(66, 193);
            this.radDiemHK.Name = "radDiemHK";
            this.radDiemHK.Size = new System.Drawing.Size(132, 28);
            this.radDiemHK.TabIndex = 0;
            this.radDiemHK.Text = "Điểm học kỳ";
            this.radDiemHK.UseVisualStyleBackColor = true;
            this.radDiemHK.CheckedChanged += new System.EventHandler(this.radDiemMieng_CheckedChanged);
            // 
            // radDiemMT
            // 
            this.radDiemMT.AutoSize = true;
            this.radDiemMT.Location = new System.Drawing.Point(66, 141);
            this.radDiemMT.Name = "radDiemMT";
            this.radDiemMT.Size = new System.Drawing.Size(115, 28);
            this.radDiemMT.TabIndex = 0;
            this.radDiemMT.Text = "Điểm 1 tiết";
            this.radDiemMT.UseVisualStyleBackColor = true;
            this.radDiemMT.CheckedChanged += new System.EventHandler(this.radDiemMieng_CheckedChanged);
            // 
            // radDiem15
            // 
            this.radDiem15.AutoSize = true;
            this.radDiem15.Location = new System.Drawing.Point(66, 89);
            this.radDiem15.Name = "radDiem15";
            this.radDiem15.Size = new System.Drawing.Size(108, 28);
            this.radDiem15.TabIndex = 0;
            this.radDiem15.Text = "Điểm 15p";
            this.radDiem15.UseVisualStyleBackColor = true;
            this.radDiem15.CheckedChanged += new System.EventHandler(this.radDiemMieng_CheckedChanged);
            // 
            // radDiemMieng
            // 
            this.radDiemMieng.AutoSize = true;
            this.radDiemMieng.Checked = true;
            this.radDiemMieng.Location = new System.Drawing.Point(66, 37);
            this.radDiemMieng.Name = "radDiemMieng";
            this.radDiemMieng.Size = new System.Drawing.Size(130, 28);
            this.radDiemMieng.TabIndex = 0;
            this.radDiemMieng.TabStop = true;
            this.radDiemMieng.Text = "Điểm miệng";
            this.radDiemMieng.UseVisualStyleBackColor = true;
            this.radDiemMieng.CheckedChanged += new System.EventHandler(this.radDiemMieng_CheckedChanged);
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Checked = true;
            this.radHK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radHK1.Location = new System.Drawing.Point(303, 63);
            this.radHK1.Name = "radHK1";
            this.radHK1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radHK1.Size = new System.Drawing.Size(144, 54);
            this.radHK1.TabIndex = 6;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "Học Kỳ 1";
            this.radHK1.UseVisualStyleBackColor = true;
            this.radHK1.CheckedChanged += new System.EventHandler(this.radHK2_CheckedChanged);
            // 
            // cbxMon
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbxMon, 2);
            this.cbxMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxMon.FormattingEnabled = true;
            this.cbxMon.Items.AddRange(new object[] {
            "-----------------Môn-----------------"});
            this.cbxMon.Location = new System.Drawing.Point(300, 15);
            this.cbxMon.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(300, 32);
            this.cbxMon.TabIndex = 1;
            this.cbxMon.Text = "-----------------Môn-----------------";
            this.cbxMon.SelectedIndexChanged += new System.EventHandler(this.cbxMon_SelectedIndexChanged);
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radHK2.Location = new System.Drawing.Point(453, 63);
            this.radHK2.Name = "radHK2";
            this.radHK2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radHK2.Size = new System.Drawing.Size(144, 54);
            this.radHK2.TabIndex = 5;
            this.radHK2.Text = "Học Kỳ 2";
            this.radHK2.UseVisualStyleBackColor = true;
            this.radHK2.CheckedChanged += new System.EventHandler(this.radHK2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(300, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox2.Size = new System.Drawing.Size(150, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại điểm hệ số 10";
            // 
            // numDiem
            // 
            this.numDiem.DecimalPlaces = 2;
            this.numDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDiem.Enabled = false;
            this.numDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numDiem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numDiem.Location = new System.Drawing.Point(20, 18);
            this.numDiem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(110, 29);
            this.numDiem.TabIndex = 4;
            this.numDiem.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numDiem.ValueChanged += new System.EventHandler(this.numDiem_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbxDat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(450, 120);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(40, 3, 30, 3);
            this.groupBox3.Size = new System.Drawing.Size(150, 60);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Đạt - Không Đạt";
            // 
            // chbxDat
            // 
            this.chbxDat.AutoSize = true;
            this.chbxDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxDat.Enabled = false;
            this.chbxDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbxDat.Location = new System.Drawing.Point(40, 18);
            this.chbxDat.Name = "chbxDat";
            this.chbxDat.Size = new System.Drawing.Size(80, 39);
            this.chbxDat.TabIndex = 3;
            this.chbxDat.Text = "Đạt";
            this.chbxDat.UseVisualStyleBackColor = true;
            this.chbxDat.CheckedChanged += new System.EventHandler(this.chbxDat_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Location = new System.Drawing.Point(453, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 55);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDiemHeSoMot);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(603, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 231);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điểm hệ số 1 - Điểm miệng + điểm 15 phút";
            // 
            // dgvDiemHeSoMot
            // 
            this.dgvDiemHeSoMot.AllowUserToAddRows = false;
            this.dgvDiemHeSoMot.AutoGenerateColumns = false;
            this.dgvDiemHeSoMot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemHeSoMot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemHeSoMot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.IDMon1,
            this.Diem1,
            this.Loai1,
            this.DiemMieng1,
            this.HocKy1});
            this.dgvDiemHeSoMot.DataSource = this.bsDiemHeSoMot;
            this.dgvDiemHeSoMot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemHeSoMot.Location = new System.Drawing.Point(3, 18);
            this.dgvDiemHeSoMot.Name = "dgvDiemHeSoMot";
            this.dgvDiemHeSoMot.Size = new System.Drawing.Size(643, 210);
            this.dgvDiemHeSoMot.TabIndex = 4;
            this.dgvDiemHeSoMot.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiemHeSoMot_CellBeginEdit);
            this.dgvDiemHeSoMot.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemHeSoMot_CellEndEdit);
            this.dgvDiemHeSoMot.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDiemHeSoMot_UserDeletingRow);
            // 
            // STT1
            // 
            this.STT1.DataPropertyName = "STT";
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.ReadOnly = true;
            // 
            // IDMon1
            // 
            this.IDMon1.DataPropertyName = "IDMon";
            this.IDMon1.HeaderText = "Môn";
            this.IDMon1.Name = "IDMon1";
            this.IDMon1.ReadOnly = true;
            this.IDMon1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDMon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Diem1
            // 
            this.Diem1.DataPropertyName = "Diem";
            this.Diem1.HeaderText = "Điểm";
            this.Diem1.Name = "Diem1";
            // 
            // Loai1
            // 
            this.Loai1.DataPropertyName = "Loai";
            this.Loai1.HeaderText = "Đạt";
            this.Loai1.Name = "Loai1";
            this.Loai1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Loai1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DiemMieng1
            // 
            this.DiemMieng1.DataPropertyName = "DiemMieng";
            this.DiemMieng1.HeaderText = "Điểm miệng";
            this.DiemMieng1.Name = "DiemMieng1";
            this.DiemMieng1.ReadOnly = true;
            this.DiemMieng1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiemMieng1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HocKy1
            // 
            this.HocKy1.DataPropertyName = "HocKy";
            this.HocKy1.HeaderText = "Học Kỳ I";
            this.HocKy1.Name = "HocKy1";
            this.HocKy1.ReadOnly = true;
            this.HocKy1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HocKy1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsDiemHeSoMot
            // 
            this.bsDiemHeSoMot.DataSource = typeof(DTO.DiemHeSoMot);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDiemHeSoHai);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(603, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 231);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Điểm hệ số 2 - 1 Tiết";
            // 
            // dgvDiemHeSoHai
            // 
            this.dgvDiemHeSoHai.AllowUserToAddRows = false;
            this.dgvDiemHeSoHai.AutoGenerateColumns = false;
            this.dgvDiemHeSoHai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemHeSoHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemHeSoHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.IDMon2,
            this.Diem2,
            this.Loai2,
            this.HocKy2});
            this.dgvDiemHeSoHai.DataSource = this.bsDiemHeSoHai;
            this.dgvDiemHeSoHai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemHeSoHai.Location = new System.Drawing.Point(3, 18);
            this.dgvDiemHeSoHai.Name = "dgvDiemHeSoHai";
            this.dgvDiemHeSoHai.Size = new System.Drawing.Size(643, 210);
            this.dgvDiemHeSoHai.TabIndex = 4;
            this.dgvDiemHeSoHai.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiemHeSoHai_CellBeginEdit);
            this.dgvDiemHeSoHai.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemHeSoHai_CellEndEdit);
            this.dgvDiemHeSoHai.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDiemHeSoHai_UserDeletingRow);
            // 
            // STT2
            // 
            this.STT2.DataPropertyName = "STT";
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.ReadOnly = true;
            // 
            // IDMon2
            // 
            this.IDMon2.DataPropertyName = "IDMon";
            this.IDMon2.HeaderText = "Môn";
            this.IDMon2.Name = "IDMon2";
            this.IDMon2.ReadOnly = true;
            this.IDMon2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDMon2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Diem2
            // 
            this.Diem2.DataPropertyName = "Diem";
            this.Diem2.HeaderText = "Điểm";
            this.Diem2.Name = "Diem2";
            // 
            // Loai2
            // 
            this.Loai2.DataPropertyName = "Loai";
            this.Loai2.HeaderText = "Đạt";
            this.Loai2.Name = "Loai2";
            this.Loai2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Loai2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HocKy2
            // 
            this.HocKy2.DataPropertyName = "HocKy";
            this.HocKy2.HeaderText = "Học Kỳ I";
            this.HocKy2.Name = "HocKy2";
            this.HocKy2.ReadOnly = true;
            this.HocKy2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HocKy2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsDiemHeSoHai
            // 
            this.bsDiemHeSoHai.DataSource = typeof(DTO.DiemHeSoHai);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDiemHocKy);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(603, 477);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(649, 235);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Điểm học kỳ";
            // 
            // dgvDiemHocKy
            // 
            this.dgvDiemHocKy.AllowUserToAddRows = false;
            this.dgvDiemHocKy.AutoGenerateColumns = false;
            this.dgvDiemHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTHK,
            this.IDMonHK,
            this.DiemHK,
            this.LoaiHK,
            this.HocKyHK});
            this.dgvDiemHocKy.DataSource = this.bsDiemHocKy;
            this.dgvDiemHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemHocKy.Location = new System.Drawing.Point(3, 18);
            this.dgvDiemHocKy.Name = "dgvDiemHocKy";
            this.dgvDiemHocKy.Size = new System.Drawing.Size(643, 214);
            this.dgvDiemHocKy.TabIndex = 4;
            this.dgvDiemHocKy.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiemHocKy_CellBeginEdit);
            this.dgvDiemHocKy.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemHocKy_CellEndEdit);
            this.dgvDiemHocKy.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDiemHocKy_UserDeletingRow);
            // 
            // STTHK
            // 
            this.STTHK.DataPropertyName = "STT";
            this.STTHK.HeaderText = "STT";
            this.STTHK.Name = "STTHK";
            this.STTHK.ReadOnly = true;
            this.STTHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IDMonHK
            // 
            this.IDMonHK.DataPropertyName = "IDMon";
            this.IDMonHK.HeaderText = "Môn";
            this.IDMonHK.Name = "IDMonHK";
            this.IDMonHK.ReadOnly = true;
            this.IDMonHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDMonHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DiemHK
            // 
            this.DiemHK.DataPropertyName = "Diem";
            this.DiemHK.HeaderText = "Điểm";
            this.DiemHK.Name = "DiemHK";
            // 
            // LoaiHK
            // 
            this.LoaiHK.DataPropertyName = "Loai";
            this.LoaiHK.HeaderText = "Đạt";
            this.LoaiHK.Name = "LoaiHK";
            this.LoaiHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HocKyHK
            // 
            this.HocKyHK.DataPropertyName = "HocKy";
            this.HocKyHK.HeaderText = "Học Kỳ I";
            this.HocKyHK.Name = "HocKyHK";
            this.HocKyHK.ReadOnly = true;
            this.HocKyHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HocKyHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsDiemHocKy
            // 
            this.bsDiemHocKy.DataSource = typeof(DTO.DiemHocKy);
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1255, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm ";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHeSoMot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHeSoMot)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHeSoHai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHeSoHai)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsHocSinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachHS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDiemHK;
        private System.Windows.Forms.RadioButton radDiemMT;
        private System.Windows.Forms.RadioButton radDiem15;
        private System.Windows.Forms.RadioButton radDiemMieng;
        private System.Windows.Forms.ComboBox cbxMon;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbxDat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource bsDiemHeSoMot;
        private System.Windows.Forms.BindingSource bsDiemHeSoHai;
        private System.Windows.Forms.BindingSource bsDiemHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDiemHeSoMot;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDiemHeSoHai;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvDiemHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDMon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Loai1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DiemMieng1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HocKy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDMon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Loai2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HocKy2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTHK;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDMonHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LoaiHK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HocKyHK;
    }
}

