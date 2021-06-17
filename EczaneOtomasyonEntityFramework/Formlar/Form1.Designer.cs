
namespace EczaneOtomasyonEntityFramework
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LblParola = new DevExpress.XtraEditors.LabelControl();
            this.TeKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.TeParola = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TeKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.Appearance.Options.UseBackColor = true;
            this.BtnGiris.Appearance.Options.UseBorderColor = true;
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Appearance.Options.UseForeColor = true;
            this.BtnGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGiris.ImageOptions.SvgImage")));
            this.BtnGiris.Location = new System.Drawing.Point(442, 201);
            this.BtnGiris.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.BtnGiris.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(123, 41);
            this.BtnGiris.TabIndex = 1;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.IndentBetweenImageAndText = 30;
            this.labelControl1.Location = new System.Drawing.Point(207, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 40);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "        KULLANICI ADI : ";
            // 
            // LblParola
            // 
            this.LblParola.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblParola.Appearance.Options.UseFont = true;
            this.LblParola.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblParola.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LblParola.ImageOptions.SvgImage")));
            this.LblParola.Location = new System.Drawing.Point(207, 143);
            this.LblParola.Name = "LblParola";
            this.LblParola.Size = new System.Drawing.Size(126, 40);
            this.LblParola.TabIndex = 3;
            this.LblParola.Text = "         PAROLA :";
            // 
            // TeKullaniciAdi
            // 
            this.TeKullaniciAdi.Location = new System.Drawing.Point(415, 86);
            this.TeKullaniciAdi.Name = "TeKullaniciAdi";
            this.TeKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TeKullaniciAdi.Size = new System.Drawing.Size(150, 28);
            this.TeKullaniciAdi.TabIndex = 4;
            // 
            // TeParola
            // 
            this.TeParola.Location = new System.Drawing.Point(415, 149);
            this.TeParola.Name = "TeParola";
            this.TeParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeParola.Properties.Appearance.Options.UseFont = true;
            this.TeParola.Size = new System.Drawing.Size(150, 28);
            this.TeParola.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(198, 230);
            this.pictureEdit1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 254);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TeParola);
            this.Controls.Add(this.TeKullaniciAdi);
            this.Controls.Add(this.LblParola);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl LblParola;
        private DevExpress.XtraEditors.TextEdit TeKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit TeParola;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

