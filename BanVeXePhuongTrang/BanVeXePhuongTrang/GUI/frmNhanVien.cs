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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            LoadDataGridView();
            TaiKhoan();
        }
        int vitri = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try { 
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbQuyenHan.DataSource = db.tblPhanQuyens.Select(t => t.TenQuyen).ToList();
            cbLoaiNV.Items.Clear();
            cbLoaiNV.DataSource = db.tblLoaiNhanViens.Select(t => t.TenLoaiNhanVien).ToList();

            BLL_NhanVien temp = new BLL_NhanVien();
            txtMaNhanVien.Text = temp.getLastestIndex().ToString();
            LoadDataGridView();
            }
            catch { }
        }
      
        public void LoadDataGridView()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            try
            {
                this.dgvNhanVien.AutoGenerateColumns = false;

                dgvNhanVien.Rows.Clear();
                foreach (var item in db.tblNhanViens.ToList())
                  {
                    tblTaiKhoan tk = db.tblTaiKhoans.Where(t=>t.MaNhanVien == item.MaNhanVien).SingleOrDefault();
                    string tenTK = "";
                    string matKhau = "";
                    string quyen = "";
                    if(tk != null)
                    {
                        tenTK = tk.TenTaiKhoan;
                        matKhau = tk.MatKhau;
                        quyen = tk.tblPhanQuyen.TenQuyen;
                    }
                    dgvNhanVien.Rows.Add(item.MaNhanVien,
                                            item.TenNhanVien,
                                            item.NgaySinh,
                                            item.CMND,
                                            item.DiaChi,
                                            item.tblLoaiNhanVien.TenLoaiNhanVien,
                                            tenTK,
                                            matKhau,
                                            quyen);
                  }

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
                if (this.dgvNhanVien.SelectedRows.Count == 0)
                    return;
                DataGridViewRow r = this.dgvNhanVien.SelectedRows[0];

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

                if (dgvNhanVien.Rows.Count != 0)
                {
                    this.txtMaNhanVien.Text = r.Cells[0].Value.ToString();
                    this.txtTenNhanVien.Text = r.Cells[1].Value.ToString();
                    this.txtDiaChi.Text = r.Cells[4].Value.ToString();
                    this.dtNgaySinh.Text = r.Cells[2].Value.ToString();
                    this.txtCMND.Text = r.Cells[3].Value.ToString();
                    this.cbLoaiNV.Text = r.Cells[5].Value.ToString();
                    this.txtTaiKhoan.Text = r.Cells[6].Value.ToString();
                    this.txtMatKhau.Text = r.Cells[7].Value.ToString();
                    this.cbQuyenHan.Text = r.Cells[8].Value.ToString();
                }
                else
                {
                    this.txtMaNhanVien.Text = "";
                    this.txtTenNhanVien.Text = "";
                    this.txtDiaChi.Text = "";                    
                    this.dtNgaySinh.Text = "";
                    this.txtCMND.Text = "";
                    this.cbLoaiNV.Text = "Nhân Viên";
                    this.txtTaiKhoan.Text = "";
                    this.txtMatKhau.Text = "";
                    this.cbQuyenHan.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
          try {
            BLL_NhanVien temp = new BLL_NhanVien();
            if (temp.canInsert(int.Parse(txtMaNhanVien.Text.ToString()),int.Parse(txtCMND.Text.ToString())))
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                tblNhanVien t = new tblNhanVien();
                tblTaiKhoan v = new tblTaiKhoan();
                t.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                t.TenNhanVien = txtTenNhanVien.Text.ToString();
                t.MaLoaiNhanVien = ConvertLoaiNhanVien();
                t.NgaySinh = dtNgaySinh.Value;
                t.CMND = int.Parse(txtCMND.Text.ToString());
                t.DiaChi = txtDiaChi.Text.ToString();

                //v.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                if(ConvertLoaiNhanVien() == 2)
                {
                    v.MaNhanVien = t.MaNhanVien;
                    v.TenTaiKhoan = txtTaiKhoan.Text.ToString();
                    v.MatKhau = txtMatKhau.Text.ToString();
                    v.MaQuyen = ConvertQuyenHan();
                    db.tblTaiKhoans.Add(v);
                    db.tblNhanViens.Add(t);
                    db.SaveChanges();
                }
                else {
                    db.tblNhanViens.Add(t);
                    db.SaveChanges();
                }
                      
                MessageBox.Show("Thêm thành công");
                LoadDataGridView();
                reset();
            }
            else
            {
                MessageBox.Show("Nhân viên đã tồn tại!");
            }
          }
          catch {
              MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
          }
        }

        int ConvertLoaiNhanVien()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            tblLoaiNhanVien temp = db.tblLoaiNhanViens.Where(t => t.TenLoaiNhanVien == cbLoaiNV.SelectedItem.ToString()).SingleOrDefault();
            if (temp != null)
                return temp.MaLoaiNhanVien;

            return 0;
        }

        void TaiKhoan(){
            if (cbLoaiNV.Text.Equals("Nhân viên"))
            { 
                BatTaiKhoan(true); 
            }
            else {
                BatTaiKhoan(false);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                cbQuyenHan.Text = "";
            }
        }

        public void BatTaiKhoan(Boolean x)
        {
            txtTaiKhoan.Enabled = x;
            txtMatKhau.Enabled = x;
            cbQuyenHan.Enabled = x;
        }

        string ConvertToStringLoaiNV(DataGridViewRow r)
        {

            if (r.Cells[5].Value.Equals(1))
                return "Tài xế";
            return "Nhân Viên";
        }

        int ConvertQuyenHan()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            tblPhanQuyen temp = db.tblPhanQuyens.Where(t => t.TenQuyen == cbQuyenHan.SelectedItem.ToString()).SingleOrDefault();
            if (temp != null)
                return temp.MaQuyen;

            return 0;
        }


        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_NhanVien temp = new BLL_NhanVien();
                if (temp.canUpdate(int.Parse(txtMaNhanVien.Text.ToString()), int.Parse(txtCMND.Text.ToString())))
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    tblNhanVien t = new tblNhanVien();
                    tblTaiKhoan v = new tblTaiKhoan();
                    t.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                    t.TenNhanVien = txtTenNhanVien.Text.ToString();
                    t.MaLoaiNhanVien = ConvertLoaiNhanVien();
                    t.NgaySinh = dtNgaySinh.Value;
                    t.CMND = int.Parse(txtCMND.Text.ToString());
                    t.DiaChi = txtDiaChi.Text.ToString();
                    v = db.tblTaiKhoans.Where(s => s.MaNhanVien == t.MaNhanVien).SingleOrDefault();
                    //v.MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());
                    if (ConvertLoaiNhanVien() == 2)
                    {
                        if (v == null)
                        {
                            v = new tblTaiKhoan();
                            v.MaNhanVien = t.MaNhanVien;
                            v.TenTaiKhoan = txtTaiKhoan.Text.ToString();
                            v.MatKhau = txtMatKhau.Text.ToString();
                            v.MaQuyen = ConvertQuyenHan();
                            db.tblTaiKhoans.Add(v);
                        }
                        else {
                            v.MaNhanVien = t.MaNhanVien;
                            v.TenTaiKhoan = txtTaiKhoan.Text.ToString();
                            v.MatKhau = txtMatKhau.Text.ToString();
                            v.MaQuyen = ConvertQuyenHan();
                            db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                        }                       
                        db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        if(v.MaNhanVien == t.MaNhanVien)
                            db.tblTaiKhoans.Remove(v);
                        db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    MessageBox.Show("Cập nhật thành công");
                    LoadDataGridView();
                    reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
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
                    tblNhanVien MaNhanVien = db.tblNhanViens.Where(t => t.MaNhanVien == MaNV).SingleOrDefault();
                    tblTaiKhoan ma = db.tblTaiKhoans.Where(t => t.MaNhanVien == MaNV).SingleOrDefault();

                    if (MessageBox.Show("Bạn có muốn xóa nhân viên'" + txtTenNhanVien.Text + "'không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(ma != null)
                            db.tblTaiKhoans.Remove(ma);
                        db.tblNhanViens.Remove(MaNhanVien);
                        db.SaveChanges();
                        reset();
                        if (vitri > 0)
                        {
                            dgvNhanVien.CurrentCell = dgvNhanVien.Rows[vitri - 1].Cells[0];
                            dgvNhanVien.Rows[vitri - 1].Selected = true;
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
            this.txtDiaChi.Text = "";           
            this.dtNgaySinh.Text = "";
            this.txtCMND.Text = "";
            this.cbLoaiNV.Text = "";
            this.txtTaiKhoan.Text = "";
            this.txtMatKhau.Text = "";
            this.cbQuyenHan.Text = "";
            LoadDataGridView();
            BLL_NhanVien temp = new BLL_NhanVien();
            txtMaNhanVien.Text = temp.getLastestIndex().ToString();
            dgvNhanVien.Enabled = true;
            btxoa.Enabled = true;
            // Gan_click();
        }

        private void dtNhanVien_Click(object sender, EventArgs e)
        {
            Gan_click();
            //vitri = dgvNhanVien.CurrentCell.RowIndex;
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dtNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 5)
            //{
            //    if (e.Value == null || e.Value == DBNull.Value)
            //        return;
            //    if ((int)e.Value == 1)
            //    {
            //        e.Value = Convert.ToInt32(e.Value).ToString("Tài xế");
            //    }             
            //    else
            //    {
            //        e.Value = Convert.ToInt32(e.Value).ToString("Nhân Viên");
            //    }

            //}
        }

 

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text.Length > 200)
            {
                MessageBox.Show("Địa chỉ nhập vào vượt quá giới hạn cho chép (<200 ký tự)");
                txtDiaChi.Focus();
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {
            if (txtCMND.Text.Length > 12 || txtCMND.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập CMND!");
                txtTenNhanVien.Focus();
            }

        }

        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNhanVien.Text.Length > 100)
            {
                MessageBox.Show("Tên nhân viên nhập vào vượt quá giới hạn cho chép (<100 ký tự)");
                txtTenNhanVien.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiKhoan();
        }
    }
}
