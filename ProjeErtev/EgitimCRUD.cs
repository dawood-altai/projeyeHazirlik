using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjeErtev
{
    public class EgitimCRUD
    {
        Db db = new Db();

        public bool kaydet(Egitim eg)
        {
            int test;
            bool cevap;
            db.ac();
            SqlCommand komut = new SqlCommand("insert into Egitim values(@Tur,@Adi,@Tarih,@Ogrsayisi,@Icerik,@Kod)", db.baglanti);
            komut.Parameters.AddWithValue("@Tur",eg.Tur );
            komut.Parameters.AddWithValue("@Adi",eg.Adi );
            komut.Parameters.AddWithValue("@Tarih",eg.Tarih );
            komut.Parameters.AddWithValue("@Ogrsayisi",eg.Ogrsayisi );
            komut.Parameters.AddWithValue("@Icerik",eg.Icerik );
            komut.Parameters.AddWithValue("@Kod", eg.Kod);

            test = komut.ExecuteNonQuery();

            if (test == 0)
            {
                cevap = false;
            }
            else
            {
                cevap = true;
            }
            db.kapat();
            return cevap;
        }


        public DataTable listele()
        {
            DataTable dt = new DataTable();
            db.ac();
            SqlCommand komut = new SqlCommand("select * from Egitim", db.baglanti);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = komut;
            adp.Fill(dt);
            db.kapat();
            return dt;
        }

      

        public bool sil(string kod)
        {
            bool cevap = true;
            int ksay;   
            db.ac();
            SqlCommand komut = new SqlCommand("delete from Egitim where egitimkod=@K", db.baglanti);
            komut.Parameters.AddWithValue("@K", kod);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;
        }



        public bool guncelle(Egitim yeni)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("update Egitim set tur=@a, adi=@b, tarih=@c, ogrencisay=@d, icerik=@e where egitimkod=@K", db.baglanti);

            komut.Parameters.AddWithValue("@a",yeni.Tur);
            komut.Parameters.AddWithValue("@b", yeni.Adi);
            komut.Parameters.AddWithValue("@c",Convert.ToDateTime( yeni.Tarih));
            komut.Parameters.AddWithValue("@d", yeni.Ogrsayisi);
            komut.Parameters.AddWithValue("@e", yeni.Icerik);
            komut.Parameters.AddWithValue("@K",yeni.Kod);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;

        }



        public Egitim getir(string ko)
        {
            Egitim eg = new Egitim();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from Egitim where egitimkod=@K", db.baglanti);
            komut.Parameters.AddWithValue("@K", ko);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            adp.Fill(dt);
            eg.Tur = dt.Rows[0][0].ToString();
            eg.Adi = dt.Rows[0][1].ToString();
            eg.Tarih = dt.Rows[0][2].ToString();
            eg.Ogrsayisi = Convert.ToInt16( dt.Rows[0][3].ToString());
            eg.Icerik = dt.Rows[0][4].ToString();
            eg.Kod =dt.Rows[0][5].ToString();
            db.kapat();
            return eg;
        }
    }
}