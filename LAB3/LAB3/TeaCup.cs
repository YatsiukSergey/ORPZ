using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class TeaCup:AbstractCup
    {
        public override void Interact(AbstractDrink drink)
        {
            Console.WriteLine(this + "interact with" + drink + "Recipe:" + drink.Recipe);
        }
    }
}

