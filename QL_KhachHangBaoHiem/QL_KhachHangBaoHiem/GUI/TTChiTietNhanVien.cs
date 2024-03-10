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
	public partial class TTChiTietNhanVien : Form
	{
		public string maNV { get; set; }
		public TTChiTietNhanVien()
		{
			InitializeComponent();
			this.Load += TTChiTietNhanVien_Load;
		}

		private void TTChiTietNhanVien_Load(object sender, EventArgs e)
		{
			Text = maNV;
			NhanVien t = new NhanVien().getListNhanVien(maNV);
			txt_HoTen.Text = t.HoTen;
			txt_MaNhanVien.Text = t.MaNV;
			txt_SDT.Text = t.SDT;
			txt_NgaySinh.Text = t.NgaySinh.ToLocalTime().ToString("dd/MM/yyyy");
			txt_NoiO.Text = t.NoiSong;

		}
	}
}
