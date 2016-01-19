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
using BanVeXePhuongTrang.BLL;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmLichChuyenDi : Form
    {
        public frmLichChuyenDi()
        {
            InitializeComponent();

            BLL_ChuyenDi temp = new BLL_ChuyenDi();
            txtMaChuyenDi.Text = temp.getLastestIndex().ToString();
        }

        public frmLichChuyenDi(tblChuyenDi chuyenDi)
        {
            InitializeComponent();
            try
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                txtMaChuyenDi.Text = chuyenDi.MaChuyenDi.ToString();
                txtGiaVe.Text = chuyenDi.DonGia.ToString();

                cbbMaTuyen.DataSource = db.tblTuyenXes.Select(t => t.MaTuyen).ToList();
                cbbMaTuyen.SelectedItem = chuyenDi.tblXeKhach.MaTuyen;
                txtTuyen.Text = chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe.TenBenXe + "-" + chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe1.TenBenXe;
                dtpKhoiHanh.Value = chuyenDi.KhoiHanh.Value;
                dtpKetThuc.Value = chuyenDi.KetThuc.Value;

                dtgBXTrungGian.Rows.Clear();
                foreach (var item in db.tblChiTietTuyens.Where(t => t.MaTuyen == chuyenDi.tblXeKhach.MaTuyen).ToList())
                {
                    dtgBXTrungGian.Rows.Add(item.tblBenXe.TenBenXe,
                                            item.ThoiGianDung,
                                            item.GhiChu);
                }

                cbbMaXe.DataSource = db.tblXeKhaches.Where(t => t.MaTuyen == chuyenDi.tblXeKhach.MaTuyen).Select(t => t.MaXe).ToList();
            }
            catch 
            { }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dtgBXTrungGian.Rows.Count > 2)
                dtgBXTrungGian.AllowUserToAddRows = false;
            {
                dtgBXTrungGian.Rows[dtgBXTrungGian.RowCount - 1].Cells[0].Value = "";
                dtgBXTrungGian.Rows[dtgBXTrungGian.RowCount - 1].Cells[1].Value = "";
            }
        }

        private void frmLichChuyenDi_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbbMaTuyen.DataSource = db.tblTuyenXes.Select(t => t.MaTuyen).ToList();
            dtgBXTrungGian.Rows.Clear();
        }

        private void cbbMaTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                string maTuyen = cbbMaTuyen.SelectedItem.ToString();
                cbbMaXe.Items.Clear();

                // Lấy danh sách xe khách chạy theo mã tuyến, kiểm tra lịch của xe có ngày kết thúc < thời gian hiện tại
                DateTime khoiHanh = dtpKhoiHanh.Value;
                List<tblXeKhach> listXeKhach = db.tblXeKhaches.Where(t => t.MaTuyen == maTuyen).ToList();
                foreach (var item in listXeKhach)
                {
                    if (db.tblChuyenDis.Where(t => t.MaXe == item.MaXe && t.KetThuc > khoiHanh).ToArray().Length > 0)
                        continue;

                    cbbMaXe.Items.Add(item.MaXe);
                }

                // Hiển thị tên tuyến
                tblTuyenXe tuyen = db.tblTuyenXes.Where(t => t.MaTuyen == maTuyen).SingleOrDefault();
                if (tuyen != null)
                    txtTuyen.Text = tuyen.tblBenXe.TenBenXe + "-" + tuyen.tblBenXe1.TenBenXe;

                // Hiển thị bến xe trung gian
                dtgBXTrungGian.Rows.Clear();
                foreach (var item in tuyen.tblChiTietTuyens.ToList())
                    dtgBXTrungGian.Rows.Add(item.tblBenXe.TenBenXe,
                                            item.ThoiGianDung,
                                            item.GhiChu);
            }
            catch 
            { }
        }


        void   insertRecord()
        {
            BLL_ChuyenDi temp = new BLL_ChuyenDi();

            tblChuyenDi chuyenDi = new tblChuyenDi();
            chuyenDi.MaChuyenDi = int.Parse(txtMaChuyenDi.Text.ToString());
            chuyenDi.DonGia = int.Parse(txtGiaVe.Text.ToString());
            chuyenDi.MaXe = int.Parse(cbbMaXe.SelectedItem.ToString());
            chuyenDi.KhoiHanh = dtpKhoiHanh.Value;
            chuyenDi.KetThuc = dtpKetThuc.Value;
            chuyenDi.SoGheTrong = chuyenDi.SoGheDat = 0;

            string message = temp.validateInput(chuyenDi.MaChuyenDi, chuyenDi.MaXe, int.Parse(chuyenDi.DonGia.ToString()), dtpKhoiHanh.Value, dtpKetThuc.Value);
            if (string.IsNullOrEmpty(message))
            {
                if (temp.canInsert(chuyenDi.MaChuyenDi, chuyenDi.MaXe))
                {
                    BLL_ChiTietTuyenXe CTChuyenDi = new BLL_ChiTietTuyenXe();
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                    db.tblChuyenDis.Add(chuyenDi);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
                MessageBox.Show(message, "Thông báo");
        }

        void    updateRecord()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            BLL_ChuyenDi temp = new BLL_ChuyenDi();
            int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());

            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t=>t.MaChuyenDi == maChuyen).SingleOrDefault();
            chuyenDi.DonGia = decimal.Parse(txtGiaVe.Text.ToString());
            chuyenDi.MaXe = int.Parse(cbbMaXe.SelectedItem.ToString());
            chuyenDi.KhoiHanh = dtpKhoiHanh.Value;
            chuyenDi.KetThuc = dtpKetThuc.Value;
            chuyenDi.SoGheTrong = chuyenDi.SoGheDat = 0;


            string message = temp.validateInput(chuyenDi.MaChuyenDi, chuyenDi.MaXe, chuyenDi.DonGia, dtpKhoiHanh.Value, dtpKetThuc.Value);
            if (string.IsNullOrEmpty(message))
            {
                if (temp.canUpdate(chuyenDi.MaChuyenDi, chuyenDi.MaXe))
                {
                    BLL_ChiTietTuyenXe CTChuyenDi = new BLL_ChiTietTuyenXe();

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            else
                MessageBox.Show(message, "Thông báo");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).ToArray().Length > 0)
                updateRecord();
            else
                insertRecord();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmLichChuyenDi_Load(sender, e);
            BLL_ChuyenDi temp = new BLL_ChuyenDi();
            txtMaChuyenDi.Text = temp.getLastestIndex().ToString();
        }
    }
}