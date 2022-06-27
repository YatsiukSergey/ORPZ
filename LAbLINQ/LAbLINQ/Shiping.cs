using System;
using System.Collections.Generic;
using System.Text;

namespace LAbLINQ
{
    class Shiping
    {
        public int IdShiping;
        public string ShipingCompany;
        public string Location;
        public Shiping()
        {

        }
        public Shiping(int idShiping, string shipingCompany, string location)
        {
            IdShiping = idShiping;
            ShipingCompany = shipingCompany;
            Location = location;


        }
    }
}
