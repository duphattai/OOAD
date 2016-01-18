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
    public partial class frmTraCuuChuyenDi : Form
    {
        DataTable DSSanBay;
        public frmTraCuuChuyenDi()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            try
            {
                this.dgvTraCuu.AutoGenerateColumns = false;
                dgvTraCuu.Rows.Clear();
                              
                foreach (var item in db.tblChuyenDis.ToList())
                {                                   
                    dgvTraCuu.Rows.Add(item.tblXeKhach.tblTuyenXe.MaBenXeDi,
                                            item.tblXeKhach.tblTuyenXe.MaBenXeDen,
                                            item.KhoiHanh,
                                            item.KetThuc,
                                            item.SoGheDat,
                                            item.SoGheTrong                                          
                                            );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbBenXeDi_MouseClick(object sender, MouseEventArgs e)
        {
            try{
                cbBenXeDi.Items.Clear();
            }
            catch { }
        }

        private void cbBenXeDen_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                cbBenXeDen.Items.Clear();
            }
            catch { }
        }

        private void frmTraCuuChuyenDi_Load(object sender, EventArgs e)
        {
            try { 
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbBenXeDi.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();        
            cbBenXeDen.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
            }
            catch { }
        }
    }
}
