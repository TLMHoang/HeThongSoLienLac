﻿namespace GUI
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSửa = new System.Windows.Forms.Button();
            this.tabPageTaiKhoanPH = new System.Windows.Forms.TabPage();
            this.tlpTKPH = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.tabPageQLTK = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            this.tabPageTaiKhoanTruong.SuspendLayout();
            this.tlpTKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageTaiKhoanPH.SuspendLayout();
            this.tlpTKPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tabPageTaiKhoanTruong.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaiKhoanTruong.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTaiKhoanTruong.Name = "tabPageTaiKhoanTruong";
            this.tabPageTaiKhoanTruong.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTaiKhoanTruong.Size = new System.Drawing.Size(591, 484);
            this.tabPageTaiKhoanTruong.TabIndex = 1;
            this.tabPageTaiKhoanTruong.Text = "Tài Khoản Trường";
            this.tabPageTaiKhoanTruong.UseVisualStyleBackColor = true;
            // 
            // tlpTKT
            // 
            this.tlpTKT.ColumnCount = 2;
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.1656F));
            this.tlpTKT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.8344F));
            this.tlpTKT.Controls.Add(this.dataGridView3, 0, 1);
            this.tlpTKT.Controls.Add(this.textBox3, 0, 0);
            this.tlpTKT.Controls.Add(this.dataGridView4, 1, 0);
            this.tlpTKT.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tlpTKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKT.Location = new System.Drawing.Point(2, 2);
            this.tlpTKT.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTKT.Name = "tlpTKT";
            this.tlpTKT.RowCount = 3;
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.372681F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.37099F));
            this.tlpTKT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.25632F));
            this.tlpTKT.Size = new System.Drawing.Size(587, 480);
            this.tlpTKT.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(2, 18);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.tlpTKT.SetRowSpan(this.dataGridView3, 2);
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(243, 460);
            this.dataGridView3.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(2, 2);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 23);
            this.textBox3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(249, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.tlpTKT.SetRowSpan(this.dataGridView4, 2);
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(336, 301);
            this.dataGridView4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.60802F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.38976F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49889F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSửa, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(249, 307);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.04762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.47619F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 171);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(81, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSửa
            // 
            this.btnSửa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSửa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSửa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSửa.ForeColor = System.Drawing.Color.White;
            this.btnSửa.Location = new System.Drawing.Point(169, 51);
            this.btnSửa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.Size = new System.Drawing.Size(81, 46);
            this.btnSửa.TabIndex = 2;
            this.btnSửa.Text = "Sửa";
            this.btnSửa.UseVisualStyleBackColor = false;
            // 
            // tabPageTaiKhoanPH
            // 
            this.tabPageTaiKhoanPH.Controls.Add(this.tlpTKPH);
            this.tabPageTaiKhoanPH.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaiKhoanPH.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTaiKhoanPH.Name = "tabPageTaiKhoanPH";
            this.tabPageTaiKhoanPH.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTaiKhoanPH.Size = new System.Drawing.Size(591, 484);
            this.tabPageTaiKhoanPH.TabIndex = 0;
            this.tabPageTaiKhoanPH.Text = "Tài Khoản Phụ Huynh";
            this.tabPageTaiKhoanPH.UseVisualStyleBackColor = true;
            // 
            // tlpTKPH
            // 
            this.tlpTKPH.ColumnCount = 2;
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24619F));
            this.tlpTKPH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tlpTKPH.Controls.Add(this.textBox2, 1, 0);
            this.tlpTKPH.Controls.Add(this.dataGridView1, 0, 1);
            this.tlpTKPH.Controls.Add(this.textBox1, 0, 0);
            this.tlpTKPH.Controls.Add(this.dataGridView2, 1, 1);
            this.tlpTKPH.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tlpTKPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTKPH.Location = new System.Drawing.Point(2, 2);
            this.tlpTKPH.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTKPH.Name = "tlpTKPH";
            this.tlpTKPH.RowCount = 3;
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.505155F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.49484F));
            this.tlpTKPH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tlpTKPH.Size = new System.Drawing.Size(587, 480);
            this.tlpTKPH.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(285, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.tlpTKPH.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(279, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(285, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(300, 262);
            this.dataGridView2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.32331F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.05514F));
            this.tableLayoutPanel1.Controls.Add(this.btnThemTK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDatLaiMK, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(285, 292);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 186);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.White;
            this.btnThemTK.Location = new System.Drawing.Point(52, 71);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(90, 49);
            this.btnThemTK.TabIndex = 0;
            this.btnThemTK.Text = "Xác Nhận";
            this.btnThemTK.UseVisualStyleBackColor = false;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatLaiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatLaiMK.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMK.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMK.Location = new System.Drawing.Point(146, 71);
            this.btnDatLaiMK.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(84, 49);
            this.btnDatLaiMK.TabIndex = 1;
            this.btnDatLaiMK.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            // 
            // tabPageQLTK
            // 
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanPH);
            this.tabPageQLTK.Controls.Add(this.tabPageTaiKhoanTruong);
            this.tabPageQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabPageQLTK.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageQLTK.Name = "tabPageQLTK";
            this.tabPageQLTK.SelectedIndex = 0;
            this.tabPageQLTK.Size = new System.Drawing.Size(599, 510);
            this.tabPageQLTK.TabIndex = 0;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(599, 510);
            this.Controls.Add(this.tabPageQLTK);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPageTaiKhoanPH.ResumeLayout(false);
            this.tlpTKPH.ResumeLayout(false);
            this.tlpTKPH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabPageQLTK;
        private System.Windows.Forms.TableLayoutPanel tlpTKT;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSửa;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnDatLaiMK;
    }
}