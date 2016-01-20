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
using Microsoft.Reporting.WinForms;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmBCDoanhThuThang : Form
    {
        public frmBCDoanhThuThang()
        {
            InitializeComponent();            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuChuyenDi' table. You can move, or remove it, as needed.
            this.tblBaoCaoDoanhThuChuyenDiTableAdapter.Fill(this.qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuChuyenDi, decimal.Parse(cbThang.SelectedItem.ToString()), decimal.Parse(cbNam.SelectedItem.ToString()));
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet1.tblBaoCaoDoanhThuChuyenDi' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }

        private void frmBCDoanhThuThang_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                cbThang.Items.Add(i);
            }
            for (int i = 2010; i < DateTime.Now.Year + 1; i++)
            {
                cbNam.Items.Add(i);
            }
            cbThang.SelectedIndex = 0;
            cbNam.SelectedIndex = 0;          
        }
    }
}
