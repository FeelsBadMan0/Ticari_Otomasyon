﻿using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        public string kullanici;
        FrmUrunler fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }


        }
        FrmMusteriler fr2;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FrmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmFirmalar fr3;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FrmFirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        FrmPersoneller fr4;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new FrmPersoneller();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        FrmRehber fr5;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new FrmRehber();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        FrmGiderler fr6;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new FrmGiderler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        FrmBankalar fr7;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new FrmBankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        FrmFaturalar fr8;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new FrmFaturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        FrmNotlar fr9;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new FrmNotlar();
                fr9.MdiParent = this;
                fr9.Show();
            }

        }

        FrmHareketler fr10;
        private void btnHateketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new FrmHareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }

        }

        FrmRapor fr11;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new FrmRapor();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }

        FrmStoklar fr12;
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new FrmStoklar();
                fr12.MdiParent = this;
                fr12.Show();
            }

        }


        FrmAyarlar fr13;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new FrmAyarlar();
                fr13.Show();
            }

        }

        FrmKasa fr14;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new FrmKasa();
                fr14.ad = kullanici;
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        FrmAnaSayfa fr15;
        private void FrmAnaModul_Load(object sender, System.EventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new FrmAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }


        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new FrmAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
    }
}
