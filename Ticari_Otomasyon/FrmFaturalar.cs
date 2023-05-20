using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtSeri.Text = "";
            txtSıraNo.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergiDairesi.Text = "";
            txtAlıcı.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
        }

        void temizle2()
        {
            txtUrunID.Text = "";
            txtUrunAd.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtTutar.Text = "";
            txtFaturaID.Text = "";
            txtPersonel.Text = "";
            txtFirma.Text = "";

        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFaturaID.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@p6", txtAlıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();

            }

            if (txtFaturaID.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();


                //Hareket Tablosuna Veri Girişi
                SqlCommand komut3 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaID.Text);
                komut3.Parameters.AddWithValue("@h8", mskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Stok Sayısı azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtUrunID.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("Fatura Detay başarılı bir şekide kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle2();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["FATURABILGIID"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                txtSıraNo.Text = dr["SIRANO"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                txtAlıcı.Text = dr["ALICI"].ToString();
                txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                txtTeslimAlan.Text = dr["TESLIMALAN"].ToString();


            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Faturayı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komt = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
                komt.Parameters.AddWithValue("@p1", txtID.Text);
                komt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 where FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtSeri.Text);
            komut.Parameters.AddWithValue("@P2", txtSıraNo.Text);
            komut.Parameters.AddWithValue("@P3", mskTarih.Text);
            komut.Parameters.AddWithValue("@P4", mskSaat.Text);
            komut.Parameters.AddWithValue("@P5", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P6", txtAlıcı.Text);
            komut.Parameters.AddWithValue("@P7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@P8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@P9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunler fr = new FrmFaturaUrunler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ID = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select URUNAD,SATISFIYAT FROM TBL_URUNLER WHERE ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
