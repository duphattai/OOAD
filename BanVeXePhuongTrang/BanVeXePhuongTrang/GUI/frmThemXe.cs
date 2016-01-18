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
using BanVeXePhuongTrang.BLL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThemXe : Form
    {
        public frmThemXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmThemXe_Load(object sender, EventArgs e)
        {
            BLL_XeKhach temp = new BLL_XeKhach();
            BLL_XeTrungChuyen xeTrungChuyen = new BLL_XeTrungChuyen();

            txtMaXeKhach.Text = temp.getLastestIndex().ToString();
            txtMaXeTrungChuyen.Text = xeTrungChuyen.getLastestIndex().ToString();

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbbTaiXeXK.DataSource = db.tblNhanViens.Where(t => t.tblLoaiNhanVien.MaLoaiNhanVien == 1).Select(t => t.TenNhanVien).ToList();
            cbbLoaiXe.DataSource = db.tblLoaiXes.Select(t => t.TenLoaiXe).ToList();

            cbbTuyenXe.DataSource = db.tblTuyenXes.Select(t => t.MaTuyen).ToList();
            cbbTuyenXe_SelectedIndexChanged(sender, e);

            cbbTaiXeXTC.DataSource = db.tblNhanViens.Where(t => t.tblLoaiNhanVien.MaLoaiNhanVien == 1).Select(t => t.TenNhanVien).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            // check tab selected
            if(tabControl.SelectedTab.Name == "tabXeKhach")
            {
                tblXeKhach xeKhach = new tblXeKhach();
                xeKhach.MaXe = int.Parse(txtMaXeKhach.Text.ToString());
                xeKhach.SoGhe = int.Parse(txtSoGhe.Text.ToString());
                xeKhach.MaLoaiXe = db.tblLoaiXes.Where(t => t.TenLoaiXe == cbbLoaiXe.SelectedItem.ToString()).SingleOrDefault().MaLoaiXe;
                xeKhach.MaTuyen = cbbTuyenXe.SelectedItem.ToString();
                xeKhach.MaTaiXe = db.tblNhanViens.Where(t => t.TenNhanVien == cbbTaiXeXK.SelectedItem.ToString()).SingleOrDefault().MaNhanVien;
                xeKhach.BienSoXe = txtBienSoXK.Text.ToString();


                BLL_XeKhach temp = new BLL_XeKhach();
                string message = temp.validateInput(xeKhach.MaXe, xeKhach.MaTaiXe, xeKhach.MaLoaiXe, xeKhach.BienSoXe, xeKhach.MaTuyen, xeKhach.SoGhe);
                if (string.IsNullOrEmpty(message))
                {
                    if (temp.canInsert(xeKhach.MaXe, xeKhach.BienSoXe))
                    {
                        db.tblXeKhaches.Add(xeKhach);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else
                    MessageBox.Show(message);
               
            }
            else 
            {
                tblXeTrungChuyen xe = new tblXeTrungChuyen();
                xe.MaXe = int.Parse(txtMaXeTrungChuyen.Text.ToString());
                xe.MaTaiXe = db.tblNhanViens.Where(t => t.TenNhanVien == cbbTaiXeXTC.SelectedItem.ToString()).SingleOrDefault().MaNhanVien;
                xe.BienSoXe = txtBienSoXTC.Text.ToString();
                xe.DiaDiemTrungChuyen = txtDiaDiem.Text.ToString();


                BLL_XeTrungChuyen temp = new BLL_XeTrungChuyen();
                string message = temp.validateInput(xe.MaXe, xe.MaTaiXe, xe.BienSoXe, xe.DiaDiemTrungChuyen);
                if(string.IsNullOrEmpty(message))
                {
                    if (temp.canInsert(xe.MaXe, xe.BienSoXe))
                    {
                        db.tblXeTrungChuyens.Add(xe);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else
                    MessageBox.Show(message);
            }

            btnTaoMoi_Click(sender, e);
        }

        private void cbbTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if(cbbTuyenXe.SelectedIndex >= 0)
            {
                tblTuyenXe tuyenXe = db.tblTuyenXes.Where(t => t.MaTuyen == cbbTuyenXe.SelectedItem.ToString()).SingleOrDefault();
                if (tuyenXe != null)
                    txtTuyenXe.Text = tuyenXe.tblBenXe.TenBenXe + "-" + tuyenXe.tblBenXe1.TenBenXe;
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            BLL_XeKhach temp = new BLL_XeKhach();
            txtMaXeKhach.Text = temp.getLastestIndex().ToString();
            txtBienSoXK.Text = "";
            txtSoGhe.Text = "";

            BLL_XeTrungChuyen xeTC = new BLL_XeTrungChuyen();
            txtMaXeTrungChuyen.Text = xeTC.getLastestIndex().ToString();
            txtBienSoXTC.Text = "";
            txtDiaDiem.Text = "";
        }
    }
}
