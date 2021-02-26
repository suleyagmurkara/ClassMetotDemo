using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!");
            Console.WriteLine("Adı: " + musteri.Ad);
            Console.WriteLine("Soyadı: " + musteri.Soyad);
            Console.WriteLine("Telefon: " + musteri.Telefon);
            Console.WriteLine("------------------------------");
        }

        public void MusteriListele(Musteri musteri)
        {

        }
    }
}
