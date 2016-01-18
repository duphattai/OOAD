using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_ChiTietPhieuDatCho
    {
        public int getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblChiTietPhieuDatChoes.ToArray().Length == 0)
                return 1;
            else
                return db.tblChiTietPhieuDatChoes.Max(t => t.MaCTPhieu) + 1;
        }

        public string validateInput(int maPhieu, int maChuyenDi, int? viTriGhe)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t=>t.MaChuyenDi == maChuyenDi).SingleOrDefault();
            if (db.tblChiTietPhieuDatChoes.Where(t => t.MaChuyenDi == maChuyenDi && t.LayVe == true).ToArray().Length >= chuyenDi.tblXeKhach.SoGhe)
                return "Hết chỗ, không thể bán hay đặt vé";
            if (db.tblChiTietPhieuDatChoes.Where(t => t.MaChuyenDi == maChuyenDi && t.ViTriGhe == viTriGhe).ToArray().Length > 0)
                return "Vị trí ghế bị trùng";
            if (viTriGhe < 0 || viTriGhe >= chuyenDi.tblXeKhach.SoGhe)
                return "Vị trí ghế nằm (0, 50)";

            return null;
        }


    }
}
