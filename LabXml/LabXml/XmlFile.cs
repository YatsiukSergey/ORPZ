using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace LabXml
{
    class XmlFile
    {
        public static void CreateXmlFile(List<Ship> ships, List<Shiping> shipings, List<River> rivers, List<Sea> seas)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xmlWriter = XmlWriter.Create("lab2.xml", settings))
            {

                xmlWriter.WriteStartElement("LABXML");
                xmlWriter.WriteStartElement("ships");
                foreach (Ship ship in ships)
                {

                    xmlWriter.WriteStartElement("ship");
                    xmlWriter.WriteElementString("idship", ship.IdShip.ToString());
                    xmlWriter.WriteElementString("name", ship.Name);
                    xmlWriter.WriteElementString("amoutpasengers", ship.AmountPassengers.ToString());
                    xmlWriter.WriteElementString("shipingCompany", ship.ShipingCompany);
                    xmlWriter.WriteElementString("yearofconstruction", ship.YearOfConstruction.ToString());
                    xmlWriter.WriteElementString("type", ship.Type);
                    xmlWriter.WriteEndElement();


                }

                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("shipings");
                foreach (Shiping shiping in shipings)
                {
                    xmlWriter.WriteStartElement("shiping");
                    xmlWriter.WriteElementString("idshiping", shiping.IdShiping.ToString());
                    xmlWriter.WriteElementString("shipingCompany", shiping.ShipingCompany);
                    xmlWriter.WriteElementString("location", shiping.Location);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("rivers");
                foreach (River river in rivers)
                {
                    xmlWriter.WriteStartElement("river");
                    xmlWriter.WriteElementString("idriver", river.IdRiver.ToString());
                    xmlWriter.WriteElementString("nameRiver", river.Name);
                    xmlWriter.WriteElementString("length", river.Length.ToString());
                    xmlWriter.WriteElementString("width", river.Width.ToString());
                    xmlWriter.WriteElementString("amountTributaries", river.AmountTributaries.ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("rivers");
               
                xmlWriter.WriteStartElement("seas");
                foreach (Sea sea in seas)
                {
                    xmlWriter.WriteStartElement("sea");
                    xmlWriter.WriteElementString("idsea", sea.IdSea.ToString());
                    xmlWriter.WriteElementString("nameSea", sea.Name);
                    xmlWriter.WriteElementString("square", sea.Square.ToString());

                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();


                xmlWriter.Close();
            }


        }
    }
}
