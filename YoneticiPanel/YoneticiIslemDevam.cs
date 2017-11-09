using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYarismasiOnline.YöneticiPanel
{

    public class YoneticiIslemDevam
    {

        static string yol = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=OnlineBilgiYarismasi;Integrated Security=True";

        SqlConnection baglanti = new SqlConnection(yol);
        SqlConnection baglanti2 = new SqlConnection(yol);

        public string soru, secenekA, secenekB, secenekC, secenekD, kat_adi,cevap; // SORU GÜNCELLEME FORMUNA GİDECEK VERİLER İÇİN

        private string gelen = ""; //KATEGORİYİ BELİRLEMEK İÇİN
        private string gidecek = ""; //CEVABI BELİRLEMEK İÇİN

        public void baglantiAc()
        {
            baglanti.Open();
            baglanti2.Open();
        }

        public void baglantiKapa()
        {
            baglanti.Close();
            baglanti2.Close();
        }

        //SEÇİLEN SORUYU SİLME (KATEGOORİYE GÖRE)
        public void soruSil(int id,string kategori)
        {

            switch (kategori)
            {
                case "TARİH":
                    gelen = kategori;
                    break;
                case "BİLİM":
                    gelen = kategori;
                    break;
                case "SPOR":
                    gelen = kategori;
                    break;
                case "SANAT":
                    gelen = kategori;
                    break;
            }

            baglantiAc();

            SqlCommand cmd = new SqlCommand("delete from soruBilgi where id=@id and kategoriler.kategori_adi=@kategori",baglanti);

            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@kategori",gelen);

            cmd.ExecuteNonQuery();

            baglantiKapa();

        }

        //SORU GÜNCELLEME FORMUNA VERİ AKTARMA
        public void yukle(int id,string kat_adi)
        {
            baglantiAc();

            SqlCommand cmd = new SqlCommand("select soru,secenekA,secenekB,secenekC,secenekD from soruBilgi where id=@id",baglanti);
            SqlCommand cmd2 = new SqlCommand("select cevap from cevaplar where id=@id",baglanti2);

            cmd.Parameters.AddWithValue("@id",id);
            cmd2.Parameters.AddWithValue("@id",id);

            SqlDataReader oku = cmd.ExecuteReader();
            SqlDataReader oku2 = cmd2.ExecuteReader();

            if (oku.Read() & oku2.Read())
            {

                soru = oku["soru"].ToString();
                secenekA = oku["secenekA"].ToString();
                secenekB= oku["secenekB"].ToString();
                secenekC = oku["secenekC"].ToString();
                secenekD = oku["secenekD"].ToString();
                cevap= oku2["cevap"].ToString();


                oku.Close();
                oku2.Close();

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

            }

            baglantiKapa();

        }

        //SORU GÜNCELLEME KISMININ GERÇEKLEŞTİĞİ YER (VERİTABANINA İŞLENDİĞİ YER)
        public void guncelle(int id,string kat_adi)
        {
            baglantiAc();

      SqlCommand cmd = new SqlCommand("update soruBilgi set soru=@soru,secenekA=@secenekA,secenekB=@secenekB,secenekC=@secenekC,secenekD=@secenekD where id=@id",baglanti);
      SqlCommand cmd2 = new SqlCommand("update cevaplar set cevap=@cevap where id=@id2",baglanti2);

            cmd.Parameters.AddWithValue("@soru",soru);

            cmd.Parameters.AddWithValue("@secenekA", secenekA);
            cmd.Parameters.AddWithValue("@secenekB", secenekB);
            cmd.Parameters.AddWithValue("@secenekC", secenekC);
            cmd.Parameters.AddWithValue("@secenekD", secenekD);

            cmd.Parameters.AddWithValue("@id",id);

            cmd2.Parameters.AddWithValue("@cevap", cevabiGetir(cevap));
            cmd2.Parameters.AddWithValue("@id2",id);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            baglantiKapa();

        }


        //SORUNU CEVABINI GETİRME
        private string cevabiGetir(string gelen)
        {

            switch (gelen)
            {
                case "SEÇENEK A":
                    gidecek = secenekA;
                    break;
                case "SEÇENEK B":
                    gidecek = secenekB;
                    break;
                case "SEÇENEK C":
                    gidecek = secenekC;
                    break;
                case "SEÇENEK D":
                    gidecek = secenekD;
                    break;

            }
            return gidecek;
        }

    }

}