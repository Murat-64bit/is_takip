
namespace ForzaYazilim
{
    partial class FrmIstatistik
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView3 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.toplamadeleter = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.sonEklenenler = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AdetCikisTarih = new DevExpress.XtraEditors.GroupControl();
            this.lblid = new System.Windows.Forms.Label();
            this.lblsqldil = new System.Windows.Forms.Label();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.SonIslemID = new DevExpress.XtraEditors.GroupControl();
            this.chartControl4 = new DevExpress.XtraCharts.ChartControl();
            this.stoksayisi20dendusukler = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toplamadeleter)).BeginInit();
            this.toplamadeleter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonEklenenler)).BeginInit();
            this.sonEklenenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetCikisTarih)).BeginInit();
            this.AdetCikisTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonIslemID)).BeginInit();
            this.SonIslemID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksayisi20dendusukler)).BeginInit();
            this.stoksayisi20dendusukler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toplamadeleter
            // 
            this.toplamadeleter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toplamadeleter.Controls.Add(this.chartControl1);
            this.toplamadeleter.Location = new System.Drawing.Point(2, 3);
            this.toplamadeleter.Name = "toplamadeleter";
            this.toplamadeleter.Size = new System.Drawing.Size(368, 240);
            this.toplamadeleter.TabIndex = 0;
            this.toplamadeleter.Text = "Toplam Adetler";
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Northern Lights";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(2, 23);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Northern Lights";
            series1.Name = "Piece";
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            series1.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(364, 215);
            this.chartControl1.TabIndex = 0;
            // 
            // sonEklenenler
            // 
            this.sonEklenenler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sonEklenenler.Controls.Add(this.gridControl2);
            this.sonEklenenler.Location = new System.Drawing.Point(374, 3);
            this.sonEklenenler.Name = "sonEklenenler";
            this.sonEklenenler.Size = new System.Drawing.Size(265, 240);
            this.sonEklenenler.TabIndex = 1;
            this.sonEklenenler.Text = "Son Eklenenler";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 23);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(261, 215);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // AdetCikisTarih
            // 
            this.AdetCikisTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdetCikisTarih.Controls.Add(this.lblid);
            this.AdetCikisTarih.Controls.Add(this.lblsqldil);
            this.AdetCikisTarih.Controls.Add(this.chartControl2);
            this.AdetCikisTarih.Location = new System.Drawing.Point(0, 246);
            this.AdetCikisTarih.Name = "AdetCikisTarih";
            this.AdetCikisTarih.Size = new System.Drawing.Size(368, 244);
            this.AdetCikisTarih.TabIndex = 2;
            this.AdetCikisTarih.Text = "Adet Düşüş Tarihleri";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(322, 7);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "11";
            this.lblid.Visible = false;
            // 
            // lblsqldil
            // 
            this.lblsqldil.AutoSize = true;
            this.lblsqldil.Location = new System.Drawing.Point(263, 7);
            this.lblsqldil.Name = "lblsqldil";
            this.lblsqldil.Size = new System.Drawing.Size(17, 13);
            this.lblsqldil.TabIndex = 13;
            this.lblsqldil.Text = "dil";
            this.lblsqldil.Visible = false;
            this.lblsqldil.TextChanged += new System.EventHandler(this.lblsqldil_TextChanged);
            // 
            // chartControl2
            // 
            this.chartControl2.AppearanceNameSerializable = "In A Fog";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(2, 23);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteName = "In A Fog";
            series2.Name = "Piece";
            sideBySideBarSeriesView2.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = sideBySideBarSeriesView2;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(364, 219);
            this.chartControl2.TabIndex = 1;
            // 
            // SonIslemID
            // 
            this.SonIslemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SonIslemID.Controls.Add(this.chartControl4);
            this.SonIslemID.Location = new System.Drawing.Point(374, 246);
            this.SonIslemID.Name = "SonIslemID";
            this.SonIslemID.Size = new System.Drawing.Size(265, 244);
            this.SonIslemID.TabIndex = 3;
            this.SonIslemID.Text = "Son İşlem Yapan ID";
            // 
            // chartControl4
            // 
            this.chartControl4.AppearanceNameSerializable = "Pastel Kit";
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl4.Diagram = xyDiagram3;
            this.chartControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl4.Legend.Name = "Default Legend";
            this.chartControl4.Location = new System.Drawing.Point(2, 23);
            this.chartControl4.Name = "chartControl4";
            this.chartControl4.PaletteName = "Pastel Kit";
            series3.Name = "Piece";
            sideBySideBarSeriesView3.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            series3.View = sideBySideBarSeriesView3;
            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl4.Size = new System.Drawing.Size(261, 219);
            this.chartControl4.TabIndex = 1;
            // 
            // stoksayisi20dendusukler
            // 
            this.stoksayisi20dendusukler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stoksayisi20dendusukler.Controls.Add(this.gridControl1);
            this.stoksayisi20dendusukler.Location = new System.Drawing.Point(645, 26);
            this.stoksayisi20dendusukler.Name = "stoksayisi20dendusukler";
            this.stoksayisi20dendusukler.Size = new System.Drawing.Size(227, 464);
            this.stoksayisi20dendusukler.TabIndex = 2;
            this.stoksayisi20dendusukler.Text = "Stok sayısı 20\'den düşükler";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(223, 439);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.Location = new System.Drawing.Point(645, 3);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(227, 20);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmIstatistik
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.stoksayisi20dendusukler);
            this.Controls.Add(this.SonIslemID);
            this.Controls.Add(this.AdetCikisTarih);
            this.Controls.Add(this.sonEklenenler);
            this.Controls.Add(this.toplamadeleter);
            this.Name = "FrmIstatistik";
            this.Size = new System.Drawing.Size(875, 493);
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplamadeleter)).EndInit();
            this.toplamadeleter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonEklenenler)).EndInit();
            this.sonEklenenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetCikisTarih)).EndInit();
            this.AdetCikisTarih.ResumeLayout(false);
            this.AdetCikisTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonIslemID)).EndInit();
            this.SonIslemID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksayisi20dendusukler)).EndInit();
            this.stoksayisi20dendusukler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl toplamadeleter;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.GroupControl sonEklenenler;
        private DevExpress.XtraEditors.GroupControl AdetCikisTarih;
        private DevExpress.XtraEditors.GroupControl SonIslemID;
        private DevExpress.XtraEditors.GroupControl stoksayisi20dendusukler;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblsqldil;
        private System.Windows.Forms.Timer timer1;
    }
}
