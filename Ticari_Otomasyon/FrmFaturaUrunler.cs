using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturaUrunler : Form
    {
        public FrmFaturaUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string ID;



        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURADETAY where FATURAID='" + ID + "'", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        private void FrmFaturaUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenle fr = new FrmFaturaUrunDuzenle();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ID = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
            //this.Hide();
        }
    }
}
