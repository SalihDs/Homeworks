using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(1, "Ali");
            Console.WriteLine(ogrenci[1]);

            MyDictionary<string, int> ogrenci2 = new MyDictionary<string, int>();
            ogrenci2.Add("Salih", 2);
            Console.WriteLine(ogrenci2.Get("Salih"));


        }
    }
}
