using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Do not repeat yourself - Kendini Tekrarlama
            //typeSafety - tip güvenliği
            //değer tutucu ,alias
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sitemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sitemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }
             

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
