using System;
using System.Collections.Generic;
using System.Text;

namespace LAbLINQ
{
    class Database
    {
        public static List<Sea> Seas = new List<Sea>();
        public static List<River> Rivers = new List<River>();
        public static List<Shiping> Shipings  = new List<Shiping>();
        public static List<Ship> Ships = new List<Ship>();

        public static void InitData()
        {

            River Dnipro = new River(1, "Dnipro", 10000, 1.5F, 5);
            River Dunai = new River(2, "Dunai", 5000, 1, 2);
            River Gorin = new River(3, "Gorin", 3000, 0.2F, 3);
            Rivers.Add(Dnipro);
            Rivers.Add(Dunai);
            Rivers.Add(Gorin);

            Sea BlackSea = new Sea(1, "Black sea", 300000);
            Sea MediterraneanSea = new Sea(2, "Mediterranean Sea", 500000);
            Sea CaribbeanSea = new Sea(3, "Caribbean Sea", 200000);
            Seas.Add(BlackSea);
            Seas.Add(MediterraneanSea);
            Seas.Add(CaribbeanSea);

            Shiping OdesaBud = new Shiping(1, "OdesaBud", Seas[0].Name);
            Shiping Seasail = new Shiping(2, "Seasail", Seas[1].Name);
            Shiping Flot = new Shiping(3, "Flot", Seas[2].Name);
            Shipings.Add(OdesaBud);
            Shipings.Add(Seasail);
            Shipings.Add(Flot);


            Ship BlackJack = new Ship(1, "Black-Jack", 20, OdesaBud.ShipingCompany, 1999, "Sea");
            Ship Belatries = new Ship(2, "Belatries", 30, Seasail.ShipingCompany, 2000, "Sea");
            Ship BlackPearl = new Ship(3, "Black-Pearl", 50, Flot.ShipingCompany, 1980, "River");
            Ship FlyingDutch = new Ship(4, "Flying-Dutch", 60, Flot.ShipingCompany, 1950, "River");
            Ships.Add(BlackJack);
            Ships.Add(Belatries);
            Ships.Add(BlackPearl);
            Ships.Add(FlyingDutch);
           
        }
    
    }
}
