using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_XeTrungChuyen
    {
        public int getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblXeTrungChuyens.ToArray().Length == 0)
                return 1;
            else
                return db.tblXeTrungChuyens.Max(t => t.MaXe) + 1;
        }

        public bool canInsert(int maXe, string bienSoXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeTrungChuyen xe = db.tblXeTrungChuyens.Where(t => t.MaXe == maXe || t.BienSoXe == bienSoXe).SingleOrDefault();
            if (xe != null)
                return false;

            return true;
        }

        public bool canUpdate(int maXe, string bienSoXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeTrungChuyen xe = db.tblXeTrungChuyens.Where(t => t.MaXe != maXe && t.BienSoXe == bienSoXe).SingleOrDefault();
            if (xe != null)
                return false;

            return true;
        }

        public bool canDelete(int maXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblXeTrungChuyen xeKhach = db.tblXeTrungChuyens.Where(t => t.MaXe == maXe).SingleOrDefault();
            if (xeKhach != null)
                return true;

            return false;
        }

        public string validateInput(int maXe, int? maNhanVien, string bienSo, string diaDiem)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (maXe < 0)
                return "Mã xe không hợp lệ";
            if (db.tblNhanViens.Where(t => t.MaNhanVien == maNhanVien).ToArray().Length == 0)
                return "Tài xế không tồn tại";
            if (string.IsNullOrEmpty(bienSo))
                return "Vui lòng nhập biển số xe";
            if (string.IsNullOrEmpty(diaDiem))
                return "Vui lòng nhập địa điểm trung chuyển";

            return null;
        }
    }
}
