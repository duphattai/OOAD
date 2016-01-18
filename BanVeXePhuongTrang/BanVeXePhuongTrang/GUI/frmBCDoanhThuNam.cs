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


namespace BanVeXePhuongTrang.GUI
{
    public partial class frmBCDoanhThuNam : Form
    {     

        public frmBCDoanhThuNam()
        {
            InitializeComponent();         
        }


        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            this.tblBaoCaoDoanhThuNamTableAdapter.Fill(this.qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuNam, int.Parse(cbNam.SelectedIndex.ToString()));

            this.reportViewer1.RefreshReport();
        }

        private void frmBCDoanhThuNam_Load(object sender, EventArgs e)
        {
           
           
            for (int i = 2010; i < DateTime.Now.Year + 1; i++)
            {
                cbNam.Items.Add(i);
            }
        }

    }
}
