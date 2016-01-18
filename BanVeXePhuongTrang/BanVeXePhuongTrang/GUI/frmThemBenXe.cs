using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang.BLL;
using BanVeXePhuongTrang.DAL;
namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThemBenXe : Form
    {
        public frmThemBenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            { 
                BLL_BenXe temp = new BLL_BenXe();
                if (temp.canInsert(txtMaBenXe.Text.ToString(), txtTenBenXe.Text.ToString()))
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    tblBenXe t = new tblBenXe();
                    t.MaBenXe = txtMaBenXe.Text.ToString();
                    t.TenBenXe = txtTenBenXe.Text.ToString();
                    db.tblBenXes.Add(t);
                    db.SaveChanges();

                    btnTaoMoi_Click(sender, e);
                    MessageBox.Show("Thêm thành công");
                }
                else 
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch { }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaBenXe.Text = "";
            txtTenBenXe.Text = "";
        }
    }
}
