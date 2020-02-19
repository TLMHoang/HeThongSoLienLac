namespace GUI
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
            this.txtSeachInfor = new System.Windows.Forms.TextBox();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTaoTaiKhoanGV = new System.Windows.Forms.Panel();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblSDTGV = new System.Windows.Forms.Label();
            this.lblMonDay = new System.Windows.Forms.Label();
            this.cboMonDay = new System.Windows.Forms.ComboBox();
            this.cboChonLopDay = new System.Windows.Forms.ComboBox();
            this.lblChonLopDay = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkGVCN = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIDTKT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTaoTaiKhoanGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeachInfor
            // 
            this.txtSeachInfor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachInfor.Location = new System.Drawing.Point(170, 42);
            this.txtSeachInfor.Name = "txtSeachInfor";
            this.txtSeachInfor.Size = new System.Drawing.Size(455, 27);
            this.txtSeachInfor.TabIndex = 0;
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInfo.Location = new System.Drawing.Point(8, 45);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(156, 19);
            this.lblSearchInfo.TabIndex = 2;
            this.lblSearchInfo.Text = "Nhập Tên Giáo Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 546);
            this.dataGridView1.TabIndex = 3;
            // 
            // pnlTaoTaiKhoanGV
            // 
            this.pnlTaoTaiKhoanGV.Controls.Add(this.textBox1);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblIDTKT);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.btnXoa);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.btnSua);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.btnThem);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.chkGVCN);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblGVCN);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.cboChonLopDay);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblChonLopDay);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.cboMonDay);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblMonDay);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.txtDT);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblSDTGV);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.txtTenGV);
            this.pnlTaoTaiKhoanGV.Controls.Add(this.lblTenGV);
            this.pnlTaoTaiKhoanGV.Location = new System.Drawing.Point(633, 10);
            this.pnlTaoTaiKhoanGV.Name = "pnlTaoTaiKhoanGV";
            this.pnlTaoTaiKhoanGV.Size = new System.Drawing.Size(668, 661);
            this.pnlTaoTaiKhoanGV.TabIndex = 4;
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(54, 181);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(177, 20);
            this.lblTenGV.TabIndex = 0;
            this.lblTenGV.Text = "Nhập Tên Giáo Viên";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(326, 178);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(299, 27);
            this.txtTenGV.TabIndex = 1;
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(326, 224);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(299, 27);
            this.txtDT.TabIndex = 3;
            // 
            // lblSDTGV
            // 
            this.lblSDTGV.AutoSize = true;
            this.lblSDTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDTGV.Location = new System.Drawing.Point(54, 227);
            this.lblSDTGV.Name = "lblSDTGV";
            this.lblSDTGV.Size = new System.Drawing.Size(46, 20);
            this.lblSDTGV.TabIndex = 2;
            this.lblSDTGV.Text = "SDT";
            // 
            // lblMonDay
            // 
            this.lblMonDay.AutoSize = true;
            this.lblMonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonDay.Location = new System.Drawing.Point(54, 272);
            this.lblMonDay.Name = "lblMonDay";
            this.lblMonDay.Size = new System.Drawing.Size(225, 20);
            this.lblMonDay.TabIndex = 4;
            this.lblMonDay.Text = "Chọn Môn Học Phụ Trách";
            // 
            // cboMonDay
            // 
            this.cboMonDay.FormattingEnabled = true;
            this.cboMonDay.Location = new System.Drawing.Point(326, 272);
            this.cboMonDay.Name = "cboMonDay";
            this.cboMonDay.Size = new System.Drawing.Size(299, 24);
            this.cboMonDay.TabIndex = 5;
            // 
            // cboChonLopDay
            // 
            this.cboChonLopDay.FormattingEnabled = true;
            this.cboChonLopDay.Location = new System.Drawing.Point(326, 321);
            this.cboChonLopDay.Name = "cboChonLopDay";
            this.cboChonLopDay.Size = new System.Drawing.Size(299, 24);
            this.cboChonLopDay.TabIndex = 7;
            // 
            // lblChonLopDay
            // 
            this.lblChonLopDay.AutoSize = true;
            this.lblChonLopDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLopDay.Location = new System.Drawing.Point(54, 321);
            this.lblChonLopDay.Name = "lblChonLopDay";
            this.lblChonLopDay.Size = new System.Drawing.Size(128, 20);
            this.lblChonLopDay.TabIndex = 6;
            this.lblChonLopDay.Text = "Chọn Lớp Dạy";
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGVCN.Location = new System.Drawing.Point(54, 373);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(189, 20);
            this.lblGVCN.TabIndex = 8;
            this.lblGVCN.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // chkGVCN
            // 
            this.chkGVCN.AutoSize = true;
            this.chkGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGVCN.Location = new System.Drawing.Point(326, 369);
            this.chkGVCN.Name = "chkGVCN";
            this.chkGVCN.Size = new System.Drawing.Size(54, 24);
            this.chkGVCN.TabIndex = 9;
            this.chkGVCN.Text = "Có";
            this.chkGVCN.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(40, 487);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 47);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(237, 487);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(191, 47);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa Thông Tin";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(434, 487);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 47);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa Tài Khoản";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 27);
            this.textBox1.TabIndex = 14;
            // 
            // lblIDTKT
            // 
            this.lblIDTKT.AutoSize = true;
            this.lblIDTKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTKT.Location = new System.Drawing.Point(54, 131);
            this.lblIDTKT.Name = "lblIDTKT";
            this.lblIDTKT.Size = new System.Drawing.Size(165, 20);
            this.lblIDTKT.TabIndex = 13;
            this.lblIDTKT.Text = "Nhập ID Giáo Viên";
            // 
            // frmTaiKhoanGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 676);
            this.Controls.Add(this.pnlTaoTaiKhoanGV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.txtSeachInfor);
            this.Name = "frmTaiKhoanGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giáo Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTaoTaiKhoanGV.ResumeLayout(false);
            this.pnlTaoTaiKhoanGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeachInfor;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlTaoTaiKhoanGV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox chkGVCN;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.ComboBox cboChonLopDay;
        private System.Windows.Forms.Label lblChonLopDay;
        private System.Windows.Forms.ComboBox cboMonDay;
        private System.Windows.Forms.Label lblMonDay;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblSDTGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIDTKT;
    }
}