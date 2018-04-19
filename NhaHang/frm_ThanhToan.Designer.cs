namespace NhaHang
{
    partial class frm_ChonBan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gc_ChonMon = new DevExpress.XtraGrid.GridControl();
            this.gv_ChonMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cChon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_CheckChon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenMonAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repository_SoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_SoHD = new DevExpress.XtraEditors.TextEdit();
            this.cbb_Ban = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_GhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.Lbl_SoHD = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gc_list = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cID_CT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cID_HD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ccTenMonAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cID_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ccSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ccDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_TaoHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_BoChonAll = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BoChon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Chon = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChonMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChonMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_CheckChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Ban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(469, 561);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn món";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_ChonMon);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 183);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(465, 376);
            this.panelControl3.TabIndex = 5;
            // 
            // gc_ChonMon
            // 
            this.gc_ChonMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ChonMon.Location = new System.Drawing.Point(2, 2);
            this.gc_ChonMon.MainView = this.gv_ChonMon;
            this.gc_ChonMon.Name = "gc_ChonMon";
            this.gc_ChonMon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repository_SoLuong,
            this.rep_CheckChon});
            this.gc_ChonMon.Size = new System.Drawing.Size(461, 372);
            this.gc_ChonMon.TabIndex = 0;
            this.gc_ChonMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ChonMon});
            // 
            // gv_ChonMon
            // 
            this.gv_ChonMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cChon,
            this.cID,
            this.cTenMonAn,
            this.cSoLuong,
            this.cDonGia});
            this.gv_ChonMon.GridControl = this.gc_ChonMon;
            this.gv_ChonMon.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DonGia", this.cDonGia, "N0")});
            this.gv_ChonMon.Name = "gv_ChonMon";
            this.gv_ChonMon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_ChonMon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_ChonMon.OptionsSelection.MultiSelect = true;
            // 
            // cChon
            // 
            this.cChon.AppearanceHeader.Options.UseTextOptions = true;
            this.cChon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cChon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cChon.Caption = "Chọn";
            this.cChon.ColumnEdit = this.rep_CheckChon;
            this.cChon.FieldName = "Chon";
            this.cChon.Name = "cChon";
            this.cChon.Visible = true;
            this.cChon.VisibleIndex = 0;
            this.cChon.Width = 35;
            // 
            // rep_CheckChon
            // 
            this.rep_CheckChon.AutoHeight = false;
            this.rep_CheckChon.Name = "rep_CheckChon";
            this.rep_CheckChon.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.rep_CheckChon.CheckedChanged += new System.EventHandler(this.rep_CheckChon_CheckedChanged);
            // 
            // cID
            // 
            this.cID.AppearanceHeader.Options.UseTextOptions = true;
            this.cID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cID.Caption = "ID";
            this.cID.FieldName = "ID";
            this.cID.Name = "cID";
            this.cID.OptionsColumn.AllowEdit = false;
            this.cID.Width = 35;
            // 
            // cTenMonAn
            // 
            this.cTenMonAn.AppearanceHeader.Options.UseTextOptions = true;
            this.cTenMonAn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cTenMonAn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTenMonAn.Caption = "Tên món";
            this.cTenMonAn.FieldName = "TenMonAn";
            this.cTenMonAn.Name = "cTenMonAn";
            this.cTenMonAn.OptionsColumn.AllowEdit = false;
            this.cTenMonAn.Visible = true;
            this.cTenMonAn.VisibleIndex = 1;
            this.cTenMonAn.Width = 155;
            // 
            // cSoLuong
            // 
            this.cSoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.cSoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cSoLuong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.cSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cSoLuong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cSoLuong.Caption = "Số lượng";
            this.cSoLuong.ColumnEdit = this.repository_SoLuong;
            this.cSoLuong.FieldName = "SoLuong";
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Visible = true;
            this.cSoLuong.VisibleIndex = 2;
            this.cSoLuong.Width = 34;
            // 
            // repository_SoLuong
            // 
            this.repository_SoLuong.AutoHeight = false;
            this.repository_SoLuong.Mask.EditMask = "\\d+";
            this.repository_SoLuong.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repository_SoLuong.Name = "repository_SoLuong";
            // 
            // cDonGia
            // 
            this.cDonGia.AppearanceCell.Options.UseTextOptions = true;
            this.cDonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cDonGia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.cDonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cDonGia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonGia.Caption = "Đơn giá";
            this.cDonGia.FieldName = "DonGia";
            this.cDonGia.Name = "cDonGia";
            this.cDonGia.OptionsColumn.AllowEdit = false;
            this.cDonGia.Visible = true;
            this.cDonGia.VisibleIndex = 3;
            this.cDonGia.Width = 180;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_SoHD);
            this.panelControl2.Controls.Add(this.cbb_Ban);
            this.panelControl2.Controls.Add(this.txt_GhiChu);
            this.panelControl2.Controls.Add(this.Lbl_SoHD);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(465, 162);
            this.panelControl2.TabIndex = 4;
            // 
            // txt_SoHD
            // 
            this.txt_SoHD.Location = new System.Drawing.Point(104, 18);
            this.txt_SoHD.Name = "txt_SoHD";
            this.txt_SoHD.Properties.ReadOnly = true;
            this.txt_SoHD.Size = new System.Drawing.Size(98, 20);
            this.txt_SoHD.TabIndex = 5;
            // 
            // cbb_Ban
            // 
            this.cbb_Ban.Location = new System.Drawing.Point(332, 15);
            this.cbb_Ban.Name = "cbb_Ban";
            this.cbb_Ban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_Ban.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Ban", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenBan", 120, "Tên bàn")});
            this.cbb_Ban.Properties.NullText = "Chọn bàn";
            this.cbb_Ban.Size = new System.Drawing.Size(100, 20);
            this.cbb_Ban.TabIndex = 4;
            this.cbb_Ban.EditValueChanged += new System.EventHandler(this.cbb_Ban_EditValueChanged);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(104, 50);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(328, 96);
            this.txt_GhiChu.TabIndex = 3;
            // 
            // Lbl_SoHD
            // 
            this.Lbl_SoHD.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SoHD.Location = new System.Drawing.Point(44, 18);
            this.Lbl_SoHD.Name = "Lbl_SoHD";
            this.Lbl_SoHD.Size = new System.Drawing.Size(37, 13);
            this.Lbl_SoHD.TabIndex = 0;
            this.Lbl_SoHD.Text = "Số HĐ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(260, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn bàn:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(37, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.panelControl5);
            this.groupControl2.Controls.Add(this.panelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(660, 561);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Món ăn đã chọn";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gc_list);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 21);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(656, 468);
            this.panelControl5.TabIndex = 7;
            // 
            // gc_list
            // 
            this.gc_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_list.Location = new System.Drawing.Point(2, 2);
            this.gc_list.MainView = this.gridView2;
            this.gc_list.Name = "gc_list";
            this.gc_list.Size = new System.Drawing.Size(652, 464);
            this.gc_list.TabIndex = 5;
            this.gc_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cID_CT,
            this.cID_HD,
            this.ccTenMonAn,
            this.cID_MA,
            this.ccSoLuong,
            this.ccDonGia,
            this.cThanhTien});
            this.gridView2.GridControl = this.gc_list;
            this.gridView2.Name = "gridView2";
            // 
            // cID_CT
            // 
            this.cID_CT.Caption = "ID chi tiết";
            this.cID_CT.FieldName = "ID_CT";
            this.cID_CT.Name = "cID_CT";
            // 
            // cID_HD
            // 
            this.cID_HD.Caption = "ID hóa đơn";
            this.cID_HD.FieldName = "ID_HD";
            this.cID_HD.Name = "cID_HD";
            this.cID_HD.Visible = true;
            this.cID_HD.VisibleIndex = 0;
            // 
            // ccTenMonAn
            // 
            this.ccTenMonAn.Caption = "Tên món ăn";
            this.ccTenMonAn.FieldName = "TenMonAn";
            this.ccTenMonAn.Name = "ccTenMonAn";
            this.ccTenMonAn.Visible = true;
            this.ccTenMonAn.VisibleIndex = 1;
            // 
            // cID_MA
            // 
            this.cID_MA.Caption = "ID món ăn";
            this.cID_MA.FieldName = "ID_MA";
            this.cID_MA.Name = "cID_MA";
            // 
            // ccSoLuong
            // 
            this.ccSoLuong.Caption = "Số lượng";
            this.ccSoLuong.FieldName = "SoLuong";
            this.ccSoLuong.Name = "ccSoLuong";
            this.ccSoLuong.Visible = true;
            this.ccSoLuong.VisibleIndex = 2;
            // 
            // ccDonGia
            // 
            this.ccDonGia.Caption = "Đơn giá";
            this.ccDonGia.FieldName = "DonGia";
            this.ccDonGia.Name = "ccDonGia";
            this.ccDonGia.Visible = true;
            this.ccDonGia.VisibleIndex = 3;
            // 
            // cThanhTien
            // 
            this.cThanhTien.Caption = "Thành tiền";
            this.cThanhTien.DisplayFormat.FormatString = "N0";
            this.cThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cThanhTien.FieldName = "ThanhTien";
            this.cThanhTien.Name = "cThanhTien";
            this.cThanhTien.Visible = true;
            this.cThanhTien.VisibleIndex = 4;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_TaoHoaDon);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 489);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(656, 70);
            this.panelControl4.TabIndex = 6;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.Appearance.Options.UseFont = true;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(15, 22);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(95, 38);
            this.btn_TaoHoaDon.TabIndex = 0;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_BoChonAll);
            this.panelControl1.Controls.Add(this.btn_BoChon);
            this.panelControl1.Controls.Add(this.btn_Chon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(56, 561);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_BoChonAll
            // 
            this.btn_BoChonAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoChonAll.Appearance.Options.UseFont = true;
            this.btn_BoChonAll.Location = new System.Drawing.Point(7, 197);
            this.btn_BoChonAll.Name = "btn_BoChonAll";
            this.btn_BoChonAll.Size = new System.Drawing.Size(46, 23);
            this.btn_BoChonAll.TabIndex = 0;
            this.btn_BoChonAll.Text = "<<<";
            this.btn_BoChonAll.ToolTip = "Bỏ chọn tất cả";
            // 
            // btn_BoChon
            // 
            this.btn_BoChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoChon.Appearance.Options.UseFont = true;
            this.btn_BoChon.Location = new System.Drawing.Point(6, 160);
            this.btn_BoChon.Name = "btn_BoChon";
            this.btn_BoChon.Size = new System.Drawing.Size(46, 23);
            this.btn_BoChon.TabIndex = 0;
            this.btn_BoChon.Text = "<<";
            this.btn_BoChon.ToolTip = "Bỏ chọn";
            // 
            // btn_Chon
            // 
            this.btn_Chon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Appearance.Options.UseFont = true;
            this.btn_Chon.Location = new System.Drawing.Point(6, 125);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(46, 23);
            this.btn_Chon.TabIndex = 0;
            this.btn_Chon.Text = ">>";
            this.btn_Chon.ToolTip = "Chọn";
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1195, 561);
            this.splitContainerControl1.SplitterPosition = 530;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(530, 561);
            this.splitContainerControl2.SplitterPosition = 469;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // frm_ChonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 561);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frm_ChonBan";
            this.Text = "Chọn bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChonMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChonMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_CheckChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Ban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txt_GhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_BoChonAll;
        private DevExpress.XtraEditors.SimpleButton btn_BoChon;
        private DevExpress.XtraEditors.SimpleButton btn_Chon;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gc_ChonMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChonMon;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn cID;
        private DevExpress.XtraGrid.Columns.GridColumn cTenMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn cSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repository_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn cDonGia;
        private DevExpress.XtraEditors.LookUpEdit cbb_Ban;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.Columns.GridColumn cChon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_CheckChon;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_TaoHoaDon;
        private DevExpress.XtraEditors.TextEdit txt_SoHD;
        private DevExpress.XtraEditors.LabelControl Lbl_SoHD;
        private DevExpress.XtraGrid.Columns.GridColumn cID_CT;
        private DevExpress.XtraGrid.Columns.GridColumn cID_HD;
        private DevExpress.XtraGrid.Columns.GridColumn cID_MA;
        private DevExpress.XtraGrid.Columns.GridColumn ccDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ccSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ccTenMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn cThanhTien;
    }
}