﻿using System;
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
    public partial class Frmistatislik : Form
    {
        public Frmistatislik()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-273NEV0;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void Frmistatislik_Load(object sender, EventArgs e)
        {
            //TOPLAM PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglanti);

            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();



            //EVLİ PERSONEL SAYISI

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_Personel Where PerDurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }    
            baglanti.Close();



            //BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum = 0",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            
            baglanti.Close();



            //TOPLAM ŞEHİR SAYİSİ

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel",baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehir.Text = dr4[0].ToString();
            }

            baglanti.Close();

            //TOPLAM MAAŞ 

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from Tbl_Personel",baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //ORTALAMA MAAŞ

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            
            baglanti.Close();            
        }
    }
}
