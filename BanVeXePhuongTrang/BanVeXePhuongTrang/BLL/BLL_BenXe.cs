using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_BenXe
    {
        public bool canInsert(string maBen, string tenBen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblBenXes.Where(t => t.MaBenXe == maBen || t.TenBenXe == tenBen).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canUpdate(string maBen, string tenBen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblBenXes.Where(t => t.MaBenXe != maBen && t.TenBenXe == tenBen).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canDelete(string maBen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblBenXes.Where(t => t.MaBenXe == maBen).ToArray().Length != 0)
                return true;

            return false;
        }
    }
}
