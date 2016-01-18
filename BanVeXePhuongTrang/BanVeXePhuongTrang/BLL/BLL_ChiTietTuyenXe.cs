using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_ChiTietTuyenXe
    {
        public string validateInput(string maTuyen, int? thoiGianDung)
        {
            int minTGDung = 0;
            int maxTGDung = 0;

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            foreach(var item in db.tblThamSoes.ToList())
            {
                minTGDung = item.ThoiGianDungToiThieu.Value;
                maxTGDung = item.ThoiGianDungToiDa.Value;
            }

            if (thoiGianDung.Value > maxTGDung && thoiGianDung.Value < minTGDung )
                return "Thời gian dừng phải nằm trong (10, 20)";

            return null;
        }
    }
}
