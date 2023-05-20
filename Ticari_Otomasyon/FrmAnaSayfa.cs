using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
namespace Ticari_Otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD,sum(ADET) AS 'ADET' FROM TBL_URUNLER GROUP BY URUNAD HAVING SUM(ADET)<=20 ORDER BY SUM(ADET)", bgl.baglanti());
            da.Fill(dt);
            gridKontrolStoklar.DataSource = dt;
        }

        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select TOP 10 TARIH,SAAT,BASLIK from TBL_NOTLAR ORDER BY ID DESC", bgl.baglanti());
            da.Fill(dt);
            gridAjanda.DataSource = dt;
        }

        void firmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec FirmaHareket2", bgl.baglanti());
            da.Fill(dt);
            gridFirmaHareketler.DataSource = dt;
        }

        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,TELEFON1 FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridFihrist.DataSource = dt;
        }

        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            firmaHareket();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            haberler();



        }
    }
}
