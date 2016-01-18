using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_XeKhach
    {
        public int  getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblXeKhaches.ToArray().Length == 0)
                return 1;
            else
                return db.tblXeKhaches.Max(t => t.MaXe) + 1;
        }

        public bool canInsert(int maXe, string bienSoXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeKhach xeKhach = db.tblXeKhaches.Where(t => t.MaXe == maXe || t.BienSoXe == bienSoXe).SingleOrDefault();
            if (xeKhach != null)
                return false;

            return true;
        }

        public bool canUpdate(int maXe, string bienSoXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeKhach xeKhach = db.tblXeKhaches.Where(t => t.MaXe != maXe && t.BienSoXe == bienSoXe).SingleOrDefault();
            if (xeKhach != null)
                return false;

            return true;
        }

        public bool canDelete(int maXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeKhach xeKhach = db.tblXeKhaches.Where(t => t.MaXe == maXe).SingleOrDefault();
            if (xeKhach != null)
                return true;

            return false;
        }

        public string validateInput(int maXe, int? maNhanVien, int? maLoaiXe,  string bienSo, string maTuyen, int? soGhe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (maXe < 0) 
                return "Mã xe không hợp lệ";
            if (db.tblNhanViens.Where(t => t.MaNhanVien == maNhanVien).ToArray().Length == 0)
                return "Tài xế không tồn tại";
            if (db.tblLoaiXes.Where(t => t.MaLoaiXe == maLoaiXe).ToArray().Length == 0)
                return "Loại xe không tồn tại";
            if (string.IsNullOrEmpty(bienSo))
                return "Vui lòng nhập biển số xe";
            if (db.tblTuyenXes.Where(t => t.MaTuyen == maTuyen).ToArray().Length == 0)
                return "Tuyến xe không tồn tại";
            if (soGhe <= 0)
                return "Vui lòng nhật số ghế (số ghế > 0)";

            return null;
        }
    }
}
