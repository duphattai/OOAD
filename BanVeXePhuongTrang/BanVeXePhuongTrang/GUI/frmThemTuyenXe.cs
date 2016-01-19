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
        bool editMode;

        public frmThemTuyenXe()
        {
            InitializeComponent();
            editMode = false;
        }

        public frmThemTuyenXe(tblTuyenXe tuyenXe)
        {
            InitializeComponent();
            editMode = true;
            cbbBenXeDen.Enabled = false;
            cbbBenXeDi.Enabled = false;


            foreach (var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
            {
                cbbBenXeDen.Items.Add(item.TenBenXe);
                cbbBenXeDi.Items.Add(item.TenBenXe);
            }
            // Edit mode
            cbbBenXeDi.SelectedItem = tuyenXe.tblBenXe.TenBenXe;
            cbbBenXeDen.SelectedItem = tuyenXe.tblBenXe1.TenBenXe;
            txtMaTuyen.Text = tuyenXe.MaTuyen;

            dtgChiTietTuyen.Rows.Clear();
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            List<tblChiTietTuyen> listChiTietTuyen = tuyenXe.tblChiTietTuyens.ToList();
            for (int i = 0; i < listChiTietTuyen.Count; i++)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dtgChiTietTuyen.Rows[i].Cells["BenXeTrungGian"];
                foreach (var row in db.tblBenXes.Select(t => t.TenBenXe).ToList())
                    cell.Items.Add(row);

                cell.Value = listChiTietTuyen[i].tblBenXe.TenBenXe;
                dtgChiTietTuyen.Rows[i].Cells["ThoiGianDung"].Value = listChiTietTuyen[i].ThoiGianDung;
                dtgChiTietTuyen.Rows[i].Cells["GhiChu"].Value = listChiTietTuyen[i].GhiChu;
            } 
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTuyenXe_Load(object sender, EventArgs e)
        {
            foreach (var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
            {
                cbbBenXeDen.Items.Add(item.TenBenXe);
                cbbBenXeDi.Items.Add(item.TenBenXe);
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

            tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDi.SelectedItem.ToString()).Single();
            tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDen.SelectedItem.ToString()).Single();

            tblTuyenXe tuyenXe = null;
            if (editMode)
            {
                tuyenXe = db.tblTuyenXes.Where(t => t.MaTuyen == txtMaTuyen.Text.ToString()).SingleOrDefault();
                if(tuyenXe == null)
                {
                    MessageBox.Show("Dữ liệu không tồn tại.");
                    return;
                }
            }            
            else
                tuyenXe = new tblTuyenXe();

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

            // Xóa record
            tuyenXe.tblChiTietTuyens.Clear();
            foreach (var item in listCTtuyen)
                tuyenXe.tblChiTietTuyens.Add(item);

            if(!editMode)
            {
                if (new BLL_TuyenXe().canInsert(benXeDi.MaBenXe, benXeDen.MaBenXe))
                    db.tblTuyenXes.Add(tuyenXe);
                else
                    MessageBox.Show("Lưu thất bại");
            }     
            db.SaveChanges();

            MessageBox.Show("Lưu thành công");
        }

        private void dtgChiTietTuyen_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            tblThamSo thamSo = new QUANLYXEKHACHEntities().tblThamSoes.ToArray()[0];
            int maxRow = thamSo.BenXeTrungGianToiDa.Value;
            if (dtgChiTietTuyen.Rows.Count > maxRow)
                dtgChiTietTuyen.AllowUserToAddRows = false;
        }

        private void cbbBenXeDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbbBenXeDen.Text.Equals("") && !cbbBenXeDi.Text.Equals(""))
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDi.SelectedItem.ToString()).Single();
                tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbbBenXeDen.SelectedItem.ToString()).Single();

                txtMaTuyen.Text = benXeDi.MaBenXe + "_" + benXeDen.MaBenXe;
            }
        }

        private void cbbBenXeDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbBenXeDi_SelectedIndexChanged(sender, e);
        }

        private void dtgChiTietTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dtgChiTietTuyen.Rows[e.RowIndex].Cells["BenXeTrungGian"];
                    if (cell.Items.Count == 0)
                    {
                        cell.Value = "";
                        foreach (var row in db.tblBenXes.Select(t => t.TenBenXe).ToList())
                            cell.Items.Add(row);
                    }
                }
            }
            catch
            { }
        }
    }
}
