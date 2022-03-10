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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-273NEV0;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre= @p2",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }

            baglanti.Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
            this.Hide();





        }
    }
}
