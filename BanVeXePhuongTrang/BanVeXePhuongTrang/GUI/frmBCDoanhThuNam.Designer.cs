namespace BanVeXePhuongTrang.GUI
{
    partial class frmBCDoanhThuNam
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblBaoCaoDoanhThuNamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYXEKHACHDataSet = new BanVeXePhuongTrang.QUANLYXEKHACHDataSet();
            this.tblBaoCaoDoanhThuNamTableAdapter = new BanVeXePhuongTrang.QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuNamTableAdapter();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuNamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1121, 542);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.reportViewer1);
            this.panelEx2.Controls.Add(this.btThoat);
            this.panelEx2.Controls.Add(this.PictureBox1);
            this.panelEx2.Controls.Add(this.btBaoCao);
            this.panelEx2.Controls.Add(this.cbNam);
            this.panelEx2.Controls.Add(this.Label3);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1121, 542);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNam.ForeColor = System.Drawing.Color.Blue;
            this.cbNam.Location = new System.Drawing.Point(317, 28);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(152, 27);
            this.cbNam.TabIndex = 39;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(254, 32);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(57, 23);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Năm:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblBaoCaoDoanhThuNamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BanVeXePhuongTrang.GUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1121, 452);
            this.reportViewer1.TabIndex = 80;
            // 
            // tblBaoCaoDoanhThuNamBindingSource
            // 
            this.tblBaoCaoDoanhThuNamBindingSource.DataMember = "tblBaoCaoDoanhThuNam";
            this.tblBaoCaoDoanhThuNamBindingSource.DataSource = this.qUANLYXEKHACHDataSet;
            // 
            // qUANLYXEKHACHDataSet
            // 
            this.qUANLYXEKHACHDataSet.DataSetName = "QUANLYXEKHACHDataSet";
            this.qUANLYXEKHACHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBaoCaoDoanhThuNamTableAdapter
            // 
            this.tblBaoCaoDoanhThuNamTableAdapter.ClearBeforeFill = true;
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.Location = new System.Drawing.Point(752, 14);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(108, 49);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 79;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_31;
            this.PictureBox1.Location = new System.Drawing.Point(51, 14);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 78;
            this.PictureBox1.TabStop = false;
            // 
            // btBaoCao
            // 
            this.btBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBaoCao.Image = global::BanVeXePhuongTrang.Properties.Resources.Generate_tables_icon;
            this.btBaoCao.Location = new System.Drawing.Point(572, 14);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(124, 49);
            this.btBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btBaoCao.TabIndex = 75;
            this.btBaoCao.Text = "Báo Cáo";
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // frmBCDoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 542);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmBCDoanhThuNam";
            this.Text = "Báo Cáo Doanh Thu Nam";
            this.Load += new System.EventHandler(this.frmBCDoanhThuNam_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCaoDoanhThuNamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYXEKHACHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btBaoCao;
        internal System.Windows.Forms.ComboBox cbNam;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QUANLYXEKHACHDataSet qUANLYXEKHACHDataSet;
        private System.Windows.Forms.BindingSource tblBaoCaoDoanhThuNamBindingSource;
        private QUANLYXEKHACHDataSetTableAdapters.tblBaoCaoDoanhThuNamTableAdapter tblBaoCaoDoanhThuNamTableAdapter;
    }
}