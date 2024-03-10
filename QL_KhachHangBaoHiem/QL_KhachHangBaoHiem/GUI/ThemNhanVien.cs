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
	public partial class ThemNhanVien : Form
	{
		public ThemNhanVien()
		{
			InitializeComponent();
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			string MaNhanVien = txt_MaNhanVien.Text;
			string HoTen = txt_HoTen.Text;
			string NgaySinh = txt_NgaySinh.Text;
			string SDT = txt_SDT.Text;
			string NoiSong = txt_NoiO.Text;
			string TenNguoiDung = txt_TenNguoiDung.Text;
			string MatKhau = txt_MatKhau.Text;
			NhanVien nhanVien = new NhanVien()
			{
				HoTen = HoTen,
				MaNV = MaNhanVien,
				NgaySinh = new MongoDB.Bson.BsonDateTime(DateTime.Parse(NgaySinh)),
				SDT = SDT,
				NoiSong = NoiSong,
				TaiKhoan = new TaiKhoan() { TenNguoiDung = new List<string>() { SDT, TenNguoiDung }, MatKhau = MatKhau, Quyen = "NV" }
			};

			NhanVien bll = new NhanVien();
			try
			{
				bll.ThemNhanVien(nhanVien);
				this.Hide();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}
	}
}
