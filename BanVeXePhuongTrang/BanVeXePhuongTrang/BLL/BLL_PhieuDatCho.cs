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

        public string validateInput(int maPhieu, string hoTen, int? dienThoai)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (db.tblPhieuDatChoes.Where(t => t.DienThoai == dienThoai || t.MaPhieu == maPhieu).Count() != 0)
                return "Hành khách đã tồn tại";
            return null;
        }


    }
}
