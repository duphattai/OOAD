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

        const string idGheThuong = "gheThuong";
        const string idGheNam = "gheNam";
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

            frmThongTinVe form = new frmThongTinVe(chuyenDi);
            form.ShowDialog();

            cbMaChuyenDi_SelectedIndexChanged(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        void    capNhatTinhTrangGhe(string ghe, Color color, Control control)
        {
            if(control.Controls[ghe] is Label)
            {
                Label label = (Label)control.Controls[ghe];
                label.BackColor = color;
            }
        }

        void    khoiPhucTinhTrangGhe()
        {
            // Dành cho xe ghế ngồi
            for(int i = 1; i < 50; i++)
                capNhatTinhTrangGhe(idGheThuong + i, Color.White, pnlXeThuong);

            // Danh cho xe ghe nam
            for (int i = 1; i < 41; i++)
                capNhatTinhTrangGhe(idGheNam + i, Color.White, pnlGiuongNam);
        }

        private void cbMaChuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoiPhucTinhTrangGhe();

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            int maChuyen = int.Parse(cbbMaChuyenDi.SelectedItem.ToString());
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();
            txtTuyen.Text = chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe.TenBenXe.ToString() + "-" + chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe1.TenBenXe.ToString();
            txtKhoiHanh.Text = chuyenDi.KhoiHanh.Value.ToString();
            txtGia.Text = chuyenDi.DonGia.ToString();
         
            foreach (var item in chuyenDi.tblChiTietPhieuDatChoes.ToList())
            {
                if(chuyenDi.tblXeKhach.MaLoaiXe == 1) // ghế ngồi
                {
                    if (item.LayVe.Value)
                        capNhatTinhTrangGhe(idGheThuong + item.ViTriGhe, Color.Red, pnlXeThuong);
                    else
                        capNhatTinhTrangGhe(idGheThuong + item.ViTriGhe, Color.Green, pnlXeThuong);
                }
                else
                {
                    if (item.LayVe.Value)
                        capNhatTinhTrangGhe(idGheNam + item.ViTriGhe, Color.Red, pnlGiuongNam);
                    else
                        capNhatTinhTrangGhe(idGheNam + item.ViTriGhe, Color.Green, pnlGiuongNam);
                }
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
