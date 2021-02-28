using Struct;
using System;
using System.Collections.Generic;

namespace BtkAkademi
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListDemo2();


            Dot dot = new Dot(4,5);
            dot.SetOrigin();
            Console.WriteLine("İlk noktada kesişen değerler         :{0}",dot);
            dot.Change();
           
            Console.WriteLine("İkinci noktada kesişen değerler       :{0}",dot);

            var dot1 = dot;
            dot1.X = dot1.X * -2;
            Console.WriteLine("Üçüncü noktada kesişen değerler         :{0}",dot1);


            

        }

        private static void ListDemo2()
        {
            //Struct kullanımı

            List<Student> students = new List<Student>
            {
              new Student{FirstName="Furkan",LastName="Kavak",Gender="Erkek",Id=1,Departmant="Yazılım Bilimcisi",City="Batman"}
            };

            Student student1 = new Student()
            {
                FirstName = "Gamze",
                LastName = "Kavak",
                Id = 2,
                Gender = "Kadın",
                Departmant = "Hemşire",
                City = "Bursa"
            };

            students.Add(student1);

            students.ForEach(s => Console.WriteLine(s));

            //foreach (var s in students)
            //{
            //    Console.WriteLine(s);
            //}
        }
    }

}
