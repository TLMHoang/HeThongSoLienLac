namespace GUI
{
    partial class frmPhanCong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhanCongMon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.tabMon = new System.Windows.Forms.TabPage();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.bsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.bsView = new System.Windows.Forms.BindingSource(this.components);
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPhanCongMon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhanCongMon);
            this.tabControl1.Controls.Add(this.tabMon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 689);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhanCongMon
            // 
            this.tabPhanCongMon.Controls.Add(this.tableLayoutPanel1);
            this.tabPhanCongMon.Location = new System.Drawing.Point(4, 25);
            this.tabPhanCongMon.Margin = new System.Windows.Forms.Padding(4);
            this.tabPhanCongMon.Name = "tabPhanCongMon";
            this.tabPhanCongMon.Padding = new System.Windows.Forms.Padding(4);
            this.tabPhanCongMon.Size = new System.Drawing.Size(764, 660);
            this.tabPhanCongMon.TabIndex = 0;
            this.tabPhanCongMon.Text = "Phân công giáo viên";
            this.tabPhanCongMon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiemGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSLop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvView, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 652);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(608, 197);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(153, 197);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(144, 56);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemGV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiemGV, 3);
            this.txtTimKiemGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemGV.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemGV.Location = new System.Drawing.Point(3, 2);
            this.txtTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(477, 23);
            this.txtTimKiemGV.TabIndex = 1;
            this.txtTimKiemGV.Text = "Nhập ID hoặc Tên GV";
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AutoGenerateColumns = false;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTKTDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSGV, 3);
            this.dgvDSGV.DataSource = this.bsDSGV;
            this.dgvDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSGV.Location = new System.Drawing.Point(3, 27);
            this.dgvDSGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.Size = new System.Drawing.Size(477, 166);
            this.dgvDSGV.TabIndex = 2;
            // 
            // tabMon
            // 
            this.tabMon.Location = new System.Drawing.Point(4, 25);
            this.tabMon.Margin = new System.Windows.Forms.Padding(4);
            this.tabMon.Name = "tabMon";
            this.tabMon.Padding = new System.Windows.Forms.Padding(4);
            this.tabMon.Size = new System.Drawing.Size(764, 660);
            this.tabMon.TabIndex = 1;
            this.tabMon.Text = "Quản lý môn";
            this.tabMon.UseVisualStyleBackColor = true;
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLop,
            this.TenLop,
            this.Check});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSLop, 2);
            this.dgvDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLop.Location = new System.Drawing.Point(486, 28);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.Size = new System.Drawing.Size(267, 164);
            this.dgvDSLop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(486, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(3, 197);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 56);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // dgvView
            // 
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.iDGiaoVienDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn,
            this.iDMonDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvView, 5);
            this.dgvView.DataSource = this.bsView;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.Location = new System.Drawing.Point(3, 258);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(750, 391);
            this.dgvView.TabIndex = 8;
            // 
            // bsDSGV
            // 
            this.bsDSGV.DataSource = typeof(DTO.ThongTinGV);
            // 
            // bsView
            // 
            this.bsView.DataSource = typeof(DTO.PhanCong);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // iDGiaoVienDataGridViewTextBoxColumn
            // 
            this.iDGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "IDGiaoVien";
            this.iDGiaoVienDataGridViewTextBoxColumn.HeaderText = "IDGiaoVien";
            this.iDGiaoVienDataGridViewTextBoxColumn.Name = "iDGiaoVienDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // iDMonDataGridViewTextBoxColumn
            // 
            this.iDMonDataGridViewTextBoxColumn.DataPropertyName = "IDMon";
            this.iDMonDataGridViewTextBoxColumn.HeaderText = "IDMon";
            this.iDMonDataGridViewTextBoxColumn.Name = "iDMonDataGridViewTextBoxColumn";
            // 
            // iDTKTDataGridViewTextBoxColumn
            // 
            this.iDTKTDataGridViewTextBoxColumn.DataPropertyName = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.HeaderText = "IDTKT";
            this.iDTKTDataGridViewTextBoxColumn.Name = "iDTKTDataGridViewTextBoxColumn";
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn1
            // 
            this.iDLopDataGridViewTextBoxColumn1.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn1.HeaderText = "IDLop";
            this.iDLopDataGridViewTextBoxColumn1.Name = "iDLopDataGridViewTextBoxColumn1";
            // 
            // IDLop
            // 
            this.IDLop.HeaderText = "Mã";
            this.IDLop.Name = "IDLop";
            this.IDLop.Width = 50;
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // Check
            // 
            this.Check.HeaderText = "Dạy";
            this.Check.Name = "Check";
            this.Check.Width = 50;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 689);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Công";
            this.tabControl1.ResumeLayout(false);
            this.tabPhanCongMon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhanCongMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TabPage tabMon;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsDSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}