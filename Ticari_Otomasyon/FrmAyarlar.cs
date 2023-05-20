using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ADMIN", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        void temizle()
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN VALUES (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            if (btnKaydet.Text == "Güncelle")
            {
                SqlCommand komut2 = new SqlCommand("update TBL_ADMIN set SIFRE=@p1 where KULLANICIAD=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut2.Parameters.AddWithValue("@p2", txtKullaniciAdi.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKullaniciAdi.Text = dr["KULLANICIAD"].ToString();
                txtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "")
            {
                btnKaydet.Text = "Güncelle";
            }
            else
            {
                btnKaydet.Text = "Kaydet";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
