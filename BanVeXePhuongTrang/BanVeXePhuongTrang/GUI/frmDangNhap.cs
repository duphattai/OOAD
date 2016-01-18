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
    public partial class frmDangNhap : Form
    {
        //public delegate void TruyenLaiDuLieu(string MaNhanVien, string data);
        //public static TruyenLaiDuLieu truyendulieu;
        public frmDangNhap()
        {
            InitializeComponent();
            frmMain.TenDangNhap = "Chưa đăng nhập";
            frmMain.MaNhanVien = 0;
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin");
                txtTenDangNhap.Focus();
            }
            else
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblTaiKhoan tk = db.tblTaiKhoans.Where(t => t.TenTaiKhoan == TenDangNhap && t.MatKhau == MatKhau).SingleOrDefault();
           
                if (tk != null)
                {
                    
                    MessageBox.Show("Đang nhập thành công");
                    this.DialogResult = DialogResult.OK;
                    //string dlCon = dr["TenNhanVien"].ToString();
                    string dlCon = tk.tblNhanVien.TenNhanVien.ToString();
                    int MaNV =int.Parse(tk.MaNhanVien.ToString());
                    this.DialogResult = DialogResult.OK;
                    frmMain.MaNhanVien = MaNV;
                    frmMain.TenDangNhap = dlCon;

                    frmMain f = new frmMain();
                    f.BatTat(true);
                }
                else
                {
                    MessageBox.Show("\tĐang nhập thất bại! \nVui lòng kiểm tra lại thông tin đăng nhập!");
                    txtTenDangNhap.Focus();
                }
            }
        }

        private void txtMatKhau_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.Focus();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
