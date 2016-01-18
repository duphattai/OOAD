using BanVeXePhuongTrang.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_TaiKhoan
    {
        public bool canInsert(string tenDN, string mk)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTaiKhoans.Where(t => t.TenTaiKhoan == tenDN || t.MatKhau == mk).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canUpdate(string tenDN, string mk)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTaiKhoans.Where(t => t.TenTaiKhoan == tenDN && t.MatKhau == mk).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canDelete(int maNV)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTaiKhoans.Where(t => t.MaNhanVien == maNV).ToArray().Length != 0)
                return true;

            return false;
        }
    }
}
