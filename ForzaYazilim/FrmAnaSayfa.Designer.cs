
namespace ForzaYazilim
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.dilswitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnAnaSayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnistatistik = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnNot = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNotlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNotEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.BtnUrunMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnUrunEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnUrunCikisi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRaporlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnSecenekler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHesaplar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnGuncelle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.lblid = new System.Windows.Forms.Label();
            this.lblsqldil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dilswitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 31);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(991, 545);
            this.container.TabIndex = 0;
            this.container.Click += new System.EventHandler(this.container_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Controls.Add(this.dilswitch);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.btnAnaSayfa,
            this.accordionControlSeparator3,
            this.BtnUrunMenu,
            this.accordionControlSeparator2,
            this.btnSecenekler});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 545);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // dilswitch
            // 
            this.dilswitch.Location = new System.Drawing.Point(136, 441);
            this.dilswitch.MenuManager = this.fluentFormDefaultManager1;
            this.dilswitch.Name = "dilswitch";
            this.dilswitch.Properties.OffText = "Turkish";
            this.dilswitch.Properties.OnText = "French";
            this.dilswitch.Size = new System.Drawing.Size(95, 18);
            this.dilswitch.TabIndex = 2;
            this.dilswitch.Toggled += new System.EventHandler(this.dilswitch_Toggled);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.skinBarSubItem2});
            this.fluentFormDefaultManager1.MaxItemId = 4;
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem1.Id = 1;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinDropDownButtonItem1.Id = 2;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinBarSubItem2.Caption = "skinBarSubItem2";
            this.skinBarSubItem2.Id = 3;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnistatistik,
            this.BtnNot});
            this.btnAnaSayfa.Expanded = true;
            this.btnAnaSayfa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAnaSayfa.ImageOptions.SvgImage")));
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnistatistik.ImageOptions.SvgImage")));
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // BtnNot
            // 
            this.BtnNot.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnNotlar,
            this.btnNotEkle});
            this.BtnNot.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNot.ImageOptions.SvgImage")));
            this.BtnNot.Name = "BtnNot";
            this.BtnNot.Text = "Notlar";
            this.BtnNot.Visible = false;
            this.BtnNot.Click += new System.EventHandler(this.BtnNot_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotlar.ImageOptions.SvgImage")));
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNotlar.Text = "Not Listesi";
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotEkle.ImageOptions.SvgImage")));
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // BtnUrunMenu
            // 
            this.BtnUrunMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnUrunEkle,
            this.BtnUrunCikisi,
            this.btnRaporlar});
            this.BtnUrunMenu.Expanded = true;
            this.BtnUrunMenu.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.BtnUrunMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunMenu.ImageOptions.SvgImage")));
            this.BtnUrunMenu.Name = "BtnUrunMenu";
            this.BtnUrunMenu.Text = "Ürün Menüsü";
            this.BtnUrunMenu.Click += new System.EventHandler(this.BtnUrunMenu_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunEkle.ImageOptions.SvgImage")));
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunCikisi
            // 
            this.BtnUrunCikisi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunCikisi.ImageOptions.SvgImage")));
            this.BtnUrunCikisi.Name = "BtnUrunCikisi";
            this.BtnUrunCikisi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnUrunCikisi.Text = "Ürün Çıkışı";
            this.BtnUrunCikisi.Click += new System.EventHandler(this.BtnUrunCikisi_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporlar.ImageOptions.SvgImage")));
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRaporlar.Text = "Rapolar";
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHesaplar,
            this.btnGuncelle,
            this.btnDil});
            this.btnSecenekler.Expanded = true;
            this.btnSecenekler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSecenekler.ImageOptions.SvgImage")));
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Text = "Seçenekler";
            // 
            // btnHesaplar
            // 
            this.btnHesaplar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHesaplar.ImageOptions.SvgImage")));
            this.btnHesaplar.Name = "btnHesaplar";
            this.btnHesaplar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHesaplar.Text = "Hesaplar";
            this.btnHesaplar.Click += new System.EventHandler(this.btnHesaplar_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDil
            // 
            this.btnDil.HeaderControl = this.dilswitch;
            this.btnDil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDil.ImageOptions.SvgImage")));
            this.btnDil.Name = "btnDil";
            this.btnDil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDil.Text = "Dil";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.skinBarSubItem2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1251, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(142, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.EnableBonusSkins = true;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement6.ImageOptions.SvgImage")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Grafikler";
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(73, 500);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "11";
            this.lblid.Visible = false;
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // lblsqldil
            // 
            this.lblsqldil.AutoSize = true;
            this.lblsqldil.Location = new System.Drawing.Point(105, 501);
            this.lblsqldil.Name = "lblsqldil";
            this.lblsqldil.Size = new System.Drawing.Size(17, 13);
            this.lblsqldil.TabIndex = 4;
            this.lblsqldil.Text = "dil";
            this.lblsqldil.Visible = false;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 576);
            this.ControlContainer = this.container;
            this.Controls.Add(this.lblsqldil);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmAnaSayfa.IconOptions.SvgImage")));
            this.Name = "FrmAnaSayfa";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forza Metal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dilswitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnUrunMenu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnUrunEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnUrunCikisi;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSecenekler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHesaplar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDil;
        private DevExpress.XtraEditors.ToggleSwitch dilswitch;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnGuncelle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAnaSayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnistatistik;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNotlar;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblsqldil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnNot;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNotEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRaporlar;
    }
}