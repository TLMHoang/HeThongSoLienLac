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
            this.components = new System.ComponentModel.Container();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTaiKhoanTruong = new System.Windows.Forms.TabPage();
            this.tlpTKT = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tabPageTaiKhoanPH = new System.Windows.Forms.TabPage();
            this.tlpTKPH = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageQLTK = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            this.tabPageTaiKhoanTruong.SuspendLayout();
            this.tlpTKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPageTaiKhoanPH.SuspendLayout();
            this.tlpTKPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageQLTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // tabPageTaiKhoanTruong
            // 
            this.tabPageTaiKhoanTruong.Controls.Add(this.tlpTKT);
            this.tabPageTaiKhoanTruong.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanTruong.Name = "tabPageTaiKhoanTruong";
            this.tabPageTaiKhoanTruong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanTruong.Size = new System.Drawing.Size(791, 599);
            this.tabPageTaiKhoanTruong.TabIndex = 1;
            this.tabPageTaiKhoanTruong.Text = "Tài Khoản Trường";
            this.tabPageTaiKhoanTruong.UseVisualStyleBackColor = true;
            // 
            // tlpTKT
            // 
            this.tlpTKT.ColumnCount = 3;
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.12903F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.87097F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpTKT.Controls.Add(this.dataGridView3, 0, 1);
            this.tlpTKT.Controls.Add(this.textBox3, 0, 0);
            this.tlpTKT.Controls.Add(this.dataGridView4, 1, 0);
            this.tlpTKT.Controls.Add(this.btnLuu, 2, 2);
            this.tlpTKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKT.Location = new System.Drawing.Point(3, 2);
            this.tlpTKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTKT.Name = "tlpTKT";
            this.tlpTKT.RowCount = 3;
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.372681F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92437F));
            this.tlpTKT.Size = new System.Drawing.Size(785, 595);
            this.tlpTKT.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 22);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.tlpTKT.SetRowSpan(this.dataGridView3, 2);
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(372, 571);
            this.dataGridView3.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 2);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(372, 27);
            this.textBox3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpTKT.SetColumnSpan(this.dataGridView4, 2);
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(381, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.tlpTKT.SetRowSpan(this.dataGridView4, 2);
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(401, 525);
            this.dataGridView4.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(622, 532);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 60);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // tabPageTaiKhoanPH
            // 
            this.tabPageTaiKhoanPH.Controls.Add(this.tlpTKPH);
            this.tabPageTaiKhoanPH.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoanPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanPH.Name = "tabPageTaiKhoanPH";
            this.tabPageTaiKhoanPH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTaiKhoanPH.Size = new System.Drawing.Size(791, 599);
            this.tabPageTaiKhoanPH.TabIndex = 0;
            this.tabPageTaiKhoanPH.Text = "Tài Khoản Phụ Huynh";
            this.tabPageTaiKhoanPH.UseVisualStyleBackColor = true;
            // 
            // tlpTKPH
            // 
            this.tlpTKPH.ColumnCount = 3;
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24619F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tlpTKPH.Controls.Add(this.btnThem, 0, 2);
            this.tlpTKPH.Controls.Add(this.btnDatLaiMK, 0, 2);
            this.tlpTKPH.Controls.Add(this.textBox2, 1, 0);
            this.tlpTKPH.Controls.Add(this.dataGridView1, 0, 1);
            this.tlpTKPH.Controls.Add(this.textBox1, 0, 0);
            this.tlpTKPH.Controls.Add(this.dataGridView2, 1, 1);
            this.tlpTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKPH.Location = new System.Drawing.Point(3, 2);
            this.tlpTKPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTKPH.Name = "tlpTKPH";
            this.tlpTKPH.RowCount = 3;
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.753199F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.2468F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpTKPH.Size = new System.Drawing.Size(785, 595);
            this.tlpTKPH.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(363, 536);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(208, 56);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatLaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLaiMK.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMK.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMK.Location = new System.Drawing.Point(577, 536);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(205, 56);
            this.btnDatLaiMK.TabIndex = 7;
            this.btnDatLaiMK.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.tlpTKPH.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(363, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(419, 22);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.tlpTKPH.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 566);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpTKPH.SetColumnSpan(this.dataGridView2, 2);
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(363, 27);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(419, 504);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabPageQLTK
            // 
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanPH);
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanTruong);
            this.tabPageQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabPageQLTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageQLTK.Name = "tabPageQLTK";
            this.tabPageQLTK.SelectedIndex = 0;
            this.tabPageQLTK.Size = new System.Drawing.Size(799, 628);
            this.tabPageQLTK.TabIndex = 0;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(799, 628);
            this.Controls.Add(this.tabPageQLTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            this.tabPageTaiKhoanTruong.ResumeLayout(false);
            this.tlpTKT.ResumeLayout(false);
            this.tlpTKT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPageTaiKhoanPH.ResumeLayout(false);
            this.tlpTKPH.ResumeLayout(false);
            this.tlpTKPH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageQLTK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.TabPage tabPageTaiKhoanTruong;
        private System.Windows.Forms.TabPage tabPageTaiKhoanPH;
        private System.Windows.Forms.TableLayoutPanel tlpTKPH;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabPageQLTK;
        private System.Windows.Forms.TableLayoutPanel tlpTKT;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDatLaiMK;
    }
}