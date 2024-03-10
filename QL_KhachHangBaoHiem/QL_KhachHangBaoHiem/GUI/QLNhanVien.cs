using QL_KhachHangBaoHiem.BLL;
using QL_KhachHangBaoHiem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachHangBaoHiem.GUI
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
			this.Load += QLNhanVien_Load;
			dG_NhanVien.DoubleClick += DG_NhanVien_DoubleClick;
        }

		private void DG_NhanVien_DoubleClick(object sender, EventArgs e)
		{
			TTChiTietNhanVien f = new TTChiTietNhanVien();
			f.maNV = dG_NhanVien.CurrentRow.Cells[0].Value.ToString();
			f.ShowDialog();
		}

		private void QLNhanVien_Load(object sender, EventArgs e)
		{
			load();
		}
		void load()
		{
			NhanVien bll = new NhanVien();
			var nhanViens = bll.getListNhanVien();
			dG_NhanVien.DataSource = nhanViens;
		}
		private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = new HopDongBaoHiem().ThongKe();
        }

		private void btnChiTiet_Click(object sender, EventArgs e)
		{
			TTChiTietNhanVien f = new TTChiTietNhanVien();
			f.maNV = dG_NhanVien.CurrentRow.Cells[0].Value.ToString();
			f.ShowDialog();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			ThemNhanVien f = new ThemNhanVien();
			f.ShowDialog();
			load();

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			load();

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				new NhanVien().XoaNhanVien(dG_NhanVien.CurrentRow.Cells[0].Value.ToString());
				MessageBox.Show("Xóa thành công nhân viên!", "Thành Công");
				load();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Xóa Thất Bại");
			}
		}

		private void dG_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
