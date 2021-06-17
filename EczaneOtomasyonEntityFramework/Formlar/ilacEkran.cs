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
    public partial class ilacEkran : Form
    {
        public ilacEkran()
        {
            InitializeComponent();
        }

        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Te_ilac_ismi.Text == string.Empty || Te_ilac_ismi.Text == null || TeFiyat.Text == string.Empty || TeFiyat.Text == null || TeStok.Text == string.Empty
                || TeStok.Text == null || DateTuketim.Text == string.Empty || DateTuketim.Text == null || DateUretim.Text == string.Empty || DateUretim.Text == null)
            {
                XtraMessageBox.Show("Bilgileri Tam giriniz", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ilaclar ilac = new ilaclar();
                ilac.ilac_ismi = Te_ilac_ismi.Text;
                ilac.fiyat = float.Parse(TeFiyat.Text.ToString());
                ilac.stok = int.Parse(TeStok.Text.ToString());
                ilac.tuketim_tarihi = DateTime.Parse(DateTuketim.EditValue.ToString());
                ilac.uretim_tarihi = DateTime.Parse(DateUretim.EditValue.ToString());
                ilac.tur_id = int.Parse(Lupe_ilacTuru.EditValue.ToString());
                db.ilaclar.Add(ilac);
                db.SaveChanges();

                XtraMessageBox.Show("Yeni İlaç eklendi ! !", " Eczane Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ilacListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (Te_ilac_ismi.Text == string.Empty || Te_ilac_ismi.Text == null || TeFiyat.Text == string.Empty || TeFiyat.Text == null || TeStok.Text == string.Empty
                || TeStok.Text == null || DateTuketim.Text == string.Empty || DateTuketim.Text == null || DateUretim.Text == string.Empty || DateUretim.Text == null || Lupe_ilacTuru.Text == string.Empty || Lupe_ilacTuru.Text == null)
            {
                XtraMessageBox.Show("Bilgileri Tam giriniz", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("İlaçID").ToString());
                if (guncellenecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Eczane Otomasyon ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var urun = db.ilaclar.Find(guncellenecekId);
                    urun.ilac_ismi = Te_ilac_ismi.Text;
                    urun.fiyat = float.Parse(TeFiyat.Text.ToString());
                    urun.stok = int.Parse(TeStok.Text.ToString());
                    urun.tuketim_tarihi = DateTime.Parse(DateTuketim.EditValue.ToString());
                    urun.uretim_tarihi = DateTime.Parse(DateUretim.EditValue.ToString());
                    urun.tur_id = int.Parse(Lupe_ilacTuru.EditValue.ToString());
                    db.SaveChanges();
                    XtraMessageBox.Show("İlaç Güncellendi !", "Başarılı ! | Eczane Otomasyon ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ilacListele();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("İlaçID").ToString());
            if (silinecekId.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Silme işleminde hata !", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var silinecekIlac = (from x in db.ilaclar
                                     where x.ilac_id == silinecekId
                                     select x).FirstOrDefault();
                db.ilaclar.Remove(silinecekIlac);
                db.SaveChanges();
                XtraMessageBox.Show("İlaç Silindi !", "Başarılı | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ilacListele();
        }
        private void TeFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && TeFiyat.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
        private void TeStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        public void ilacListele() //Grid Control'e kayıtları çekiyor
        {
            var ilacVer = from x in db.ilaclar
                          select new
                          {
                              İlaçID = x.ilac_id,
                              İlaçİsmi = x.ilac_ismi,
                              Fiyat = x.fiyat,
                              Stok = x.stok,
                              Tür = x.ilac_turleri.tur_ismi,
                              ÜretimTarihi = x.uretim_tarihi,
                              TüketimTarihi = x.tuketim_tarihi,

                          };
            gridControl1.DataSource = ilacVer.ToList();
        }

        private void ilacEkran_Load(object sender, EventArgs e)
        {
            ilacListele();
            lupeTurCek();
        }
        private void lupeTurCek() //Lupe'ye VERİLERİ ÇEKİYOR
        {
            var TurVer = (from x in db.ilac_turleri
                          select new
                          {
                              Tür = x.tur_ismi,
                              ID = x.tur_id
                          }).ToList();

            Lupe_ilacTuru.Properties.ValueMember = "ID";
            Lupe_ilacTuru.Properties.DisplayMember = "Tür";
            Lupe_ilacTuru.Properties.DataSource = TurVer;
        }
        private bool TurKontrol(string tur) //ZATEN BÖYLE BİR KATEGORİ VAR MI KONTROLÜ YAPIYOR
        {
            bool varmi = false;
            var turbul = (from x in db.ilac_turleri
                          where x.tur_ismi.ToString() == tur
                          select x).FirstOrDefault();
            if (turbul == null)//YOKSA
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

        private void BtnTurEkle_Click(object sender, EventArgs e)
        {
            if (TeYeniTur.Text == string.Empty || TeYeniTur.Text == null)
            {
                XtraMessageBox.Show("Yeni Tür Adını Boş Bırakmayınız.", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TurKontrol(TeYeniTur.Text)) //ZATEN BÖYLE BİR KATEGORİ VARSA
            {
                XtraMessageBox.Show("Bu Tür Zaten Kayıtlı !", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ilac_turleri ilacTuru = new ilac_turleri();
                ilacTuru.tur_ismi = TeYeniTur.Text;
                if (ilacTuru != null)
                {
                    db.ilac_turleri.Add(ilacTuru);
                    db.SaveChanges();
                    TeYeniTur.Text = "";
                    XtraMessageBox.Show("Yeni Tür Ekleme Başarılı !", "Başarılı ! | Eczane Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Yeni Tür Eklemede Sorun Yaşandı !", "Hata | Eczane Otomasyonu ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            lupeTurCek();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Te_ilac_ismi.Text = gridView1.GetFocusedRowCellValue("İlaçİsmi").ToString();
            TeFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            TeStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
            DateTuketim.Text = gridView1.GetFocusedRowCellValue("TüketimTarihi").ToString();
            DateUretim.Text = gridView1.GetFocusedRowCellValue("ÜretimTarihi").ToString();
            Lupe_ilacTuru.Text = gridView1.GetFocusedRowCellValue("Tür").ToString();
        }
    }
}
