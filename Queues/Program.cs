using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //KuyrukTest1();

            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.Write("Kuyruğa eklenme yapılsın mı?\t",k);
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"{k,5} kuyruğa eklendi");
                    Console.WriteLine("Kuyruktaki eleman sayısı:{0}",kuyruk.Count);
                }
            }

            Console.WriteLine("Kuyruktan eleman çıkarılmasını istiyorsanız Esc tuşuna basınınız..");
            secim = Console.ReadKey();
            if (secim.Key==ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count>=0)
                {
                    Console.WriteLine($"{kuyruk.Peek(),5} elemanı kuyruktan  çıkartılıyor.");
                    Console.WriteLine("İlgili eleman kuyruktan çıkartıldı.", kuyruk.Dequeue());
                    Console.WriteLine("Kuyruktaki eleman sayısı:{0}", kuyruk.Count);

                }
                Console.WriteLine("Kuyruktan çıkarılma işlemi tamamlandı.");
            }
            Console.WriteLine("Program bitti..İyi günler dileriz");


        }

        private static void KuyrukTest1()
        {
            //ilk gelen ilk çalışır mantığı , veri sırası belirgindir burada

            //Queue tanımlama
            var karakterKuyruğu = new Queue<char>();

            //enqueue ile ekleme
          
            karakterKuyruğu.Enqueue('a');
            karakterKuyruğu.Enqueue('b');
            karakterKuyruğu.Enqueue('c');
            karakterKuyruğu.Enqueue('d');


          

            Console.WriteLine("Elaman sayısı: {0}", karakterKuyruğu.Count);
         
            //kuyruğu diziye çevirme işlemi yapıldı
            var dizi = karakterKuyruğu.ToArray();


            //Dequeue ile geri çıkarma işlemi yapılır
            Console.WriteLine();

            while (karakterKuyruğu.Count > 0)
            {
                Console.WriteLine("Kuyruğun başındaki eleman:{0}", karakterKuyruğu.Peek());
                Console.WriteLine(karakterKuyruğu.Dequeue() + "-> Kuyruktan çıkarıldı..\n");
                Console.WriteLine("Elaman sayısı: {0}", karakterKuyruğu.Count);
            }
        }
    }
}
