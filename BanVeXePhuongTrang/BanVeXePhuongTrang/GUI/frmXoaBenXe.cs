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
    public partial class frmXoaBenXe : Form
    {
        public frmXoaBenXe()
        {
            InitializeComponent();
        }

        private void frmXoaBenXe_Load(object sender, EventArgs e)
        {
            cbTenBenXe.Items.Clear();

            foreach (var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
            {
                cbTenBenXe.Items.Add(item.TenBenXe);    
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btXoa_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            BLL.BLL_BenXe temp = new BLL.BLL_BenXe();

            tblBenXe benXe = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenXe.SelectedItem.ToString()).SingleOrDefault();
            if(benXe != null)
            {
                if (temp.canDelete(benXe.MaBenXe))
                {
                    db.tblBenXes.Remove(benXe);
                    db.SaveChanges();

                    frmXoaBenXe_Load(sender, e);
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        
    }
}
