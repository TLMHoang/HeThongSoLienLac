namespace AppQuanLyNhaTruong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.dgvSearchAccount = new System.Windows.Forms.DataGridView();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchAccount = new System.Windows.Forms.Label();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblListAccount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAddAccount = new System.Windows.Forms.Panel();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.txtAccountStudentClass = new System.Windows.Forms.TextBox();
            this.lblAccountStudentClass = new System.Windows.Forms.Label();
            this.txtAccountStudentName = new System.Windows.Forms.TextBox();
            this.lblAccountStudentName = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchAccount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.dgvSearchAccount);
            this.tabPage.Controls.Add(this.lblSearchAccount);
            this.tabPage.Controls.Add(this.txtSearchAccount);
            this.tabPage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(4, 28);
            this.tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage.Size = new System.Drawing.Size(1209, 628);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Tra Cứu";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // dgvSearchAccount
            // 
            this.dgvSearchAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountName,
            this.PassWord,
            this.StudentName,
            this.Class});
            this.dgvSearchAccount.Location = new System.Drawing.Point(5, 78);
            this.dgvSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearchAccount.Name = "dgvSearchAccount";
            this.dgvSearchAccount.RowTemplate.Height = 24;
            this.dgvSearchAccount.Size = new System.Drawing.Size(1197, 544);
            this.dgvSearchAccount.TabIndex = 3;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Tên Tài Khoản";
            this.AccountName.Name = "AccountName";
            // 
            // PassWord
            // 
            this.PassWord.HeaderText = "Mật Khẩu";
            this.PassWord.Name = "PassWord";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Tên Học Sinh Quản Lý";
            this.StudentName.Name = "StudentName";
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.Name = "Class";
            // 
            // lblSearchAccount
            // 
            this.lblSearchAccount.AutoSize = true;
            this.lblSearchAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAccount.Location = new System.Drawing.Point(227, 34);
            this.lblSearchAccount.Name = "lblSearchAccount";
            this.lblSearchAccount.Size = new System.Drawing.Size(228, 19);
            this.lblSearchAccount.TabIndex = 2;
            this.lblSearchAccount.Text = "Nhập Tên Tài Khoản Cần Tìm ";
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(501, 31);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(409, 27);
            this.txtSearchAccount.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlAddAccount);
            this.tabPage2.Controls.Add(this.lblListAccount);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1209, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Tài Khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblListAccount
            // 
            this.lblListAccount.AutoSize = true;
            this.lblListAccount.Location = new System.Drawing.Point(204, 28);
            this.lblListAccount.Name = "lblListAccount";
            this.lblListAccount.Size = new System.Drawing.Size(153, 19);
            this.lblListAccount.TabIndex = 1;
            this.lblListAccount.Text = "Danh Sách Tài Khoản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlAddAccount
            // 
            this.pnlAddAccount.Controls.Add(this.btnDeleteAccount);
            this.pnlAddAccount.Controls.Add(this.btnEditAccount);
            this.pnlAddAccount.Controls.Add(this.txtAccountStudentClass);
            this.pnlAddAccount.Controls.Add(this.lblAccountStudentClass);
            this.pnlAddAccount.Controls.Add(this.txtAccountStudentName);
            this.pnlAddAccount.Controls.Add(this.lblAccountStudentName);
            this.pnlAddAccount.Controls.Add(this.txtPassWord);
            this.pnlAddAccount.Controls.Add(this.lblPassWord);
            this.pnlAddAccount.Controls.Add(this.txtAccountName);
            this.pnlAddAccount.Controls.Add(this.lblAccountName);
            this.pnlAddAccount.Controls.Add(this.btnAddAccount);
            this.pnlAddAccount.Location = new System.Drawing.Point(603, 4);
            this.pnlAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddAccount.Name = "pnlAddAccount";
            this.pnlAddAccount.Size = new System.Drawing.Size(603, 620);
            this.pnlAddAccount.TabIndex = 3;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(407, 343);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(159, 55);
            this.btnDeleteAccount.TabIndex = 10;
            this.btnDeleteAccount.Text = "Xóa Tài Khoản";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(243, 343);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(159, 55);
            this.btnEditAccount.TabIndex = 9;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountStudentClass
            // 
            this.txtAccountStudentClass.Location = new System.Drawing.Point(164, 295);
            this.txtAccountStudentClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountStudentClass.Name = "txtAccountStudentClass";
            this.txtAccountStudentClass.Size = new System.Drawing.Size(363, 27);
            this.txtAccountStudentClass.TabIndex = 8;
            // 
            // lblAccountStudentClass
            // 
            this.lblAccountStudentClass.AutoSize = true;
            this.lblAccountStudentClass.Location = new System.Drawing.Point(40, 299);
            this.lblAccountStudentClass.Name = "lblAccountStudentClass";
            this.lblAccountStudentClass.Size = new System.Drawing.Size(36, 19);
            this.lblAccountStudentClass.TabIndex = 7;
            this.lblAccountStudentClass.Text = "Lớp";
            // 
            // txtAccountStudentName
            // 
            this.txtAccountStudentName.Location = new System.Drawing.Point(164, 258);
            this.txtAccountStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountStudentName.Name = "txtAccountStudentName";
            this.txtAccountStudentName.Size = new System.Drawing.Size(363, 27);
            this.txtAccountStudentName.TabIndex = 6;
            // 
            // lblAccountStudentName
            // 
            this.lblAccountStudentName.AutoSize = true;
            this.lblAccountStudentName.Location = new System.Drawing.Point(40, 261);
            this.lblAccountStudentName.Name = "lblAccountStudentName";
            this.lblAccountStudentName.Size = new System.Drawing.Size(101, 19);
            this.lblAccountStudentName.TabIndex = 5;
            this.lblAccountStudentName.Text = "Tên Học Sinh";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(164, 217);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(363, 27);
            this.txtPassWord.TabIndex = 4;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(40, 220);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(75, 19);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "Mật Khẩu";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(164, 178);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(363, 27);
            this.txtAccountName.TabIndex = 2;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(40, 181);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(107, 19);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Tên Tài Khoản";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(77, 343);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(159, 55);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm Tài Khoản";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 676);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchAccount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddAccount.ResumeLayout(false);
            this.pnlAddAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSearchAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Label lblSearchAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Label lblListAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.TextBox txtAccountStudentClass;
        private System.Windows.Forms.Label lblAccountStudentClass;
        private System.Windows.Forms.TextBox txtAccountStudentName;
        private System.Windows.Forms.Label lblAccountStudentName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnAddAccount;
    }
}