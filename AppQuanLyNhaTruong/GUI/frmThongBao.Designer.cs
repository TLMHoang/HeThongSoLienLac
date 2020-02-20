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
            this.cboChonLoaiTB = new System.Windows.Forms.ComboBox();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bsThongBaoTruong = new System.Windows.Forms.BindingSource(this.components);
            this.bsThongBaoLop = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08866F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSTB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboChonLoaiTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNhapNoiDung, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbNhapNoiDung, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.597701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.73787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.24272F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTB.Location = new System.Drawing.Point(2, 25);
            this.dgvDSTB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSTB.Name = "dgvDSTB";
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSTB, 3);
            this.dgvDSTB.RowTemplate.Height = 24;
            this.dgvDSTB.Size = new System.Drawing.Size(443, 475);
            this.dgvDSTB.TabIndex = 0;
            // 
            // cboChonLoaiTB
            // 
            this.cboChonLoaiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLoaiTB.FormattingEnabled = true;
            this.cboChonLoaiTB.Location = new System.Drawing.Point(2, 2);
            this.cboChonLoaiTB.Margin = new System.Windows.Forms.Padding(2);
            this.cboChonLoaiTB.Name = "cboChonLoaiTB";
            this.cboChonLoaiTB.Size = new System.Drawing.Size(443, 21);
            this.cboChonLoaiTB.TabIndex = 2;
            this.cboChonLoaiTB.SelectedIndexChanged += new System.EventHandler(this.cboChonLoaiTB_SelectedIndexChanged);
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(449, 0);
            this.lblNhapNoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(118, 17);
            this.lblNhapNoiDung.TabIndex = 3;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung";
            // 
            // rtbNhapNoiDung
            // 
            this.rtbNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(449, 25);
            this.rtbNhapNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(336, 290);
            this.rtbNhapNoiDung.TabIndex = 4;
            this.rtbNhapNoiDung.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16388F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.cboChonLop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(449, 319);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 181);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cboChonLop
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cboChonLop, 3);
            this.cboChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(2, 2);
            this.cboChonLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(332, 21);
            this.cboChonLop.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(2, 60);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 49);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(116, 60);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 48);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa Thông Báo";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(227, 60);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 48);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa Thông Báo";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // bsThongBaoTruong
            // 
            this.bsThongBaoTruong.DataSource = typeof(DTO.ThongBaoTruong);
            // 
            // bsThongBaoLop
            // 
            this.bsThongBaoLop.DataSource = typeof(DTO.ThongBaoLop);
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Chung";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDSTB;
        private System.Windows.Forms.ComboBox cboChonLoaiTB;
        private System.Windows.Forms.BindingSource bsThongBaoTruong;
        private System.Windows.Forms.BindingSource bsThongBaoLop;
        private System.Windows.Forms.Label lblNhapNoiDung;
        private System.Windows.Forms.RichTextBox rtbNhapNoiDung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}