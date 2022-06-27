using System;
using System.Collections.Generic;
using System.Text;

namespace LabXml
{
    class Shiping
    {
        public int IdShiping;
        public string ShipingCompany;
        public string Location;//!!
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
