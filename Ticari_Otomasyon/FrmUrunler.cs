using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtAd.Text = "";
            txtID.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYıl.Text = "";
            nudAdet.Value = 0;
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            rchDetay.Text = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYıl.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", rchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarılı bir şekilde kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYıl.Text = dr["YIL"].ToString();
            nudAdet.Value = int.Parse(dr["ADET"].ToString());
            txtAlisFiyat.Text = dr["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            rchDetay.Text = dr["DETAY"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtMarka.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", txtModel.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", mskYıl.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Value.ToString()));
            komutGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            komutGuncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            komutGuncelle.Parameters.AddWithValue("@p8", rchDetay.Text);
            komutGuncelle.Parameters.AddWithValue("@p9", txtID.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urunler sistemde başarılı bir şekilde güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
