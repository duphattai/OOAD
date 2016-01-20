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
        bool timDatVe;

        public frmDanhSachDatVe()
        {
            InitializeComponent();
            cbbTinhTrangVe.SelectedIndex = 0;
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

                timDatVe = cbbTinhTrangVe.SelectedIndex == 0 ? false : true;

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
                                  where tuyenXe.MaBenXeDi == benXeDi.MaBenXe && tuyenXe.MaBenXeDen == benXeDen.MaBenXe && ctPhieu.LayVe == timDatVe && (phieuDatCho.HoTen == txtHoten.Text || phieuDatCho.DienThoai.ToString().Contains(dienThoai.ToString())) 
                                  select new
                                  {
                                      HoTen = phieuDatCho.HoTen,
                                      Tuyen = xeDi.TenBenXe + "-" + xeDen.TenBenXe,
                                      DienThoai = phieuDatCho.DienThoai,
                                      TrungChuyen = phieuDatCho.TrungChuyen,
                                      KhoiHanh = chuyenDi.KhoiHanh,
                                      ViTriGhe = ctPhieu.ViTriGhe,
                                      LayVe = ctPhieu.LayVe,
                                      MaCTPhieu = ctPhieu.MaCTPhieu
                                  }).ToList();

                if (entryPoint.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy");
                    return;
                }
                   
                dtgDanhSachVe.Rows.Clear();
                foreach(var item in entryPoint)
                    dtgDanhSachVe.Rows.Add( item.HoTen, item.MaCTPhieu, item.Tuyen, item.DienThoai, item.TrungChuyen, item.KhoiHanh, item.ViTriGhe, item.LayVe);
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            List<tblChiTietPhieuDatCho> listCTPhieu = new List<tblChiTietPhieuDatCho>();
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            
            // tìm các vé đặt chỗ - LayVe == false => if LayVe == true -> đã cập nhật
            for(int i = 0; i < dtgDanhSachVe.RowCount; i++)
            {
                if(bool.Parse(dtgDanhSachVe.Rows[i].Cells["LayVe"].Value.ToString()) != timDatVe)
                {
                    int maCTPhieu = int.Parse(dtgDanhSachVe.Rows[i].Cells["MaCTPhieu"].Value.ToString());
                    tblChiTietPhieuDatCho phieu = db.tblChiTietPhieuDatChoes.Where(t => t.MaCTPhieu == maCTPhieu).SingleOrDefault();
                    if (phieu != null)
                    {
                        phieu.LayVe = !timDatVe;
                        listCTPhieu.Add(phieu);
                    }     
                }
            }

            DialogResult result = MessageBox.Show("Dữ liệu có sự thay đổi, bản muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                db.SaveChanges();
                MessageBox.Show("Thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maCTPhieu = int.Parse(dtgDanhSachVe.CurrentRow.Cells["MaCTPhieu"].Value.ToString());
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblChiTietPhieuDatCho ctPhieu = db.tblChiTietPhieuDatChoes.Where(t => t.MaCTPhieu == maCTPhieu).SingleOrDefault();
                if (ctPhieu != null)
                    db.tblChiTietPhieuDatChoes.Remove(ctPhieu);
                db.SaveChanges();
                MessageBox.Show("Thành công");
            }
        }
        
    }
}
