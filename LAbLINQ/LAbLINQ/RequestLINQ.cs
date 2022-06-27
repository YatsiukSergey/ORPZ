using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LAbLINQ

{
    /*
    class RequestLINQ
    {
        
            string Name { get; set; }
            string NameLocation { get; set; }
            float Square { get; set; }
        public List<> FirstRequest()
        {
            Database.InitData();
            var firstrequest = from p in Database.Shipings
                               join c in Database.Seas on p.Location equals c.Name
                               select new RequestLINQ { Name = p.ShipingCompany, NameLocation = c.Name, Square = c.Square }
                                   ;



            return firstrequest.ToList();
        }     
   
    
    
    }*/
}
