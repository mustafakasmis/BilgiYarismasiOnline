using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace BilgiYarismasiOnline
{
    public class KullaniciIslemleri
    {
        static string yol = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog = OnlineBilgiYarismasi; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(yol);
        SqlConnection con = new SqlConnection(yol);

        public string soru, secenekA, secenekB, secenekC, secenekD;

        public int dogru=0, yanlis=0;

        public string gidecek="";

        //SORUYU GETİRME
        public void sorularıGetir(int id,int sayac)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("select * from soruBilgi where kategori_id=@kategori_id and id=@id",baglanti);

            cmd.Parameters.AddWithValue("@id",sayac);
            cmd.Parameters.AddWithValue("@kategori_id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                soru = dr["soru"].ToString();
                secenekA = dr["secenekA"].ToString();
                secenekB = dr["secenekB"].ToString();
                secenekC = dr["secenekC"].ToString();
                secenekD = dr["secenekD"].ToString();
            }

            dr.Close();
            baglanti.Close();
       
        }

        //SORUNU CEVABINI GETİRME
        public string cevabiGetir(int id, int sayac)
        {
            string cevap="";

            baglanti.Open();

            SqlCommand cmd = new SqlCommand("select cevap from cevaplar where katid=@katid and id=@id", baglanti);

            cmd.Parameters.AddWithValue("@id", sayac);
            cmd.Parameters.AddWithValue("@katid", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
                cevap = dr["cevap"].ToString();

            dr.Close();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            return cevap;
        }

        //KULLANICI CEVABINI EKLEME
        public void kullaniciCevapEkle(string kullaniciadi,int katid,int soruid,string cevap)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("insert into kullanici_cevaplar values(@kadi,@kid,@sid,@cevap)",baglanti);

            cmd.Parameters.AddWithValue("@kadi",kullaniciadi);
            cmd.Parameters.AddWithValue("@kid", katid);
            cmd.Parameters.AddWithValue("@sid",soruid);
            cmd.Parameters.AddWithValue("@cevap",cevap);

            cmd.ExecuteNonQuery();

            baglanti.Close();
        }
    

        //İSTATİSTİK LERİ GÖSTERME KISMI (CEVAP SAYILARINI ÇEKME)
        public string cevapSayiGetir(string ad,string id)
        {
            int ID = Convert.ToInt32(id);

            baglanti.Open();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select kullanici_cevap from kullanici_cevaplar where kullaniciadi=@kadi and kategori_id=@kid", baglanti);
            cmd1.Parameters.AddWithValue("@kadi",ad);
            cmd1.Parameters.AddWithValue("@kid",ID);

            SqlCommand cmd2 = new SqlCommand("select cevap from cevaplar where katid=@kid",con);
            cmd2.Parameters.AddWithValue("@kid",ID);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while(dr1.Read() && dr2.Read())
            {

                if (dr1["kullanici_cevap"].ToString() == dr2["cevap"].ToString())
                    dogru++;
                else
                    yanlis++;
            }

            gidecek = dogru + "-" + yanlis;

            dr1.Close();
            dr2.Close();

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            baglanti.Close();
            con.Close();


            return gidecek;
        }

    }
}