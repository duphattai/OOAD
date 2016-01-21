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
    public partial class frmThayDoiQD : Form
    {
        QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
        public frmThayDoiQD()
        {
            InitializeComponent();
        }

        private void frmThayDoiQD1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        void GetData()
        {
            tblThamSo ts = db.tblThamSoes.ToList().SingleOrDefault();
            txtTGDiToiThieu.Text = ts.ThoiGianDiToiThieu.ToString();
            txtSoBXTGToiDa.Text = ts.BenXeTrungGianToiDa.ToString();
            txtTGDToiDa.Text = ts.ThoiGianDungToiDa.ToString();
            txtTGDToiThieu.Text = ts.ThoiGianDungToiThieu.ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try {
                tblThamSo ts = db.tblThamSoes.ToList().SingleOrDefault();
                ts.ThoiGianDiToiThieu = int.Parse(txtTGDiToiThieu.Text.ToString());
                ts.BenXeTrungGianToiDa = int.Parse(txtSoBXTGToiDa.Text.ToString());
                ts.ThoiGianDungToiDa = int.Parse(txtTGDToiDa.Text.ToString());
                ts.ThoiGianDungToiThieu = int.Parse(txtTGDToiThieu.Text.ToString());
                db.Entry(ts).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                GetData();
            }
            catch { }
        }
    }
}
