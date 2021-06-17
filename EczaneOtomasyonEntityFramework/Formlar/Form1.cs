using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EczaneOtomasyonEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SatisEkran satisForm = new SatisEkran();
        Formlar.YoneticiEkran yoneticiForm = new Formlar.YoneticiEkran();
        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();
        public static int calisan_id;
        public static string calisan_ad_soyad;

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TeKullaniciAdi.Text == string.Empty || TeParola.Text == string.Empty)
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifreyi boş bırakmayınız.", "Hata | Eczane Giriş Sistemi ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                calisanlar kullaniciAdiBul = db.calisanlar.Where(x => x.kullanici_adi == TeKullaniciAdi.Text).FirstOrDefault();
                if (kullaniciAdiBul != null)
                {
                    calisanlar calisanBul = db.calisanlar.Where(x => x.kullanici_adi == TeKullaniciAdi.Text && x.parola == TeParola.Text).FirstOrDefault();
                    if (calisanBul != null)
                    {
                        calisan_id = calisanBul.calisan_id;
                        calisan_ad_soyad = (calisanBul.calisan_adi + " " + calisanBul.calisan_soyadi);
                        if (calisanBul.roller.rol_ismi == "yonetici")
                        {
                            this.Hide();
                            yoneticiForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            satisForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Parolayı kontrol ediniz !", "Hata | Eczane Giriş Sistemi ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adını kontrol ediniz !", "Hata | Eczane Giriş Sistemi ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

