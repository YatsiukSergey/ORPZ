using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class LateFactory:AbstractFactory
    {
      
        public override AbstractDrink CreateDrink()
        {
            return new LateDrink();
        }
        public override AbstractCup CreateCup()
        {
            return new LateCup();
        }
    }
}
