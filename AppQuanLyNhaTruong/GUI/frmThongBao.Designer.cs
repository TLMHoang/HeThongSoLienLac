namespace GUI
{
    partial class frmThongBao
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
            this.dgvDSTB = new System.Windows.Forms.DataGridView();
            this.lblChonTB = new System.Windows.Forms.Label();
            this.cboChonLoaiTB = new System.Windows.Forms.ComboBox();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsThongBaoTruong = new System.Windows.Forms.BindingSource(this.components);
            this.bsThongBaoLop = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoLop)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.84652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.15348F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSTB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblChonTB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboChonLoaiTB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNhapNoiDung, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbNhapNoiDung, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.090312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.597701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.11166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.374384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 670);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTB.Location = new System.Drawing.Point(3, 121);
            this.dgvDSTB.Name = "dgvDSTB";
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSTB, 3);
            this.dgvDSTB.RowTemplate.Height = 24;
            this.dgvDSTB.Size = new System.Drawing.Size(605, 546);
            this.dgvDSTB.TabIndex = 0;
            // 
            // lblChonTB
            // 
            this.lblChonTB.AutoSize = true;
            this.lblChonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTB.Location = new System.Drawing.Point(3, 61);
            this.lblChonTB.Name = "lblChonTB";
            this.lblChonTB.Size = new System.Drawing.Size(190, 20);
            this.lblChonTB.TabIndex = 1;
            this.lblChonTB.Text = "Chọn Loại Thông Báo";
            // 
            // cboChonLoaiTB
            // 
            this.cboChonLoaiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLoaiTB.FormattingEnabled = true;
            this.cboChonLoaiTB.Location = new System.Drawing.Point(3, 94);
            this.cboChonLoaiTB.Name = "cboChonLoaiTB";
            this.cboChonLoaiTB.Size = new System.Drawing.Size(605, 24);
            this.cboChonLoaiTB.TabIndex = 2;
            this.cboChonLoaiTB.SelectedIndexChanged += new System.EventHandler(this.cboChonLoaiTB_SelectedIndexChanged);
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(614, 61);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(232, 20);
            this.lblNhapNoiDung.TabIndex = 3;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung Thông Báo";
            // 
            // rtbNhapNoiDung
            // 
            this.rtbNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(614, 94);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.tableLayoutPanel1.SetRowSpan(this.rtbNhapNoiDung, 2);
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(660, 312);
            this.rtbNhapNoiDung.TabIndex = 4;
            this.rtbNhapNoiDung.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80864F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19136F));
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(614, 412);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 255);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(417, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(240, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Thông Báo";
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
            this.btnSua.Location = new System.Drawing.Point(417, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(240, 51);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa Thông Báo";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(417, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(240, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Thông Báo";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.63725F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.36275F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(408, 135);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Ust;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel3.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(118, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bsThongBaoTruong
            // 
            this.bsThongBaoTruong.DataSource = typeof(DTO.ThongBaoTruong);
            // 
            // bsThongBaoLop
            // 
            this.bsThongBaoLop.DataSource = typeof(DTO.ThongBaoLop);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblChonLop, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboChonLop, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(401, 51);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(3, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(69, 17);
            this.lblChonLop.TabIndex = 0;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // cboChonLop
            // 
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(3, 28);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(194, 24);
            this.cboChonLop.TabIndex = 1;
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Chung";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoLop)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDSTB;
        private System.Windows.Forms.Label lblChonTB;
        private System.Windows.Forms.ComboBox cboChonLoaiTB;
        private System.Windows.Forms.Label lblNhapNoiDung;
        private System.Windows.Forms.RichTextBox rtbNhapNoiDung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bsThongBaoTruong;
        private System.Windows.Forms.BindingSource bsThongBaoLop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboChonLop;
    }
}