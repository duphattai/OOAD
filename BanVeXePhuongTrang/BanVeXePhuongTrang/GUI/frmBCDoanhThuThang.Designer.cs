namespace BanVeXePhuongTrang.GUI
{
    partial class frmBCDoanhThuThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblBaoCaoDoanhThuThangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYXEKHACHDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYXEKHACHDataSet1 = new BanVeXePhuongTrang.QUANLYXEKHACHDataSet();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.qUANLYXEKHACHDataSet = new BanVeXePhuongTrang.QUANLYXEKHACHDataSet();
            this.qUANLYXEKHACHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBaoCaoDoanhThuThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBaoCaoDoanhThuThangTableAdapter = new BanVeXePhuongTrang.QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuThangTableAdapter();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBaoCaoDoanhThuThangBindingSource1
            // 
            this.tblBaoCaoDoanhThuThangBindingSource1.DataMember = "tblBaoCaoDoanhThuThang";
            this.tblBaoCaoDoanhThuThangBindingSource1.DataSource = this.qUANLYXEKHACHDataSet1BindingSource;
            // 
            // qUANLYXEKHACHDataSet1BindingSource
            // 
            this.qUANLYXEKHACHDataSet1BindingSource.DataSource = this.qUANLYXEKHACHDataSet1;
            this.qUANLYXEKHACHDataSet1BindingSource.Position = 0;
            // 
            // qUANLYXEKHACHDataSet1
            // 
            this.qUANLYXEKHACHDataSet1.DataSetName = "QUANLYXEKHACHDataSet";
            this.qUANLYXEKHACHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.reportViewer1);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.Controls.Add(this.btBaoCao);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.cbNam);
            this.panelEx1.Controls.Add(this.cbThang);
            this.panelEx1.Controls.Add(this.Label3);
            this.panelEx1.Controls.Add(this.Label2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1142, 541);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblBaoCaoDoanhThuThangBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BanVeXePhuongTrang.GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1142, 451);
            this.reportViewer1.TabIndex = 82;
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNam.ForeColor = System.Drawing.Color.Blue;
            this.cbNam.Location = new System.Drawing.Point(501, 27);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(72, 27);
            this.cbNam.TabIndex = 39;
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbThang.ForeColor = System.Drawing.Color.Blue;
            this.cbThang.Location = new System.Drawing.Point(349, 27);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(56, 27);
            this.cbThang.TabIndex = 38;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(439, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 23);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Năm:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.Location = new System.Drawing.Point(279, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 23);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "Tháng:";
            // 
            // qUANLYXEKHACHDataSet
            // 
            this.qUANLYXEKHACHDataSet.DataSetName = "QUANLYXEKHACHDataSet";
            this.qUANLYXEKHACHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYXEKHACHDataSetBindingSource
            // 
            this.qUANLYXEKHACHDataSetBindingSource.DataSource = this.qUANLYXEKHACHDataSet;
            this.qUANLYXEKHACHDataSetBindingSource.Position = 0;
            // 
            // tblBaoCaoDoanhThuThangBindingSource
            // 
            this.tblBaoCaoDoanhThuThangBindingSource.DataMember = "tblBaoCaoDoanhThuThang";
            this.tblBaoCaoDoanhThuThangBindingSource.DataSource = this.qUANLYXEKHACHDataSetBindingSource;
            // 
            // tblBaoCaoDoanhThuThangTableAdapter
            // 
            this.tblBaoCaoDoanhThuThangTableAdapter.ClearBeforeFill = true;
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.Location = new System.Drawing.Point(808, 18);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(108, 49);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 81;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBaoCao
            // 
            this.btBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBaoCao.Image = global::BanVeXePhuongTrang.Properties.Resources.Generate_tables_icon;
            this.btBaoCao.Location = new System.Drawing.Point(628, 18);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(124, 49);
            this.btBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btBaoCao.TabIndex = 80;
            this.btBaoCao.Text = "Báo Cáo";
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_3;
            this.PictureBox1.Location = new System.Drawing.Point(31, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // frmBCDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 541);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmBCDoanhThuThang";
            this.Text = "Báo Cáo Doanh Thu Tháng";
            this.Load += new System.EventHandler(this.frmBCDoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ComboBox cbNam;
        internal System.Windows.Forms.ComboBox cbThang;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qUANLYXEKHACHDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuThangBindingSource;
        private BanVeXePhuongTrang.QUANLYXEKHACHDataSet qUANLYXEKHACHDataSet;
        private BanVeXePhuongTrang.QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuThangTableAdapter tblBaoCaoDoanhThuThangTableAdapter;
        private QUANLYXEKHACHDataSet qUANLYXEKHACHDataSet1;
        private System.Windows.Forms.BindingSource qUANLYXEKHACHDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuThangBindingSource1;
    }
}