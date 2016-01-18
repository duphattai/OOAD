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
    public partial class frmSuaBenXe : Form
    {
        public frmSuaBenXe()
        {
            InitializeComponent();
        }

        private void frmSuaBenXe_Load(object sender, EventArgs e)
        {
            cbMaBenXe.Items.Clear();
            cbMaBenXe.SelectedItem = "";
            foreach(var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
                cbMaBenXe.Items.Add(item.MaBenXe);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaSanBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblBenXe benXe = new QUANLYXEKHACHEntities().tblBenXes.Where(t => t.MaBenXe == cbMaBenXe.SelectedItem.ToString()).SingleOrDefault();
            if(benXe != null)
            {
                txtTenBenXe.Text = benXe.TenBenXe;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maBen = cbMaBenXe.SelectedItem.ToString();
            string tenBen = txtTenBenXe.Text.ToString();

            BLL_BenXe temp = new BLL_BenXe();
            if(temp.canUpdate(maBen, tenBen))
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblBenXe benXe = db.tblBenXes.Where(t => t.MaBenXe == maBen).SingleOrDefault();
                if(benXe != null)
                {
                    benXe.TenBenXe = tenBen;
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thành công");
                }
            }
            else 
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

       
    }
}
