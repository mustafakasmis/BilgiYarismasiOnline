using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.IO;

namespace BilgiYarismasiOnline
{
    public class KullaniciIslem
    {

        static string yol =@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog = OnlineBilgiYarismasi; Integrated Security = True";

        SqlConnection con = new SqlConnection(yol);
        SqlConnection con2 = new SqlConnection(yol);

        KullaniciProfil kp = new KullaniciProfil();

        public string ad, soyad, kullaniciadi, email, parola, sevilenkategori,durum;

        public string oncekiKullaniciAdi;  //KAYIT GÜNCELLENECEK KİŞİNİN KULLANICI İSMİ TUTULUYOR

        public bool aynisiVarmi;

        public bool varmi = false;

        // SİSTEME KAYIT EKLEMENİN YAPILDIĞI KISIM
        public void KayıtEkle()
        {

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from kullanicilar", con);
            SqlDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {

                //BURADA KAYIT OLUNURKEN AYNI KULLANICI ADINA SAHİP BİR KULLANICI VAR MI O KONTROL EDİLİR EĞER VARSA ENGELLENİR 
                if (kullaniciadi.Equals(dr["kullanici_adi"].ToString()))
                {
                    varmi = true;
                }

            }

            dr.Close();
            cmd1.ExecuteNonQuery();

            if (varmi == false)
            {

                string sorgu = "insert into kullanicilar values(@ad,@soyad,@kullaniciAdi,@eMail,@parola,@sevilenkategori,@durum)";
                SqlCommand cmd2 = new SqlCommand(sorgu, con);

                cmd2.Parameters.AddWithValue("@ad", ad);
                cmd2.Parameters.AddWithValue("@soyad", soyad);
                cmd2.Parameters.AddWithValue("@kullaniciAdi", kullaniciadi);
                cmd2.Parameters.AddWithValue("@eMail", email);
                cmd2.Parameters.AddWithValue("@parola", parola);
                cmd2.Parameters.AddWithValue("@sevilenkategori", sevilenkategori);
                cmd2.Parameters.AddWithValue("@durum", "kullanici");

                cmd2.ExecuteNonQuery();

            }

            con.Close();
        }

        //SİSTEMDE GİRİLEN BİLGİLERE AİT KİŞİ VAR MI YOK MU KONTROLÜNÜN YAPILDIĞI KISIM
        
        public bool KullaniciVarmi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from kullanicilar", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (kullaniciadi.Equals(dr["kullanici_adi"].ToString()) && parola.Equals(dr["parola"].ToString()))
                {
                    varmi = true;
                    break;
                }
            }

            dr.Close();

            cmd.ExecuteNonQuery();

            con.Close();

            return varmi;

        }

        //SEVİLEN KATEGORİYİ GETİRME KISMI
        public string sevilenKategoriGetir()
        {
           
            if (con.State == ConnectionState.Closed)
                con.Open();

    SqlCommand cmd = new SqlCommand("select sevilenKategori from kullanicilar where kullanici_adi='"+kullaniciadi+"' ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                return dr["sevilenKategori"].ToString();

            else
                return "";

        }

        //SİSTEME GİREN KİŞİNİN KULLANICI VEYA YÖNETİCİ OLDUĞUNUN KONTROLÜNÜN YAPILDIĞI KISIM
        public string yetkiDurum()
        {

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("select durum from kullanicilar where kullanici_adi='"+kullaniciadi+"' ", con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return dr["durum"].ToString();
            }

            else
                return "";
            
        }

        //PROFİL GÜNCELLEME KISMI
        public void KayitGuncelle(string sevilenKategori)
        {

            if (con.State == ConnectionState.Closed && con2.State == ConnectionState.Closed)
            {
                con.Open();
                con2.Open();
            }

         SqlCommand cmd = new SqlCommand("select id from kullanicilar where kullanici_adi=@kullanici_adi",con);

            cmd.Parameters.AddWithValue("@kullanici_adi", oncekiKullaniciAdi);

            int id = Convert.ToInt32(cmd.ExecuteScalar()); // KULLANICI ADINA AİT İD Yİ GETİRME

            aynisiVarmi = kullaniciAdiGetir(id,kullaniciadi); 

            cmd.ExecuteNonQuery();

            con.Close();

         SqlCommand cmd2 = new SqlCommand("update kullanicilar set ad=@ad,soyad=@soyad,kullanici_adi=@kullanici_adi,e_mail=@e_mail,parola=@parola,sevilenKategori=@sevilenKategori where id=@id",con2);

            cmd2.Parameters.AddWithValue("@ad",ad);
            cmd2.Parameters.AddWithValue("@soyad", soyad);

            if (aynisiVarmi)
                kp.kontrolGelen();

            else
                cmd2.Parameters.AddWithValue("@kullanici_adi", kullaniciadi);

            cmd2.Parameters.AddWithValue("@e_mail", email);
            cmd2.Parameters.AddWithValue("@parola", parola);
            cmd2.Parameters.AddWithValue("@sevilenKategori",sevilenkategori);
            cmd2.Parameters.AddWithValue("@id", id);

            cmd2.ExecuteNonQuery();

        }

        // GÜNCELLEMEDEN ÖNCE ID YE AİT KULLANICI ADINININ OLUP OLMADIĞINI BELİRLEME
        public bool kullaniciAdiGetir(int id,string kullaniciadi)
        {
            con.Open();

            SqlCommand komut = new SqlCommand("select kullanici_adi from kullanicilar where id=@id",con);

            komut.Parameters.AddWithValue("@id",id);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                if (kullaniciadi.Equals(dr["kullanici_adi"].ToString()))
                    return true;
            }

            dr.Close();

            con.Close();

            return false;

        }

        //EĞER AYNI KULLANICI İSMİNE SAHİP KİŞİ VARSA İŞLEMİ BİTİRME KISMI (ANA YER)
        public void islemiSonlandir()
        {
            con.Close();
            con2.Close();
        }

    }

}