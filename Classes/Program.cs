using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            TeachingStaff teachingStaff = new TeachingStaff()
            {
                RegistrationNumber = 1,
                FirstName = "Furkan",
                LastName = "Kavak",
                Gender = true
            };
            Console.WriteLine(teachingStaff);


            var list = new List<TeachingStaff>()
            {
                new TeachingStaff{RegistrationNumber=1,FirstName="Salih",LastName="Bağlamış",Gender=true},
                new TeachingStaff{RegistrationNumber=2,FirstName="Melih",LastName="Kaçmaz",Gender=true},
                new TeachingStaff{RegistrationNumber=3,FirstName="Osman",LastName="Kavak",Gender=true},
                new TeachingStaff{RegistrationNumber=4,FirstName="Berat",LastName="Orun",Gender=true},
                new TeachingStaff{RegistrationNumber=5,FirstName="Zeynep",LastName="Özcan",Gender=false},
                new TeachingStaff{RegistrationNumber=6,FirstName="Nergiz",LastName="Çiçek",Gender=false},



            };
            Console.WriteLine("List1 data");
            list.ForEach(teach => Console.WriteLine(teach));
            Console.WriteLine();

          




            Console.ReadLine();
        }
    }
}
