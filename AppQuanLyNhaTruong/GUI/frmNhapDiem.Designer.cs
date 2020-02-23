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
            this.bsHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radDiemMieng = new System.Windows.Forms.RadioButton();
            this.rad15p = new System.Windows.Forms.RadioButton();
            this.rad1tiet = new System.Windows.Forms.RadioButton();
            this.radHocKy = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // bsHocSinh
            // 
            this.bsHocSinh.DataSource = typeof(DTO.ThongTinHS);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.05085F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(814, 413);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel10.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.cboLop, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.cboMonHoc, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.radDiemMieng, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.rad15p, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.rad1tiet, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.radHocKy, 3, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(806, 61);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(202, 4);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(221, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // cboLop
            // 
            this.cboLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLop.ForeColor = System.Drawing.Color.Gray;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(4, 4);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(190, 24);
            this.cboLop.TabIndex = 0;
            this.cboLop.Text = "--Lớp--";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonHoc.ForeColor = System.Drawing.Color.Gray;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(430, 3);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(203, 24);
            this.cboMonHoc.TabIndex = 4;
            this.cboMonHoc.Text = "----MÔN HỌC---";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.dgvNhapDiem, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(4, 73);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.79269F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.20732F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(806, 336);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 4;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel12.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 275);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(798, 57);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "LƯU VÀO DANH SÁCH";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(596, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "THOÁT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.AutoGenerateColumns = false;
            this.dgvNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.tenDataGridViewTextBoxColumn2,
            this.ngaySinhDataGridViewTextBoxColumn2,
            this.Column1});
            this.dgvNhapDiem.DataSource = this.bsHocSinh;
            this.dgvNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapDiem.Location = new System.Drawing.Point(4, 4);
            this.dgvNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.Size = new System.Drawing.Size(798, 263);
            this.dgvNhapDiem.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // tenDataGridViewTextBoxColumn2
            // 
            this.tenDataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn2.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn2.Name = "tenDataGridViewTextBoxColumn2";
            // 
            // ngaySinhDataGridViewTextBoxColumn2
            // 
            this.ngaySinhDataGridViewTextBoxColumn2.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn2.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn2.Name = "ngaySinhDataGridViewTextBoxColumn2";
            // 
            // radDiemMieng
            // 
            this.radDiemMieng.AutoSize = true;
            this.radDiemMieng.Location = new System.Drawing.Point(3, 31);
            this.radDiemMieng.Name = "radDiemMieng";
            this.radDiemMieng.Size = new System.Drawing.Size(97, 20);
            this.radDiemMieng.TabIndex = 6;
            this.radDiemMieng.TabStop = true;
            this.radDiemMieng.Text = "Điểm Miệng";
            this.radDiemMieng.UseVisualStyleBackColor = true;
            this.radDiemMieng.CheckedChanged += new System.EventHandler(this.radDiemMieng_CheckedChanged);
            // 
            // rad15p
            // 
            this.rad15p.AutoSize = true;
            this.rad15p.Location = new System.Drawing.Point(201, 31);
            this.rad15p.Name = "rad15p";
            this.rad15p.Size = new System.Drawing.Size(82, 20);
            this.rad15p.TabIndex = 7;
            this.rad15p.TabStop = true;
            this.rad15p.Text = "Điểm 15p";
            this.rad15p.UseVisualStyleBackColor = true;
            // 
            // rad1tiet
            // 
            this.rad1tiet.AutoSize = true;
            this.rad1tiet.Location = new System.Drawing.Point(430, 31);
            this.rad1tiet.Name = "rad1tiet";
            this.rad1tiet.Size = new System.Drawing.Size(93, 20);
            this.rad1tiet.TabIndex = 8;
            this.rad1tiet.TabStop = true;
            this.rad1tiet.Text = "Điểm 1 Tiết";
            this.rad1tiet.UseVisualStyleBackColor = true;
            // 
            // radHocKy
            // 
            this.radHocKy.AutoSize = true;
            this.radHocKy.Location = new System.Drawing.Point(639, 31);
            this.radHocKy.Name = "radHocKy";
            this.radHocKy.Size = new System.Drawing.Size(99, 20);
            this.radHocKy.TabIndex = 9;
            this.radHocKy.TabStop = true;
            this.radHocKy.Text = "Điểm học kỳ";
            this.radHocKy.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Điểm";
            this.Column1.Name = "Column1";
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 413);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapDiem_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHocSinh)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsHocSinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.RadioButton radDiemMieng;
        private System.Windows.Forms.RadioButton rad15p;
        private System.Windows.Forms.RadioButton rad1tiet;
        private System.Windows.Forms.RadioButton radHocKy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvNhapDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

