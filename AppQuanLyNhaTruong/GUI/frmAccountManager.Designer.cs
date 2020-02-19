namespace GUI
{
    partial class frmAccountManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTraCuuTK = new System.Windows.Forms.TextBox();
            this.pnlAddAccount = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.lblAccountStudentClass = new System.Windows.Forms.Label();
            this.txtAccountStudentName = new System.Windows.Forms.TextBox();
            this.lblIDHocSinh = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblListAccount = new System.Windows.Forms.Label();
            this.dgvDanhSachTK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlAddAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTraCuuTK);
            this.panel1.Controls.Add(this.pnlAddAccount);
            this.panel1.Controls.Add(this.lblListAccount);
            this.panel1.Controls.Add(this.dgvDanhSachTK);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 546);
            this.panel1.TabIndex = 0;
            // 
            // txtTraCuuTK
            // 
            this.txtTraCuuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuTK.Location = new System.Drawing.Point(168, 22);
            this.txtTraCuuTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTraCuuTK.Name = "txtTraCuuTK";
            this.txtTraCuuTK.Size = new System.Drawing.Size(280, 23);
            this.txtTraCuuTK.TabIndex = 7;
            // 
            // pnlAddAccount
            // 
            this.pnlAddAccount.Controls.Add(this.dataGridView1);
            this.pnlAddAccount.Controls.Add(this.comboBox1);
            this.pnlAddAccount.Controls.Add(this.btnDeleteAccount);
            this.pnlAddAccount.Controls.Add(this.btnEditAccount);
            this.pnlAddAccount.Controls.Add(this.lblAccountStudentClass);
            this.pnlAddAccount.Controls.Add(this.txtAccountStudentName);
            this.pnlAddAccount.Controls.Add(this.lblIDHocSinh);
            this.pnlAddAccount.Controls.Add(this.txtPassWord);
            this.pnlAddAccount.Controls.Add(this.lblPassWord);
            this.pnlAddAccount.Controls.Add(this.txtAccountName);
            this.pnlAddAccount.Controls.Add(this.lblAccountName);
            this.pnlAddAccount.Controls.Add(this.btnAddAccount);
            this.pnlAddAccount.Location = new System.Drawing.Point(454, 2);
            this.pnlAddAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddAccount.Name = "pnlAddAccount";
            this.pnlAddAccount.Size = new System.Drawing.Size(452, 543);
            this.pnlAddAccount.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(2, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 222);
            this.dataGridView1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(301, 444);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(119, 45);
            this.btnDeleteAccount.TabIndex = 10;
            this.btnDeleteAccount.Text = "Xóa Tài Khoản";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditAccount.FlatAppearance.BorderSize = 0;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.Location = new System.Drawing.Point(178, 444);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(119, 45);
            this.btnEditAccount.TabIndex = 9;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            // 
            // lblAccountStudentClass
            // 
            this.lblAccountStudentClass.AutoSize = true;
            this.lblAccountStudentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountStudentClass.Location = new System.Drawing.Point(34, 25);
            this.lblAccountStudentClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountStudentClass.Name = "lblAccountStudentClass";
            this.lblAccountStudentClass.Size = new System.Drawing.Size(28, 13);
            this.lblAccountStudentClass.TabIndex = 7;
            this.lblAccountStudentClass.Text = "Lớp";
            // 
            // txtAccountStudentName
            // 
            this.txtAccountStudentName.Location = new System.Drawing.Point(127, 315);
            this.txtAccountStudentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountStudentName.Name = "txtAccountStudentName";
            this.txtAccountStudentName.Size = new System.Drawing.Size(273, 20);
            this.txtAccountStudentName.TabIndex = 6;
            // 
            // lblIDHocSinh
            // 
            this.lblIDHocSinh.AutoSize = true;
            this.lblIDHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDHocSinh.Location = new System.Drawing.Point(34, 318);
            this.lblIDHocSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDHocSinh.Name = "lblIDHocSinh";
            this.lblIDHocSinh.Size = new System.Drawing.Size(76, 13);
            this.lblIDHocSinh.TabIndex = 5;
            this.lblIDHocSinh.Text = "ID Học Sinh";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(127, 381);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(273, 20);
            this.txtPassWord.TabIndex = 4;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(34, 385);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(61, 13);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "Mật Khẩu";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(127, 349);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(273, 20);
            this.txtAccountName.TabIndex = 2;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(34, 352);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(91, 13);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Tên Tài Khoản";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(53, 444);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(119, 45);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm Tài Khoản";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            // 
            // lblListAccount
            // 
            this.lblListAccount.AutoSize = true;
            this.lblListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAccount.Location = new System.Drawing.Point(4, 21);
            this.lblListAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListAccount.Name = "lblListAccount";
            this.lblListAccount.Size = new System.Drawing.Size(157, 20);
            this.lblListAccount.TabIndex = 5;
            this.lblListAccount.Text = "Tra Cứu Tài Khoản";
            // 
            // dgvDanhSachTK
            // 
            this.dgvDanhSachTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTK.Location = new System.Drawing.Point(6, 67);
            this.dgvDanhSachTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSachTK.Name = "dgvDanhSachTK";
            this.dgvDanhSachTK.RowTemplate.Height = 24;
            this.dgvDanhSachTK.Size = new System.Drawing.Size(441, 478);
            this.dgvDanhSachTK.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(922, 563);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddAccount.ResumeLayout(false);
            this.pnlAddAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Label lblAccountStudentClass;
        private System.Windows.Forms.TextBox txtAccountStudentName;
        private System.Windows.Forms.Label lblIDHocSinh;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblListAccount;
        private System.Windows.Forms.DataGridView dgvDanhSachTK;
        private System.Windows.Forms.TextBox txtTraCuuTK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}