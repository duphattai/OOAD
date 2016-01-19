using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BanVeXePhuongTrang.GUI;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        static public string TenDangNhap;
        static public int MaNhanVien;

        public static DevComponents.DotNetBar.TabControl  m_Tab;
        public frmMain()
        {
            InitializeComponent();
        }

        #region truyền tham số từ form con

        int ma;
        public void laydulieu()
        {
            lbTenDangNhap.Text = TenDangNhap;
            ma = MaNhanVien;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (checkTab("Giơi thiệu") == false)
            {
                TabItem tab = tabControl.CreateTab("Giơi thiệu");
                tab.CloseButtonVisible = false;
                frmGioiThieu frm01 = new frmGioiThieu();
                frm01.Dock = DockStyle.Fill;
                frm01.FormBorderStyle = FormBorderStyle.None;
                frm01.TopLevel = false;
                tab.AttachedControl.Controls.Add(frm01);
                frm01.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }

            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                btDangNhap.Enabled = true;
                btDangXuat.Enabled = false;
                btDoiMatKhau.Enabled = false;                
                // MessageBox.Show("Chưa đăng nhập");
            }
            else
            {
                btDangNhap.Enabled = false;
                btDangXuat.Enabled = true;
                btDoiMatKhau.Enabled = true;                
                // MessageBox.Show("da đăng nhập");
            }
            lbthoigian.Text = Convert.ToDateTime(DateTime.Today).ToString("dd/MM/yyyy");


            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            laydulieu();
             
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                BatTat(false);
                btnTraCuu.Enabled = true;
                btnThoat.Enabled = true;
            }
            else
            {
                BatTat(true);
            }

            XuLyQuyenHan();
        }

        #region Su ly Bật Tắt
        public void     BatTat(Boolean xl)
        {
            rbpDanhMuc.Enabled = xl;
            rbpBaoCao.Enabled = xl;
            rbpThayDoi.Enabled = xl;
            rbpPhanQuyen.Enabled = xl;
            btnNhanLich.Enabled = xl;
            btnVe.Enabled = xl;
            btnDatVe.Enabled = xl;
            btnBaoCaoThang.Enabled = xl;
            btnBaoCaoNam.Enabled = xl;
        }
        #endregion

        #region xuly quyen han

        public void BatTatQTV()
        {
            rbpDanhMuc.Enabled = false;
            rbpTraCuu.Enabled = false;
            rbpBaoCao.Enabled = false;
            rbpThayDoi.Enabled = false;
            rbpPhanQuyen.Enabled = true;
            btnNhanLich.Enabled = false;
            btnVe.Enabled = false;
            btnDatVe.Enabled = false;
            btnTraCuu.Enabled = false;
            btnBaoCaoThang.Enabled = false;
            btnBaoCaoNam.Enabled = false;
        }

        public void BatTatBGD()
        {
            rbpDanhMuc.Enabled = false;
            rbpTraCuu.Enabled = true;
            rbpBaoCao.Enabled = false;
            rbpThayDoi.Enabled = true;
            rbpPhanQuyen.Enabled = false;
            btnNhanLich.Enabled = false;
            btnVe.Enabled = false;
            btnDatVe.Enabled = false;
            btnTraCuu.Enabled = true;
            btnBaoCaoThang.Enabled = false;
            btnBaoCaoNam.Enabled = false;
        }

        public void BatTatNV()
        {
            rbpDanhMuc.Enabled = true;
            rbpTraCuu.Enabled = true;
            rbpBaoCao.Enabled = true;
            rbpThayDoi.Enabled = false;
            rbpPhanQuyen.Enabled = false;
            btnNhanLich.Enabled = true;
            btnVe.Enabled = true;
            btnDatVe.Enabled = true;
            btnTraCuu.Enabled = true;
            btnBaoCaoThang.Enabled = true;
            btnBaoCaoNam.Enabled = true;
        }
        public void XuLyQuyenHan()
        {
            try {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblTaiKhoan tk = new tblTaiKhoan();
                tk = db.tblTaiKhoans.Where(t => t.MaNhanVien == MaNhanVien).SingleOrDefault();

                if (tk != null)
                {
                    if (tk.MaQuyen == 1)
                    {
                        BatTatQTV();
                    }
                    else if (tk.MaQuyen == 2)
                    {
                        BatTatNV();
                    }
                    else
                    {
                        BatTatBGD();
                    }

                }
            }
            catch { }
        }
        #endregion

        #region đăng nhập
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        public void DangNhap()
        {
            frmDangNhap f = new frmDangNhap();
            
            f.ShowDialog();
            laydulieu();
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                BatTat(false);
            }
            else
            {
                BatTat(true);
                btDangNhap.Enabled = false;
                btDangXuat.Enabled = true;
                btDoiMatKhau.Enabled = true;               
                XuLyQuyenHan();
            }
        }
        #endregion
           
        #region đăng xuất
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        public void DangXuat()
        {
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                btDangXuat.Enabled = false;
                btDoiMatKhau.Enabled = true;               
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    BatTat(false);
                    lbTenDangNhap.Text = "Chưa đăng nhập";                  
                    tabControl.Tabs.Clear();
                    //}

                    if (checkTab("Giơi thiệu") == false)
                    {
                        TabItem tab = tabControl.CreateTab("Giơi thiệu");
                        tab.CloseButtonVisible = false;
                        frmGioiThieu frm01 = new frmGioiThieu();
                        frm01.Dock = DockStyle.Fill;
                        frm01.FormBorderStyle = FormBorderStyle.None;
                        frm01.TopLevel = false;
                        tab.AttachedControl.Controls.Add(frm01);
                        frm01.Show();
                        tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
                        btDangXuat.Enabled = false;
                        btDoiMatKhau.Enabled = false;                        
                    }
                    btDangNhap.Enabled = true;                    
                    DangNhap();
                }
            }
        }
        #endregion

        #region đổi mật khẩu
        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(ma);
            frm.ShowDialog();
        }
        #endregion

        #region sự kiên thay đổi lbTenDangNhap
        private void lbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            btDangNhap.Enabled = false;
            btDangXuat.Enabled = true;
            btDoiMatKhau.Enabled = true;
        }
     
        #endregion

        #region nhân viên
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (checkTab("Tài khoản") == false)
            {
                 frmTaiKhoan form = new frmTaiKhoan();
                 AddTabControl(form, "Tài khoản");
            }
        }
        #endregion

        public void AddTabControl(Form form, string nameTab)
        {
            TabItem tab = tabControl.CreateTab(nameTab);
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            tab.AttachedControl.Controls.Add(form);
            form.Show();
            tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            m_Tab = tabControl;
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tabControl_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        private void btLichChuyenDi_Click(object sender, EventArgs e)
        {
            if (checkTab("Lịch Chuyến Đi") == false)
            {
                frmLichChuyenDi form = new frmLichChuyenDi();
                AddTabControl(form, "Lịch Chuyến Đi");
            }
        }

        private void btVeXe_Click(object sender, EventArgs e)
        {
            if (checkTab("Vé Xe") == false)
            {
                frmVeXe form = new frmVeXe();
                AddTabControl(form, "Vé Xe");
            }
        }

        private void btDSDatVe_Click(object sender, EventArgs e)
        {
            if (checkTab("Danh Sách Đặt Vé") == false)
            {
                frmDanhSachDatVe form = new frmDanhSachDatVe();
                AddTabControl(form, "Danh Sách Đặt Vé");
            }
        }

        private void btTraCuuChuyenDi_Click(object sender, EventArgs e)
        {
            if (checkTab("Tra Cứu Chuyến Đi") == false)
            {
                frmTraCuuChuyenDi form = new frmTraCuuChuyenDi();
                AddTabControl(form, "Tra Cứu Chuyến Đi");
            }
        }

        private void btDTThang_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Doanh Thu Tháng") == false)
            {
                frmBCDoanhThuThang form = new frmBCDoanhThuThang();
                AddTabControl(form, "Báo Cáo Doanh Thu Tháng");
            }
        }

        private void btDTNam_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Doanh Thu Năm") == false)
            {
                frmBCDoanhThuNam form = new frmBCDoanhThuNam();
                AddTabControl(form, "Báo Cáo Doanh Thu Năm");
            }
          
        }

        private void btQuyDinh1_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 1") == false)
            {
                frmThayDoiQD1 form = new frmThayDoiQD1();
                AddTabControl(form, "Thay Đổi Quy Định 1");
            }
        }

        private void btQuyDinh2_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 2") == false)
            {
                frmThayDoiQD2 form = new frmThayDoiQD2();
                AddTabControl(form, "Thay Đổi Quy Định 2");
            }
        }

        private void btQuyDinh3_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 3") == false)
            {
                frmThayDoiQD2 form = new frmThayDoiQD2();
                AddTabControl(form, "Thay Đổi Quy Định 3");
            }
        }

        private void btQLChuyenDi_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Chuyến Đi") == false)
            {
                frmQuanLyChuyenDi form = new frmQuanLyChuyenDi();
                AddTabControl(form, "Quản Lý Chuyến Đi");
            }
        }

        private void btQLBenXe_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Bến Xe") == false)
            {
                frmQuanLyBenXe form = new frmQuanLyBenXe();
                AddTabControl(form, "Quản Lý Bến Xe");
            }
        }

        private void btQLTuyenXe_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Tuyến Xe") == false)
            {
                frmQuanLyTuyenXe form = new frmQuanLyTuyenXe();
                AddTabControl(form, "Quản Lý Tuyến Xe");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_Tab.Tabs.Count; i++)
                {
                    m_Tab.Tabs.RemoveAt(i);
                    i--;
                }
            }
            catch { }


            this.Close();
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            btLichChuyenDi_Click(sender, e);
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            btVeXe_Click(sender, e);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            btDSDatVe_Click(sender, e);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            btTraCuuChuyenDi_Click(sender, e);
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            btDTThang_Click(sender, e);
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            btDTNam_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btThoat_Click(sender, e);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin form = new frmThongTin();
            form.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (checkTab("Nhân Viên") == false)
            {
                frmNhanVien form = new frmNhanVien();
                AddTabControl(form, "Nhân Viên");
            }
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Xe") == false)
            {
                frmQuanLyXe form = new frmQuanLyXe();
                AddTabControl(form, "Quản Lý Xe");
            }
        }

        private void btnQLTrungChuyen_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Trung Chuyển") == false)
            {
                frmQuanLyTrungChuyen form = new frmQuanLyTrungChuyen();
                AddTabControl(form, "Quản Lý Trung Chuyển");
            }
        }

    }
}