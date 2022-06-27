using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class TeaFactory:AbstractFactory
    {
        public override AbstractDrink CreateDrink()
        {
            return new TeaDrink();
        }
        public override AbstractCup CreateCup()
        {
            return new TeaCup();
        }
    }
}
