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
    public partial class frmQuanLyXe : Form
    {
        bool dtgDanhSachXeKhachSelected = false;

        public frmQuanLyXe()
        {
            InitializeComponent();

            dtgDSXeKhach.AllowUserToAddRows = false;
            dtgDSXeTrungChuyen.AllowUserToAddRows = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemXe form = new frmThemXe();
            form.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaXe form = null;
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if(dtgDanhSachXeKhachSelected)
            {
                int maXe = int.Parse(dtgDSXeKhach.CurrentRow.Cells["MaXe"].Value.ToString());
                tblXeKhach xe = db.tblXeKhaches.Where(t => t.MaXe == maXe).SingleOrDefault();
                if(xe != null)
                {
                    form = new frmSuaXe(xe);
                }
            }
            else
            {
                int maXe = int.Parse(dtgDSXeTrungChuyen.CurrentRow.Cells["MaXeTC"].Value.ToString());
                tblXeTrungChuyen xe = db.tblXeTrungChuyens.Where(t => t.MaXe == maXe).SingleOrDefault();
                if (xe != null)
                {
                    form = new frmSuaXe(xe);
                }
            }

            form.Show();
        }

        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            dtgDSXeKhach.Rows.Clear();
            dtgDSXeTrungChuyen.Rows.Clear();
            foreach(var item in db.tblXeKhaches.ToList())
            {
                dtgDSXeKhach.Rows.Add(item.MaXe, 
                                      item.tblNhanVien.TenNhanVien, 
                                      item.tblLoaiXe.TenLoaiXe, 
                                      item.BienSoXe, 
                                      item.tblTuyenXe.tblBenXe.TenBenXe +"-"+ item.tblTuyenXe.tblBenXe1.TenBenXe, 
                                      item.SoGhe);
            }

            foreach(var item in db.tblXeTrungChuyens.ToList())
            {
                dtgDSXeTrungChuyen.Rows.Add(item.MaXe,
                                      item.tblNhanVien.TenNhanVien,
                                      item.BienSoXe,
                                      item.DiaDiemTrungChuyen);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            if(dtgDanhSachXeKhachSelected)
            {
                int maXe = int.Parse(dtgDSXeKhach.CurrentRow.Cells["MaXe"].Value.ToString());
                tblXeKhach xe = db.tblXeKhaches.Where(t => t.MaXe == maXe).SingleOrDefault();


                DialogResult result = MessageBox.Show(string.Format("Bạn muốn xóa thông tin xe khách\nMã xe: {0}\nTài xế: {1}\nBiển số: {2}", xe.MaXe, xe.tblNhanVien.TenNhanVien, xe.BienSoXe), "Thông báo", MessageBoxButtons.YesNo);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    BLL.BLL_XeKhach temp = new BLL.BLL_XeKhach();
                    if(temp.canDelete(xe.MaXe))
                    {
                        try
                        {
                            db.tblXeKhaches.Remove(xe);
                            db.SaveChanges();

                            MessageBox.Show("Thành công!");
                        }catch(Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng, không thể xóa!", "Lỗi");
                        }
                        
                    }
                    else
                        MessageBox.Show("Dữ liệu không tồn tại!", "Lỗi");
                }
            }
            else
            {
                int maXe = int.Parse(dtgDSXeTrungChuyen.CurrentRow.Cells["MaXeTC"].Value.ToString());
                tblXeTrungChuyen xe = db.tblXeTrungChuyens.Where(t => t.MaXe == maXe).SingleOrDefault();


                DialogResult result = MessageBox.Show(string.Format("Bạn muốn xóa thông tin xe trung chuyển\nMã xe: {0}\nTài xế: {1}\nBiển số: {2}", xe.MaXe, xe.tblNhanVien.TenNhanVien, xe.BienSoXe), "Thông báo", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    BLL.BLL_XeTrungChuyen temp = new BLL.BLL_XeTrungChuyen();
                    if (temp.canDelete(xe.MaXe))
                    {
                        try
                        {
                            db.tblXeTrungChuyens.Remove(xe);
                            db.SaveChanges();

                            MessageBox.Show("Thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng, không thể xóa!", "Lỗi");
                        }

                    }
                    else
                        MessageBox.Show("Dữ liệu không tồn tại!", "Lỗi");
                }
            }
        }

        private void dtgDSXeKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgDSXeTrungChuyen.ClearSelection();
            dtgDanhSachXeKhachSelected = true;
        }

        private void dtgDSXeTrungChuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgDSXeKhach.ClearSelection();
            dtgDanhSachXeKhachSelected = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmQuanLyXe_Load(sender, e);
        }
    }
}
