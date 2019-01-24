﻿namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class OdemeBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colPortfoyNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colOdemeTuruAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGirisTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colVade = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTahsil = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTahsilde = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIade = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKalan = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaSubeId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBelgeNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHesapNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAsilBorclu = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colCiranta = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTutarYazi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colVadeYazi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBelgeDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSonHareketTarih = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSonIslemYeri = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryBankaHesap = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryBankaSube = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBankaHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBankaSube)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 304);
            this.insUptNavigator.Size = new System.Drawing.Size(790, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal,
            this.repositoryBankaHesap,
            this.repositoryBanka,
            this.repositoryBankaSube});
            this.grid.Size = new System.Drawing.Size(790, 304);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPortfoyNo,
            this.colOdemeTuruAdi,
            this.colBankaHesapAdi,
            this.colGirisTarihi,
            this.colVade,
            this.colTahsil,
            this.colTahsilde,
            this.colIade,
            this.colKalan,
            this.colBankaId,
            this.colBankaAdi,
            this.colBankaSubeId,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colTutarYazi,
            this.colVadeYazi,
            this.colAciklama,
            this.colBelgeDurumu,
            this.colSonHareketTarih,
            this.colSonIslemYeri});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowColumnMoving = false;
            this.tablo.OptionsCustomization.AllowSort = false;
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Ödeme Bilgileri";
            // 
            // colPortfoyNo
            // 
            this.colPortfoyNo.Caption = "Portföy No";
            this.colPortfoyNo.FieldName = "Id";
            this.colPortfoyNo.Name = "colPortfoyNo";
            this.colPortfoyNo.OptionsColumn.AllowEdit = false;
            this.colPortfoyNo.OptionsFilter.AllowAutoFilter = false;
            this.colPortfoyNo.OptionsFilter.AllowFilter = false;
            this.colPortfoyNo.StatusBarAciklama = null;
            this.colPortfoyNo.StatusBarKisayol = null;
            this.colPortfoyNo.StatusBarKisayolAciklama = null;
            this.colPortfoyNo.Visible = true;
            this.colPortfoyNo.VisibleIndex = 0;
            this.colPortfoyNo.Width = 85;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme  Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsFilter.AllowAutoFilter = false;
            this.colOdemeTuruAdi.OptionsFilter.AllowFilter = false;
            this.colOdemeTuruAdi.StatusBarAciklama = null;
            this.colOdemeTuruAdi.StatusBarKisayol = null;
            this.colOdemeTuruAdi.StatusBarKisayolAciklama = null;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            this.colOdemeTuruAdi.Width = 85;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Banka Hesap Adı";
            this.colBankaHesapAdi.ColumnEdit = this.repositoryBankaHesap;
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaHesapAdi.OptionsFilter.AllowFilter = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisayol = null;
            this.colBankaHesapAdi.StatusBarKisayolAciklama = null;
            this.colBankaHesapAdi.Width = 150;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giriş Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colGirisTarihi.OptionsFilter.AllowFilter = false;
            this.colGirisTarihi.StatusBarAciklama = null;
            this.colGirisTarihi.StatusBarKisayol = null;
            this.colGirisTarihi.StatusBarKisayolAciklama = null;
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.VisibleIndex = 2;
            this.colGirisTarihi.Width = 85;
            // 
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryTarih;
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.OptionsFilter.AllowAutoFilter = false;
            this.colVade.OptionsFilter.AllowFilter = false;
            this.colVade.StatusBarAciklama = null;
            this.colVade.StatusBarKisayol = null;
            this.colVade.StatusBarKisayolAciklama = null;
            this.colVade.Visible = true;
            this.colVade.VisibleIndex = 3;
            this.colVade.Width = 85;
            // 
            // colTahsil
            // 
            this.colTahsil.Caption = "Tahsil";
            this.colTahsil.ColumnEdit = this.repositoryDecimal;
            this.colTahsil.FieldName = "Tahsil";
            this.colTahsil.Name = "colTahsil";
            this.colTahsil.OptionsColumn.AllowEdit = false;
            this.colTahsil.OptionsFilter.AllowAutoFilter = false;
            this.colTahsil.OptionsFilter.AllowFilter = false;
            this.colTahsil.StatusBarAciklama = null;
            this.colTahsil.StatusBarKisayol = null;
            this.colTahsil.StatusBarKisayolAciklama = null;
            this.colTahsil.Visible = true;
            this.colTahsil.VisibleIndex = 4;
            this.colTahsil.Width = 95;
            // 
            // colTahsilde
            // 
            this.colTahsilde.Caption = "Tahsilde";
            this.colTahsilde.ColumnEdit = this.repositoryDecimal;
            this.colTahsilde.FieldName = "Tahsilde";
            this.colTahsilde.Name = "colTahsilde";
            this.colTahsilde.OptionsColumn.AllowEdit = false;
            this.colTahsilde.OptionsFilter.AllowAutoFilter = false;
            this.colTahsilde.OptionsFilter.AllowFilter = false;
            this.colTahsilde.StatusBarAciklama = null;
            this.colTahsilde.StatusBarKisayol = null;
            this.colTahsilde.StatusBarKisayolAciklama = null;
            this.colTahsilde.Visible = true;
            this.colTahsilde.VisibleIndex = 5;
            this.colTahsilde.Width = 95;
            // 
            // colIade
            // 
            this.colIade.Caption = "İade";
            this.colIade.ColumnEdit = this.repositoryDecimal;
            this.colIade.FieldName = "Iade";
            this.colIade.Name = "colIade";
            this.colIade.OptionsColumn.AllowEdit = false;
            this.colIade.OptionsFilter.AllowAutoFilter = false;
            this.colIade.OptionsFilter.AllowFilter = false;
            this.colIade.StatusBarAciklama = null;
            this.colIade.StatusBarKisayol = null;
            this.colIade.StatusBarKisayolAciklama = null;
            this.colIade.Visible = true;
            this.colIade.VisibleIndex = 6;
            this.colIade.Width = 95;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan";
            this.colKalan.ColumnEdit = this.repositoryDecimal;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.OptionsFilter.AllowAutoFilter = false;
            this.colKalan.OptionsFilter.AllowFilter = false;
            this.colKalan.StatusBarAciklama = null;
            this.colKalan.StatusBarKisayol = null;
            this.colKalan.StatusBarKisayolAciklama = null;
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 7;
            this.colKalan.Width = 95;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowEdit = false;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaId.OptionsFilter.AllowFilter = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisayol = null;
            this.colBankaId.StatusBarKisayolAciklama = null;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.ColumnEdit = this.repositoryBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisayol = null;
            this.colBankaAdi.StatusBarKisayolAciklama = null;
            this.colBankaAdi.Width = 150;
            // 
            // colBankaSubeId
            // 
            this.colBankaSubeId.Caption = "BankaSubeId";
            this.colBankaSubeId.FieldName = "BankaSubeId";
            this.colBankaSubeId.Name = "colBankaSubeId";
            this.colBankaSubeId.OptionsColumn.AllowEdit = false;
            this.colBankaSubeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaSubeId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaSubeId.OptionsFilter.AllowFilter = false;
            this.colBankaSubeId.StatusBarAciklama = null;
            this.colBankaSubeId.StatusBarKisayol = null;
            this.colBankaSubeId.StatusBarKisayolAciklama = null;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube Adı";
            this.colBankaSubeAdi.ColumnEdit = this.repositoryBankaSube;
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaSubeAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaSubeAdi.OptionsFilter.AllowFilter = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisayol = null;
            this.colBankaSubeAdi.StatusBarKisayolAciklama = null;
            this.colBankaSubeAdi.Width = 150;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colBelgeNo.OptionsFilter.AllowAutoFilter = false;
            this.colBelgeNo.OptionsFilter.AllowFilter = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisayol = null;
            this.colBelgeNo.StatusBarKisayolAciklama = null;
            this.colBelgeNo.Width = 85;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colHesapNo.OptionsFilter.AllowAutoFilter = false;
            this.colHesapNo.OptionsFilter.AllowFilter = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisayol = null;
            this.colHesapNo.StatusBarKisayolAciklama = null;
            this.colHesapNo.Width = 150;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asıl Borçlu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.OptionsColumn.ShowInCustomizationForm = false;
            this.colAsilBorclu.OptionsFilter.AllowAutoFilter = false;
            this.colAsilBorclu.OptionsFilter.AllowFilter = false;
            this.colAsilBorclu.StatusBarAciklama = null;
            this.colAsilBorclu.StatusBarKisayol = null;
            this.colAsilBorclu.StatusBarKisayolAciklama = null;
            this.colAsilBorclu.Width = 150;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.OptionsColumn.ShowInCustomizationForm = false;
            this.colCiranta.OptionsFilter.AllowAutoFilter = false;
            this.colCiranta.OptionsFilter.AllowFilter = false;
            this.colCiranta.StatusBarAciklama = null;
            this.colCiranta.StatusBarKisayol = null;
            this.colCiranta.StatusBarKisayolAciklama = null;
            this.colCiranta.Width = 150;
            // 
            // colTutarYazi
            // 
            this.colTutarYazi.Caption = "TutarYazi";
            this.colTutarYazi.FieldName = "TutarYazi";
            this.colTutarYazi.Name = "colTutarYazi";
            this.colTutarYazi.OptionsColumn.AllowEdit = false;
            this.colTutarYazi.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutarYazi.OptionsFilter.AllowAutoFilter = false;
            this.colTutarYazi.OptionsFilter.AllowFilter = false;
            this.colTutarYazi.StatusBarAciklama = null;
            this.colTutarYazi.StatusBarKisayol = null;
            this.colTutarYazi.StatusBarKisayolAciklama = null;
            // 
            // colVadeYazi
            // 
            this.colVadeYazi.Caption = "VadeYazi";
            this.colVadeYazi.FieldName = "VadeYazi";
            this.colVadeYazi.Name = "colVadeYazi";
            this.colVadeYazi.OptionsColumn.AllowEdit = false;
            this.colVadeYazi.OptionsColumn.ShowInCustomizationForm = false;
            this.colVadeYazi.OptionsFilter.AllowAutoFilter = false;
            this.colVadeYazi.OptionsFilter.AllowFilter = false;
            this.colVadeYazi.StatusBarAciklama = null;
            this.colVadeYazi.StatusBarKisayol = null;
            this.colVadeYazi.StatusBarKisayolAciklama = null;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Aciklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 350;
            // 
            // colBelgeDurumu
            // 
            this.colBelgeDurumu.Caption = "Durum";
            this.colBelgeDurumu.FieldName = "BelgeDurumu";
            this.colBelgeDurumu.Name = "colBelgeDurumu";
            this.colBelgeDurumu.OptionsColumn.AllowEdit = false;
            this.colBelgeDurumu.OptionsFilter.AllowAutoFilter = false;
            this.colBelgeDurumu.OptionsFilter.AllowFilter = false;
            this.colBelgeDurumu.StatusBarAciklama = null;
            this.colBelgeDurumu.StatusBarKisayol = null;
            this.colBelgeDurumu.StatusBarKisayolAciklama = null;
            this.colBelgeDurumu.Visible = true;
            this.colBelgeDurumu.VisibleIndex = 8;
            this.colBelgeDurumu.Width = 200;
            // 
            // colSonHareketTarih
            // 
            this.colSonHareketTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colSonHareketTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonHareketTarih.Caption = "Son İşlem Tarihi";
            this.colSonHareketTarih.ColumnEdit = this.repositoryTarih;
            this.colSonHareketTarih.FieldName = "SonHareketTarih";
            this.colSonHareketTarih.Name = "colSonHareketTarih";
            this.colSonHareketTarih.OptionsColumn.AllowEdit = false;
            this.colSonHareketTarih.OptionsFilter.AllowAutoFilter = false;
            this.colSonHareketTarih.OptionsFilter.AllowFilter = false;
            this.colSonHareketTarih.StatusBarAciklama = null;
            this.colSonHareketTarih.StatusBarKisayol = null;
            this.colSonHareketTarih.StatusBarKisayolAciklama = null;
            this.colSonHareketTarih.Visible = true;
            this.colSonHareketTarih.VisibleIndex = 10;
            this.colSonHareketTarih.Width = 100;
            // 
            // colSonIslemYeri
            // 
            this.colSonIslemYeri.Caption = "Son İşlem Yeri";
            this.colSonIslemYeri.FieldName = "SonIslemYeri";
            this.colSonIslemYeri.Name = "colSonIslemYeri";
            this.colSonIslemYeri.OptionsColumn.AllowEdit = false;
            this.colSonIslemYeri.OptionsFilter.AllowAutoFilter = false;
            this.colSonIslemYeri.OptionsFilter.AllowFilter = false;
            this.colSonIslemYeri.StatusBarAciklama = null;
            this.colSonIslemYeri.StatusBarKisayol = null;
            this.colSonIslemYeri.StatusBarKisayolAciklama = null;
            this.colSonIslemYeri.Visible = true;
            this.colSonIslemYeri.VisibleIndex = 11;
            this.colSonIslemYeri.Width = 185;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "n2";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "n2";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // repositoryBankaHesap
            // 
            this.repositoryBankaHesap.AutoHeight = false;
            this.repositoryBankaHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryBankaHesap.Name = "repositoryBankaHesap";
            this.repositoryBankaHesap.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryBanka
            // 
            this.repositoryBanka.AutoHeight = false;
            this.repositoryBanka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryBanka.Name = "repositoryBanka";
            this.repositoryBanka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryBankaSube
            // 
            this.repositoryBankaSube.AutoHeight = false;
            this.repositoryBankaSube.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryBankaSube.Name = "repositoryBankaSube";
            this.repositoryBankaSube.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // OdemeBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "OdemeBilgileriTable";
            this.Size = new System.Drawing.Size(790, 328);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBankaHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBankaSube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colPortfoyNo;
        private Grid.MyGridColumn colOdemeTuruAdi;
        private Grid.MyGridColumn colBankaHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBankaHesap;
        private Grid.MyGridColumn colGirisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyGridColumn colVade;
        private Grid.MyGridColumn colTahsil;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyGridColumn colTahsilde;
        private Grid.MyGridColumn colIade;
        private Grid.MyGridColumn colKalan;
        private Grid.MyGridColumn colBankaId;
        private Grid.MyGridColumn colBankaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBanka;
        private Grid.MyGridColumn colBankaSubeId;
        private Grid.MyGridColumn colBankaSubeAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBankaSube;
        private Grid.MyGridColumn colBelgeNo;
        private Grid.MyGridColumn colHesapNo;
        private Grid.MyGridColumn colAsilBorclu;
        private Grid.MyGridColumn colCiranta;
        private Grid.MyGridColumn colTutarYazi;
        private Grid.MyGridColumn colVadeYazi;
        private Grid.MyGridColumn colAciklama;
        private Grid.MyGridColumn colBelgeDurumu;
        private Grid.MyGridColumn colSonHareketTarih;
        private Grid.MyGridColumn colSonIslemYeri;
    }
}
