﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ronahi";
            int yas = 20;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ronahi Güven";
            kurs1.IzlenmeOrani= 12;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Fatma";
            kurs2.IzlenmeOrani = 12;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ayse";
            kurs3.IzlenmeOrani = 12;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ayse";
            kurs4.IzlenmeOrani = 12;
            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };
            foreach (var kurs in kurslar )
            {
                Console .WriteLine(kurs.KursAdi+":"+kurs.Egitmen);   
            }

        }
    }

    class Kurs
    {
        public string KursAdi{ get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
