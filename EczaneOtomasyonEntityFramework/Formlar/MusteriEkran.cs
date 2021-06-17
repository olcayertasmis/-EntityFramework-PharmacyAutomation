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
    public partial class MusteriEkran : Form
    {
        public MusteriEkran()
        {
            InitializeComponent();
        }

        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TeAd.Text == string.Empty || TeAd.Text == null || TeSoyad.Text == string.Empty || TeSoyad.Text == null || TeTc.Text == string.Empty || TeTc.Text == null)
            {
                XtraMessageBox.Show("Eksik Bilgi Bırakmayınız", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tcKontrol(TeTc.Text)) // AYNI TC KULLANILMIŞ MI SORGUSU
            {
                XtraMessageBox.Show("Bu Tc Zaten Kayıtlı !", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                musteri musteriler = new musteri();
                musteriler.musteri_ad = TeAd.Text;
                musteriler.musteri_soyad = TeSoyad.Text;
                musteriler.musteri_tc = TeTc.Text;
                musteriler.tel = TeTel.Text;
                musteriler.adres = TeAdres.Text;
                db.musteri.Add(musteriler);
                db.SaveChanges();

                XtraMessageBox.Show("Yeni Müşteri eklendi ! !", "Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusteriListele();
            }
        }
        private bool tcKontrol(string tc) //ZATEN TC KAYITLI MI KONTROLÜ
        {
            bool varmi = false;
            var tcBul = (from x in db.musteri
                         where x.musteri_tc.ToString() == tc
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
        public void MusteriListele() //Grid Control'e kayıtları çekiyor
        {
            var musterileriCek = from x in db.musteri
                                 select new
                                 {
                                     ID = x.musteri_id,
                                     Ad = x.musteri_ad,
                                     Soyad = x.musteri_soyad,
                                     TC = x.musteri_tc,
                                     Tel = x.tel,
                                     Adres = x.adres
                                 };
            gridControl1.DataSource = musterileriCek.ToList();
        }

        private void TeTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TeSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TeTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TeTel.Text = gridView1.GetFocusedRowCellValue("Tel").ToString();
            TeAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            if (silinecekId.ToString() == string.Empty || silinecekId == null)
            {
                XtraMessageBox.Show("Silme işleminde hata !", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var silinecekMusteri = (from x in db.musteri
                                        where x.musteri_id == silinecekId
                                        select x).FirstOrDefault();
                db.musteri.Remove(silinecekMusteri);
                db.SaveChanges();
                MusteriListele();
                XtraMessageBox.Show("Müşteri Silindi !", "Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MusteriEkran_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.musteri.Find(id);
            deger.musteri_ad = TeAd.Text;
            deger.musteri_soyad = TeSoyad.Text;
            deger.musteri_tc = TeTc.Text;
            deger.tel = TeTel.Text;
            deger.adres = TeAdres.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Müşteri Başarılı Bir Şekilde Güncellendi !", "Başarılı ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusteriListele();
        }
    }
}
