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
    public partial class frmThongTinVe : Form
    {
        tblChuyenDi chuyenDi;
        tblPhieuDatCho phieuDatCho;
        public frmThongTinVe(tblChuyenDi chuyenDi, tblPhieuDatCho phieu)
        {
            InitializeComponent();

            this.chuyenDi = chuyenDi;
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
            txtHoTen.Text = phieuDatCho.HoTen.ToString();
            txtDienThoai.Text = phieuDatCho.DienThoai.ToString();
            txtTrungChuyen.Text = phieuDatCho.TrungChuyen.ToString();
            // Thông tin ghế
            dtgGhe.DataSource = db.tblChiTietPhieuDatChoes.Where(t=>t.MaPhieu == phieuDatCho.MaPhieu).Select(t=>t.ViTriGhe).ToList();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            phieuDatCho.HoTen = txtHoTen.Text;
            phieuDatCho.TrungChuyen = txtTrungChuyen.Text;
            phieuDatCho.DienThoai = int.Parse(txtDienThoai.Text);

            List<tblChiTietPhieuDatCho> listCTPhieu = new List<tblChiTietPhieuDatCho>();
            BLL.BLL_ChiTietPhieuDatCho temp = new BLL.BLL_ChiTietPhieuDatCho();
            foreach (DataGridViewRow row in dtgGhe.Rows)
            {
                if (string.IsNullOrEmpty(row.Cells["ViTriGhe"].Value + ""))
                    continue;


                tblChiTietPhieuDatCho ctPhieu = new tblChiTietPhieuDatCho();
                ctPhieu.MaPhieu = phieuDatCho.MaPhieu;
                ctPhieu.ViTriGhe = int.Parse(row.Cells["ViTriGhe"].Value.ToString());
                ctPhieu.LayVe = rdBanVe.Checked;
                ctPhieu.MaCTPhieu = temp.getLastestIndex();
                ctPhieu.MaChuyenDi = chuyenDi.MaChuyenDi;

                string message = temp.validateInput(phieuDatCho.MaPhieu, chuyenDi.MaChuyenDi, ctPhieu.ViTriGhe);
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                    listCTPhieu.Add(ctPhieu);
            }


            if (phieuDatCho.tblChiTietPhieuDatChoes != null)
                phieuDatCho.tblChiTietPhieuDatChoes.Clear();
            if(listCTPhieu.ToArray().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vị trí ghế");
                return;
            }

            foreach (var item in listCTPhieu)
                phieuDatCho.tblChiTietPhieuDatChoes.Add(item);


            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            string mes = new BLL.BLL_PhieuDatCho().validateInput(phieuDatCho.MaPhieu, chuyenDi.MaChuyenDi, phieuDatCho.HoTen);
            if (string.IsNullOrEmpty(mes))
            {
                if (db.tblPhieuDatChoes.Where(t => t.MaPhieu == phieuDatCho.MaPhieu).Count() == 0) // insert
                {
                    phieuDatCho.MaPhieu = new BLL.BLL_PhieuDatCho().getLastestIndex();
                    db.tblPhieuDatChoes.Add(phieuDatCho);
                }
                   
                db.SaveChanges();

                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show(mes);
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
