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
    public partial class frmQuanLyTuyenXe : Form
    {
        public frmQuanLyTuyenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemTuyenXe form = new frmThemTuyenXe();
            form.ShowDialog();
            frmQuanLyTuyenXe_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaTuyenXe form = new frmXoaTuyenXe();
            form.ShowDialog();
            frmQuanLyTuyenXe_Load(sender, e);
        }


        private void frmQuanLyTuyenXe_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDanhSachTuyen.Rows.Clear();
                foreach (var item in new QUANLYXEKHACHEntities().tblTuyenXes.ToList())
                    dtgDanhSachTuyen.Rows.Add(item.MaTuyen, item.tblBenXe.TenBenXe, item.tblBenXe1.TenBenXe);
            }
            catch { }   
        }

        private void dtgDanhSachTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maTuyen = dtgDanhSachTuyen.Rows[e.RowIndex].Cells["Matuyen"].Value.ToString();

                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                dtgChiTietTuyen.Rows.Clear();
                foreach (var item in db.tblChiTietTuyens.Where(t => t.MaTuyen == maTuyen).ToList())
                {
                    dtgChiTietTuyen.Rows.Add(item.tblBenXe.TenBenXe,
                                            item.ThoiGianDung,
                                            item.GhiChu);
                }

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maTuyen = dtgDanhSachTuyen.CurrentRow.Cells["MaTuyen"].Value.ToString();
            tblTuyenXe tuyenXe = new QUANLYXEKHACHEntities().tblTuyenXes.Where(t => t.MaTuyen == maTuyen).SingleOrDefault();
            frmThemTuyenXe form = new frmThemTuyenXe(tuyenXe);
            form.ShowDialog();
            frmQuanLyTuyenXe_Load(sender, e);
        }

    }
}
