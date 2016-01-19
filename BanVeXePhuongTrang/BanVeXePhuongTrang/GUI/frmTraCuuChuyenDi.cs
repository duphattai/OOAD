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
            string MaTuyen;
            DateTime dateTime = dtpTuNgay.Value;
            try
            {
                
                
                    tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbBenXeDi.SelectedItem.ToString()).Single();
                    tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbBenXeDen.SelectedItem.ToString()).Single();
                    
                    
                    MaTuyen = benXeDi.MaBenXe + "_" + benXeDen.MaBenXe;

                    var entryPoint = (from tuyenXe in db.tblTuyenXes
                                      join xeDi in db.tblBenXes on tuyenXe.MaBenXeDi equals xeDi.MaBenXe
                                      join xeDen in db.tblBenXes on tuyenXe.MaBenXeDen equals xeDen.MaBenXe 
                                      join xe in db.tblXeKhaches on tuyenXe.MaTuyen equals xe.MaTuyen
                                      join chuyenDi in db.tblChuyenDis on xe.MaXe equals chuyenDi.MaXe
         
                                      where tuyenXe.MaTuyen == MaTuyen
                                      select new
                                      {
                                          KhoiHanh = chuyenDi.KhoiHanh,
                                          BenXeDi = xeDi.TenBenXe,
                                          BenXeDen = xeDen.TenBenXe,
                                          SoGheTrong = chuyenDi.SoGheTrong,
                                          SoGheDat = chuyenDi.SoGheDat,
                                          KetThuc = chuyenDi.KetThuc
                                      }).ToList();

                    dgvTraCuu.DataSource = entryPoint;
                    


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
