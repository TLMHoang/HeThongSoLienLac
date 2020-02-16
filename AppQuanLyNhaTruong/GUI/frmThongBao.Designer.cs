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
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.lblChonLoai = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboSTT = new System.Windows.Forms.ComboBox();
            this.picTeam = new System.Windows.Forms.PictureBox();
            this.lblSoThongBao = new System.Windows.Forms.Label();
            this.btnXoaThongBao = new System.Windows.Forms.Button();
            this.btnSuaThongBao = new System.Windows.Forms.Button();
            this.btnThongBaoToanTruong = new System.Windows.Forms.Button();
            this.lblNhapTB = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDSThongBao = new System.Windows.Forms.Label();
            this.dgvDSThongBao = new System.Windows.Forms.DataGridView();
            this.pnlThongBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Controls.Add(this.lblChonLoai);
            this.pnlThongBao.Controls.Add(this.comboBox1);
            this.pnlThongBao.Controls.Add(this.cboSTT);
            this.pnlThongBao.Controls.Add(this.picTeam);
            this.pnlThongBao.Controls.Add(this.lblSoThongBao);
            this.pnlThongBao.Controls.Add(this.btnXoaThongBao);
            this.pnlThongBao.Controls.Add(this.btnSuaThongBao);
            this.pnlThongBao.Controls.Add(this.btnThongBaoToanTruong);
            this.pnlThongBao.Controls.Add(this.lblNhapTB);
            this.pnlThongBao.Controls.Add(this.richTextBox1);
            this.pnlThongBao.Controls.Add(this.lblDSThongBao);
            this.pnlThongBao.Controls.Add(this.dgvDSThongBao);
            this.pnlThongBao.Location = new System.Drawing.Point(9, 12);
            this.pnlThongBao.Name = "pnlThongBao";
            this.pnlThongBao.Size = new System.Drawing.Size(1261, 654);
            this.pnlThongBao.TabIndex = 0;
            // 
            // lblChonLoai
            // 
            this.lblChonLoai.AutoSize = true;
            this.lblChonLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoai.Location = new System.Drawing.Point(78, 52);
            this.lblChonLoai.Name = "lblChonLoai";
            this.lblChonLoai.Size = new System.Drawing.Size(190, 20);
            this.lblChonLoai.TabIndex = 22;
            this.lblChonLoai.Text = "Chọn Loại Thông Báo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // cboSTT
            // 
            this.cboSTT.FormattingEnabled = true;
            this.cboSTT.Location = new System.Drawing.Point(861, 561);
            this.cboSTT.Name = "cboSTT";
            this.cboSTT.Size = new System.Drawing.Size(120, 24);
            this.cboSTT.TabIndex = 20;
            // 
            // picTeam
            // 
            this.picTeam.Image = global::GUI.Properties.Resources.Ust;
            this.picTeam.Location = new System.Drawing.Point(384, 467);
            this.picTeam.Name = "picTeam";
            this.picTeam.Size = new System.Drawing.Size(192, 179);
            this.picTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeam.TabIndex = 19;
            this.picTeam.TabStop = false;
            // 
            // lblSoThongBao
            // 
            this.lblSoThongBao.AutoSize = true;
            this.lblSoThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThongBao.Location = new System.Drawing.Point(650, 561);
            this.lblSoThongBao.Name = "lblSoThongBao";
            this.lblSoThongBao.Size = new System.Drawing.Size(176, 20);
            this.lblSoThongBao.TabIndex = 18;
            this.lblSoThongBao.Text = "Chọn Số Thông Báo";
            // 
            // btnXoaThongBao
            // 
            this.btnXoaThongBao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaThongBao.FlatAppearance.BorderSize = 0;
            this.btnXoaThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongBao.ForeColor = System.Drawing.Color.White;
            this.btnXoaThongBao.Location = new System.Drawing.Point(997, 578);
            this.btnXoaThongBao.Name = "btnXoaThongBao";
            this.btnXoaThongBao.Size = new System.Drawing.Size(253, 48);
            this.btnXoaThongBao.TabIndex = 17;
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
            this.btnSuaThongBao.Location = new System.Drawing.Point(997, 526);
            this.btnSuaThongBao.Name = "btnSuaThongBao";
            this.btnSuaThongBao.Size = new System.Drawing.Size(253, 46);
            this.btnSuaThongBao.TabIndex = 16;
            this.btnSuaThongBao.Text = "Sửa Thông Báo";
            this.btnSuaThongBao.UseVisualStyleBackColor = false;
            // 
            // btnThongBaoToanTruong
            // 
            this.btnThongBaoToanTruong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongBaoToanTruong.FlatAppearance.BorderSize = 0;
            this.btnThongBaoToanTruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBaoToanTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBaoToanTruong.ForeColor = System.Drawing.Color.White;
            this.btnThongBaoToanTruong.Location = new System.Drawing.Point(997, 467);
            this.btnThongBaoToanTruong.Name = "btnThongBaoToanTruong";
            this.btnThongBaoToanTruong.Size = new System.Drawing.Size(253, 53);
            this.btnThongBaoToanTruong.TabIndex = 15;
            this.btnThongBaoToanTruong.Text = "Thông Báo";
            this.btnThongBaoToanTruong.UseVisualStyleBackColor = false;
            // 
            // lblNhapTB
            // 
            this.lblNhapTB.AutoSize = true;
            this.lblNhapTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTB.Location = new System.Drawing.Point(738, 52);
            this.lblNhapTB.Name = "lblNhapTB";
            this.lblNhapTB.Size = new System.Drawing.Size(148, 20);
            this.lblNhapTB.TabIndex = 14;
            this.lblNhapTB.Text = "Nhập Thông Báo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(375, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 386);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // lblDSThongBao
            // 
            this.lblDSThongBao.AutoSize = true;
            this.lblDSThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSThongBao.Location = new System.Drawing.Point(78, 111);
            this.lblDSThongBao.Name = "lblDSThongBao";
            this.lblDSThongBao.Size = new System.Drawing.Size(197, 20);
            this.lblDSThongBao.TabIndex = 12;
            this.lblDSThongBao.Text = "Danh Sách Thông Báo";
            // 
            // dgvDSThongBao
            // 
            this.dgvDSThongBao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThongBao.Location = new System.Drawing.Point(11, 149);
            this.dgvDSThongBao.Name = "dgvDSThongBao";
            this.dgvDSThongBao.RowTemplate.Height = 24;
            this.dgvDSThongBao.Size = new System.Drawing.Size(358, 472);
            this.dgvDSThongBao.TabIndex = 11;
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 670);
            this.Controls.Add(this.pnlThongBao);
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Chung";
            this.pnlThongBao.ResumeLayout(false);
            this.pnlThongBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongBao;
        private System.Windows.Forms.Label lblChonLoai;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboSTT;
        private System.Windows.Forms.PictureBox picTeam;
        private System.Windows.Forms.Label lblSoThongBao;
        private System.Windows.Forms.Button btnXoaThongBao;
        private System.Windows.Forms.Button btnSuaThongBao;
        private System.Windows.Forms.Button btnThongBaoToanTruong;
        private System.Windows.Forms.Label lblNhapTB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDSThongBao;
        private System.Windows.Forms.DataGridView dgvDSThongBao;
    }
}