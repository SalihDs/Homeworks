using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+musteri.Ad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : "+musteri.Ad);
        }
        public void MusterileriListele()
        {
            Console.WriteLine("Müşteriler Listelendi");
        }
    }
}
