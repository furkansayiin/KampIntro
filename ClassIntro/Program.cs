﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Pyhton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;


            Kurs kurs4 = new Kurs();
            kurs3.Kursadi = "C++";
            kurs3.Egitmen = "Murat Kurtboğan";
            kurs3.İzlenmeOrani = 100;


            //Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
