using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Figure
    {
        protected string model;
        public IMovable Movable { private get; set; }
     
        public Figure( string model,IMovable mov)
        {
          
            this.model = model;
            Movable = mov;
        }
        public string Move(int distance)
        {
           return Movable.Move(distance);
        }


    }
}
