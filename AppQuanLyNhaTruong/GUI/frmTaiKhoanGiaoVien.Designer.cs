namespace AppQuanLyNhaTruong
{
    partial class frmTaiKhoanGiaoVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDTKT = new System.Windows.Forms.Label();
            this.txtNhapID = new System.Windows.Forms.TextBox();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.txtNhapTenGV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblIDMon = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblIDLop = new System.Windows.Forms.Label();
            this.cboLopPhuTrach = new System.Windows.Forms.ComboBox();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.chkGVCN = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSGV, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNhapTen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNhapTen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.728539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.27146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 676);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.iDLopDataGridViewTextBoxColumn,
            this.gVCNDataGridViewTextBoxColumn});
            this.dgvDSGV.DataSource = this.bsDSGV;
            this.dgvDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSGV.Location = new System.Drawing.Point(3, 64);
            this.dgvDSGV.Name = "dgvDSGV";
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSGV, 3);
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.Size = new System.Drawing.Size(647, 609);
            this.dgvDSGV.TabIndex = 0;
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.Location = new System.Drawing.Point(3, 0);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(647, 38);
            this.lblNhapTen.TabIndex = 1;
            this.lblNhapTen.Text = "Nhập Tên Cần Tìm";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTen.Location = new System.Drawing.Point(3, 41);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(647, 22);
            this.txtNhapTen.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.37558F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.62442F));
            this.tableLayoutPanel2.Controls.Add(this.lblGVCN, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboLopPhuTrach, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblIDLop, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblIDMon, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSDT, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSDT, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNhapTenGV, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTenGV, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblIDTKT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNhapID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboMonHoc, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chkGVCN, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(656, 64);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(647, 314);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(656, 384);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(647, 86);
            this.tableLayoutPanel3.TabIndex = 4;
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
            this.txtNhapID.Location = new System.Drawing.Point(206, 3);
            this.txtNhapID.Name = "txtNhapID";
            this.txtNhapID.Size = new System.Drawing.Size(438, 27);
            this.txtNhapID.TabIndex = 1;
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(3, 52);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(197, 52);
            this.lblTenGV.TabIndex = 2;
            this.lblTenGV.Text = "Nhập Tên";
            // 
            // txtNhapTenGV
            // 
            this.txtNhapTenGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenGV.Location = new System.Drawing.Point(206, 55);
            this.txtNhapTenGV.Name = "txtNhapTenGV";
            this.txtNhapTenGV.Size = new System.Drawing.Size(438, 27);
            this.txtNhapTenGV.TabIndex = 3;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(3, 104);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(197, 52);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(206, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(438, 27);
            this.txtSDT.TabIndex = 5;
            // 
            // lblIDMon
            // 
            this.lblIDMon.AutoSize = true;
            this.lblIDMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIDMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMon.Location = new System.Drawing.Point(3, 156);
            this.lblIDMon.Name = "lblIDMon";
            this.lblIDMon.Size = new System.Drawing.Size(197, 52);
            this.lblIDMon.TabIndex = 6;
            this.lblIDMon.Text = "Môn Dạy Phụ Trách";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(206, 159);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(438, 28);
            this.cboMonHoc.TabIndex = 7;
            // 
            // lblIDLop
            // 
            this.lblIDLop.AutoSize = true;
            this.lblIDLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIDLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLop.Location = new System.Drawing.Point(3, 208);
            this.lblIDLop.Name = "lblIDLop";
            this.lblIDLop.Size = new System.Drawing.Size(197, 52);
            this.lblIDLop.TabIndex = 8;
            this.lblIDLop.Text = "Lớp Phụ Trách";
            // 
            // cboLopPhuTrach
            // 
            this.cboLopPhuTrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopPhuTrach.FormattingEnabled = true;
            this.cboLopPhuTrach.Location = new System.Drawing.Point(206, 211);
            this.cboLopPhuTrach.Name = "cboLopPhuTrach";
            this.cboLopPhuTrach.Size = new System.Drawing.Size(438, 28);
            this.cboLopPhuTrach.TabIndex = 9;
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGVCN.Location = new System.Drawing.Point(3, 260);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(197, 54);
            this.lblGVCN.TabIndex = 10;
            this.lblGVCN.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // chkGVCN
            // 
            this.chkGVCN.AutoSize = true;
            this.chkGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGVCN.Location = new System.Drawing.Point(206, 263);
            this.chkGVCN.Name = "chkGVCN";
            this.chkGVCN.Size = new System.Drawing.Size(54, 24);
            this.chkGVCN.TabIndex = 11;
            this.chkGVCN.Text = "Có";
            this.chkGVCN.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(209, 80);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(218, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(209, 80);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(433, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(211, 80);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
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
            // gVCNDataGridViewTextBoxColumn
            // 
            this.gVCNDataGridViewTextBoxColumn.DataPropertyName = "GVCN";
            this.gVCNDataGridViewTextBoxColumn.HeaderText = "GVCN";
            this.gVCNDataGridViewTextBoxColumn.Name = "gVCNDataGridViewTextBoxColumn";
            // 
            // frmTaiKhoanGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 676);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTaiKhoanGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giáo Viên";
            this.Load += new System.EventHandler(this.frmTaiKhoanGiaoVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtNhapTenGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblIDTKT;
        private System.Windows.Forms.TextBox txtNhapID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.ComboBox cboLopPhuTrach;
        private System.Windows.Forms.Label lblIDLop;
        private System.Windows.Forms.Label lblIDMon;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.CheckBox chkGVCN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVCNDataGridViewTextBoxColumn;
    }
}