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
    public partial class frmDanhSachDatVe : Form
    {
        public frmDanhSachDatVe()
        {
            InitializeComponent();
        }

        private void frmDanhSachDatVe_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu những thay đổi", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if(dtgDanhSachVe.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không có dữ liệu để lưu", "Thông báo");
                    return;
                }

                foreach (DataGridViewRow row in dtgDanhSachVe.Rows)
                {
                   
                }

                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDanhSachVe.Rows.Clear();
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                  // mã tuyến
                string maBenDi = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDi.SelectedItem.ToString()).Select(t => t.TenBenXe).ToString();
                string maBenDen = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDen.SelectedItem.ToString()).Select(t => t.TenBenXe).ToString();

                string maTuyen = maBenDi + "-" + maBenDen;
                int dienThoai = int.Parse(txtDienThoai.Text.ToString());
                foreach (var item in db.tblPhieuDatChoes.Where(t=>t.HoTen == txtHoten.Text.ToString() || t.DienThoai == dienThoai).ToList())
                {
                    dtgDanhSachVe.Rows.Add(item.HoTen,
                                            "",
                                            item.DienThoai,
                                            item.TrungChuyen,
                                            "");
                }
            }
            catch { }
            
        }

        
    }
}
