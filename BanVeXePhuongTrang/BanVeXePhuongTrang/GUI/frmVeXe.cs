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
    public partial class frmVeXe : Form
    {
       
        public frmVeXe()
        {
            InitializeComponent();  
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }


        private void btnLapVe_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            int maChuyen = int.Parse(cbbMaChuyenDi.SelectedItem.ToString());
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();

            frmThongTinVe form = new frmThongTinVe(chuyenDi, new tblPhieuDatCho());
            form.Show();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        
        void    setPropertiesCheckBox(Color color, bool enable, int number)
        {
            switch(number)
            {
                case 1:
                    XeKhach_Cb1.TextColor = color;
                    XeKhach_Cb1.Enabled = enable;
                    break;
                case 2:
                    XeKhach_Cb2.TextColor = color;
                    XeKhach_Cb2.Enabled = enable;
                    break;
                case 3:
                    XeKhach_Cb3.TextColor = color;
                    XeKhach_Cb3.Enabled = enable;
                    break;
                case 4:
                    XeKhach_Cb4.TextColor = color;
                    XeKhach_Cb4.Enabled = enable;
                    break;
                case 5:
                    XeKhach_Cb5.TextColor = color;
                    XeKhach_Cb5.Enabled = enable;
                    break;
                case 6:
                    XeKhach_Cb6.TextColor = color;
                    XeKhach_Cb6.Enabled = enable;
                    break;
                case 7:
                    XeKhach_Cb7.TextColor = color;
                    XeKhach_Cb7.Enabled = enable;
                    break;
                case 8:
                    XeKhach_Cb8.TextColor = color;
                    XeKhach_Cb8.Enabled = enable;
                    break;
                case 9:
                    XeKhach_Cb9.TextColor = color;
                    XeKhach_Cb9.Enabled = enable;
                    break;
                case 10:
                    XeKhach_Cb10.TextColor = color;
                    XeKhach_Cb10.Enabled = enable;
                    break;
                case 11:
                    XeKhach_Cb11.TextColor = color;
                    XeKhach_Cb11.Enabled = enable;
                    break;
                case 12:
                    XeKhach_Cb12.TextColor = color;
                    XeKhach_Cb12.Enabled = enable;
                    break;
                case 13:
                    XeKhach_Cb13.TextColor = color;
                    XeKhach_Cb13.Enabled = enable;
                    break;
                case 14:
                    XeKhach_Cb14.TextColor = color;
                    XeKhach_Cb14.Enabled = enable;
                    break;
                case 15:
                    XeKhach_Cb15.TextColor = color;
                    XeKhach_Cb15.Enabled = enable;
                    break;
                case 16:
                    XeKhach_Cb16.TextColor = color;
                    XeKhach_Cb16.Enabled = enable;
                    break;
                case 17:
                    XeKhach_Cb17.TextColor = color;
                    XeKhach_Cb17.Enabled = enable;
                    break;
                case 18:
                    XeKhach_Cb18.TextColor = color;
                    XeKhach_Cb18.Enabled = enable;
                    break;
                case 19:
                    XeKhach_Cb19.TextColor = color;
                    XeKhach_Cb19.Enabled = enable;
                    break;
                case 20:
                    XeKhach_Cb20.TextColor = color;
                    XeKhach_Cb20.Enabled = enable;
                    break;
                case 21:
                    XeKhach_Cb21.TextColor = color;
                    XeKhach_Cb21.Enabled = enable;
                    break;
                case 22:
                    XeKhach_Cb22.TextColor = color;
                    XeKhach_Cb22.Enabled = enable;
                    break;
                case 23:
                    XeKhach_Cb23.TextColor = color;
                    XeKhach_Cb23.Enabled = enable;
                    break;
                case 24:
                    XeKhach_Cb24.TextColor = color;
                    XeKhach_Cb24.Enabled = enable;
                    break;
                case 25:
                    XeKhach_Cb25.TextColor = color;
                    XeKhach_Cb25.Enabled = enable;
                    break;
                case 26:
                    XeKhach_Cb26.TextColor = color;
                    XeKhach_Cb26.Enabled = enable;
                    break;
                case 27:
                    XeKhach_Cb27.TextColor = color;
                    XeKhach_Cb27.Enabled = enable;
                    break;
                case 28:
                    XeKhach_Cb28.TextColor = color;
                    XeKhach_Cb28.Enabled = enable;
                    break;
                case 29:
                    XeKhach_Cb29.TextColor = color;
                    XeKhach_Cb29.Enabled = enable;
                    break;
                case 30:
                    XeKhach_Cb30.TextColor = color;
                    XeKhach_Cb30.Enabled = enable;
                    break;
                case 31:
                    XeKhach_Cb31.TextColor = color;
                    XeKhach_Cb31.Enabled = enable;
                    break;
                case 32:
                    XeKhach_Cb32.TextColor = color;
                    XeKhach_Cb32.Enabled = enable;
                    break;
                case 33:
                    XeKhach_Cb33.TextColor = color;
                    XeKhach_Cb33.Enabled = enable;
                    break;
                case 34:
                    XeKhach_Cb34.TextColor = color;
                    XeKhach_Cb34.Enabled = enable;
                    break;
                case 35:
                    XeKhach_Cb35.TextColor = color;
                    XeKhach_Cb35.Enabled = enable;
                    break;
                case 36:
                    XeKhach_Cb36.TextColor = color;
                    XeKhach_Cb36.Enabled = enable;
                    break;
                case 37:
                    XeKhach_Cb37.TextColor = color;
                    XeKhach_Cb37.Enabled = enable;
                    break;
                case 38:
                    XeKhach_Cb38.TextColor = color;
                    XeKhach_Cb38.Enabled = enable;
                    break;
                case 39:
                    XeKhach_Cb39.TextColor = color;
                    XeKhach_Cb39.Enabled = enable;
                    break;
                case 40:
                    XeKhach_Cb40.TextColor = color;
                    XeKhach_Cb40.Enabled = enable;
                    break;
                case 41:
                    XeKhach_Cb41.TextColor = color;
                    XeKhach_Cb41.Enabled = enable;
                    break;
                case 42:
                    XeKhach_Cb42.TextColor = color;
                    XeKhach_Cb42.Enabled = enable;
                    break;
                case 43:
                    XeKhach_Cb43.TextColor = color;
                    XeKhach_Cb43.Enabled = enable;
                    break;
                case 44:
                    XeKhach_Cb44.TextColor = color;
                    XeKhach_Cb44.Enabled = enable;
                    break;
                case 45:
                    XeKhach_Cb45.TextColor = color;
                    XeKhach_Cb45.Enabled = enable;
                    break;
                case 46:
                    XeKhach_Cb46.TextColor = color;
                    XeKhach_Cb46.Enabled = enable;
                    break;
                case 47:
                    XeKhach_Cb47.TextColor = color;
                    XeKhach_Cb47.Enabled = enable;
                    break;
                case 48:
                    XeKhach_Cb48.TextColor = color;
                    XeKhach_Cb48.Enabled = enable;
                    break;
                case 49:
                    XeKhach_Cb49.TextColor = color;
                    XeKhach_Cb49.Enabled = enable;
                    break;
            }
        }

        private void cbMaChuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            int maChuyen = int.Parse(cbbMaChuyenDi.SelectedItem.ToString());
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();
            txtTuyen.Text = chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe.TenBenXe.ToString() + "-" + chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe1.TenBenXe.ToString();
            txtKhoiHanh.Text = chuyenDi.KhoiHanh.Value.ToString();
            txtGia.Text = chuyenDi.DonGia.ToString();

            foreach (var item in db.tblChiTietPhieuDatChoes.Where(t => t.MaChuyenDi == maChuyen).ToList())
            {
                if (item.LayVe.Value)
                    setPropertiesCheckBox(Color.FromName("Red"), false, int.Parse(item.ViTriGhe.ToString()));
                else
                    setPropertiesCheckBox(Color.FromName("Yellow"), false, int.Parse(item.ViTriGhe.ToString()));
            }

            tabXeThuong.Visible = tabXeGiuongNam.Visible = true;

            if (chuyenDi.tblXeKhach.MaLoaiXe == 1) // ghế ngồi
                tabXeGiuongNam.Visible = false;
            else
                tabXeThuong.Visible = false;
        }

        private void frmVeXe_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbbMaChuyenDi.DataSource = db.tblChuyenDis.Select(t => t.MaChuyenDi).ToList();
        }
    }
}
