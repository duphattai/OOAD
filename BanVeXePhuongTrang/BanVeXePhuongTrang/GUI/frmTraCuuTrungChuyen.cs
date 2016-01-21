using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmTraCuuTrungChuyen : Form
    {
        public frmTraCuuTrungChuyen()
        {
            InitializeComponent();

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbbXeTrungChuyen.DataSource = db.tblXeTrungChuyens.Select(t => new { BienSo = t.BienSoXe, DiaDiem = t.DiaDiemTrungChuyen }).ToList();
        }

        private void cbbXeTrungChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            dynamic selectedItem = cbbXeTrungChuyen.SelectedItem;
            string bienSo = selectedItem.BienSo;

            var table = (from ct in db.tblChiTietTrungChuyens
                         join phieu in db.tblPhieuDatChoes on ct.MaPhieu equals phieu.MaPhieu
                         join xe in db.tblXeTrungChuyens on ct.MaXe equals xe.MaXe
                         join ctPhieu in db.tblChiTietPhieuDatChoes on phieu.MaPhieu equals ctPhieu.MaPhieu
                         join chuyenDi in db.tblChuyenDis on ctPhieu.MaChuyenDi equals chuyenDi.MaChuyenDi
                         where xe.BienSoXe == bienSo && ct.DaRuoc == false
                         select new
                         {
                             HoTen = phieu.HoTen,
                             SDT = phieu.DienThoai,
                             DiaDiem = phieu.TrungChuyen,
                             SoVe = ct.SoLuong,
                             KhoiHanh = chuyenDi.KhoiHanh.Value,
                             DaRuoc = ct.DaRuoc
                         }).Distinct().ToList();

            dtgDanhSachTC.DataSource = table;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }
    }
}
