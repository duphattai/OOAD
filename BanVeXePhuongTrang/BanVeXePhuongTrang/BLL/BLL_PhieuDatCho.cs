using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_PhieuDatCho
    {
        public int getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblPhieuDatChoes.ToArray().Length == 0)
                return 1;
            else
                return db.tblPhieuDatChoes.Max(t => t.MaPhieu) + 1;
        }

        public string validateInput(int maPhieu, int maChuyenDi, string hoTen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyenDi).Count() == 0)
                return "Chuyến đi không tồn tại";
            if (string.IsNullOrEmpty(hoTen))
                return "Vui lòng nhập họ tên";

            return null;
        }


    }
}
