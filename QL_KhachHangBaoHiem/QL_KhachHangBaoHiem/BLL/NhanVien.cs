using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using QL_KhachHangBaoHiem.DAL;
using QL_KhachHangBaoHiem.GUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class NhanVien
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("MaNV")]
		public string MaNV { get; set; }
        [BsonElement("HoTen")]
        public string HoTen { get; set; }

        [BsonElement("NgaySinh")]
        public BsonDateTime NgaySinh { get; set; }
        [BsonElement("SDT")]
        public string SDT { get; set; }
        [BsonElement("NoiSong")]
        public string NoiSong { get; set; }
        [BsonElement("TaiKhoan")]
        public TaiKhoan TaiKhoan { get; set; }

        public NhanVien() { }

		public List<object> getListNhanVien()
		{
			return new NhanVienDAL().getListNhanVien().Select(t => new { t.MaNV,t.HoTen, t.NgaySinh, t.SDT, t.NoiSong,t.TaiKhoan.Quyen }).ToList<object>();
		}

		public NhanVien getListNhanVien(string maNV)
		{
            NhanVienDAL dal = new NhanVienDAL();
            var list = dal.getListNhanVien().ToList<NhanVien>();
            var match = list.Where(x => x.MaNV == maNV).FirstOrDefault();
            return match;

		}
        public void ThemNhanVien(NhanVien nhanVien)
        {
            NhanVienDAL dal = new NhanVienDAL();
            dal.ThemNhanVien(nhanVien);
        }
        public void XoaNhanVien(string maNV)
        {
            try
            {
				NhanVienDAL dal = new NhanVienDAL();
				dal.XoaNhanVien(maNV);
			}
            catch (Exception ec)
            {

                throw ec;
            }
        }
	}
}
