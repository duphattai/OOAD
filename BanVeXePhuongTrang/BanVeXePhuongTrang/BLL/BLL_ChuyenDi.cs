using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_ChuyenDi
    {

        public int  getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblChuyenDis.Count() == 0)
                return 1;
            else
                return db.tblChuyenDis.Max(t => t.MaChuyenDi) + 1;
        }

        public string validateInput(int maChuyen, int? maXe, decimal? giaVe, DateTime khoiHanh, DateTime ketThuc)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (maChuyen < 0)
                return "Mã chuyến đi không hợp lệ";
            if (db.tblXeKhaches.Where(t => t.MaXe == maXe).ToArray().Length == 0)
                return "Mã xe không hợp lệ";
            if(giaVe < 0)
                return "Giá vé không hợp lệ";
            if ((ketThuc - khoiHanh).TotalMinutes < 30)
                return "Thời gian đi phải lớn hơn 30 phút";
            //if (db.tblChiTietChuyenDis.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length > 2)
            //    return "Tối đa chỉ được";

            return null;
        }

        public bool canInsert(int maChuyen, int? maXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canUpdate(int maChuyen, int? maXe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length != 0)
                return true;

            return false;
        }

        public bool canDelete(int maChuyen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            // Kiểm tra có được sử dụng
            if (db.tblChiTietPhieuDatChoes.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length > 0)
                return false;
            if (db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length == 0)
                return false;

            return true;
        }
    }
}
