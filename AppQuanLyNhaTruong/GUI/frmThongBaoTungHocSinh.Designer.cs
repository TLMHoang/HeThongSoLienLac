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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.lblDSHS = new System.Windows.Forms.Label();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.rtbNhapNoiDung = new System.Windows.Forms.RichTextBox();
            this.lblNhapNoiDung = new System.Windows.Forms.Label();
            this.txtIDHocSinh = new System.Windows.Forms.TextBox();
            this.lblIDHS = new System.Windows.Forms.Label();
            this.btnXoaThongBao = new System.Windows.Forms.Button();
            this.btnSuaThongBao = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.picTeam = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboSTT = new System.Windows.Forms.ComboBox();
            this.lblSoThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLop.Location = new System.Drawing.Point(10, 30);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(95, 20);
            this.lblChonLop.TabIndex = 1;
            this.lblChonLop.Text = "Chọn Lớp ";
            // 
            // lblDSHS
            // 
            this.lblDSHS.AutoSize = true;
            this.lblDSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHS.Location = new System.Drawing.Point(111, 67);
            this.lblDSHS.Name = "lblDSHS";
            this.lblDSHS.Size = new System.Drawing.Size(184, 20);
            this.lblDSHS.TabIndex = 2;
            this.lblDSHS.Text = "Danh Sách Học Sinh";
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Location = new System.Drawing.Point(16, 105);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.RowTemplate.Height = 24;
            this.dgvDSHS.Size = new System.Drawing.Size(406, 585);
            this.dgvDSHS.TabIndex = 3;
            // 
            // rtbNhapNoiDung
            // 
            this.rtbNhapNoiDung.Location = new System.Drawing.Point(804, 105);
            this.rtbNhapNoiDung.Name = "rtbNhapNoiDung";
            this.rtbNhapNoiDung.Size = new System.Drawing.Size(392, 440);
            this.rtbNhapNoiDung.TabIndex = 4;
            this.rtbNhapNoiDung.Text = "";
            // 
            // lblNhapNoiDung
            // 
            this.lblNhapNoiDung.AutoSize = true;
            this.lblNhapNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapNoiDung.Location = new System.Drawing.Point(930, 70);
            this.lblNhapNoiDung.Name = "lblNhapNoiDung";
            this.lblNhapNoiDung.Size = new System.Drawing.Size(136, 20);
            this.lblNhapNoiDung.TabIndex = 5;
            this.lblNhapNoiDung.Text = "Nhập Nội Dung";
            // 
            // txtIDHocSinh
            // 
            this.txtIDHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHocSinh.Location = new System.Drawing.Point(517, 67);
            this.txtIDHocSinh.Name = "txtIDHocSinh";
            this.txtIDHocSinh.Size = new System.Drawing.Size(199, 27);
            this.txtIDHocSinh.TabIndex = 6;
            // 
            // lblIDHS
            // 
            this.lblIDHS.AutoSize = true;
            this.lblIDHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDHS.Location = new System.Drawing.Point(534, 34);
            this.lblIDHS.Name = "lblIDHS";
            this.lblIDHS.Size = new System.Drawing.Size(160, 20);
            this.lblIDHS.TabIndex = 7;
            this.lblIDHS.Text = "Nhập ID Học Sinh";
            // 
            // btnXoaThongBao
            // 
            this.btnXoaThongBao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaThongBao.FlatAppearance.BorderSize = 0;
            this.btnXoaThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongBao.ForeColor = System.Drawing.Color.White;
            this.btnXoaThongBao.Location = new System.Drawing.Point(873, 644);
            this.btnXoaThongBao.Name = "btnXoaThongBao";
            this.btnXoaThongBao.Size = new System.Drawing.Size(253, 46);
            this.btnXoaThongBao.TabIndex = 20;
            this.btnXoaThongBao.Text = "Xóa Thông Báo";
            this.btnXoaThongBao.UseVisualStyleBackColor = false;
            // 
            // btnSuaThongBao
            // 
            this.btnSuaThongBao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuaThongBao.FlatAppearance.BorderSize = 0;
            this.btnSuaThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongBao.ForeColor = System.Drawing.Color.White;
            this.btnSuaThongBao.Location = new System.Drawing.Point(873, 599);
            this.btnSuaThongBao.Name = "btnSuaThongBao";
            this.btnSuaThongBao.Size = new System.Drawing.Size(253, 39);
            this.btnSuaThongBao.TabIndex = 19;
            this.btnSuaThongBao.Text = "Sửa Thông Báo";
            this.btnSuaThongBao.UseVisualStyleBackColor = false;
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(873, 551);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(253, 42);
            this.btnThongBao.TabIndex = 18;
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.UseVisualStyleBackColor = false;
            // 
            // picTeam
            // 
            this.picTeam.Image = global::GUI.Properties.Resources.Ust;
            this.picTeam.Location = new System.Drawing.Point(428, 551);
            this.picTeam.Name = "picTeam";
            this.picTeam.Size = new System.Drawing.Size(139, 139);
            this.picTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeam.TabIndex = 21;
            this.picTeam.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(349, 440);
            this.dataGridView1.TabIndex = 22;
            // 
            // cboSTT
            // 
            this.cboSTT.FormattingEnabled = true;
            this.cboSTT.Location = new System.Drawing.Point(662, 657);
            this.cboSTT.Name = "cboSTT";
            this.cboSTT.Size = new System.Drawing.Size(172, 24);
            this.cboSTT.TabIndex = 24;
            // 
            // lblSoThongBao
            // 
            this.lblSoThongBao.AutoSize = true;
            this.lblSoThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThongBao.Location = new System.Drawing.Point(658, 608);
            this.lblSoThongBao.Name = "lblSoThongBao";
            this.lblSoThongBao.Size = new System.Drawing.Size(176, 20);
            this.lblSoThongBao.TabIndex = 23;
            this.lblSoThongBao.Text = "Chọn Số Thông Báo";
            // 
            // frmThongBaoTungHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 702);
            this.Controls.Add(this.cboSTT);
            this.Controls.Add(this.lblSoThongBao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picTeam);
            this.Controls.Add(this.btnXoaThongBao);
            this.Controls.Add(this.btnSuaThongBao);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.lblIDHS);
            this.Controls.Add(this.txtIDHocSinh);
            this.Controls.Add(this.lblNhapNoiDung);
            this.Controls.Add(this.rtbNhapNoiDung);
            this.Controls.Add(this.dgvDSHS);
            this.Controls.Add(this.lblDSHS);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmThongBaoTungHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Tới Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Label lblDSHS;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.RichTextBox rtbNhapNoiDung;
        private System.Windows.Forms.Label lblNhapNoiDung;
        private System.Windows.Forms.TextBox txtIDHocSinh;
        private System.Windows.Forms.Label lblIDHS;
        private System.Windows.Forms.Button btnXoaThongBao;
        private System.Windows.Forms.Button btnSuaThongBao;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.PictureBox picTeam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboSTT;
        private System.Windows.Forms.Label lblSoThongBao;
    }
}