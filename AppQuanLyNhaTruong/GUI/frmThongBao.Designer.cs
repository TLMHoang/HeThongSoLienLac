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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongBao));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboChonLoaiTB = new System.Windows.Forms.ComboBox();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.dgvDSTB = new System.Windows.Forms.DataGridView();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblThongTinLop = new System.Windows.Forms.Label();
            this.bsThongBaoTruong = new System.Windows.Forms.BindingSource(this.components);
            this.bsThongBaoLop = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsThongBaoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Controls.Add(this.cboChonLoaiTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNhapNoiDung, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbNhapNoiDung, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSTB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboChonLop, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblThongTinLop, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cboChonLoaiTB
            // 
            this.cboChonLoaiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLoaiTB.FormattingEnabled = true;
            this.cboChonLoaiTB.Location = new System.Drawing.Point(3, 2);
            this.cboChonLoaiTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonLoaiTB.Name = "cboChonLoaiTB";
            this.cboChonLoaiTB.Size = new System.Drawing.Size(281, 24);
            this.cboChonLoaiTB.TabIndex = 2;
            this.cboChonLoaiTB.Text = "Thông Báo Trường";
            this.cboChonLoaiTB.SelectedIndexChanged += new System.EventHandler(this.cboChonLoaiTB_SelectedIndexChanged);
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNhapNoiDung, 2);
            this.lblNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(290, 0);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(682, 32);
            this.lblNhapNoiDung.TabIndex = 3;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung";
            this.lblNhapNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbNhapNoiDung
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbNhapNoiDung, 2);
            this.rtbNhapNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(290, 34);
            this.rtbNhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.tableLayoutPanel1.SetRowSpan(this.rtbNhapNoiDung, 3);
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(682, 433);
            this.rtbNhapNoiDung.TabIndex = 4;
            this.rtbNhapNoiDung.Text = "";
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTB.Location = new System.Drawing.Point(3, 34);
            this.dgvDSTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSTB.Name = "dgvDSTB";
            this.dgvDSTB.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDSTB, 5);
            this.dgvDSTB.RowTemplate.Height = 24;
            this.dgvDSTB.Size = new System.Drawing.Size(281, 498);
            this.dgvDSTB.TabIndex = 0;
            this.dgvDSTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTB_CellClick);
            this.dgvDSTB.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDSTB_UserDeletingRow);
            // 
            // cboChonLop
            // 
            this.cboChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(290, 471);
            this.cboChonLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(527, 24);
            this.cboChonLop.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(823, 471);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.tableLayoutPanel1.SetRowSpan(this.btnLuu, 2);
            this.btnLuu.Size = new System.Drawing.Size(149, 61);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongTinLop
            // 
            this.lblThongTinLop.AutoSize = true;
            this.lblThongTinLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinLop.Location = new System.Drawing.Point(290, 500);
            this.lblThongTinLop.Name = "lblThongTinLop";
            this.lblThongTinLop.Size = new System.Drawing.Size(57, 20);
            this.lblThongTinLop.TabIndex = 7;
            this.lblThongTinLop.Text = "label1";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Chung";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
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
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblThongTinLop;
    }
}