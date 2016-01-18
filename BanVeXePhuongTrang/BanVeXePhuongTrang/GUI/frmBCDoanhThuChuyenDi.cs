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
    public partial class frmBCDoanhThuChuyenDi : Form
    {
        public frmBCDoanhThuChuyenDi()
        {
            InitializeComponent();
        }

        private void frmBCDoanhThuChuyenDi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuChuyenDi' table. You can move, or remove it, as needed.
            this.tblBaoCaoDoanhThuChuyenDiTableAdapter.Fill(this.qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuChuyenDi);
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet1.tblBaoCaoDoanhThuChuyenDi' table. You can move, or remove it, as needed.
            
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            this.tblBaoCaoDoanhThuChuyenDiTableAdapter.Fill(this.qUANLYXEKHACHDataSet1.tblBaoCaoDoanhThuChuyenDi);
            reportViewer1.RefreshReport();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }
    }
}
