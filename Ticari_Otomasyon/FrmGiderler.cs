using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void temizle()
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbYıl.Text = "";
            txtElektrik.Text = "";
            txtSu.Text = "";
            txtDogalGaz.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtEkstra.Text = "";
            rchNotlar.Text = "";

        }


        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            komut.Parameters.AddWithValue("@p2", cmbYıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalGaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@p9", rchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Giderler başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                cmbYıl.Text = dr["YIL"].ToString();
                txtElektrik.Text = dr["ELEKTRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtDogalGaz.Text = dr["DOGALGAZ"].ToString();
                txtInternet.Text = dr["INTERNET"].ToString();
                txtMaaslar.Text = dr["MAASLAR"].ToString();
                txtEkstra.Text = dr["EKSTRA"].ToString();
                rchNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Gideri silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Gider başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giderListesi();
                temizle();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmbAy.Text);
            komut.Parameters.AddWithValue("@P2", cmbYıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtDogalGaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtMaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", rchNotlar.Text);
            komut.Parameters.AddWithValue("@P10", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider başarılı bir şekilde güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }
    }
}
