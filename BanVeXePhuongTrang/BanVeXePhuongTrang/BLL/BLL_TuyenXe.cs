using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_TuyenXe
    {
        public bool canInsert(string maBenDi, string maBenDen)
        {
            if (maBenDi == maBenDen) return false;

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTuyenXes.Where(t => t.MaBenXeDi == maBenDi && t.MaBenXeDen == maBenDen).SingleOrDefault() != null)
                return false;

            return true;
        }

        public bool canUpdate(string maBenDi, string maBenDen)
        {
            if (maBenDi == maBenDen) return false;

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTuyenXes.Where(t => t.MaBenXeDi == maBenDi && t.MaBenXeDen == maBenDen).SingleOrDefault() != null)
                return true;

            return false;
        }


        public bool canDelete(string maTuyen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblTuyenXes.Where(t => t.MaTuyen == maTuyen).SingleOrDefault() != null)
                return true;

            return false;
        }


    }
}
