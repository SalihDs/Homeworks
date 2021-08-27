using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Salih";
            musteri.Soyad = "Dürüs";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriSil(musteri);
            musteriManager.MusterileriListele();
        }
    }
}
