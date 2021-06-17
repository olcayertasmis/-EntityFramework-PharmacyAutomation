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
    public partial class PersonelEkran : Form
    {
        public PersonelEkran()
        {
            InitializeComponent();
        }

        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TeAd.Text == string.Empty || TeAd.Text == null || TeSoyad.Text == string.Empty || TeSoyad.Text == null || TeTc.Text == string.Empty || TeTc.Text == null || TeKullaniciAdi.Text == string.Empty
                || TeKullaniciAdi.Text == null || TeParola.Text == string.Empty || TeParola.Text == null || LupeRol.Properties.DisplayMember.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Eksik Bilgi Bırakmayınız", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tcKontrol(TeTc.Text) && kullaniciKontrol(TeKullaniciAdi.Text)) // AYNI TC ve kullanıcı adı KULLANILMIŞ MI SORGUSU
            {
                XtraMessageBox.Show("Bu Tc Zaten Kayıtlı !", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                calisanlar calisan = new calisanlar();
                calisan.calisan_adi = TeAd.Text;
                calisan.calisan_soyadi = TeSoyad.Text;
                calisan.TC = TeTc.Text;
                calisan.kullanici_adi = TeKullaniciAdi.Text;
                calisan.parola = TeParola.Text;
                calisan.rol_id = int.Parse(LupeRol.EditValue.ToString());
                db.calisanlar.Add(calisan);
                db.SaveChanges();

                XtraMessageBox.Show("Yeni Çalışan eklendi ! !", "Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalisanListele();
            }
        }

        private bool tcKontrol(string tc) //ZATEN TC KAYITLI MI KONTROLÜ
        {
            bool varmi = false;
            var tcBul = (from x in db.calisanlar
                         where x.TC.ToString() == tc
                         select x).FirstOrDefault();
            if (tcBul == null)//YOKSA
            {
                varmi = false;
                return varmi;
            }
            else
            {
                varmi = true;
                return varmi;
            }
        }
        private bool kullaniciKontrol(string kullaniciadi) //AYNI KULLANICI ADI VAR MI
        {
            bool varmi = false;
            var kaBul = (from x in db.calisanlar
                         where x.kullanici_adi.ToString() == kullaniciadi
                         select x).FirstOrDefault();
            if (kaBul == null)//YOKSA
            {
                varmi = false;
                return varmi;
            }
            else //VARSA
            {
                varmi = true;
                return varmi;
            }
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        public void CalisanListele() //Grid Control'e kayıtları çekiyor
        {
            var calisanlariCek = from x in db.calisanlar
                                 select new
                                 {
                                     id = x.calisan_id,
                                     Ad = x.calisan_adi,
                                     Soyad = x.calisan_soyadi,
                                     TC = x.TC,
                                     KullanıcıAdı = x.kullanici_adi,
                                     Parola = x.parola,
                                     Rol = x.roller.rol_ismi
                                 };
            gridControl1.DataSource = calisanlariCek.ToList();
        }

        private void BtnRolEkle_Click(object sender, EventArgs e)
        {
            if (TeYeniRol.Text == string.Empty || TeYeniRol.Text == null)
            {
                XtraMessageBox.Show("Yeni Rol Adını Boş Bırakmayınız.", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rolKontrol(TeYeniRol.Text)) //ZATEN BÖYLE BİR ROL VARSA
            {
                XtraMessageBox.Show("Bu Rol Zaten Kayıtlı !", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                roller rol = new roller();
                rol.rol_ismi = TeYeniRol.Text;
                if (rol != null)
                {
                    db.roller.Add(rol);
                    db.SaveChanges();
                    XtraMessageBox.Show("Yeni Rol Ekleme Başarılı !", "Başarılı ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RolCek();
                }
                else
                {
                    XtraMessageBox.Show("Yeni rol eklemede sorun yaşandı !", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void RolCek() //ComboBox'a VERİLERİ ÇEKİYOR
        {
            var rolCek = (from x in db.roller
                          select new
                          {
                              x.rol_ismi,
                              x.rol_id
                          }).ToList();

            LupeRol.Properties.ValueMember = "rol_id";
            LupeRol.Properties.DisplayMember = "rol_ismi";
            LupeRol.Properties.DataSource = rolCek;
        }
        private bool rolKontrol(string rol) //ZATEN BÖYLE BİR ROL VAR MI KONTROLÜ YAPIYOR
        {
            bool varmi = false;
            var rolBul = (from x in db.roller
                          where x.rol_ismi.ToString() == rol
                          select x).FirstOrDefault();
            if (rolBul == null)//YOKSA
            {
                varmi = false;
                return varmi;
            }
            else//VARSA
            {
                varmi = true;
                return varmi;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TeSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TeTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TeKullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullanıcıAdı").ToString();
            TeParola.Text = gridView1.GetFocusedRowCellValue("Parola").ToString();
            LupeRol.Text = gridView1.GetFocusedRowCellValue("Rol").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            if (silinecekId.ToString() == string.Empty || silinecekId == null)
            {
                XtraMessageBox.Show("Silme işleminde hata !", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var silinecekCalisan = (from x in db.calisanlar
                                        where x.calisan_id == silinecekId
                                        select x).FirstOrDefault();
                db.calisanlar.Remove(silinecekCalisan);
                db.SaveChanges();
                CalisanListele();
                XtraMessageBox.Show("Çalışan Silindi !", "Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PersonelEkran_Load(object sender, EventArgs e)
        {
            CalisanListele();
            RolCek();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            var deger = db.calisanlar.Find(id);
            deger.calisan_adi = TeAd.Text;
            deger.calisan_soyadi = TeSoyad.Text;
            deger.TC = TeTc.Text;
            deger.kullanici_adi = TeKullaniciAdi.Text;
            deger.parola = TeParola.Text;
            deger.rol_id = int.Parse(LupeRol.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Çalışan Başarılı Bir Şekilde Güncellendi !", "Başarılı ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CalisanListele();
        }
    }
}
