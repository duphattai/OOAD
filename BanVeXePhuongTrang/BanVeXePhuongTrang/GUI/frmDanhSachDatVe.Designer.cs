namespace BanVeXePhuongTrang.GUI
{
    partial class frmDanhSachDatVe
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDanhSachVe = new System.Windows.Forms.DataGridView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.Thongtin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbbTinhTrangVe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.datVe = new DevComponents.Editors.ComboItem();
            this.daBan = new DevComponents.Editors.ComboItem();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.txtHoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbBenXeDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBenXeDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.HoTen = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaChuyenDi = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaPhieu = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaCTPhieu = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriGhe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.LayVe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachVe)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.Thongtin.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên: ";
            // 
            // dtgDanhSachVe
            // 
            this.dtgDanhSachVe.AllowUserToAddRows = false;
            this.dtgDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.MaChuyenDi,
            this.MaPhieu,
            this.MaCTPhieu,
            this.Tuyen,
            this.DienThoai,
            this.TrungChuyen,
            this.KhoiHanh,
            this.ViTriGhe,
            this.LayVe});
            this.dtgDanhSachVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhSachVe.Location = new System.Drawing.Point(0, 0);
            this.dtgDanhSachVe.MultiSelect = false;
            this.dtgDanhSachVe.Name = "dtgDanhSachVe";
            this.dtgDanhSachVe.Size = new System.Drawing.Size(879, 307);
            this.dtgDanhSachVe.TabIndex = 3;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel3);
            this.panelEx1.Controls.Add(this.Thongtin);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1154, 524);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btSua);
            this.groupPanel3.Controls.Add(this.buttonX1);
            this.groupPanel3.Controls.Add(this.btnCapNhat);
            this.groupPanel3.Controls.Add(this.btnXoa);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(955, 180);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(157, 324);
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
            this.groupPanel3.TabIndex = 96;
            this.groupPanel3.Text = "Chức năng";
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = global::BanVeXePhuongTrang.Properties.Resources.Pencil_icon;
            this.btSua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btSua.Location = new System.Drawing.Point(23, 54);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(106, 32);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 86;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.buttonX1.Location = new System.Drawing.Point(23, 268);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 32);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 83;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Image = global::BanVeXePhuongTrang.Properties.Resources.edit_validated_icon;
            this.btnCapNhat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCapNhat.Location = new System.Drawing.Point(23, 105);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(106, 32);
            this.btnCapNhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapNhat.TabIndex = 84;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_edit_delete_icon;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnXoa.Location = new System.Drawing.Point(23, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 32);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 86;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Thongtin
            // 
            this.Thongtin.CanvasColor = System.Drawing.SystemColors.Control;
            this.Thongtin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Thongtin.Controls.Add(this.cbbTinhTrangVe);
            this.Thongtin.Controls.Add(this.label6);
            this.Thongtin.Controls.Add(this.dtpKhoiHanh);
            this.Thongtin.Controls.Add(this.btnTim);
            this.Thongtin.Controls.Add(this.label2);
            this.Thongtin.Controls.Add(this.txtHoten);
            this.Thongtin.Controls.Add(this.cbbBenXeDen);
            this.Thongtin.Controls.Add(this.label1);
            this.Thongtin.Controls.Add(this.cbbBenXeDi);
            this.Thongtin.Controls.Add(this.txtDienThoai);
            this.Thongtin.Controls.Add(this.label5);
            this.Thongtin.Controls.Add(this.label4);
            this.Thongtin.Controls.Add(this.label3);
            this.Thongtin.DisabledBackColor = System.Drawing.Color.Empty;
            this.Thongtin.Location = new System.Drawing.Point(34, 74);
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Size = new System.Drawing.Size(1078, 101);
            // 
            // 
            // 
            this.Thongtin.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Thongtin.Style.BackColorGradientAngle = 90;
            this.Thongtin.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Thongtin.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Thongtin.Style.BorderBottomWidth = 1;
            this.Thongtin.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Thongtin.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Thongtin.Style.BorderLeftWidth = 1;
            this.Thongtin.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Thongtin.Style.BorderRightWidth = 1;
            this.Thongtin.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Thongtin.Style.BorderTopWidth = 1;
            this.Thongtin.Style.CornerDiameter = 4;
            this.Thongtin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Thongtin.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Thongtin.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Thongtin.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.Thongtin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Thongtin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Thongtin.TabIndex = 92;
            this.Thongtin.Text = "Tìm kiếm";
            // 
            // cbbTinhTrangVe
            // 
            this.cbbTinhTrangVe.DisplayMember = "Text";
            this.cbbTinhTrangVe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTinhTrangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrangVe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrangVe.FormattingEnabled = true;
            this.cbbTinhTrangVe.ItemHeight = 19;
            this.cbbTinhTrangVe.Items.AddRange(new object[] {
            this.datVe,
            this.daBan});
            this.cbbTinhTrangVe.Location = new System.Drawing.Point(660, 45);
            this.cbbTinhTrangVe.Name = "cbbTinhTrangVe";
            this.cbbTinhTrangVe.Size = new System.Drawing.Size(158, 25);
            this.cbbTinhTrangVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTinhTrangVe.TabIndex = 95;
            // 
            // datVe
            // 
            this.datVe.Text = "Đặt vé";
            // 
            // daBan
            // 
            this.daBan.Text = "Đã bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(551, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Tình trạng vé:";
            // 
            // dtpKhoiHanh
            // 
            this.dtpKhoiHanh.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtpKhoiHanh.CustomFormat = "HH:mm dd/MM/ yyyy ";
            this.dtpKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKhoiHanh.Location = new System.Drawing.Point(660, 11);
            this.dtpKhoiHanh.Name = "dtpKhoiHanh";
            this.dtpKhoiHanh.Size = new System.Drawing.Size(158, 26);
            this.dtpKhoiHanh.TabIndex = 93;
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Image = global::BanVeXePhuongTrang.Properties.Resources.Zoom_icon;
            this.btnTim.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnTim.Location = new System.Drawing.Point(944, 11);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 32);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 92;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtHoten
            // 
            // 
            // 
            // 
            this.txtHoten.Border.Class = "TextBoxBorder";
            this.txtHoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoten.ButtonCustom.Tooltip = "";
            this.txtHoten.ButtonCustom2.Tooltip = "";
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(112, 8);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PreventEnterBeep = true;
            this.txtHoten.Size = new System.Drawing.Size(150, 25);
            this.txtHoten.TabIndex = 89;
            // 
            // cbbBenXeDen
            // 
            this.cbbBenXeDen.DisplayMember = "Text";
            this.cbbBenXeDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBenXeDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBenXeDen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBenXeDen.FormattingEnabled = true;
            this.cbbBenXeDen.ItemHeight = 19;
            this.cbbBenXeDen.Location = new System.Drawing.Point(374, 45);
            this.cbbBenXeDen.Name = "cbbBenXeDen";
            this.cbbBenXeDen.Size = new System.Drawing.Size(150, 25);
            this.cbbBenXeDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbBenXeDen.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(275, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "SĐT: ";
            // 
            // cbbBenXeDi
            // 
            this.cbbBenXeDi.DisplayMember = "Text";
            this.cbbBenXeDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBenXeDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBenXeDi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBenXeDi.FormattingEnabled = true;
            this.cbbBenXeDi.ItemHeight = 19;
            this.cbbBenXeDi.Location = new System.Drawing.Point(112, 48);
            this.cbbBenXeDi.Name = "cbbBenXeDi";
            this.cbbBenXeDi.Size = new System.Drawing.Size(150, 25);
            this.cbbBenXeDi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbBenXeDi.TabIndex = 90;
            // 
            // txtDienThoai
            // 
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.ButtonCustom.Tooltip = "";
            this.txtDienThoai.ButtonCustom2.Tooltip = "";
            this.txtDienThoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(374, 10);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PreventEnterBeep = true;
            this.txtDienThoai.Size = new System.Drawing.Size(150, 25);
            this.txtDienThoai.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(551, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khởi hành: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(275, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bến xe đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bến xe đi:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgDanhSachVe);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(34, 180);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(885, 328);
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
            this.groupPanel1.Text = "Danh sách đặt vé";
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(338, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(302, 56);
            this.reflectionLabel1.TabIndex = 87;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">DANH SÁCH VÉ</font></font></b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_31;
            this.PictureBox1.Location = new System.Drawing.Point(70, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 86;
            this.PictureBox1.TabStop = false;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // MaChuyenDi
            // 
            this.MaChuyenDi.HeaderText = "MaChuyenDi";
            this.MaChuyenDi.Name = "MaChuyenDi";
            this.MaChuyenDi.ReadOnly = true;
            this.MaChuyenDi.Visible = false;
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "MaPhieu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Visible = false;
            // 
            // MaCTPhieu
            // 
            this.MaCTPhieu.HeaderText = "MaCTPhieu";
            this.MaCTPhieu.Name = "MaCTPhieu";
            this.MaCTPhieu.ReadOnly = true;
            this.MaCTPhieu.Visible = false;
            // 
            // Tuyen
            // 
            this.Tuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tuyen.DataPropertyName = "Tuyen";
            this.Tuyen.HeaderText = "Tuyến";
            this.Tuyen.Name = "Tuyen";
            this.Tuyen.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // TrungChuyen
            // 
            this.TrungChuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrungChuyen.DataPropertyName = "TrungChuyen";
            this.TrungChuyen.HeaderText = "Trung chuyển";
            this.TrungChuyen.Name = "TrungChuyen";
            this.TrungChuyen.ReadOnly = true;
            this.TrungChuyen.Width = 200;
            // 
            // KhoiHanh
            // 
            this.KhoiHanh.DataPropertyName = "KhoiHanh";
            this.KhoiHanh.HeaderText = "Khởi hành";
            this.KhoiHanh.Name = "KhoiHanh";
            this.KhoiHanh.ReadOnly = true;
            // 
            // ViTriGhe
            // 
            this.ViTriGhe.DataPropertyName = "ViTriGhe";
            this.ViTriGhe.HeaderText = "Ghế";
            this.ViTriGhe.Name = "ViTriGhe";
            this.ViTriGhe.ReadOnly = true;
            this.ViTriGhe.Width = 50;
            // 
            // LayVe
            // 
            this.LayVe.DataPropertyName = "LayVe";
            this.LayVe.HeaderText = "Lấy vé";
            this.LayVe.Name = "LayVe";
            this.LayVe.Width = 50;
            // 
            // frmDanhSachDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 524);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachDatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Phiếu Đặt Chỗ";
            this.Load += new System.EventHandler(this.frmDanhSachDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachVe)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.Thongtin.ResumeLayout(false);
            this.Thongtin.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgDanhSachVe;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoten;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel Thongtin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbBenXeDen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbBenXeDi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnTim;
        internal System.Windows.Forms.DateTimePicker dtpKhoiHanh;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTinhTrangVe;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.ComboItem daBan;
        private DevComponents.Editors.ComboItem datVe;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HoTen;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaChuyenDi;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaPhieu;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaCTPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiHanh;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ViTriGhe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LayVe;
    }
}