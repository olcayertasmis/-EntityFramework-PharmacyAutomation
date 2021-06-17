
namespace EczaneOtomasyonEntityFramework
{
    partial class PersonelEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkran));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TeYeniRol = new DevExpress.XtraEditors.TextEdit();
            this.BtnRolEkle = new DevExpress.XtraEditors.SimpleButton();
            this.LupeRol = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TeParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TeKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TeTc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeYeniRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupeRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(15, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(863, 555);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TeParola);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TeKullaniciAdi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TeTc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TeSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TeAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(886, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 555);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "                  PERSONEL EKLEME PENCERESİ";
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.TeYeniRol);
            this.groupControl2.Controls.Add(this.BtnRolEkle);
            this.groupControl2.Controls.Add(this.LupeRol);
            this.groupControl2.Location = new System.Drawing.Point(12, 273);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(341, 125);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "                             Rol Penceresi";
            // 
            // TeYeniRol
            // 
            this.TeYeniRol.Location = new System.Drawing.Point(12, 79);
            this.TeYeniRol.Margin = new System.Windows.Forms.Padding(4);
            this.TeYeniRol.Name = "TeYeniRol";
            this.TeYeniRol.Size = new System.Drawing.Size(156, 22);
            this.TeYeniRol.TabIndex = 16;
            // 
            // BtnRolEkle
            // 
            this.BtnRolEkle.AutoSize = true;
            this.BtnRolEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRolEkle.ImageOptions.SvgImage")));
            this.BtnRolEkle.Location = new System.Drawing.Point(201, 74);
            this.BtnRolEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRolEkle.Name = "BtnRolEkle";
            this.BtnRolEkle.Size = new System.Drawing.Size(134, 44);
            this.BtnRolEkle.TabIndex = 11;
            this.BtnRolEkle.Text = "YENİ ROL EKLE";
            this.BtnRolEkle.Click += new System.EventHandler(this.BtnRolEkle_Click);
            // 
            // LupeRol
            // 
            this.LupeRol.Location = new System.Drawing.Point(12, 39);
            this.LupeRol.Margin = new System.Windows.Forms.Padding(4);
            this.LupeRol.Name = "LupeRol";
            this.LupeRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupeRol.Properties.NullText = "";
            this.LupeRol.Size = new System.Drawing.Size(325, 22);
            this.LupeRol.TabIndex = 10;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuncelle.Location = new System.Drawing.Point(57, 453);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(256, 44);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "PERSONEL GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSil.ImageOptions.SvgImage")));
            this.BtnSil.Location = new System.Drawing.Point(101, 505);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(176, 44);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "PERSONEL SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnKaydet.Location = new System.Drawing.Point(24, 401);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(325, 44);
            this.BtnKaydet.TabIndex = 11;
            this.BtnKaydet.Text = "YENİ PERSONEL KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TeParola
            // 
            this.TeParola.Location = new System.Drawing.Point(187, 238);
            this.TeParola.Margin = new System.Windows.Forms.Padding(4);
            this.TeParola.Name = "TeParola";
            this.TeParola.Size = new System.Drawing.Size(156, 22);
            this.TeParola.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 241);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "PAROLA :";
            // 
            // TeKullaniciAdi
            // 
            this.TeKullaniciAdi.Location = new System.Drawing.Point(187, 185);
            this.TeKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TeKullaniciAdi.Name = "TeKullaniciAdi";
            this.TeKullaniciAdi.Size = new System.Drawing.Size(156, 22);
            this.TeKullaniciAdi.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 188);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "KULLANİCİ ADİ :";
            // 
            // TeTc
            // 
            this.TeTc.Location = new System.Drawing.Point(186, 136);
            this.TeTc.Margin = new System.Windows.Forms.Padding(4);
            this.TeTc.Name = "TeTc";
            this.TeTc.Properties.MaxLength = 11;
            this.TeTc.Size = new System.Drawing.Size(156, 22);
            this.TeTc.TabIndex = 5;
            this.TeTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 139);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TC :";
            // 
            // TeSoyad
            // 
            this.TeSoyad.Location = new System.Drawing.Point(187, 84);
            this.TeSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TeSoyad.Name = "TeSoyad";
            this.TeSoyad.Size = new System.Drawing.Size(156, 22);
            this.TeSoyad.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "SOYADI :";
            // 
            // TeAd
            // 
            this.TeAd.Location = new System.Drawing.Point(186, 37);
            this.TeAd.Margin = new System.Windows.Forms.Padding(4);
            this.TeAd.Name = "TeAd";
            this.TeAd.Size = new System.Drawing.Size(156, 22);
            this.TeAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ADI :";
            // 
            // PersonelEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 578);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkran";
            this.Text = "PERSONEL EKRANI";
            this.Load += new System.EventHandler(this.PersonelEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeYeniRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupeRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnRolEkle;
        private DevExpress.XtraEditors.LookUpEdit LupeRol;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TeParola;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TeKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TeTc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TeYeniRol;
    }
}