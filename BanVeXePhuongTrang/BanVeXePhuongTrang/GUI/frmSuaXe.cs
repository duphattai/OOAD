using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang.BLL;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmSuaXe : Form
    {
        public frmSuaXe(tblXeKhach xe)
        {
            InitializeComponent();
            tabXeTrungChuyen.Visible = false;

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            txtMaXeKhach.Text = xe.MaXe.ToString();
            
            cbbTaiXeXK.DataSource = db.tblNhanViens.Where(t => t.MaLoaiNhanVien == 1).Select(t => t.TenNhanVien).ToList();
            cbbTaiXeXK.SelectedItem = xe.tblNhanVien.TenNhanVien;

            cbbLoaiXe.DataSource = db.tblLoaiXes.Select(t => t.TenLoaiXe).ToList();
            cbbLoaiXe.SelectedItem = xe.tblLoaiXe.TenLoaiXe;

            txtBienSoXK.Text = xe.BienSoXe;

            cbbMaTuyen.DataSource = db.tblTuyenXes.Select(t => t.MaTuyen).ToList();
            cbbMaTuyen.SelectedItem = xe.MaTuyen;
            txtTuyenXe.Text = xe.tblTuyenXe.tblBenXe.TenBenXe + "-" + xe.tblTuyenXe.tblBenXe1.TenBenXe;

            txtSoGhe.Text = xe.SoGhe.ToString();
        }

        public frmSuaXe(tblXeTrungChuyen xe)
        {
            InitializeComponent();
            tabXeKhach.Visible = false;

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            txtMaXeTC.Text = xe.MaXe.ToString();
            cbbTaiXeXTC.DataSource = db.tblNhanViens.Where(t => t.MaLoaiNhanVien == 1).Select(t => t.TenNhanVien).ToList();
            cbbTaiXeXTC.SelectedItem = xe.tblNhanVien.TenNhanVien;

            txtBienSoXTC.Text = xe.BienSoXe;

            txtDiaDiem.Text = xe.DiaDiemTrungChuyen;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if(tabXeKhach.Visible)
            {
                int maXe = int.Parse(txtMaXeKhach.Text.ToString());

                tblXeKhach xeKhach = db.tblXeKhaches.Where(t=>t.MaXe == maXe).SingleOrDefault();
                xeKhach.SoGhe = int.Parse(txtSoGhe.Text.ToString());
                xeKhach.MaLoaiXe = db.tblLoaiXes.Where(t => t.TenLoaiXe == cbbLoaiXe.SelectedItem.ToString()).SingleOrDefault().MaLoaiXe;
                xeKhach.MaTuyen = cbbMaTuyen.SelectedItem.ToString();
                xeKhach.MaTaiXe = db.tblNhanViens.Where(t => t.TenNhanVien == cbbTaiXeXK.SelectedItem.ToString()).SingleOrDefault().MaNhanVien;
                xeKhach.BienSoXe = txtBienSoXK.Text.ToString();


                BLL_XeKhach temp = new BLL_XeKhach();
                string message = temp.validateInput(xeKhach.MaXe, xeKhach.MaTaiXe, xeKhach.MaLoaiXe, xeKhach.BienSoXe, xeKhach.MaTuyen, xeKhach.SoGhe);
                if (string.IsNullOrEmpty(message))
                {
                    if (temp.canUpdate(xeKhach.MaXe, xeKhach.BienSoXe))
                    {
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
                else
                    MessageBox.Show(message);
            }
            else
            {
                int maXe = int.Parse(txtMaXeTC.Text.ToString());
                
                tblXeTrungChuyen xe = db.tblXeTrungChuyens.Where(t=>t.MaXe == maXe).SingleOrDefault();
                xe.MaTaiXe = db.tblNhanViens.Where(t => t.TenNhanVien == cbbTaiXeXTC.SelectedItem.ToString()).SingleOrDefault().MaNhanVien;
                xe.BienSoXe = txtBienSoXTC.Text.ToString();
                xe.DiaDiemTrungChuyen = txtDiaDiem.Text.ToString();


                BLL_XeTrungChuyen temp = new BLL_XeTrungChuyen();
                string message = temp.validateInput(xe.MaXe, xe.MaTaiXe, xe.BienSoXe, xe.DiaDiemTrungChuyen);
                if (string.IsNullOrEmpty(message))
                {
                    if (temp.canUpdate(xe.MaXe, xe.BienSoXe))
                    {
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
                else
                    MessageBox.Show(message);
            }
        }

        private void cbbMaTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (cbbMaTuyen.SelectedIndex >= 0)
            {
                tblTuyenXe tuyenXe = db.tblTuyenXes.Where(t => t.MaTuyen == cbbMaTuyen.SelectedItem.ToString()).SingleOrDefault();
                if (tuyenXe != null)
                    txtTuyenXe.Text = tuyenXe.tblBenXe.TenBenXe + "-" + tuyenXe.tblBenXe1.TenBenXe;
            }
        }
    }
}
