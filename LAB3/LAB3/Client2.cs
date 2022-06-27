using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class Client2
    {
        private AbstractDrink drink;
        private AbstractCup cup;
        public Client2()
        {
        }
        public Client2(AbstractFactory factory)
        {
            drink = factory.CreateDrink();
            cup = factory.CreateCup();
        }
        public void Run()
        {
            cup.Interact(drink);
        }
    }
}
