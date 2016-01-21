namespace BanVeXePhuongTrang.GUI
{
    partial class frmQuanLyTrungChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTrungChuyen));
            this.dtgDanhSachTC = new System.Windows.Forms.DataGridView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.dtpKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.HoTen_KH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaPhieu_KH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.SDT_KH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.DiaDiem_KH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.SoVe_KH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.cbbXeTrungChuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.HoTen = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaPhieu = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.SDT = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.DiaDiem = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.SoVe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.DaRuoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachTC)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDanhSachTC
            // 
            this.dtgDanhSachTC.AllowUserToAddRows = false;
            this.dtgDanhSachTC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgDanhSachTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.MaPhieu,
            this.SDT,
            this.DiaDiem,
            this.SoVe,
            this.DaRuoc});
            this.dtgDanhSachTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhSachTC.Location = new System.Drawing.Point(0, 0);
            this.dtgDanhSachTC.Name = "dtgDanhSachTC";
            this.dtgDanhSachTC.Size = new System.Drawing.Size(480, 268);
            this.dtgDanhSachTC.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnTim);
            this.panelEx2.Controls.Add(this.dtpKhoiHanh);
            this.panelEx2.Controls.Add(this.label5);
            this.panelEx2.Controls.Add(this.groupPanel3);
            this.panelEx2.Controls.Add(this.cbbXeTrungChuyen);
            this.panelEx2.Controls.Add(this.label3);
            this.panelEx2.Controls.Add(this.groupPanel1);
            this.panelEx2.Controls.Add(this.groupPanel2);
            this.panelEx2.Controls.Add(this.reflectionLabel1);
            this.panelEx2.Controls.Add(this.PictureBox1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1176, 513);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Image = global::BanVeXePhuongTrang.Properties.Resources.Zoom_icon;
            this.btnTim.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnTim.Location = new System.Drawing.Point(990, 139);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 32);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 98;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpKhoiHanh
            // 
            this.dtpKhoiHanh.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtpKhoiHanh.CustomFormat = "HH:mm dd/MM/ yyyy ";
            this.dtpKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKhoiHanh.Location = new System.Drawing.Point(800, 143);
            this.dtpKhoiHanh.Name = "dtpKhoiHanh";
            this.dtpKhoiHanh.Size = new System.Drawing.Size(158, 26);
            this.dtpKhoiHanh.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(704, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 96;
            this.label5.Text = "Khởi hành: ";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dtgKhachHang);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(657, 183);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(481, 289);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 95;
            this.groupPanel3.Text = "Thông tin khách";
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.AllowUserToAddRows = false;
            this.dtgKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen_KH,
            this.MaPhieu_KH,
            this.SDT_KH,
            this.DiaDiem_KH,
            this.SoVe_KH});
            this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dtgKhachHang.MultiSelect = false;
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(475, 268);
            this.dtgKhachHang.TabIndex = 0;
            // 
            // HoTen_KH
            // 
            this.HoTen_KH.DataPropertyName = "HoTen";
            this.HoTen_KH.FillWeight = 250F;
            this.HoTen_KH.HeaderText = "Họ tên";
            this.HoTen_KH.Name = "HoTen_KH";
            this.HoTen_KH.Width = 150;
            // 
            // MaPhieu_KH
            // 
            this.MaPhieu_KH.DataPropertyName = "MaPhieu";
            this.MaPhieu_KH.HeaderText = "MaPhieu";
            this.MaPhieu_KH.Name = "MaPhieu_KH";
            this.MaPhieu_KH.ReadOnly = true;
            this.MaPhieu_KH.Visible = false;
            // 
            // SDT_KH
            // 
            this.SDT_KH.DataPropertyName = "SDT";
            this.SDT_KH.HeaderText = "SĐT";
            this.SDT_KH.Name = "SDT_KH";
            // 
            // DiaDiem_KH
            // 
            this.DiaDiem_KH.DataPropertyName = "DiaDiem";
            this.DiaDiem_KH.HeaderText = "Địa điểm";
            this.DiaDiem_KH.Name = "DiaDiem_KH";
            // 
            // SoVe_KH
            // 
            this.SoVe_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoVe_KH.DataPropertyName = "SoVe";
            this.SoVe_KH.HeaderText = "Số vé";
            this.SoVe_KH.Name = "SoVe_KH";
            // 
            // cbbXeTrungChuyen
            // 
            this.cbbXeTrungChuyen.DisplayMember = "Text";
            this.cbbXeTrungChuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbXeTrungChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbXeTrungChuyen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbXeTrungChuyen.FormattingEnabled = true;
            this.cbbXeTrungChuyen.ItemHeight = 19;
            this.cbbXeTrungChuyen.Location = new System.Drawing.Point(187, 146);
            this.cbbXeTrungChuyen.Name = "cbbXeTrungChuyen";
            this.cbbXeTrungChuyen.Size = new System.Drawing.Size(304, 25);
            this.cbbXeTrungChuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbXeTrungChuyen.TabIndex = 94;
            this.cbbXeTrungChuyen.SelectedIndexChanged += new System.EventHandler(this.cbbXeTrungChuyen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(61, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 93;
            this.label3.Text = "Xe trung chuyển:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgDanhSachTC);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(40, 183);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(486, 289);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 91;
            this.groupPanel1.Text = "Thông tin chi tiết trung chuyển";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btCapNhat);
            this.groupPanel2.Controls.Add(this.btnThoat);
            this.groupPanel2.Controls.Add(this.btThoat);
            this.groupPanel2.Controls.Add(this.btThem);
            this.groupPanel2.Controls.Add(this.btXoa);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(532, 183);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(119, 286);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 92;
            this.groupPanel2.Text = "Chức năng";
            // 
            // btCapNhat
            // 
            this.btCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCapNhat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCapNhat.Image = global::BanVeXePhuongTrang.Properties.Resources.Save_icon;
            this.btCapNhat.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btCapNhat.Location = new System.Drawing.Point(3, 119);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(106, 29);
            this.btCapNhat.TabIndex = 88;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btnThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnThoat.Location = new System.Drawing.Point(3, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 32);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 87;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(48, 313);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 32);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 83;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThem.Location = new System.Drawing.Point(3, 43);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 32);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.TabIndex = 86;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btXoa.Location = new System.Drawing.Point(3, 81);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 32);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 86;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(289, 31);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(361, 56);
            this.reflectionLabel1.TabIndex = 85;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">QUẢN LÝ TRUNG CHUYỂN</font></font" +
    "></b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_3;
            this.PictureBox1.Location = new System.Drawing.Point(101, 31);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
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
            this.panelEx1.Size = new System.Drawing.Size(1176, 513);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 250F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "MaPhieuTC";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Visible = false;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // DiaDiem
            // 
            this.DiaDiem.HeaderText = "Địa diểm";
            this.DiaDiem.Name = "DiaDiem";
            // 
            // SoVe
            // 
            this.SoVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoVe.HeaderText = "Số vé";
            this.SoVe.Name = "SoVe";
            // 
            // DaRuoc
            // 
            this.DaRuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DaRuoc.DataPropertyName = "DaRuoc";
            this.DaRuoc.HeaderText = "Đã rướt";
            this.DaRuoc.Name = "DaRuoc";
            // 
            // frmQuanLyTrungChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 513);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmQuanLyTrungChuyen";
            this.Text = "Quản lý trung chuyển";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachTC)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachTC;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbXeTrungChuyen;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dtpKhoiHanh;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HoTen_KH;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaPhieu_KH;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn SDT_KH;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn DiaDiem_KH;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn SoVe_KH;
        private DevComponents.DotNetBar.ButtonX btCapNhat;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HoTen;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaPhieu;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn SDT;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn DiaDiem;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn SoVe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaRuoc;
    }
}