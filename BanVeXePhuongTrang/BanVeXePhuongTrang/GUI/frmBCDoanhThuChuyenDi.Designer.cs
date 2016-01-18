namespace BanVeXePhuongTrang.GUI
{
    partial class frmBCDoanhThuChuyenDi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblBaoCaoDoanhThuThangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYXEKHACHDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYXEKHACHDataSet1 = new BanVeXePhuongTrang.QUANLYXEKHACHDataSet();
            this.qUANLYXEKHACHDataSet = new BanVeXePhuongTrang.QUANLYXEKHACHDataSet();
            this.qUANLYXEKHACHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBaoCaoDoanhThuThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBaoCaoDoanhThuThangTableAdapter = new BanVeXePhuongTrang.QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuThangTableAdapter();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblBaoCaoDoanhThuChuyenDiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBaoCaoDoanhThuChuyenDiTableAdapter = new BanVeXePhuongTrang.QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuChuyenDiTableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuChuyenDiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.reportViewer1);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.Controls.Add(this.btBaoCao);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1013, 545);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblBaoCaoDoanhThuChuyenDiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BanVeXePhuongTrang.GUI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1013, 451);
            this.reportViewer1.TabIndex = 82;
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
            this.btThoat.Location = new System.Drawing.Point(600, 18);
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
            this.btBaoCao.Location = new System.Drawing.Point(364, 18);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(124, 49);
            this.btBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btBaoCao.TabIndex = 80;
            this.btBaoCao.Text = "Báo Cáo";
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_31;
            this.PictureBox1.Location = new System.Drawing.Point(31, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // tblBaoCaoDoanhThuChuyenDiBindingSource
            // 
            this.tblBaoCaoDoanhThuChuyenDiBindingSource.DataMember = "tblBaoCaoDoanhThuChuyenDi";
            this.tblBaoCaoDoanhThuChuyenDiBindingSource.DataSource = this.qUANLYXEKHACHDataSet1;
            // 
            // tblBaoCaoDoanhThuChuyenDiTableAdapter
            // 
            this.tblBaoCaoDoanhThuChuyenDiTableAdapter.ClearBeforeFill = true;
            // 
            // frmBCDoanhThuChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmBCDoanhThuChuyenDi";
            this.Text = "frmBCDoanhThuChuyenDi";
            this.Load += new System.EventHandler(this.frmBCDoanhThuChuyenDi_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuChuyenDiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuThangBindingSource1;
        private System.Windows.Forms.BindingSource qUANLYXEKHACHDataSet1BindingSource;
        private QUANLYXEKHACHDataSet qUANLYXEKHACHDataSet1;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btBaoCao;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private QUANLYXEKHACHDataSet qUANLYXEKHACHDataSet;
        private System.Windows.Forms.BindingSource qUANLYXEKHACHDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuThangBindingSource;
        private QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuThangTableAdapter tblBaoCaoDoanhThuThangTableAdapter;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuChuyenDiBindingSource;
        private QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuChuyenDiTableAdapter tblBaoCaoDoanhThuChuyenDiTableAdapter;
    }
}