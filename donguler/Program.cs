using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya Baslangic Icin Temel Kursu";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python Kursu";
            string kurs5 = "C++ Kursu";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            //array-dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampı" , "Programlamaya Baslangic Icin Temel Kursu" ,"Java Kursu"};

            for (int i = 1; i < kurslar.Length; i ++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti.");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu-footer");
        }
    }
}
