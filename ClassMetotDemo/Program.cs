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

            int i;
            Console.WriteLine("Bir işlem seçiniz.");
            Console.WriteLine("1-Müşterileri Ekleme.");
            Console.WriteLine("2-Müşterileri Listeleme.");
            Console.WriteLine("3-Müşterileri Silme.");
            i = Convert.ToInt16(Console.ReadLine());

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};
            MusteriManager musteriManager = new MusteriManager();
            
            if (i == 1)
            {
                musteriManager.MusteriEkle(musteri1);
                musteriManager.MusteriEkle(musteri2);
                musteriManager.MusteriEkle(musteri3);
            }else if(i == 2){
                musteriManager.MusteriListele(musteriler);
            }else if(i == 3)
            {
                musteriManager.MusteriSil(musteri1);
                musteriManager.MusteriSil(musteri2);
                musteriManager.MusteriSil(musteri3);
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
            }
        }
    }
}
