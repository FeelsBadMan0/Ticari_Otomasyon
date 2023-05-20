using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();


        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSektor.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkiliAdSoyad.Text = "";
            mskYetkiliTC.Text = "";
            mskTel.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            txtMail.Text = "";
            mskFax.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiDaire.Text = "";
            rchAdres.Text = "";
        }



        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            temizle();
            sehirListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSektor.Text = dr["SEKTOR"].ToString();
                txtYetkiliGorev.Text = dr["YETKILI"].ToString();
                txtYetkiliAdSoyad.Text = dr["YETKILIADSOYAD"].ToString();
                mskYetkiliTC.Text = dr["YETKILITC"].ToString();
                mskTel.Text = dr["TELEFON1"].ToString();
                mskTel2.Text = dr["TELEFON2"].ToString();
                mskTel3.Text = dr["TELEFON3"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                mskFax.Text = dr["FAX"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtVergiDaire.Text = dr["VERGIDAIRE"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,SEKTOR,YETKILI,YETKILIADSOYAD,YETKILITC,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSektor.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p4", txtYetkiliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p5", mskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@p6", mskTel.Text);
            komut.Parameters.AddWithValue("@p7", mskTel2.Text);
            komut.Parameters.AddWithValue("@p8", mskTel3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbIl.Text);
            komut.Parameters.AddWithValue("@p12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p14", rchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firmayı sisteme başarılı bir şekilde kaydettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Firmayı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firmaListesi();
                temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@p1,SEKTOR=@p2,YETKILI=@p3,YETKILIADSOYAD=@p4,YETKILITC=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@P12,VERGIDAIRE=@p13,ADRES=@p14 where ID=@p15", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSektor.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p4", txtYetkiliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p5", mskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@p6", mskTel.Text);
            komut.Parameters.AddWithValue("@p7", mskTel2.Text);
            komut.Parameters.AddWithValue("@p8", mskTel3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbIl.Text);
            komut.Parameters.AddWithValue("@p12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p14", rchAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            temizle();
        }
    }
}
