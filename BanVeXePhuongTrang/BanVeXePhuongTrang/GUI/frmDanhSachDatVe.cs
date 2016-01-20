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
    public partial class frmDanhSachDatVe : Form
    {
        public frmDanhSachDatVe()
        {
            InitializeComponent();
        }

        private void frmDanhSachDatVe_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            cbbBenXeDen.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
            cbbBenXeDi.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                // mã tuyến
                tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDi.SelectedItem.ToString()).SingleOrDefault();
                tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDen.SelectedItem.ToString()).SingleOrDefault();
                int dienThoai;
                int.TryParse(txtDienThoai.Text.ToString(), out dienThoai);

                var entryPoint = (from tuyenXe in db.tblTuyenXes
                                  join xeDi in db.tblBenXes on tuyenXe.MaBenXeDi equals xeDi.MaBenXe
                                  join xeDen in db.tblBenXes on tuyenXe.MaBenXeDen equals xeDen.MaBenXe
                                  join xe in db.tblXeKhaches on tuyenXe.MaTuyen equals xe.MaTuyen
                                  join chuyenDi in db.tblChuyenDis on xe.MaXe equals chuyenDi.MaXe
                                  join ctPhieu in db.tblChiTietPhieuDatChoes on chuyenDi.MaChuyenDi equals ctPhieu.MaChuyenDi
                                  join phieuDatCho in db.tblPhieuDatChoes on ctPhieu.MaPhieu equals phieuDatCho.MaPhieu
                                  where tuyenXe.MaBenXeDi == benXeDi.MaBenXe && tuyenXe.MaBenXeDen == benXeDen.MaBenXe && (phieuDatCho.HoTen == txtHoten.Text || phieuDatCho.DienThoai.ToString().Contains(dienThoai.ToString())) 
                                  select new
                                  {
                                      HoTen = phieuDatCho.HoTen,
                                      Tuyen = xeDi.TenBenXe + "-" + xeDen.TenBenXe,
                                      DienThoai = phieuDatCho.DienThoai,
                                      TrungChuyen = phieuDatCho.TrungChuyen,
                                      KhoiHanh = chuyenDi.KhoiHanh,
                                  }).ToList();

               dtgDanhSachVe.DataSource = entryPoint;
                    
            }
            catch { }
            
        }
        
    }
}
