using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // YığınTest1();
            //YığınTest2();
           SayılarıBasamaklarınaAyırmaTesti();
        }

        private static void SayılarıBasamaklarınaAyırmaTesti()
        {
            Console.WriteLine("Lütfen bir sayı giriniz      :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiyiğini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiyiğini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiyiğini.Count - 1;
            foreach (var s in sayiyiğini)
            {
                Console.WriteLine($"\t{s} x {Math.Pow(10, n - i)} = {s * Math.Pow(10, n - i)}");
                i++;
            }
            Console.ReadLine();
        }

        private static void YığınTest2()
        {
            var karakterYiğini = new Stack<char>();
            for (int i = 65; i <= 75; i++)
            {
                karakterYiğini.Push((char)i);
                Console.WriteLine(karakterYiğini.Count + ". olan elemanımız yığına eklenmek üzere getirildi\n" + karakterYiğini.Peek() + " adlı eleman yığına eklendi...\n");

                //Console.WriteLine(karakterYiğini.Peek()+ " yığına eklendi ");

            }
            //  var array2 = karakterYiğini.ToArray();
            Console.WriteLine("Yığından çıkarma işlemi için bir tuşa basınız...");
            Console.WriteLine();
            Console.ReadKey();

            while (karakterYiğini.Count > 0)
            {
                Console.WriteLine(karakterYiğini.Count + ". olan elemanımız yığından çıkarılma işlemi için getirildi." + karakterYiğini.Pop() + " adlı eleman yığından çıkartıldı...\t\n");
            }
        }

        private static void YığınTest1()
        {
            //Stack tanımlama 
            var cities = new Stack<string>();

            //Push ile ekleme yaptık ardından peek ile elemanı getirtiyoruz
            cities.Push("Batman\n");
            Console.WriteLine(cities.Peek());
            cities.Push("Adana\n");
            Console.WriteLine(cities.Peek());
            cities.Push("İstanbul\n");
            Console.WriteLine(cities.Peek());

            //Çıkarma işlemi yapcaz.Yığın sınıfında ilk giren son çıkar

            Console.WriteLine(cities.Pop() + "Elamanı çıkartıldı");
            Console.WriteLine(cities.Pop() + "Elamanı çıkartıldı");
            Console.WriteLine(cities.Pop() + "Elamanı çıkartıldı");
        }
    }
}
