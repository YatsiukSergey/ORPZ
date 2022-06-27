using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class AlichaCombineTree:TreeDecorator
    {
        public AlichaCombineTree(Tree p)
:       base(p.Name + "з аличею",5,p.Type+ "з аличею дикорослою", p)
        {
            if (p.Age < 5)
            {
                throw new ArgumentException("Age не может быть меньше ");
            }
        }
       
        
    }
}
