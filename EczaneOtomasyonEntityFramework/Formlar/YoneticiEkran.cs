using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonEntityFramework.Formlar
{
    public partial class YoneticiEkran : Form
    {

        public YoneticiEkran()
        {

            InitializeComponent();
        }


        ilacEkran ilacForm;

        private void Btn_ilac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ilacForm == null || ilacForm.IsDisposed)
            {
                ilacForm = new ilacEkran();
                ilacForm.MdiParent = this;
                ilacForm.Show();
            }
        }

        PersonelEkran personelForm;
        private void BtnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelForm == null || personelForm.IsDisposed)
            {
                personelForm = new PersonelEkran();
                personelForm.MdiParent = this;
                personelForm.Show();
            }
        }


        MusteriEkran musteriForm;
        private void BtnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteriForm == null || musteriForm.IsDisposed)
            {
                musteriForm = new MusteriEkran();
                musteriForm.MdiParent = this;
                musteriForm.Show();
            }
        }


        RaporEkran raporForm;
        private void BtnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raporForm == null || raporForm.IsDisposed)
            {
                raporForm = new RaporEkran();
                raporForm.MdiParent = this;
                raporForm.Show();
            }
        }


        SatisEkran satisForm;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satisForm == null || satisForm.IsDisposed)
            {
                satisForm = new SatisEkran();
                satisForm.MdiParent = this;
                satisForm.Show();
            }
        }

        private void YoneticiEkran_Load(object sender, EventArgs e)
        {
        }
    }
}
