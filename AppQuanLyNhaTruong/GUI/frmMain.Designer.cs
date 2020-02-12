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
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Location = new System.Drawing.Point(7, 7);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1221, 657);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlChucNang.Controls.Add(this.btnSearch);
            this.pnlChucNang.Controls.Add(this.btnAccountManagement);
            this.pnlChucNang.Controls.Add(this.btnStudentManagement);
            this.pnlChucNang.Location = new System.Drawing.Point(7, 41);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(489, 623);
            this.pnlChucNang.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(45, 387);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(382, 103);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tra Cứu Giáo Viên";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAccountManagement.FlatAppearance.BorderSize = 0;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountManagement.ForeColor = System.Drawing.Color.White;
            this.btnAccountManagement.Location = new System.Drawing.Point(45, 267);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(382, 103);
            this.btnAccountManagement.TabIndex = 1;
            this.btnAccountManagement.Text = "Quản Lý Tài Khoản";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStudentManagement.FlatAppearance.BorderSize = 0;
            this.btnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManagement.ForeColor = System.Drawing.Color.White;
            this.btnStudentManagement.Location = new System.Drawing.Point(45, 158);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(382, 103);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "Quản Lý Học Sinh";
            this.btnStudentManagement.UseVisualStyleBackColor = false;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(1221, 28);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1178, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 676);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ  Thống Sổ Liên Lạc Điện Tử ";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
    }
}