using QL_KhachHangBaoHiem.BLL;
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
	public partial class TraCuuThongTin : Form
	{
		public TraCuuThongTin()
		{
			InitializeComponent();
			dg_HopDong.DoubleClick += Dg_HopDong_DoubleClick;
		}

		private void Dg_HopDong_DoubleClick(object sender, EventArgs e)
		{
			var maHD = dg_HopDong.CurrentRow.Cells[0].Value.ToString();
			TTChiTietHopDong f = new TTChiTietHopDong();
			f.maHD = maHD;
			f.ShowDialog();
		}

		

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string str = txtSearch.Text;
			var lists = new HopDongBaoHiem().traCuuThongTinHopDong(str).Select(t => new { t.MaHopDong,t.ThongTinKhachHang.TenNguoiMua,t.TrangThaiHopDong,t.NgayKyHopDong}).ToList();

			if (lists == null)
			{
				MessageBox.Show("Không tìm thấy thông tin !");
				return;
			}
			dg_HopDong.DataSource = lists;
		}
	}
}
