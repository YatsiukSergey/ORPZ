using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;



namespace LabXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Database.InitData();
            XmlFile.CreateXmlFile(Database.Ships, Database.Shipings, Database.Rivers, Database.Seas);
            XDocument xdoc = XDocument.Load("lab2.xml");
            
            q1(xdoc);
            q2(xdoc);
            q3(xdoc);
            q4(xdoc);
            q5(xdoc);
            q6(xdoc);
            q7(xdoc);
            q8(xdoc);
            q9(xdoc);
           
        }
        
        
        
        
        
       
      
        static void q1(XDocument xdoc)
        {
            var q1=from d in xdoc.Descendants("ship")
                   select new {Id=d.Element("idship").Value,Name=d.Element("name").Value, AmountPasengers=d.Element("amoutpasengers").Value };
           
            foreach(var p in  q1)
            {
                Console.WriteLine($"{ p.Id}, { p.Name}, { p.AmountPasengers}");
            }
            
        }

        static void q2(XDocument xdoc)
        {
            var q2=from p in xdoc.Descendants("ship")
                   where p.Element("shipingCompany").Value=="Flot"
                   select new
                   {

                       Id = p.Element("idship").Value,
                       Name = p.Element("name").Value,
                       shipingCompany = p.Element("shipingCompany").Value,
                       yearofconstruction = p.Element("yearofconstruction").Value
                   }
                   ;
            foreach (var q in q2)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine();
        }

        static void q3(XDocument xdoc)
        {

            var q3 = from p in xdoc.Descendants("ship")
                     orderby int.Parse(p.Element("yearofconstruction").Value)
                     select new
                     {
                         Id = p.Element("idship").Value, Name = p.Element("name").Value,
                         yearofconstruction = p.Element("yearofconstruction").Value 

                };
            foreach (var q in q3)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine();

        }
        static void q4(XDocument xdoc)
        {
            List<int> ids = new List<int> { 1, 2, 10 };
            var q4 = from p in xdoc.Descendants("ship")
                     where ids.Contains(int.Parse(p.Element("idship").Value))
                     select new
                     {

                         Id = p.Element("idship").Value,
                         Name = p.Element("name").Value,
                         shipingCompany = p.Element("shipingCompany").Value,
                         yearofconstruction = p.Element("yearofconstruction").Value
                     }
                   ;
            foreach (var q in q4)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine();

        }
        static void q5(XDocument xdoc)
        {
            var q5 = from p in xdoc.Descendants("yearofconstruction")
                     select int.Parse(p.Value);
            Console.WriteLine(q5.Max());
        }
        static void q6(XDocument xdoc)
        {
            var q6 = from p in xdoc.Descendants("ship")
                     group p by p.Element("shipingCompany").Value into grp
                     select new
                     {
                         shipingCompany=grp.Key,
                         Count=grp.Count()

                     };


            foreach (var q in q6)
            {
                Console.WriteLine("shipingCompany:" + q.shipingCompany + "Count:" + q.Count);
            }


        }
        static void q7(XDocument xdoc)
        {
            var q7 = from p in xdoc.Descendants("ship")
                     join c in xdoc.Descendants("shiping") on p.Element("idship").Value equals c.Element("idshiping").Value
                     select new { Id = p.Element("idship").Value, Name = p.Element("name").Value, Location = c.Element("location").Value };
            foreach (var q in q7)
            {
                Console.WriteLine(q);
            }
        }
        static void q8(XDocument xdoc)
        {
            var q8 = from p in xdoc.Descendants("river")
                     where int.Parse(p.Element("length").Value) > 4000
                     select p.Name
                                ;

            Console.WriteLine(q8.Count());

            Console.WriteLine("============================================================");

        }
        static void q9(XDocument xdoc)
        {
            var NighRequest = from p in xdoc.Descendants("ship")
                              select int.Parse(p.Element("yearofconstruction").Value);
            Console.WriteLine("Середній {0} вік,найбільший вік {1} та найменший {2}", NighRequest.Average(), NighRequest.Max(), NighRequest.Min());


        }
        


    }
    }


