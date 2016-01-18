using BanVeXePhuongTrang.BLL;
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
    public partial class frmTaiKhoan : Form
    {       
        public frmTaiKhoan()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        int vitri = 0;

        public void LoadDataGridView()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            try
            {
                this.dgvTaiKhoan.AutoGenerateColumns = false;

                dgvTaiKhoan.DataSource = db.tblNhanViens.Where(t => t.tblLoaiNhanVien.MaLoaiNhanVien == 2).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //-----------Gán nguồn từ DataGridView cho textbox khi lick chuột-------------
        public void Gan_click()
        {
            try
            {
                if (this.dgvTaiKhoan.SelectedRows.Count == 0)
                    return;
                DataGridViewRow r = this.dgvTaiKhoan.SelectedRows[0];

                GanDK(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {

                if (dgvTaiKhoan.Rows.Count != 0)
                {
                    this.txtMaNhanVien.Text = r.Cells[0].Value.ToString();
                    this.txtTenNhanVien.Text = r.Cells[1].Value.ToString();
                    if (r.Cells[2].Value.Equals(null))
                    {
                    //this.txtTenDangNhap.Text = string.IsNullOrEmpty(r.Cells[2].Value.ToString()) ? "" : r.Cells[2].Value.ToString();
                        this.txtTenDangNhap.Text = "";
                    }
                    else { this.txtTenNhanVien.Text = r.Cells[2].Value.ToString(); }
                    this.txtMatKhau.Text = string.IsNullOrEmpty(r.Cells[3].Value.ToString()) ? "" : r.Cells[3].Value.ToString();
                    this.cbQuyenHan.Text = string.IsNullOrEmpty(ConvertToStringQuyenHan(r)) ? "Nhân Viên" : ConvertToStringQuyenHan(r);
                }
                else
                {
                    this.txtMaNhanVien.Text = "";
                    this.txtTenNhanVien.Text = "";
                    this.txtTenDangNhap.Text = "";
                    this.txtMatKhau.Text = "";
                    this.cbQuyenHan.Text = "Nhân Viên";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_TaiKhoan temp = new BLL_TaiKhoan();
                if (temp.canInsert(txtTenDangNhap.Text.ToString(), txtMatKhau.Text.ToString()))
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    tblTaiKhoan t = new tblTaiKhoan();
                    t.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                    t.TenTaiKhoan = txtTenDangNhap.Text.ToString();
                    t.MatKhau = txtMatKhau.Text.ToString();
                    t.MaQuyen = ConvertQuyenHan();                  
                    db.tblTaiKhoans.Add(t);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công");
                    LoadDataGridView();
                    reset();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        int ConvertQuyenHan()
        {
            if (cbQuyenHan.Text.Equals("Quản Trị Viên"))
            {
                return 1;
            }
            else if (cbQuyenHan.Text.Equals("Ban Giám Đốc"))
            {
                return 2;
            }

            return 0;
        }

        string ConvertToStringQuyenHan(DataGridViewRow r)
        {

            if (r.Cells[4].Value.Equals(1))
                return "Quản Trị Viên";
            else if (r.Cells[4].Value.Equals(2))
                return "Ban Giám Đốc";

            return "Nhân Viên";
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_TaiKhoan temp = new BLL_TaiKhoan();
                if (temp.canInsert(txtTenDangNhap.Text.ToString(), txtMatKhau.Text.ToString()))
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    tblTaiKhoan t = new tblTaiKhoan();
                    t.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                    t.TenTaiKhoan = txtTenDangNhap.Text.ToString();
                    t.MatKhau = txtMatKhau.Text.ToString();
                    t.MaQuyen = ConvertQuyenHan();
                    db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thành công");
                    LoadDataGridView();
                    reset();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }

            }
            catch { MessageBox.Show("Vui lòng nhập đầy đủ thông tin!"); }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            try
            {
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Tên nhân viên không tồn tại");
                }
                else
                {
                    int MaNV = int.Parse(txtMaNhanVien.Text.ToString());
                    tblTaiKhoan MaNhanVien = db.tblTaiKhoans.Where(t => t.MaNhanVien == MaNV).SingleOrDefault();

                    if (MessageBox.Show("Bạn có muốn xóa nhân viên'" + txtTenNhanVien.Text + "'không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.tblTaiKhoans.Remove(MaNhanVien);
                        db.SaveChanges();
                        reset();
                        if (vitri > 0)
                        {
                            dgvTaiKhoan.CurrentCell = dgvTaiKhoan.Rows[vitri - 1].Cells[0];
                            dgvTaiKhoan.Rows[vitri - 1].Selected = true;
                            Gan_click();
                        }
                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btkhong_Click(object sender, EventArgs e)
        {
            reset();
            //Gan_click();
        }
        public void reset()
        {
            this.txtMaNhanVien.Text = "";
            this.txtTenNhanVien.Text = "";
            this.txtTenDangNhap.Text = "";
            this.txtMatKhau.Text = "";
            this.cbQuyenHan.Text = "";
            LoadDataGridView();

            dgvTaiKhoan.Enabled = true;
            btxoa.Enabled = true;
            // Gan_click();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            Gan_click();
            vitri = dgvTaiKhoan.CurrentCell.RowIndex;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }
    }
}
