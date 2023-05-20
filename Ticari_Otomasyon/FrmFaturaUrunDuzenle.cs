using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturaUrunDuzenle : Form
    {
        public FrmFaturaUrunDuzenle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            txtUrunID.Text = "";
            txtUrunAd.Text = "";
            txtFiyat.Text = "";
            txtMiktar.Text = "";
            txtTutar.Text = "";
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string ID;
        private void FrmFaturaUrunDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select FATURAURUNID,URUNAD,MIKTAR,FIYAT,TUTAR from TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunID.Text = dr[0].ToString();
                txtUrunAd.Text = dr[1].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtTutar.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 where FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@P2", txtMiktar.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@P5", txtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Fatura Bilgisini silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }

        }
    }
}
