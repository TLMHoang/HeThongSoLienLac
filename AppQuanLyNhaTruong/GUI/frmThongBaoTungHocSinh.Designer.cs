namespace GUI
{
    partial class frmThongBaoTungHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongBaoTungHocSinh));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiemID = new System.Windows.Forms.TextBox();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHS = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDSTB = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHocSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsThongBao = new System.Windows.Forms.BindingSource(this.components);
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblDSTB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiemID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSTB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rtbNhapNoiDung, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNhapNoiDung, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDSTB, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.445947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.55405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTimKiemID
            // 
            this.txtTimKiemID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemID.Location = new System.Drawing.Point(3, 2);
            this.txtTimKiemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemID.Name = "txtTimKiemID";
            this.txtTimKiemID.Size = new System.Drawing.Size(428, 22);
            this.txtTimKiemID.TabIndex = 0;
            this.txtTimKiemID.Text = "Nhập ID Hoặc Tên Để Tìm";
            this.txtTimKiemID.TextChanged += new System.EventHandler(this.txtTimKiemID_TextChanged);
            this.txtTimKiemID.Enter += new System.EventHandler(this.txtTimKiemID_Enter);
            this.txtTimKiemID.Leave += new System.EventHandler(this.txtTimKiemID_Leave);
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AutoGenerateColumns = false;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn});
            this.dgvDSHS.DataSource = this.bsHS;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(3, 27);
            this.dgvDSHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.ReadOnly = true;
            this.dgvDSHS.RowTemplate.Height = 24;
            this.dgvDSHS.Size = new System.Drawing.Size(428, 268);
            this.dgvDSHS.TabIndex = 2;
            this.dgvDSHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHS_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Học Sinh";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsHS
            // 
            this.bsHS.DataSource = typeof(DTO.ThongTinHS);
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.AutoGenerateColumns = false;
            this.dgvDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.iDHocSinhDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn});
            this.dgvDSTB.DataSource = this.bsThongBao;
            this.dgvDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTB.Location = new System.Drawing.Point(3, 327);
            this.dgvDSTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSTB.Name = "dgvDSTB";
            this.dgvDSTB.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSTB, 2);
            this.dgvDSTB.RowTemplate.Height = 24;
            this.dgvDSTB.Size = new System.Drawing.Size(428, 289);
            this.dgvDSTB.TabIndex = 3;
            this.dgvDSTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTB_CellClick);
            this.dgvDSTB.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDSTB_UserDeletingRow);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDHocSinhDataGridViewTextBoxColumn
            // 
            this.iDHocSinhDataGridViewTextBoxColumn.DataPropertyName = "IDHocSinh";
            this.iDHocSinhDataGridViewTextBoxColumn.HeaderText = "ID Học Sinh";
            this.iDHocSinhDataGridViewTextBoxColumn.Name = "iDHocSinhDataGridViewTextBoxColumn";
            this.iDHocSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsThongBao
            // 
            this.bsThongBao.DataSource = typeof(DTO.ThongBaoHS);
            // 
            // rtbNhapNoiDung
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNhapNoiDung, 2);
            this.rtbNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(437, 27);
            this.rtbNhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.tableLayoutPanel1.SetRowSpan(this.rtbNhapNoiDung, 3);
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(609, 538);
            this.rtbNhapNoiDung.TabIndex = 4;
            this.rtbNhapNoiDung.Text = "";
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNhapNoiDung, 2);
            this.lblNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(437, 0);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(609, 25);
            this.lblNhapNoiDung.TabIndex = 5;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung";
            this.lblNhapNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(871, 569);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 47);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblDSTB
            // 
            this.lblDSTB.AutoSize = true;
            this.lblDSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSTB.Location = new System.Drawing.Point(3, 297);
            this.lblDSTB.Name = "lblDSTB";
            this.lblDSTB.Size = new System.Drawing.Size(171, 17);
            this.lblDSTB.TabIndex = 7;
            this.lblDSTB.Text = "Danh Sách Thông Báo";
            // 
            // frmThongBaoTungHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongBaoTungHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Tới Học Sinh";
            this.Load += new System.EventHandler(this.frmThongBaoTungHocSinh_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiemID;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.DataGridView dgvDSTB;
        private System.Windows.Forms.RichTextBox rtbNhapNoiDung;
        private System.Windows.Forms.Label lblNhapNoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource bsHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDSTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsThongBao;
    }
}