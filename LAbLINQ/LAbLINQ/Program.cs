using System;
using Microsoft;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace LAbLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.InitData();
            FirstRequest();
            SecondRequest();
            ThirdRequest();
            FourthRequest();
            FifthRequest();
            SixRequest();
            SeventhRequest();
            EighthRequest();
            NinthRequest();
            

        }

        static void FirstRequest()//зєднання таблиць
        {
            var firstrequest = from p in Database.Shipings
                               join c in Database.Seas on p.Location equals c.Name
                               select new { Name = p.ShipingCompany, NameLocation = c.Name, Squere = c.Square }
                       ;

            foreach (var first in firstrequest)
                Console.WriteLine($"{first.Name} - {first.NameLocation} {first.Squere} m^2");
            Console.WriteLine("============================================================");

        }
        static void SecondRequest()//зєднання таблиць
        {
            var secondrequest = from p in Database.Ships
                                join c in Database.Shipings on p.IdShip equals c.IdShiping
                                select new { Id = p.IdShip, Name = p.Name, Location = c.Location };

            foreach (var second in secondrequest)
                Console.WriteLine($"{second.Id} - {second.Name} {second.Location} ");


            Console.WriteLine("============================================================");



        }
        static void ThirdRequest()//Відбір річок з id<2
        {
            var thirdrequest = from p in Database.Rivers
                               where p.IdRiver < 2
                               select new { Id = p.IdRiver, Name = p.Name, Width = p.Width };

            foreach (var third in thirdrequest)
                Console.WriteLine($"{third.Id} {third.Name} {third.Width}");
            Console.WriteLine("============================================================");

        }
        static void FourthRequest()//Проста вибірка кораблів
        {
            var fourthrequest = from p in Database.Ships
                                select p.Name;
            foreach (var fourth in fourthrequest)
                Console.WriteLine(fourth);
            Console.WriteLine("============================================================");
        }
        static void FifthRequest()//вибір річок за притоками 
        {
            var fifthrequest = from p in Database.Rivers
                               where (p.AmountTributaries == 5 || p.AmountTributaries == 2)
                               select new { Name = p.Name, Width = p.Width, AmountTributaries = p.AmountTributaries }
                        ;
            foreach (var fifth in fifthrequest)
                Console.WriteLine($"{fifth.Name} {fifth.Width} km {fifth.AmountTributaries}");
            Console.WriteLine("============================================================");
        }
        static void SixRequest()//сортування по спаданю
        {

            var sixrequest = from p in Database.Shipings
                             orderby p.IdShiping descending
                             select new { Id = p.IdShiping, Name = p.ShipingCompany, Location = p.Location }
                           ;

            foreach (var six in sixrequest)
                Console.WriteLine($"{six.Id} {six.Name}  {six.Location}");
            Console.WriteLine("============================================================");


        }
        static void SeventhRequest()//групувати по компанія кораблі
        {
            var seventhrequest = from p in Database.Ships
                                 group p by p.ShipingCompany;


            foreach (var shipingcompany in seventhrequest)
            {
                Console.WriteLine($"{ shipingcompany.Key} ");
                foreach (var ship in shipingcompany)
                {
                    Console.WriteLine(ship.Name);

                }
                Console.WriteLine();
            }
            Console.WriteLine("============================================================");
        }

        static void EighthRequest()//сортуваня річок за довжиною
        {
            var eigthrequest = from p in Database.Rivers
                                where (p.Length > 4000)
                               select p.Name
                                ;

            Console.WriteLine(eigthrequest.Count());

            Console.WriteLine("============================================================");
        }
        static void NinthRequest()// вік кораблів макс мін середенє
        {
            var NighRequest = from p in Database.Ships
                              select p.YearOfConstruction;
            Console.WriteLine("Середній {0} вік,найбільший вік {1} та найменший {2}", NighRequest.Average(), NighRequest.Max(), NighRequest.Min());

        }
        
    }
}

           

            
              
         

            













