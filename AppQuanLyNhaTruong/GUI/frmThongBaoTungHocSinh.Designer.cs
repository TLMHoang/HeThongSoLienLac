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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChonLop = new System.Windows.Forms.DataGridView();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSTB = new System.Windows.Forms.DataGridView();
            this.tlpLBL = new System.Windows.Forms.TableLayoutPanel();
            this.lblDSTB = new System.Windows.Forms.Label();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLop)).BeginInit();
            this.tlp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            this.tlpLBL.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.77378F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.22622F));
            this.tableLayoutPanel1.Controls.Add(this.dgvChonLop, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTimKiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tlp2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tlpLBL, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 595F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvChonLop
            // 
            this.dgvChonLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonLop.Location = new System.Drawing.Point(3, 124);
            this.dgvChonLop.Name = "dgvChonLop";
            this.dgvChonLop.RowTemplate.Height = 24;
            this.dgvChonLop.Size = new System.Drawing.Size(403, 590);
            this.dgvChonLop.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(3, 54);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(278, 20);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Nhập ID Hoặc Tên Để Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 90);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(403, 27);
            this.txtTimKiem.TabIndex = 2;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 4;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.360465F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.63953F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tlp2.Controls.Add(this.dgvDSTB, 1, 0);
            this.tlp2.Controls.Add(this.rtbNhapNoiDung, 3, 0);
            this.tlp2.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(412, 124);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 2;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.20339F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79661F));
            this.tlp2.Size = new System.Drawing.Size(836, 590);
            this.tlp2.TabIndex = 3;
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTB.Location = new System.Drawing.Point(17, 3);
            this.dgvDSTB.Name = "dgvDSTB";
            this.dgvDSTB.RowTemplate.Height = 24;
            this.dgvDSTB.Size = new System.Drawing.Size(311, 420);
            this.dgvDSTB.TabIndex = 0;
            // 
            // tlpLBL
            // 
            this.tlpLBL.ColumnCount = 2;
            this.tlpLBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.00478F));
            this.tlpLBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.99522F));
            this.tlpLBL.Controls.Add(this.lblNhapNoiDung, 0, 1);
            this.tlpLBL.Controls.Add(this.lblDSTB, 0, 1);
            this.tlpLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLBL.Location = new System.Drawing.Point(412, 57);
            this.tlpLBL.Name = "tlpLBL";
            this.tlpLBL.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tlpLBL, 2);
            this.tlpLBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLBL.Size = new System.Drawing.Size(836, 61);
            this.tlpLBL.TabIndex = 4;
            // 
            // lblDSTB
            // 
            this.lblDSTB.AutoSize = true;
            this.lblDSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSTB.Location = new System.Drawing.Point(3, 30);
            this.lblDSTB.Name = "lblDSTB";
            this.lblDSTB.Size = new System.Drawing.Size(279, 25);
            this.lblDSTB.TabIndex = 5;
            this.lblDSTB.Text = "        Danh Sách Thông Báo";
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(512, 30);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(158, 25);
            this.lblNhapNoiDung.TabIndex = 6;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung";
            // 
            // rtbNhapNoiDung
            // 
            this.rtbNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(378, 3);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(455, 420);
            this.rtbNhapNoiDung.TabIndex = 2;
            this.rtbNhapNoiDung.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tlp2.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 429);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 158);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(387, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 73);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(521, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 73);
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
            this.btnXoa.Location = new System.Drawing.Point(653, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 73);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // frmThongBaoTungHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongBaoTungHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Tới Học Sinh";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLop)).EndInit();
            this.tlp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
            this.tlpLBL.ResumeLayout(false);
            this.tlpLBL.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvChonLop;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.DataGridView dgvDSTB;
        private System.Windows.Forms.RichTextBox rtbNhapNoiDung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TableLayoutPanel tlpLBL;
        private System.Windows.Forms.Label lblNhapNoiDung;
        private System.Windows.Forms.Label lblDSTB;
    }
}