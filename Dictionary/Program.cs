using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string , int > products = new MyDictionary<string , int>();
            products.Add("Bilgisayar", 13000);
            products.Add("İphone",6000);
            products.Add("Televizyon", 3000);

            Console.WriteLine(products.Count);
        }
    }
}
