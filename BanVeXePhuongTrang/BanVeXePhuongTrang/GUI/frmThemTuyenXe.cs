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
using BanVeXePhuongTrang.BLL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThemTuyenXe : Form
    {
        public frmThemTuyenXe()
        {
            InitializeComponent();
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbMaSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbTenBenDen.Text.Equals("") && !cbTenBenDi.Text.Equals(""))
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDi.SelectedItem.ToString()).Single();
                tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDen.SelectedItem.ToString()).Single();
                
                txtMaTuyen.Text = benXeDi.MaBenXe + "_" + benXeDen.MaBenXe;
            }
        }

        private void cbMaSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaSanBayDi_SelectedIndexChanged(sender, e);
        }

        private void frmThemTuyenXe_Load(object sender, EventArgs e)
        {
            foreach (var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
            {
                cbTenBenDen.Items.Add(item.TenBenXe);
                cbTenBenDi.Items.Add(item.TenBenXe);
            }
        }


        private List<tblChiTietTuyen> solveDataInputChiTietTuyen()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            List<tblChiTietTuyen> list = new List<tblChiTietTuyen>();

            foreach (DataGridViewRow row in dtgChiTietTuyen.Rows)
            {
                if (string.IsNullOrEmpty(row.Cells[0].Value + "") && string.IsNullOrEmpty(row.Cells[1].Value + ""))
                    break;

                string MaBenXeTrungGian = "";
                string tenBenXe = row.Cells[0].Value.ToString();
                tblBenXe benXe = db.tblBenXes.Where(t => t.TenBenXe == tenBenXe).SingleOrDefault();
                if (benXe != null)
                    MaBenXeTrungGian = benXe.MaBenXe;

                tblChiTietTuyen temp = new tblChiTietTuyen();
                temp.MaBenXeTrungGiang = MaBenXeTrungGian;
                if (!string.IsNullOrEmpty(row.Cells[1].Value + ""))
                    temp.ThoiGianDung = int.Parse(row.Cells[1].Value.ToString());
                else
                    temp.ThoiGianDung = 0;
                temp.MaTuyen = txtMaTuyen.Text.ToString();
                if (row.Cells[2].Value != null)
                    temp.GhiChu = row.Cells[2].Value.ToString();
                else
                    temp.GhiChu = "";

                list.Add(temp);
            }

            return list;
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDi.SelectedItem.ToString()).Single();
            tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDen.SelectedItem.ToString()).Single();

            BLL_TuyenXe temp = new BLL_TuyenXe();
            if(temp.canInsert(benXeDi.MaBenXe, benXeDen.MaBenXe))
            {
                tblTuyenXe tuyenXe = new tblTuyenXe();
                tuyenXe.MaBenXeDi = benXeDi.MaBenXe;
                tuyenXe.MaBenXeDen = benXeDen.MaBenXe;
                tuyenXe.MaTuyen = txtMaTuyen.Text.ToString();

                BLL_ChiTietTuyenXe CtTuyen = new BLL_ChiTietTuyenXe();
                List<tblChiTietTuyen> listCTtuyen = solveDataInputChiTietTuyen();
                foreach (var item in listCTtuyen)
                {
                    string mes = CtTuyen.validateInput(item.MaTuyen, item.ThoiGianDung);
                    if (!string.IsNullOrEmpty(mes))
                    {
                        MessageBox.Show(mes);
                        return;
                    }
                }

                foreach (var item in listCTtuyen)
                    tuyenXe.tblChiTietTuyens.Add(item);


                db.tblTuyenXes.Add(tuyenXe);
                db.SaveChanges();

                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");
        }


        private void dtgChiTietTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dtgChiTietTuyen.Rows[e.RowIndex].Cells["BenXe"];
                    if (cell.Items.Count == 0)
                    {
                        cell.Value = "";
                        foreach (var row in db.tblBenXes.Select(t => t.TenBenXe).ToList())
                            cell.Items.Add(row);
                    }
                }
            }catch
            { }
           
        }
    }
}
