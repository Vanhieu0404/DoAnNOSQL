namespace QL_KhachHangBaoHiem.GUI
{
    partial class QLNhanVien
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
			this.dG_NhanVien = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnChiTiet = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dG_NhanVien)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dG_NhanVien
			// 
			this.dG_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dG_NhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dG_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dG_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dG_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dG_NhanVien.Location = new System.Drawing.Point(0, 0);
			this.dG_NhanVien.Margin = new System.Windows.Forms.Padding(2);
			this.dG_NhanVien.Name = "dG_NhanVien";
			this.dG_NhanVien.RowHeadersWidth = 51;
			this.dG_NhanVien.RowTemplate.Height = 24;
			this.dG_NhanVien.Size = new System.Drawing.Size(600, 366);
			this.dG_NhanVien.TabIndex = 0;
			this.dG_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_NhanVien_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 305);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 61);
			this.panel1.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 9;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanel1.Controls.Add(this.btnChiTiet, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnXoa, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnLamMoi, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnThem, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 61);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnChiTiet
			// 
			this.btnChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChiTiet.Location = new System.Drawing.Point(163, 2);
			this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2);
			this.btnChiTiet.Name = "btnChiTiet";
			this.btnChiTiet.Size = new System.Drawing.Size(127, 57);
			this.btnChiTiet.TabIndex = 0;
			this.btnChiTiet.Text = "Chi Tiết";
			this.btnChiTiet.UseVisualStyleBackColor = true;
			this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(309, 2);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(127, 57);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Location = new System.Drawing.Point(455, 2);
			this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(127, 57);
			this.btnLamMoi.TabIndex = 0;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(17, 2);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(127, 57);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dG_NhanVien);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 366);
			this.panel2.TabIndex = 3;
			// 
			// QLNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "QLNhanVien";
			this.Text = "Quản lý nhân viên";
			((System.ComponentModel.ISupportInitialize)(this.dG_NhanVien)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dG_NhanVien;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnChiTiet;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Panel panel2;
	}
}