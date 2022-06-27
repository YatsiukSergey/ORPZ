using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    abstract class AbstractFactory
    {
        public abstract AbstractDrink CreateDrink();
        public abstract AbstractCup CreateCup();
    }
}
