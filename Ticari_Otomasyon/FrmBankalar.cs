using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();


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


        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            txtID.Text = "";
            txtBanka.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtSube.Text = "";
            mskIban.Text = "";
            mskHesapNo.Text = "";
            txtYetkili.Text = "";
            mskTel.Text = "";
            mskTarih.Text = "";
            txtHesapTuru.Text = "";
            lookupFirma.Text = "";

        }

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookupFirma.Properties.NullText = "Lütfen bir firma seçiniz";
            lookupFirma.Properties.ValueMember = "ID";
            lookupFirma.Properties.DisplayMember = "AD";
            lookupFirma.Properties.DataSource = dt;

        }


        private void FrmBankalar_Load(object sender, System.EventArgs e)
        {
            listele();
            sehirListesi();
            firmaListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtBanka.Text = dr["BANKAAD"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtSube.Text = dr["SUBE"].ToString();
                mskIban.Text = dr["IBAN"].ToString();
                mskHesapNo.Text = dr["HESAPNO"].ToString();
                txtYetkili.Text = dr["YETKILI"].ToString();
                mskTel.Text = dr["TELEFON"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                txtHesapTuru.Text = dr["HESAPTURU"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAAD,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBanka.Text);
            komut.Parameters.AddWithValue("@p2", cmbIl.Text);
            komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", mskIban.Text);
            komut.Parameters.AddWithValue("@p6", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", mskTel.Text);
            komut.Parameters.AddWithValue("@p9", mskTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookupFirma.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btnTemizle_Click(object sender, System.EventArgs e)
        {
            temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void btnSil_Click(object sender, System.EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Bankayı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_BANKALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAAD=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 where ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtBanka.Text);
            komut.Parameters.AddWithValue("@P2", cmbIl.Text);
            komut.Parameters.AddWithValue("@P3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P4", txtSube.Text);
            komut.Parameters.AddWithValue("@P5", mskIban.Text);
            komut.Parameters.AddWithValue("@P6", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@P7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@P8", mskTel.Text);
            komut.Parameters.AddWithValue("@P9", mskTarih.Text);
            komut.Parameters.AddWithValue("@P10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookupFirma.EditValue);
            komut.Parameters.AddWithValue("@P12", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
