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
    public partial class frmXoaTuyenXe : Form
    {
        public frmXoaTuyenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static public void XoaTuyenBay(String MaTuyenBay)
        {
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(cbMaTuyen.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tuyến bay muốn xóa", "Lỗi");
                return;
            }

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            BLL_TuyenXe temp = new BLL_TuyenXe();
            if(temp.canDelete(cbMaTuyen.SelectedItem.ToString()))
            {
                tblTuyenXe tuyenXe = db.tblTuyenXes.Where(t => t.MaTuyen == cbMaTuyen.SelectedItem.ToString()).Single();
                db.tblTuyenXes.Remove(tuyenXe);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Tuyến không tồn tại", "Thông báo");
        }

        private void frmXoaTuyenXe_Load(object sender, EventArgs e)
        {
            cbMaTuyen.Items.Clear();
            foreach (var item in new QUANLYXEKHACHEntities().tblTuyenXes.ToList())
                cbMaTuyen.Items.Add(item.MaTuyen);
        }
    }
}
