namespace Ticari_Otomasyon
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtAlıcı = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtTeslimAlan = new DevExpress.XtraEditors.TextEdit();
            this.txtTeslimEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnBul = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1646, 791);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1653, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(250, 791);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnGuncelle);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.txtAlıcı);
            this.xtraTabPage1.Controls.Add(this.txtVergiDairesi);
            this.xtraTabPage1.Controls.Add(this.mskSaat);
            this.xtraTabPage1.Controls.Add(this.mskTarih);
            this.xtraTabPage1.Controls.Add(this.txtTeslimAlan);
            this.xtraTabPage1.Controls.Add(this.txtTeslimEden);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtSıraNo);
            this.xtraTabPage1.Controls.Add(this.labelControl17);
            this.xtraTabPage1.Controls.Add(this.txtSeri);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtID);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(248, 747);
            this.xtraTabPage1.Text = "Fatura Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(76, 356);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(105, 37);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(16, 313);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 37);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(133, 313);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 37);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAlıcı
            // 
            this.txtAlıcı.Location = new System.Drawing.Point(119, 195);
            this.txtAlıcı.Name = "txtAlıcı";
            this.txtAlıcı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAlıcı.Properties.Appearance.Options.UseFont = true;
            this.txtAlıcı.Size = new System.Drawing.Size(120, 24);
            this.txtAlıcı.TabIndex = 6;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(119, 165);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVergiDairesi.Properties.Appearance.Options.UseFont = true;
            this.txtVergiDairesi.Size = new System.Drawing.Size(120, 24);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // mskSaat
            // 
            this.mskSaat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mskSaat.Location = new System.Drawing.Point(118, 134);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(120, 25);
            this.mskSaat.TabIndex = 4;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mskTarih.Location = new System.Drawing.Point(119, 103);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(120, 25);
            this.mskTarih.TabIndex = 3;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtTeslimAlan
            // 
            this.txtTeslimAlan.Location = new System.Drawing.Point(118, 255);
            this.txtTeslimAlan.Name = "txtTeslimAlan";
            this.txtTeslimAlan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTeslimAlan.Properties.Appearance.Options.UseFont = true;
            this.txtTeslimAlan.Size = new System.Drawing.Size(120, 24);
            this.txtTeslimAlan.TabIndex = 8;
            // 
            // txtTeslimEden
            // 
            this.txtTeslimEden.Location = new System.Drawing.Point(118, 225);
            this.txtTeslimEden.Name = "txtTeslimEden";
            this.txtTeslimEden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTeslimEden.Properties.Appearance.Options.UseFont = true;
            this.txtTeslimEden.Size = new System.Drawing.Size(120, 24);
            this.txtTeslimEden.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 258);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 18);
            this.labelControl8.TabIndex = 64;
            this.labelControl8.Text = "TESLİM ALAN:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(16, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 18);
            this.labelControl7.TabIndex = 63;
            this.labelControl7.Text = "TESLİM EDEN:";
            // 
            // txtSıraNo
            // 
            this.txtSıraNo.Location = new System.Drawing.Point(119, 73);
            this.txtSıraNo.Name = "txtSıraNo";
            this.txtSıraNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSıraNo.Properties.Appearance.Options.UseFont = true;
            this.txtSıraNo.Size = new System.Drawing.Size(120, 24);
            this.txtSıraNo.TabIndex = 2;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(50, 76);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(63, 18);
            this.labelControl17.TabIndex = 61;
            this.labelControl17.Text = "SIRA NO:";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(118, 43);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSeri.Properties.Appearance.Options.UseFont = true;
            this.txtSeri.Size = new System.Drawing.Size(120, 24);
            this.txtSeri.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(70, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 18);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "ALICI:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 18);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "VERGİ DAİRESİ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(71, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 18);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "SAAT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(63, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "TARİH:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(76, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 18);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "SERİ:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(118, 13);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(120, 24);
            this.txtID.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(91, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "ID:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtFirma);
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.txtPersonel);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.btnBul);
            this.xtraTabPage2.Controls.Add(this.txtTutar);
            this.xtraTabPage2.Controls.Add(this.txtFiyat);
            this.xtraTabPage2.Controls.Add(this.txtFaturaID);
            this.xtraTabPage2.Controls.Add(this.txtMiktar);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.txtUrunAd);
            this.xtraTabPage2.Controls.Add(this.labelControl13);
            this.xtraTabPage2.Controls.Add(this.labelControl14);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.labelControl16);
            this.xtraTabPage2.Controls.Add(this.txtUrunID);
            this.xtraTabPage2.Controls.Add(this.labelControl18);
            this.xtraTabPage2.Controls.Add(this.btnKaydet);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(248, 747);
            this.xtraTabPage2.Text = "Fatura Detayları";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(119, 133);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Size = new System.Drawing.Size(120, 24);
            this.txtTutar.TabIndex = 15;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(118, 103);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtFiyat.Size = new System.Drawing.Size(120, 24);
            this.txtFiyat.TabIndex = 14;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Location = new System.Drawing.Point(119, 225);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFaturaID.Properties.Appearance.Options.UseFont = true;
            this.txtFaturaID.Size = new System.Drawing.Size(120, 24);
            this.txtFaturaID.TabIndex = 16;
            // 
            // txtMiktar
            // 
            this.txtMiktar.EditValue = "";
            this.txtMiktar.Location = new System.Drawing.Point(119, 73);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtMiktar.Size = new System.Drawing.Size(120, 24);
            this.txtMiktar.TabIndex = 13;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(53, 76);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 18);
            this.labelControl11.TabIndex = 83;
            this.labelControl11.Text = "MİKTAR:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.EditValue = "";
            this.txtUrunAd.Location = new System.Drawing.Point(118, 43);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAd.Size = new System.Drawing.Size(121, 24);
            this.txtUrunAd.TabIndex = 12;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(39, 168);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(74, 18);
            this.labelControl13.TabIndex = 80;
            this.labelControl13.Text = "PERSONEL:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(59, 137);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(53, 18);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "TUTAR:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(64, 106);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(48, 18);
            this.labelControl15.TabIndex = 78;
            this.labelControl15.Text = "FİYAT:";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(38, 46);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(74, 18);
            this.labelControl16.TabIndex = 77;
            this.labelControl16.Text = "ÜRÜN ADI:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(118, 13);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUrunID.Properties.Appearance.Options.UseFont = true;
            this.txtUrunID.Size = new System.Drawing.Size(60, 24);
            this.txtUrunID.TabIndex = 76;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(47, 16);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(65, 18);
            this.labelControl18.TabIndex = 75;
            this.labelControl18.Text = "ÜRÜN ID:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(134, 264);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 37);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnBul
            // 
            this.btnBul.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBul.Appearance.Options.UseFont = true;
            this.btnBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnBul.Location = new System.Drawing.Point(184, 13);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(54, 24);
            this.btnBul.TabIndex = 84;
            this.btnBul.Text = "Bul";
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(118, 165);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonel.Properties.Appearance.Options.UseFont = true;
            this.txtPersonel.Size = new System.Drawing.Size(120, 24);
            this.txtPersonel.TabIndex = 85;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(31, 228);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 18);
            this.labelControl9.TabIndex = 86;
            this.labelControl9.Text = "FATURA ID:";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(118, 195);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFirma.Properties.Appearance.Options.UseFont = true;
            this.txtFirma.Size = new System.Drawing.Size(120, 24);
            this.txtFirma.TabIndex = 87;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(63, 198);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 18);
            this.labelControl10.TabIndex = 88;
            this.labelControl10.Text = "FİRMA:";
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.TextEdit txtSıraNo;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTeslimAlan;
        private DevExpress.XtraEditors.TextEdit txtTeslimEden;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAlıcı;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnBul;
        private DevExpress.XtraEditors.TextEdit txtFirma;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}