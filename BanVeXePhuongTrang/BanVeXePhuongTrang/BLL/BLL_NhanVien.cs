using BanVeXePhuongTrang.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_NhanVien
    {

        public int  getLastestIndex()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if (db.tblNhanViens.ToArray().Length == 0)
                return 1;
            else
                return (db.tblNhanViens.Max(t => t.MaNhanVien) + 1);
        }


        public bool canInsert(int maNV,  int cmnd)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblNhanViens.Where(t => t.MaNhanVien == maNV || t.CMND == cmnd).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canUpdate(int maNV, int cmnd)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblNhanViens.Where(t => t.MaNhanVien != maNV && t.CMND == cmnd).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canDelete(int maNV)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblNhanViens.Where(t => t.MaNhanVien == maNV).ToArray().Length != 0)
                return true;

            return false;
        }
    }
}
