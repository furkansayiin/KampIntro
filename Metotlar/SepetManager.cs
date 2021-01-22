using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //name convention
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }


        public void Ekle2(string urunAdi , string Aciklama , double urunFiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi !");
        }
    }
}
