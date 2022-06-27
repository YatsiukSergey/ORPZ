using System;
using System.Collections.Generic;
using System.Text;

namespace LabXml
{
    class Ship
    {
        public int IdShip;
        public string Name;
        public int AmountPassengers;
        public string ShipingCompany;
        public int YearOfConstruction;
        public string Type;

        public Ship()
        {

        }
        public Ship(int idShip, string name, int amountPassengers, string shipingCompany, int yearOfConstruction, string type)
        {
            IdShip = idShip;
            Name = name;
            AmountPassengers = amountPassengers;
            ShipingCompany = shipingCompany;
            YearOfConstruction = yearOfConstruction;
            Type = type;



        }


    }
}
