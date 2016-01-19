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
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmQuanLyChuyenDi : Form
    {
        public frmQuanLyChuyenDi()
        {
            InitializeComponent();
            dtgChuyenDi.AllowUserToAddRows = false;
            dtgCTChuyenDi.AllowUserToAddRows = false;
        }

     
        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmLichChuyenDi form = new frmLichChuyenDi();
            form.ShowDialog();
            frmQuanLyChuyenDi_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgChuyenDi.CurrentCell.RowIndex;
            DataGridViewRow row = dtgChuyenDi.Rows[rowIndex];

            int maChuyenDi = int.Parse(row.Cells["MaChuyenDi"].Value.ToString());
            string message = string.Format("Bạn muốn xóa chuyến đi\nBiển sô xe: {0}\nTuyến: {1}\nKhởi hành: {2}", row.Cells["BienSoXe"].Value, row.Cells["TuyenXe"].Value, row.Cells["KhoiHanh"].Value);
            DialogResult result = MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                BLL.BLL_ChuyenDi temp = new BLL.BLL_ChuyenDi();
                if (temp.canDelete(maChuyenDi))
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyenDi).SingleOrDefault();
                    if (chuyenDi != null)
                    {
                        // Xóa báo cáo
                        tblBaoCaoDoanhThuChuyenDi bcChuyenDi = db.tblBaoCaoDoanhThuChuyenDis.Where(t => t.MaChuyenDi == chuyenDi.MaChuyenDi).SingleOrDefault();
                        if(bcChuyenDi != null)
                            db.tblBaoCaoDoanhThuChuyenDis.Remove(bcChuyenDi);

                        db.tblChuyenDis.Remove(chuyenDi);
                        db.SaveChanges();

                        MessageBox.Show("Xóa thành công");
                        frmQuanLyChuyenDi_Load(sender, e);
                    }
                }
                else
                    MessageBox.Show("Chuyến đi đã có khách hàng đặt vé hoặc mua, không thể xóa");
            }
 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgChuyenDi.CurrentCell.RowIndex;
            DataGridViewRow row = dtgChuyenDi.Rows[rowIndex];
            int maChuyen = int.Parse(row.Cells["MaChuyenDi"].Value.ToString());

            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();

            frmLichChuyenDi form = new frmLichChuyenDi(chuyenDi);
            form.ShowDialog();

            frmQuanLyChuyenDi_Load(sender, e);
        }

        private void frmQuanLyChuyenDi_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            dtgChuyenDi.Rows.Clear();
            foreach(var item in db.tblChuyenDis.ToList())
            {
                dtgChuyenDi.Rows.Add(item.MaXe,
                                      item.tblXeKhach.BienSoXe, 
                                      item.MaChuyenDi,
                                      item.tblXeKhach.tblTuyenXe.tblBenXe.TenBenXe + "-" + item.tblXeKhach.tblTuyenXe.tblBenXe1.TenBenXe,
                                      item.KhoiHanh.Value.ToString(),
                                      item.DonGia,
                                      item.tblXeKhach.MaTuyen);
            }
        }

        private void dtgChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int maChuyen = int.Parse(dtgChuyenDi.Rows[e.RowIndex].Cells["MaChuyenDi"].Value.ToString());
          
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();
                if(chuyenDi != null)
                {
                    dtgCTChuyenDi.Rows.Clear();
                    foreach (var item in db.tblChiTietTuyens.Where(t => t.MaTuyen == chuyenDi.tblXeKhach.MaTuyen).ToList())
                    {
                        dtgCTChuyenDi.Rows.Add(item.MaBenXeTrungGiang,
                                                item.tblBenXe.TenBenXe,
                                                item.ThoiGianDung,
                                                item.GhiChu);
                    }
                }
            }
        }
    }
}
