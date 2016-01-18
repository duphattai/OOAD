using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmQuanLyBenXe : Form
    {
        public frmQuanLyBenXe()
        {
            InitializeComponent();
            dtgDanhSachBen.AutoGenerateColumns = false;
        }

        private void frmQuanLyBenXe_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDanhSachBen.DataSource = new QUANLYXEKHACHEntities().tblBenXes.ToList<tblBenXe>();
            }catch
            { }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaBenXe form = new frmXoaBenXe();
            form.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaBenXe form = new frmSuaBenXe();
            form.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemBenXe form = new frmThemBenXe();
            form.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmQuanLyBenXe_Load(sender, e);
        }
    }
}
