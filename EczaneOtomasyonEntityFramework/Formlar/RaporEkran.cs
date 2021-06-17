using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonEntityFramework
{
    public partial class RaporEkran : Form
    {
        public RaporEkran()
        {
            InitializeComponent();
        }

        EczaneOtomasyonEntityDBEntities db = new EczaneOtomasyonEntityDBEntities();


        private void RaporEkran_Load(object sender, EventArgs e)
        {

        }
        public void Son24SaatSatislar() //Grid Control'e kayıtları çekiyor
        {
            string yıl = DateTime.Today.Year.ToString();
            string ay = DateTime.Today.Month.ToString();
            string gün = DateTime.Today.Day.ToString();
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }
            string bugün = yıl + "-" + ay + "-" + gün;

            GcGun.Visible = true;
            GcStokBiten.Visible = false;
            GcTarihiGecmis.Visible = false;

            var satisAl = from x in db.ilac_satis
                          where x.satis_tarihi.ToString().Substring(0, 10) == bugün
                          select new
                          {
                              SatışID = x.satis_id,
                              SatışTarihi = x.satis_tarihi,
                              SatanKullanıcı = x.calisanlar.TC,
                              İlaç = x.ilaclar.ilac_ismi,
                              İlaçID = x.ilac_id,
                              SatışFiyatı = x.satis_fiyati,
                              Adet = x.adet
                          };
            GcGun.DataSource = satisAl.ToList();
        }
        public void StokBitenUrunCek() //Grid Control'e kayıtları çekiyor
        {
            GcGun.Visible = false;
            GcTarihiGecmis.Visible = false;
            GcStokBiten.Visible = true;
            var ilacCek = from x in db.ilaclar
                          where x.stok == 0
                          select new
                          {
                              ID = x.ilac_id,
                              İlaçAdı = x.ilac_ismi,
                              Stok = x.stok,
                          };
            GcStokBiten.DataSource = ilacCek.ToList();
        }

        public void TarihiGecmisUrunCek() //Grid Control'e kayıtları çekiyor
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

            GcGun.Visible = false;
            GcTarihiGecmis.Visible = true;
            GcStokBiten.Visible = false;

            var ilacCek = from x in db.ilaclar
                          where x.tuketim_tarihi < bugun
                          select new
                          {
                              ID = x.ilac_id,
                              İlaçAdı = x.ilac_ismi,
                              Adet = x.stok,
                              TüketimTarihi = x.tuketim_tarihi,
                              ÜretimTarihi = x.uretim_tarihi,
                              Fiyat = x.fiyat,
                              Tür = x.ilac_turleri.tur_ismi,
                          };
            GcTarihiGecmis.DataSource = ilacCek.ToList();
        }

        private void Btn_G_GunSonu_Click(object sender, EventArgs e)
        {
            Son24SaatSatislar();
        }

        private void Btn_G_Stok_Click(object sender, EventArgs e)
        {
            StokBitenUrunCek();
        }

        private void Btn_G_Tarih_Click(object sender, EventArgs e)
        {
            TarihiGecmisUrunCek();
        }

        private void Btn_R_GunSonu_Click(object sender, EventArgs e)
        {
            GunSonuRapor sonSatislarRapor = new GunSonuRapor();
            ReportPrintTool printTool = new ReportPrintTool(sonSatislarRapor);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

        private void Btn_R_Stok_Click(object sender, EventArgs e)
        {
            StokBitenRapor stokBitenlerRapor = new StokBitenRapor();
            ReportPrintTool printTool = new ReportPrintTool(stokBitenlerRapor);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
