using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi ="Katogori";
            int ogrenciSayisi=32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }
            if (sistemeGirişYapmisMi==true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

          
        }
    }
}
