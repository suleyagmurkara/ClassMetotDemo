using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Şule";
            musteri1.Soyad = "KARA";
            musteri1.Telefon = 5405555555;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Yağmur";
            musteri2.Soyad = "KARA";
            musteri2.Telefon = 5322222222;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Betül";
            musteri3.Soyad = "KARA";
            musteri3.Telefon = 5687471489;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

        }
    }
}
