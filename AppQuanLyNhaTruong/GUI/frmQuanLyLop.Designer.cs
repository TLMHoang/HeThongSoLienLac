namespace GUI
{
    partial class frmQuanLyLop
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
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.lblDanhSachLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaTen = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaLop);
            this.panel1.Controls.Add(this.btnSuaTen);
            this.panel1.Controls.Add(this.btnThemLop);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Controls.Add(this.lblTenLop);
            this.panel1.Controls.Add(this.lblDanhSachLop);
            this.panel1.Controls.Add(this.dgvDanhSachLop);
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 645);
            this.panel1.TabIndex = 0;
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(3, 84);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(578, 558);
            this.dgvDanhSachLop.TabIndex = 0;
            // 
            // lblDanhSachLop
            // 
            this.lblDanhSachLop.AutoSize = true;
            this.lblDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachLop.Location = new System.Drawing.Point(184, 41);
            this.lblDanhSachLop.Name = "lblDanhSachLop";
            this.lblDanhSachLop.Size = new System.Drawing.Size(178, 20);
            this.lblDanhSachLop.TabIndex = 1;
            this.lblDanhSachLop.Text = "Danh Sách Lớp Học";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.Location = new System.Drawing.Point(652, 242);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(77, 20);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(748, 239);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(324, 27);
            this.txtTenLop.TabIndex = 3;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(712, 310);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(132, 43);
            this.btnThemLop.TabIndex = 4;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            // 
            // btnSuaTen
            // 
            this.btnSuaTen.Location = new System.Drawing.Point(850, 310);
            this.btnSuaTen.Name = "btnSuaTen";
            this.btnSuaTen.Size = new System.Drawing.Size(132, 43);
            this.btnSuaTen.TabIndex = 5;
            this.btnSuaTen.Text = "Sủa Tên Lớp";
            this.btnSuaTen.UseVisualStyleBackColor = true;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(988, 310);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(132, 43);
            this.btnXoaLop.TabIndex = 6;
            this.btnXoaLop.Text = "Xóa Lớp";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 657);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaTen;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblDanhSachLop;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
    }
}