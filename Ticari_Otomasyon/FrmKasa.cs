using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void musteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec FırmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        void GiderTablosu()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }


        public string ad;
        private void FrmKasa_Load(object sender, System.EventArgs e)
        {
            musteriHareket();
            firmaHareket();
            GiderTablosu();

            //Toplam Tutarı Hesaplama

            SqlCommand komut1 = new SqlCommand("Select sum(TUTAR) from TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblKasaToplam.Text = dr1[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();

            //Son ayın faturaları
            SqlCommand komut2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from TBL_GIDERLER  order by ID asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblOdemeler.Text = dr2[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();

            //Son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("Select MAASLAR from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblPersonelMaas.Text = dr3[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();

            //Toplam Musteri sayisi
            SqlCommand komut4 = new SqlCommand("Select Count(*) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma sayisi
            SqlCommand komut5 = new SqlCommand("Select Count(*) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma sehir sayısı
            SqlCommand komut6 = new SqlCommand("Select Count(Distinct(IL)) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblFirmaSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Müşteri sehir sayısı
            SqlCommand komut7 = new SqlCommand("Select Count(Distinct(IL)) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblMusteriSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Personel sayısı
            SqlCommand komut8 = new SqlCommand("Select Count(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Stok sayısı
            SqlCommand komut9 = new SqlCommand("SELECT sum(ADET) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

            lblAktifKullanici.Text = ad;


        }

        int sayac = 0;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            sayac++;
            //Elektrik
            if (sayac > 0 && sayac <= 5)
            {
                groupControl11.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //Su
            if (sayac > 5 && sayac <= 10)
            {
                groupControl11.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,Su from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Doğal Gaz
            if (sayac > 10 && sayac <= 15)
            {
                groupControl11.Text = "Doğal Gaz";
                chartControl1.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,DOGALGAZ from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //İnternet
            if (sayac > 15 && sayac <= 20)
            {
                groupControl11.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,INTERNET from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Ekstra
            if (sayac > 20 && sayac <= 25)
            {
                groupControl11.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,Ekstra from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, System.EventArgs e)
        {
            sayac2++;
            //Elektrik
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl12.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID asc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //Su
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl12.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,Su from TBL_GIDERLER ORDER BY ID asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Doğal Gaz
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl12.Text = "Doğal Gaz";
                chartControl2.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,DOGALGAZ from TBL_GIDERLER ORDER BY ID asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //İnternet
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl12.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,INTERNET from TBL_GIDERLER ORDER BY ID asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl12.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                //1.Chart kontrole su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("Select Top 4 Ay,Ekstra from TBL_GIDERLER ORDER BY ID asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac2 == 26)
            {
                sayac2 = 0;
            }

        }
    }
}
