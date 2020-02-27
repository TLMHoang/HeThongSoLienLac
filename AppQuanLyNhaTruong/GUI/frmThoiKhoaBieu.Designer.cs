namespace GUI
{
    partial class frmThoiKhoaBieu
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
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTKB = new System.Windows.Forms.BindingSource(this.components);
            this.cboChonThu = new System.Windows.Forms.ComboBox();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.lblTiet5 = new System.Windows.Forms.Label();
            this.lblTiet4 = new System.Windows.Forms.Label();
            this.lblTiet3 = new System.Windows.Forms.Label();
            this.lblTiet2 = new System.Windows.Forms.Label();
            this.lblTiet1 = new System.Windows.Forms.Label();
            this.lblSoTiet = new System.Windows.Forms.Label();
            this.cboChonBuoi = new System.Windows.Forms.ComboBox();
            this.lblChonBuoi = new System.Windows.Forms.Label();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboMonTiet1 = new System.Windows.Forms.ComboBox();
            this.cboMonTiet2 = new System.Windows.Forms.ComboBox();
            this.cboMonTiet3 = new System.Windows.Forms.ComboBox();
            this.cboMonTiet4 = new System.Windows.Forms.ComboBox();
            this.cboMonTiet5 = new System.Windows.Forms.ComboBox();
            this.bsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bsMonHoc2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMonHoc3 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMonHoc4 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMonHoc5 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc5)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.00831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07069F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTKB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboChonThu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboChonLop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTiet5, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblTiet4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblTiet3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblTiet2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTiet1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSoTiet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboChonBuoi, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblChonBuoi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblChonLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.cboMonTiet1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboMonTiet2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cboMonTiet3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboMonTiet4, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cboMonTiet5, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.137615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.238532F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.86239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.972477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.701467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.759593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.935948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.112302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.465012F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.641365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.650184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22679F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTKB
            // 
            this.dgvTKB.AutoGenerateColumns = false;
            this.dgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLopDataGridViewTextBoxColumn,
            this.thuDataGridViewTextBoxColumn,
            this.tietDataGridViewTextBoxColumn,
            this.iDMonDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTKB, 2);
            this.dgvTKB.DataSource = this.bsTKB;
            this.dgvTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKB.Location = new System.Drawing.Point(312, 3);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvTKB, 12);
            this.dgvTKB.RowTemplate.Height = 24;
            this.dgvTKB.Size = new System.Drawing.Size(649, 539);
            this.dgvTKB.TabIndex = 0;
            this.dgvTKB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKB_CellClick);
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "ID Lớp";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            this.iDLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thuDataGridViewTextBoxColumn
            // 
            this.thuDataGridViewTextBoxColumn.DataPropertyName = "Thu";
            this.thuDataGridViewTextBoxColumn.HeaderText = "Thứ ";
            this.thuDataGridViewTextBoxColumn.Name = "thuDataGridViewTextBoxColumn";
            this.thuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tietDataGridViewTextBoxColumn
            // 
            this.tietDataGridViewTextBoxColumn.DataPropertyName = "Tiet";
            this.tietDataGridViewTextBoxColumn.HeaderText = "Tiết";
            this.tietDataGridViewTextBoxColumn.Name = "tietDataGridViewTextBoxColumn";
            this.tietDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMonDataGridViewTextBoxColumn
            // 
            this.iDMonDataGridViewTextBoxColumn.DataPropertyName = "IDMon";
            this.iDMonDataGridViewTextBoxColumn.HeaderText = "ID Môn";
            this.iDMonDataGridViewTextBoxColumn.Name = "iDMonDataGridViewTextBoxColumn";
            this.iDMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTKB
            // 
            this.bsTKB.DataSource = typeof(DTO.ThoiKhoaBieu);
            // 
            // cboChonThu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboChonThu, 2);
            this.cboChonThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonThu.FormattingEnabled = true;
            this.cboChonThu.Location = new System.Drawing.Point(3, 65);
            this.cboChonThu.Name = "cboChonThu";
            this.cboChonThu.Size = new System.Drawing.Size(303, 28);
            this.cboChonThu.TabIndex = 2;
            // 
            // cboChonLop
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboChonLop, 2);
            this.cboChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(3, 31);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(303, 28);
            this.cboChonLop.TabIndex = 3;
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // lblTiet5
            // 
            this.lblTiet5.AutoSize = true;
            this.lblTiet5.Location = new System.Drawing.Point(3, 439);
            this.lblTiet5.Name = "lblTiet5";
            this.lblTiet5.Size = new System.Drawing.Size(57, 20);
            this.lblTiet5.TabIndex = 10;
            this.lblTiet5.Text = "Tiết 5";
            // 
            // lblTiet4
            // 
            this.lblTiet4.AutoSize = true;
            this.lblTiet4.Location = new System.Drawing.Point(3, 392);
            this.lblTiet4.Name = "lblTiet4";
            this.lblTiet4.Size = new System.Drawing.Size(63, 20);
            this.lblTiet4.TabIndex = 9;
            this.lblTiet4.Text = "Tiết 4 ";
            // 
            // lblTiet3
            // 
            this.lblTiet3.AutoSize = true;
            this.lblTiet3.Location = new System.Drawing.Point(3, 346);
            this.lblTiet3.Name = "lblTiet3";
            this.lblTiet3.Size = new System.Drawing.Size(57, 20);
            this.lblTiet3.TabIndex = 8;
            this.lblTiet3.Text = "Tiết 3";
            // 
            // lblTiet2
            // 
            this.lblTiet2.AutoSize = true;
            this.lblTiet2.Location = new System.Drawing.Point(3, 302);
            this.lblTiet2.Name = "lblTiet2";
            this.lblTiet2.Size = new System.Drawing.Size(57, 20);
            this.lblTiet2.TabIndex = 7;
            this.lblTiet2.Text = "Tiết 2";
            // 
            // lblTiet1
            // 
            this.lblTiet1.AutoSize = true;
            this.lblTiet1.Location = new System.Drawing.Point(3, 259);
            this.lblTiet1.Name = "lblTiet1";
            this.lblTiet1.Size = new System.Drawing.Size(57, 20);
            this.lblTiet1.TabIndex = 6;
            this.lblTiet1.Text = "Tiết 1";
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSoTiet, 2);
            this.lblSoTiet.Location = new System.Drawing.Point(3, 217);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(156, 20);
            this.lblSoTiet.TabIndex = 5;
            this.lblSoTiet.Text = "Nhập Vào Số Tiết";
            // 
            // cboChonBuoi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboChonBuoi, 2);
            this.cboChonBuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonBuoi.FormattingEnabled = true;
            this.cboChonBuoi.Location = new System.Drawing.Point(3, 184);
            this.cboChonBuoi.Name = "cboChonBuoi";
            this.cboChonBuoi.Size = new System.Drawing.Size(303, 28);
            this.cboChonBuoi.TabIndex = 4;
            this.cboChonBuoi.SelectedIndexChanged += new System.EventHandler(this.cboChonBuoi_SelectedIndexChanged);
            // 
            // lblChonBuoi
            // 
            this.lblChonBuoi.AutoSize = true;
            this.lblChonBuoi.Location = new System.Drawing.Point(3, 143);
            this.lblChonBuoi.Name = "lblChonBuoi";
            this.lblChonBuoi.Size = new System.Drawing.Size(96, 20);
            this.lblChonBuoi.TabIndex = 16;
            this.lblChonBuoi.Text = "Chọn Buổi";
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblChonLop, 2);
            this.lblChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonLop.Location = new System.Drawing.Point(3, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(303, 28);
            this.lblChonLop.TabIndex = 17;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(3, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 53);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(157, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 53);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboMonTiet1
            // 
            this.cboMonTiet1.DataSource = this.bsMonHoc;
            this.cboMonTiet1.DisplayMember = "TenMon";
            this.cboMonTiet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonTiet1.FormattingEnabled = true;
            this.cboMonTiet1.Location = new System.Drawing.Point(157, 262);
            this.cboMonTiet1.Name = "cboMonTiet1";
            this.cboMonTiet1.Size = new System.Drawing.Size(149, 28);
            this.cboMonTiet1.TabIndex = 20;
            this.cboMonTiet1.ValueMember = "ID";
            // 
            // cboMonTiet2
            // 
            this.cboMonTiet2.DataSource = this.bsMonHoc2;
            this.cboMonTiet2.DisplayMember = "TenMon";
            this.cboMonTiet2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonTiet2.FormattingEnabled = true;
            this.cboMonTiet2.Location = new System.Drawing.Point(157, 305);
            this.cboMonTiet2.Name = "cboMonTiet2";
            this.cboMonTiet2.Size = new System.Drawing.Size(149, 28);
            this.cboMonTiet2.TabIndex = 21;
            this.cboMonTiet2.ValueMember = "ID";
            // 
            // cboMonTiet3
            // 
            this.cboMonTiet3.DataSource = this.bsMonHoc3;
            this.cboMonTiet3.DisplayMember = "TenMon";
            this.cboMonTiet3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonTiet3.FormattingEnabled = true;
            this.cboMonTiet3.Location = new System.Drawing.Point(157, 349);
            this.cboMonTiet3.Name = "cboMonTiet3";
            this.cboMonTiet3.Size = new System.Drawing.Size(149, 28);
            this.cboMonTiet3.TabIndex = 22;
            this.cboMonTiet3.ValueMember = "ID";
            // 
            // cboMonTiet4
            // 
            this.cboMonTiet4.DataSource = this.bsMonHoc4;
            this.cboMonTiet4.DisplayMember = "TenMon";
            this.cboMonTiet4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonTiet4.FormattingEnabled = true;
            this.cboMonTiet4.Location = new System.Drawing.Point(157, 395);
            this.cboMonTiet4.Name = "cboMonTiet4";
            this.cboMonTiet4.Size = new System.Drawing.Size(149, 28);
            this.cboMonTiet4.TabIndex = 23;
            this.cboMonTiet4.ValueMember = "ID";
            // 
            // cboMonTiet5
            // 
            this.cboMonTiet5.DataSource = this.bsMonHoc5;
            this.cboMonTiet5.DisplayMember = "TenMon";
            this.cboMonTiet5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonTiet5.FormattingEnabled = true;
            this.cboMonTiet5.Location = new System.Drawing.Point(157, 442);
            this.cboMonTiet5.Name = "cboMonTiet5";
            this.cboMonTiet5.Size = new System.Drawing.Size(149, 28);
            this.cboMonTiet5.TabIndex = 24;
            this.cboMonTiet5.ValueMember = "ID";
            // 
            // bsMonHoc
            // 
            this.bsMonHoc.DataSource = typeof(DTO.MonHoc);
            // 
            // bsMonHoc2
            // 
            this.bsMonHoc2.DataSource = typeof(DTO.MonHoc);
            // 
            // bsMonHoc3
            // 
            this.bsMonHoc3.DataSource = typeof(DTO.MonHoc);
            // 
            // bsMonHoc4
            // 
            this.bsMonHoc4.DataSource = typeof(DTO.MonHoc);
            // 
            // bsMonHoc5
            // 
            this.bsMonHoc5.DataSource = typeof(DTO.MonHoc);
            // 
            // frmThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThoiKhoaBieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời Khóa Biểu";
            this.Load += new System.EventHandler(this.frmThoiKhoaBieu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.ComboBox cboChonThu;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Label lblTiet5;
        private System.Windows.Forms.Label lblTiet4;
        private System.Windows.Forms.Label lblTiet3;
        private System.Windows.Forms.Label lblTiet2;
        private System.Windows.Forms.Label lblTiet1;
        private System.Windows.Forms.Label lblSoTiet;
        private System.Windows.Forms.ComboBox cboChonBuoi;
        private System.Windows.Forms.Label lblChonBuoi;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboMonTiet1;
        private System.Windows.Forms.ComboBox cboMonTiet2;
        private System.Windows.Forms.ComboBox cboMonTiet3;
        private System.Windows.Forms.ComboBox cboMonTiet4;
        private System.Windows.Forms.ComboBox cboMonTiet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTKB;
        private System.Windows.Forms.BindingSource bsMonHoc;
        private System.Windows.Forms.BindingSource bsMonHoc2;
        private System.Windows.Forms.BindingSource bsMonHoc3;
        private System.Windows.Forms.BindingSource bsMonHoc4;
        private System.Windows.Forms.BindingSource bsMonHoc5;
    }
}