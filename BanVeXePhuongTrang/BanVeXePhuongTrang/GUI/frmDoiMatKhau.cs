using BanVeXePhuongTrang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        int ma;
        public frmDoiMatKhau(int manv)
        {
            InitializeComponent();
            ma = manv;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                int id = ma;
                tblTaiKhoan tk = db.tblTaiKhoans.Where(t => t.MaNhanVien == id).SingleOrDefault();
                string MatKhauMoi = txtMatKhauMoi.Text;
                tk.MatKhau = MatKhauMoi;
                db.Entry(tk).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bttkhong_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.Text = "";
            txtMatKhauXacNhan.Text = "";
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            int MaNV = ma;
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblTaiKhoan tk = db.tblTaiKhoans.Where(t => t.MaNhanVien == MaNV).SingleOrDefault();
            txtTenNguoiDung.Text = tk.tblNhanVien.TenNhanVien.ToString();
            txtTenDangNhap.Text = tk.TenTaiKhoan.ToString();
        }


        private void txtMatKhauNew_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtMatKhauMoi.Text.Length > 15 || txtMatKhauMoi.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải từ 3 đến 15 ký tự");
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauXacNhan_Validating_1(object sender, CancelEventArgs e)
        {
            if (!txtMatKhauXacNhan.Text.Equals(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Mat Khẩu xác nhận không chính sác");
                txtMatKhauXacNhan.Focus();
            }
        }
    }
}
