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
using BanVeXePhuongTrang.DAL;
using System.Security.Cryptography;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            frmMain.TenDangNhap = "Chưa đăng nhập";
            frmMain.MaNhanVien = 0;
        }

        private string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura).Replace("-", "").ToLower();
            }
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try{
                string TenDangNhap = txtTenDangNhap.Text;
                string MatKhau = MaHoaMD5(txtMatKhau.Text);

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
                        string dlCon = tk.tblNhanVien.TenNhanVien.ToString();
                        int MaNV = int.Parse(tk.MaNhanVien.ToString());
                        frmMain.MaNhanVien = MaNV;
                        frmMain.TenDangNhap = dlCon;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("\tĐang nhập thất bại! \nVui lòng kiểm tra lại thông tin đăng nhập!");
                        txtTenDangNhap.Focus();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("\tĐang nhập thất bại! \nVui lòng kiểm tra lại dữ liệu!");
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
