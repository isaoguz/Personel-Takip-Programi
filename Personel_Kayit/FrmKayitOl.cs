using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-273NEV0;Initial Catalog=PersonelVeriTabani;Integrated Security=True");



        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Yonetici (KullaniciAd,Sifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p2", TxtKayitSifre.Text);
            komut.Parameters.AddWithValue("@p1", TxtKayitAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            FrmGiris frm1 = new FrmGiris();
            frm1.Show();
            this.Hide();
        }
    }
}
