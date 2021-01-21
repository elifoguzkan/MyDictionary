using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> sehirPostaKodu = new Dictionary<string, int>();
            sehirPostaKodu.Add("Kayseri", 38000);
            sehirPostaKodu.Add("Samsun", 55000);
            sehirPostaKodu.Add("İzmir", 35000);
            sehirPostaKodu.Add("Sivas", 58000);
            sehirPostaKodu.Add("Ankara", 06000);
            sehirPostaKodu.Add("Mersin", 33000);
            sehirPostaKodu.Add("Kırıkkale", 71000);
            sehirPostaKodu.Add("Nevşehir", 50000);
            sehirPostaKodu.Add("İstanbul", 34000);
            sehirPostaKodu.Add("Adana", 01000);
            sehirPostaKodu.Add("Kırşehir", 40000);
            sehirPostaKodu.Add("Amasya", 05000);

            foreach (var spkBul in sehirPostaKodu) //ekrana yazdırma
            {
                Console.WriteLine(spkBul);
            }




        }
    }
}
