namespace AppQuanLyNhaTruong
{
    partial class frmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.btnAccount);
            this.pnlMain.Controls.Add(this.btnStudentManagement);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1146, 595);
            this.pnlMain.TabIndex = 0;
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManagement.Location = new System.Drawing.Point(740, 58);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(292, 84);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "Quản Lý Học Sinh";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(740, 196);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(292, 84);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Quản Lý Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(740, 335);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(292, 84);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tra Cứu Giáo Viên";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 619);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hệ Thống";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.Button btnSearch;
    }
}