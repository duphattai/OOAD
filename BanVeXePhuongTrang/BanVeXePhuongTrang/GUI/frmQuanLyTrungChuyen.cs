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
    public partial class frmQuanLyTrungChuyen : Form
    {
        public frmQuanLyTrungChuyen()
        {
            InitializeComponent();

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbbXeTrungChuyen.DataSource = db.tblXeTrungChuyens.Select(t => new { BienSo = t.BienSoXe, DiaDiem = t.DiaDiemTrungChuyen }).ToList();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            
            DateTime timeNow = DateTime.Now;
            var table = (from chuyenDi in db.tblChuyenDis
                         join ctPhieu in db.tblChiTietPhieuDatChoes on chuyenDi.MaChuyenDi equals ctPhieu.MaChuyenDi
                         join phieu in db.tblPhieuDatChoes on ctPhieu.MaPhieu equals phieu.MaPhieu
                         where chuyenDi.KhoiHanh.Value > timeNow && chuyenDi.KhoiHanh.Value < dtpKhoiHanh.Value && string.IsNullOrEmpty(phieu.TrungChuyen) == false
                         select new
                         {
                             HoTen = phieu.HoTen,
                             MaPhieu = phieu.MaPhieu,
                             SDT = phieu.DienThoai,
                             DiaDiem = phieu.TrungChuyen,
                             SoVe = phieu.tblChiTietPhieuDatChoes.Count
                         }).Distinct();


            dtgKhachHang.Rows.Clear();
            foreach(var item in table)
                dtgKhachHang.Rows.Add(item.HoTen, item.MaPhieu, item.SDT, item.DiaDiem, item.SoVe);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            tblChiTietTrungChuyen temp = new tblChiTietTrungChuyen();
            temp.MaPhieu = int.Parse(dtgKhachHang.CurrentRow.Cells["MaPhieu_KH"].Value.ToString());
            dynamic selectedItem = cbbXeTrungChuyen.SelectedItem;
            string bienSoXe = selectedItem.BienSo;
            temp.SoLuong = int.Parse(dtgKhachHang.CurrentRow.Cells["SoVe_KH"].Value.ToString());

            try
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblXeTrungChuyen xeTC = db.tblXeTrungChuyens.Where(t => t.BienSoXe == bienSoXe).SingleOrDefault();
                if(xeTC != null)
                {
                    temp.MaXe = xeTC.MaXe;
                    db.tblChiTietTrungChuyens.Add(temp);
                    db.SaveChanges();

                    dtgDanhSachTC.Rows.Add(dtgKhachHang.CurrentRow.Cells["HoTen_KH"].Value,
                                       dtgKhachHang.CurrentRow.Cells["MaPhieu_KH"].Value,
                                       dtgKhachHang.CurrentRow.Cells["SDT_KH"].Value,
                                       dtgKhachHang.CurrentRow.Cells["DiaDiem_KH"].Value,
                                       dtgKhachHang.CurrentRow.Cells["SoVe_KH"].Value);
                    dtgKhachHang.Rows.RemoveAt(dtgKhachHang.CurrentRow.Index);    
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }         
        }

        private void cbbXeTrungChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            dynamic selectedItem = cbbXeTrungChuyen.SelectedItem;
            string bienSo = selectedItem.BienSo;

            var table = (from ct in db.tblChiTietTrungChuyens
                         join phieu in db.tblPhieuDatChoes on ct.MaPhieu equals phieu.MaPhieu
                         join xe in db.tblXeTrungChuyens on ct.MaXe equals xe.MaXe
                         where xe.BienSoXe == bienSo
                         select new
                         {
                             HoTen = phieu.HoTen,
                             SDT = phieu.DienThoai,
                             DiaDiem = phieu.TrungChuyen,
                             SoVe = ct.SoLuong,
                             MaPhieu = phieu.MaPhieu
                         }).ToList();

            dtgDanhSachTC.Rows.Clear();
            foreach (var item in table)
                dtgDanhSachTC.Rows.Add(item.HoTen, item.MaPhieu, item.SDT, item.DiaDiem, item.SoVe);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            
            int maPhieu = int.Parse(dtgDanhSachTC.CurrentRow.Cells["MaPhieu"].Value.ToString());
            dynamic selectedItem = cbbXeTrungChuyen.SelectedItem;
            string bienSo = selectedItem.BienSo;
            tblXeTrungChuyen xeTC = db.tblXeTrungChuyens.Where(t => t.BienSoXe == bienSo).SingleOrDefault();
            if(xeTC != null)
            { 
                tblChiTietTrungChuyen temp = db.tblChiTietTrungChuyens.Where(t => t.MaXe == xeTC.MaXe && t.MaPhieu == maPhieu).SingleOrDefault();
                if (temp != null)
                    db.tblChiTietTrungChuyens.Remove(temp);
                db.SaveChanges();

                // thêm vào datagridview
                dtgKhachHang.Rows.Add(dtgDanhSachTC.CurrentRow.Cells["HoTen"].Value,
                                        dtgDanhSachTC.CurrentRow.Cells["MaPhieu"].Value,
                                        dtgDanhSachTC.CurrentRow.Cells["SDT"].Value,
                                        dtgDanhSachTC.CurrentRow.Cells["DiaDiem"].Value,
                                        dtgDanhSachTC.CurrentRow.Cells["SoVe"].Value);
                dtgDanhSachTC.Rows.RemoveAt(dtgDanhSachTC.CurrentRow.Index);
            }
        }
    }
}
