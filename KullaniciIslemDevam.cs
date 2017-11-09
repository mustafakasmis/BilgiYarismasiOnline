using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYarismasiOnline
{

    public class KullaniciIslemDevam
    {

        static string yol = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=OnlineBilgiYarismasi;Integrated Security=True";
        SqlConnection con = new SqlConnection(yol);


        public string ad, soyad, kullaniciadi, email, parola, sevilenkategori;


        //KULLANICININ AİT BİLGİLERİN GETİRİLMESİ
        public void ProfilGoster()
        {

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand(" select * from kullanicilar where kullanici_adi='" + kullaniciadi + "' ", con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ad = dr["ad"].ToString(); soyad = dr["soyad"].ToString();

                kullaniciadi = dr["kullanici_adi"].ToString(); email = dr["e_mail"].ToString();

                sevilenkategori = dr["sevilenKategori"].ToString();
            }


        }

    }

}
