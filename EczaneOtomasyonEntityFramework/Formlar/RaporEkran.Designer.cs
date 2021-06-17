
namespace EczaneOtomasyonEntityFramework
{
    partial class RaporEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporEkran));
            this.GcStokBiten = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.Btn_G_Tarih = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_G_Stok = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_G_GunSonu = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.Btn_R_Stok = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_R_GunSonu = new DevExpress.XtraEditors.SimpleButton();
            this.GcGun = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcTarihiGecmis = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GcStokBiten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTarihiGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // GcStokBiten
            // 
            this.GcStokBiten.Location = new System.Drawing.Point(12, 12);
            this.GcStokBiten.MainView = this.gridView1;
            this.GcStokBiten.Name = "GcStokBiten";
            this.GcStokBiten.Size = new System.Drawing.Size(933, 553);
            this.GcStokBiten.TabIndex = 0;
            this.GcStokBiten.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GcStokBiten;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TabControl
            // 
            this.TabControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TabControl.Appearance.Options.UseBackColor = true;
            this.TabControl.Location = new System.Drawing.Point(951, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.xtraTabPage1;
            this.TabControl.Size = new System.Drawing.Size(300, 554);
            this.TabControl.TabIndex = 1;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Gray;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.Btn_G_Tarih);
            this.xtraTabPage1.Controls.Add(this.Btn_G_Stok);
            this.xtraTabPage1.Controls.Add(this.Btn_G_GunSonu);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(298, 500);
            this.xtraTabPage1.Text = "Tablo Görünüm";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // Btn_G_Tarih
            // 
            this.Btn_G_Tarih.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_G_Tarih.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_G_Tarih.Appearance.Options.UseBackColor = true;
            this.Btn_G_Tarih.Appearance.Options.UseFont = true;
            this.Btn_G_Tarih.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_G_Tarih.ImageOptions.SvgImage")));
            this.Btn_G_Tarih.Location = new System.Drawing.Point(3, 326);
            this.Btn_G_Tarih.Name = "Btn_G_Tarih";
            this.Btn_G_Tarih.Size = new System.Drawing.Size(292, 82);
            this.Btn_G_Tarih.TabIndex = 6;
            this.Btn_G_Tarih.Text = "Tarihi Geçen İlaçları Görntüle";
            this.Btn_G_Tarih.Click += new System.EventHandler(this.Btn_G_Tarih_Click);
            // 
            // Btn_G_Stok
            // 
            this.Btn_G_Stok.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_G_Stok.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_G_Stok.Appearance.Options.UseBackColor = true;
            this.Btn_G_Stok.Appearance.Options.UseFont = true;
            this.Btn_G_Stok.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_G_Stok.ImageOptions.SvgImage")));
            this.Btn_G_Stok.Location = new System.Drawing.Point(3, 200);
            this.Btn_G_Stok.Name = "Btn_G_Stok";
            this.Btn_G_Stok.Size = new System.Drawing.Size(292, 82);
            this.Btn_G_Stok.TabIndex = 5;
            this.Btn_G_Stok.Text = "Stok Biten İlaçları Görüntüle";
            this.Btn_G_Stok.Click += new System.EventHandler(this.Btn_G_Stok_Click);
            // 
            // Btn_G_GunSonu
            // 
            this.Btn_G_GunSonu.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_G_GunSonu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_G_GunSonu.Appearance.Options.UseBackColor = true;
            this.Btn_G_GunSonu.Appearance.Options.UseFont = true;
            this.Btn_G_GunSonu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_G_GunSonu.ImageOptions.SvgImage")));
            this.Btn_G_GunSonu.Location = new System.Drawing.Point(3, 78);
            this.Btn_G_GunSonu.Name = "Btn_G_GunSonu";
            this.Btn_G_GunSonu.Size = new System.Drawing.Size(292, 82);
            this.Btn_G_GunSonu.TabIndex = 4;
            this.Btn_G_GunSonu.Text = "Günü Sonu Görüntüle";
            this.Btn_G_GunSonu.Click += new System.EventHandler(this.Btn_G_GunSonu_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.Btn_R_Stok);
            this.xtraTabPage2.Controls.Add(this.Btn_R_GunSonu);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(298, 500);
            this.xtraTabPage2.Text = "Raporlar";
            // 
            // Btn_R_Stok
            // 
            this.Btn_R_Stok.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_R_Stok.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_R_Stok.Appearance.Options.UseBackColor = true;
            this.Btn_R_Stok.Appearance.Options.UseFont = true;
            this.Btn_R_Stok.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Btn_R_Stok.ImageOptions.ImageToTextIndent = 10;
            this.Btn_R_Stok.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_R_Stok.ImageOptions.SvgImage")));
            this.Btn_R_Stok.Location = new System.Drawing.Point(3, 263);
            this.Btn_R_Stok.Name = "Btn_R_Stok";
            this.Btn_R_Stok.Size = new System.Drawing.Size(292, 131);
            this.Btn_R_Stok.TabIndex = 7;
            this.Btn_R_Stok.Text = "Stok Biten İlaçları Raporla";
            this.Btn_R_Stok.Click += new System.EventHandler(this.Btn_R_Stok_Click);
            // 
            // Btn_R_GunSonu
            // 
            this.Btn_R_GunSonu.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_R_GunSonu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_R_GunSonu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_R_GunSonu.Appearance.Options.UseBackColor = true;
            this.Btn_R_GunSonu.Appearance.Options.UseFont = true;
            this.Btn_R_GunSonu.Appearance.Options.UseForeColor = true;
            this.Btn_R_GunSonu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Btn_R_GunSonu.ImageOptions.ImageToTextIndent = 20;
            this.Btn_R_GunSonu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_R_GunSonu.ImageOptions.SvgImage")));
            this.Btn_R_GunSonu.Location = new System.Drawing.Point(3, 80);
            this.Btn_R_GunSonu.Name = "Btn_R_GunSonu";
            this.Btn_R_GunSonu.Size = new System.Drawing.Size(292, 131);
            this.Btn_R_GunSonu.TabIndex = 6;
            this.Btn_R_GunSonu.Text = "Günü Sonu Raporla";
            this.Btn_R_GunSonu.Click += new System.EventHandler(this.Btn_R_GunSonu_Click);
            // 
            // GcGun
            // 
            this.GcGun.Location = new System.Drawing.Point(22, 12);
            this.GcGun.MainView = this.gridView2;
            this.GcGun.Name = "GcGun";
            this.GcGun.Size = new System.Drawing.Size(923, 554);
            this.GcGun.TabIndex = 2;
            this.GcGun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GcGun;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GcTarihiGecmis
            // 
            this.GcTarihiGecmis.Location = new System.Drawing.Point(12, 12);
            this.GcTarihiGecmis.MainView = this.gridView3;
            this.GcTarihiGecmis.Name = "GcTarihiGecmis";
            this.GcTarihiGecmis.Size = new System.Drawing.Size(933, 554);
            this.GcTarihiGecmis.TabIndex = 3;
            this.GcTarihiGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.GcTarihiGecmis;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // RaporEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1263, 578);
            this.Controls.Add(this.GcTarihiGecmis);
            this.Controls.Add(this.GcGun);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.GcStokBiten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaporEkran";
            this.Text = "RAPOR EKRANI";
            this.Load += new System.EventHandler(this.RaporEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcStokBiten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTarihiGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcStokBiten;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl GcGun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl GcTarihiGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton Btn_G_GunSonu;
        private DevExpress.XtraEditors.SimpleButton Btn_G_Tarih;
        private DevExpress.XtraEditors.SimpleButton Btn_G_Stok;
        private DevExpress.XtraEditors.SimpleButton Btn_R_Stok;
        private DevExpress.XtraEditors.SimpleButton Btn_R_GunSonu;
    }
}