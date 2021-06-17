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
    public partial class SatisEkran : Form
    {
        public SatisEkran()
        {
            InitializeComponent();
        }

        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();
        float ToplamTutar = 0;
        private void SatisEkran_Load(object sender, EventArgs e)
        {
            ilacListele();
            labelPersonel.Text = Form1.calisan_ad_soyad;
        }

        public void ilacListele() //Grid Control'e kayıtları çekiyor
        {
            string yıl = DateTime.Today.Year.ToString();
            string ay = DateTime.Today.Month.ToString();
            string gün = DateTime.Today.Day.ToString();
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }

            string bugün = yıl + "-" + ay + "-" + gün;
            DateTime bugun = Convert.ToDateTime(bugün);

            var ilacCek = from x in db.ilaclar
                          where x.stok > 0 && x.tuketim_tarihi >= bugun
                          select new
                          {
                              ID = x.ilac_id,
                              ilacAdı = x.ilac_ismi,
                              Fiyat = x.fiyat,
                              Stok = x.stok,
                              ÜretimTarihi = x.uretim_tarihi,
                              TüketimTarihi = x.tuketim_tarihi,
                          };
            gridControl1.DataSource = ilacCek.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CbMiktar.Properties.Items.Clear();
            CbMiktar.Text = "";
            string maxAdetString = gridView1.GetFocusedRowCellValue("Stok").ToString();
            int maxAdet = int.Parse(maxAdetString);
            for (int i = 1; i <= maxAdet; i++)
            {
                CbMiktar.Properties.Items.Add(i);
            }
        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (CbMiktar.Text == string.Empty || CbMiktar.Text == null)
            {
                XtraMessageBox.Show("İlaç Miktarı Seçiniz ! ", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string adetFiyatString = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
                    float adetFiyat = float.Parse(adetFiyatString);
                    int adet = int.Parse(CbMiktar.Text);
                    float Fiyat = adetFiyat * adet;//listbox'a eklenecek olan fiyat
                    ToplamTutar += Fiyat; //Sepet Tutarı
                    labelToplamFiyat.Text = ToplamTutar.ToString();

                    LbFiyat.Items.Add(Fiyat); //Listbox'a Fiyat Ekleme
                    Lb_ilac.Items.Add(gridView1.GetFocusedRowCellValue("ilacAdı").ToString());
                    LbAdet.Items.Add(CbMiktar.Text);
                    LbUretim.Items.Add(gridView1.GetFocusedRowCellValue("ÜretimTarihi"));
                    LbTuketim.Items.Add(gridView1.GetFocusedRowCellValue("TüketimTarihi"));
                    LbID.Items.Add(gridView1.GetFocusedRowCellValue("ID"));
                }
                catch
                {
                    XtraMessageBox.Show("Sepete Ürün Ekleme'de Hata oluştu ! ", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnSiparisTamamla_Click(object sender, EventArgs e)
        {
            int kacUrun = LbID.ItemCount;
            if (kacUrun == 0)
            {
                XtraMessageBox.Show("Sepet BOŞ ! ", "Hata ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string yıl = DateTime.Today.Year.ToString();
                string ay = DateTime.Today.Month.ToString();
                string gün = DateTime.Today.Day.ToString();
                if (int.Parse(ay) < 10)
                {
                    ay = "0" + ay;
                }

                string bugün = yıl + "-" + ay + "-" + gün;
                DateTime bugun = Convert.ToDateTime(bugün);
                for (int i = 0; i < kacUrun; i++)
                {
                    int satanID = Form1.calisan_id;
                    int ilacID = int.Parse(LbID.GetItem(i).ToString());
                    float satisFiyat = float.Parse(LbFiyat.GetItem(i).ToString());
                    int adet = int.Parse(LbAdet.GetItem(i).ToString());
                    int musteriID = int.Parse(gridView2.GetFocusedRowCellValue("ID").ToString());
                    ilac_satis satis = new ilac_satis();
                    satis.adet = adet;
                    satis.ilac_id = ilacID;
                    satis.personel_id = satanID;
                    satis.satis_fiyati = satisFiyat;
                    satis.satis_tarihi = bugun;
                    satis.musteri_id = musteriID;
                    db.ilac_satis.Add(satis);
                    stokGuncelle(ilacID, adet);
                }
                db.SaveChanges();
                ilacListele();
                temizle();
                BtnSepeteEkle.Refresh();
                XtraMessageBox.Show("Satış Başarılı !", " Başarılı ! | Eczane Otomasyon !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void temizle()
        {
            LbAdet.Items.Clear();
            LbFiyat.Items.Clear();
            Lb_ilac.Items.Clear();
            LbUretim.Items.Clear();
            LbTuketim.Items.Clear();
            LbID.Items.Clear();
            labelToplamFiyat.Text = "";
        }

        private void BtnTcSorgu_Click(object sender, EventArgs e)
        {
            if (TeTc.Text == string.Empty || TeTc.Text == null)
            {
                XtraMessageBox.Show("Boş Kutucuk Bırakmayınız !", "Hata ! | EczaneOtomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                var musteriCek = from x in db.musteri
                                 where x.musteri_tc.Contains(TeTc.Text.ToString()) && x.musteri_tc.StartsWith(TeTc.Text.Substring(0, TeTc.Text.Length))
                                 select new
                                 {
                                     ID = x.musteri_id,
                                     Ad = x.musteri_ad,
                                     Soyad = x.musteri_soyad,
                                     TC = x.musteri_tc,
                                 };
                if (musteriCek.ToList() == null || musteriCek.Count() == 0)
                {
                    XtraMessageBox.Show(" Müşteri Bulunamadı !", "Hata ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gridControl2.DataSource = musteriCek.ToList();
                }
            }
        }
        public void stokGuncelle(int id, int adet)
        {
            var ilac = db.ilaclar.Find(id);
            ilac.stok = ilac.stok - adet;
            db.SaveChanges();
        }

        private void CbMiktar_SelectedValueChanged(object sender, EventArgs e)
        {
            string adetFiyatString = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            float adetFiyat = float.Parse(adetFiyatString);
            int adet = int.Parse(CbMiktar.Text);
            float Fiyat = adetFiyat * adet;//listbox'a eklenecek olan fiyat
            labelFiyat.Text = Fiyat.ToString();
        }

        private void BtnListeSil_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
