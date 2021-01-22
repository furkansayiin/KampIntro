using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C++";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            //array - dizi 

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs","Java","Python"};
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            
            //Foreach dizileri tek tek dolaşmaya yarar ve diziler için daha çok kullanılan tarzdır. 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}