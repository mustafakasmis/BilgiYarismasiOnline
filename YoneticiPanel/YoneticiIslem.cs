using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYarismasiOnline.YöneticiPanel
{
   
    public class YoneticiIslem
    {

        static string yol = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=OnlineBilgiYarismasi;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(yol);

        public string gelensoru, seceneka, secenekb, secenekc, secenekd, seciliKategori, seciliCevap;
        int sayac;

        private List<SqlDataReader> sorular;

        //BAĞLNATI AÇMA
        public void baglantiAc()
        {
            baglanti.Open();
        }

        //BAĞLANTI KAPAMA
        public void baglantiKapa()
        {
            baglanti.Close();
        }

        //TÜM KATEGORİLERE AİT SORULARI GETİRME
        public List<SqlDataReader> sorularıGetir()
        {

            baglantiAc();

    string tarihsorgucum = "select kategoriler.kategori_adi,soru,secenekA,secenekB,secenekC,secenekD from soruBilgi " +
                "inner join kategoriler on soruBilgi.kategori_id=kategoriler.id";

    string bilimsorgucum = "select kategoriler.kategori_adi,soru,secenekA,secenekB,secenekC,secenekD from soruBilgi " +
                "inner join kategoriler on soruBilgi.kategori_id=kategoriler.id";

    string sporsorgucum = "select kategoriler.kategori_adi,soru,secenekA,secenekB,secenekC,secenekD from soruBilgi " +
                "inner join kategoriler on soruBilgi.kategori_id=kategoriler.id";

    string sanatsorgucum = "select kategoriler.kategori_adi,soru,secenekA,secenekB,secenekC,secenekD from soruBilgi" +
                " inner join kategoriler on soruBilgi.kategori_id=kategoriler.id";

    SqlCommand tarihsorgu = new SqlCommand(tarihsorgucum, baglanti);
    SqlCommand bilimsorgu = new SqlCommand(bilimsorgucum, baglanti);
    SqlCommand sporsorgu = new SqlCommand(sporsorgucum, baglanti);
    SqlCommand sanatsorgu = new SqlCommand(sanatsorgucum, baglanti);


            sorular.Add(tarihsorgu.ExecuteReader());
            sorular.Add(bilimsorgu.ExecuteReader());
            sorular.Add(sporsorgu.ExecuteReader());
            sorular.Add(sanatsorgu.ExecuteReader());

            tarihsorgu.ExecuteNonQuery();
            bilimsorgu.ExecuteNonQuery();
            sporsorgu.ExecuteNonQuery();
            sanatsorgu.ExecuteNonQuery();

    baglantiKapa();

            return sorular;
         
        }

        //SORU EKLEME BÖLÜMÜ
        public void soruEkle()
        {

            baglantiAc();

            SqlCommand cmd = new SqlCommand("insert into soruBilgi values (@kategoriId,@soru,@seceneka,@secenekb,@secenekc,@secenekd)", baglanti);


            cmd.Parameters.AddWithValue("@kategoriId",kategoriIdGetir(seciliKategori));

            cmd.Parameters.AddWithValue("@soru", gelensoru);
            cmd.Parameters.AddWithValue("@seceneka", seceneka);
            cmd.Parameters.AddWithValue("@secenekb", secenekb);
            cmd.Parameters.AddWithValue("@secenekc", secenekc);
            cmd.Parameters.AddWithValue("@secenekd", secenekd);

            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("select count(id) from soruBilgi", baglanti);
            sayac = (int)cmd2.ExecuteScalar();

            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into cevaplar values (@katId,@soruId,@soruCevap)", baglanti);

            cmd3.Parameters.AddWithValue("@katId", kategoriIdGetir(seciliKategori));
            cmd3.Parameters.AddWithValue("@soruId", sayac);
            cmd3.Parameters.AddWithValue("@soruCevap", cevabiGetir(seciliCevap));

            cmd3.ExecuteNonQuery();

            baglantiKapa();

         }


        //SEÇİLEN KATEGORİYE AİT İD Yİ GETİRME
        private int kategoriIdGetir(string gelen)
        {

            int gidecek = 0;

            switch (gelen)
            {
                case "TARİH":
                    gidecek = 1;
                    break;
                case "BİLİM":
                    gidecek = 2;
                    break;
                case "SPOR":
                    gidecek = 3;
                    break;
                case "SANAT":
                    gidecek = 4;
                    break;
            }

            return gidecek;

        }

        //SORUNU CEVABINI GETİRME
        private string cevabiGetir(string gelen)
        {
            string gidecek = "";

            switch (gelen)
            {
                case "SEÇENEK A":
                    gidecek = seceneka;
                    break;
                case "SEÇENEK B":
                    gidecek = secenekb;
                    break;
                case "SEÇENEK C":
                    gidecek = secenekc;
                    break;
                case "SEÇENEK D":
                    gidecek = secenekd;
                    break;

            }
            return gidecek;
        }

    }

}