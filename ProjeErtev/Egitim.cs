using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeErtev
{
    public class Egitim
    {
        string tur, adi, icerik, kod, tarih;
       
        int ogrsayisi;

        public string Tur { get => tur; set => tur = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        
        public int Ogrsayisi { get => ogrsayisi; set => ogrsayisi = value; }
        public string Kod { get => kod; set => kod = value; }
        public string Tarih { get => tarih; set => tarih = value; }
    }
}