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
using System.Threading;


namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThongTinVe : Form
    {
        tblChuyenDi chuyenDi;
        tblPhieuDatCho phieuDatCho;
        bool editMode;
        public frmThongTinVe(tblChuyenDi chuyenDi, tblPhieuDatCho phieu = null)
        {
            InitializeComponent();

            this.chuyenDi = chuyenDi;
            editMode = phieu == null ? false : true;
            if (phieu == null)
                phieuDatCho = new tblPhieuDatCho();
            else
                phieuDatCho = phieu;
        }


        private void frmThongTinVe_Load(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            // Load thông tin chuyến đi
            txtMaChuyenDi.Text = chuyenDi.MaChuyenDi.ToString();
            txtBenXeDi.Text = chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe.TenBenXe.ToString();
            txtBenXeDen.Text = chuyenDi.tblXeKhach.tblTuyenXe.tblBenXe1.TenBenXe.ToString();
            txtGiaTien.Text = chuyenDi.DonGia.ToString();
            txtKhoiHanh.Text = chuyenDi.KhoiHanh.Value.ToString();


           // Thông tin hành khách
            if(phieuDatCho.HoTen != null)
                txtHoTen.Text = phieuDatCho.HoTen.ToString();
            if (phieuDatCho.DienThoai != null)
                txtDienThoai.Text = phieuDatCho.DienThoai.ToString();
            if (phieuDatCho.TrungChuyen != null)
                txtTrungChuyen.Text = phieuDatCho.TrungChuyen.ToString();
            // Thông tin ghế
            dtgGhe.Rows.Clear();
            foreach (var item in db.tblChiTietPhieuDatChoes.Where(t => t.MaPhieu == phieuDatCho.MaPhieu))
                dtgGhe.Rows.Add(item.ViTriGhe);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }


        public static void updateBaoCaoDoanhThuThang(int maChuyenDi)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            //int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());
            int maChuyen = maChuyenDi;
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();

            tblBaoCaoDoanhThuThang bc = db.tblBaoCaoDoanhThuThangs.Where(t => t.Thang == chuyenDi.KhoiHanh.Value.Month && t.Nam == chuyenDi.KhoiHanh.Value.Year).SingleOrDefault();
            if (bc == null)
            {
                bc = new tblBaoCaoDoanhThuThang();
                bc.Thang = chuyenDi.KhoiHanh.Value.Month;
                bc.Nam = chuyenDi.KhoiHanh.Value.Year;
                db.tblBaoCaoDoanhThuThangs.Add(bc);
                db.SaveChanges();
            }

            bc.SoChuyenDi = db.tblBaoCaoDoanhThuChuyenDis.Count(t => t.KhoiHanh.Value.Month == bc.Thang && t.KhoiHanh.Value.Year == bc.Nam);
            bc.DoanhThu = db.tblBaoCaoDoanhThuChuyenDis.Where(t => t.KhoiHanh.Value.Month == bc.Thang && t.KhoiHanh.Value.Year == bc.Nam).Sum(t => t.DoanhThu);

            db.SaveChanges();
        }

        public static void updateBaoCaoDoanhThuNam(int maChuyen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            //int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();

            tblBaoCaoDoanhThuNam bc = db.tblBaoCaoDoanhThuNams.Where(t => t.Nam == chuyenDi.KhoiHanh.Value.Year).SingleOrDefault();
            if (bc == null)
            {
                bc = new tblBaoCaoDoanhThuNam();
                bc.Nam = chuyenDi.KhoiHanh.Value.Year;
                db.tblBaoCaoDoanhThuNams.Add(bc);
                db.SaveChanges();
            }

            bc.DoanhThu = db.tblBaoCaoDoanhThuChuyenDis.Where(t => t.KhoiHanh.Value.Year == bc.Nam).Sum(t => t.DoanhThu);
            db.SaveChanges();
        }

        public static void updateBaoCaoDoanhThuChuyenDi(int maChuyen)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            //int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());

            tblBaoCaoDoanhThuChuyenDi bc = db.tblBaoCaoDoanhThuChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();
            if (bc == null)
            {
                bc = new tblBaoCaoDoanhThuChuyenDi();
                bc.MaChuyenDi = maChuyen;
                db.tblBaoCaoDoanhThuChuyenDis.Add(bc);
                db.SaveChanges();
            }

            // set value
           
            tblChuyenDi chuyenDi = db.tblChuyenDis.Where(t => t.MaChuyenDi == maChuyen).SingleOrDefault();
            bc.KhoiHanh = chuyenDi.KhoiHanh.Value;
            bc.SoVe = db.tblChiTietPhieuDatChoes.Count(t => t.MaChuyenDi == maChuyen && t.LayVe.Value == true);
            bc.DoanhThu = bc.SoVe * chuyenDi.DonGia;

            db.SaveChanges();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                // Kiểm tra phiếu đã tồn tại chưa
                if (!editMode)
                    phieuDatCho.MaPhieu = new BLL.BLL_PhieuDatCho().getLastestIndex();
                else
                    phieuDatCho = db.tblPhieuDatChoes.Where(t => t.MaPhieu == phieuDatCho.MaPhieu).SingleOrDefault();

                phieuDatCho.HoTen = txtHoTen.Text;
                phieuDatCho.TrungChuyen = txtTrungChuyen.Text;
                phieuDatCho.DienThoai = int.Parse(txtDienThoai.Text);


                // Chi tiết vé
                List<tblChiTietPhieuDatCho> listCTPhieu = new List<tblChiTietPhieuDatCho>();
                BLL.BLL_ChiTietPhieuDatCho temp = new BLL.BLL_ChiTietPhieuDatCho();
                foreach (DataGridViewRow row in dtgGhe.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["ViTriGhe"].Value + ""))
                        continue;


                    tblChiTietPhieuDatCho ctPhieu = new tblChiTietPhieuDatCho();
                    ctPhieu.ViTriGhe = int.Parse(row.Cells["ViTriGhe"].Value.ToString());
                    ctPhieu.LayVe = rdBanVe.Checked;
                    ctPhieu.MaChuyenDi = chuyenDi.MaChuyenDi;
                    ctPhieu.MaPhieu = phieuDatCho.MaPhieu;

                    string message = temp.validateInput(phieuDatCho.MaPhieu, chuyenDi.MaChuyenDi, ctPhieu.ViTriGhe);
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show(message);
                        return;
                    }
                    else
                        listCTPhieu.Add(ctPhieu);
                }
                if (listCTPhieu.ToArray().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập vị trí ghế");
                    return;
                }

                if (phieuDatCho.tblChiTietPhieuDatChoes != null)
                    phieuDatCho.tblChiTietPhieuDatChoes.Clear();
                
                    
                // Thêm chi tiết vé
                int lastCTPhieu = temp.getLastestIndex();
                foreach (var item in listCTPhieu)
                {
                    item.MaCTPhieu = lastCTPhieu++;
                    phieuDatCho.tblChiTietPhieuDatChoes.Add(item);
                }


                // Thông tin phiếu
                string mes = new BLL.BLL_PhieuDatCho().validateInput(phieuDatCho.MaPhieu, phieuDatCho.HoTen, phieuDatCho.DienThoai);
                if (string.IsNullOrEmpty(mes)) // Insert
                {
                    if (!editMode)
                        db.tblPhieuDatChoes.Add(phieuDatCho);
                }
                db.SaveChanges();
                MessageBox.Show("Thành công");
            }
            catch(FormatException)
            {
                MessageBox.Show("Ghế nhập sai. Phải là số nguyên");
            }catch(Exception)
            {
                MessageBox.Show("Lỗi");
            }



            // Đa luồng
            Thread thread = new Thread((ThreadStart)=>
            {
                int maChuyen = int.Parse(txtMaChuyenDi.Text.ToString());
                updateBaoCaoDoanhThuChuyenDi(maChuyen);
                updateBaoCaoDoanhThuThang(maChuyen);
                updateBaoCaoDoanhThuNam(maChuyen);
            });

            thread.Start();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            dtgGhe.Rows.Clear();
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtTrungChuyen.Text = "";
        }
    }
}
