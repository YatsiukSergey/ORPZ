using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    public class Client
    {
        private AbstractDrink drink;
        private AbstractCup cup;
        public Client()
        {
        }
        /*public Client(AbstractFactory factory)
        {
            drink = factory.CreateDrink();
            cup = factory.CreateCup();
        }
        */
        public void Run()
        {
            cup.Interact(drink);
        }
    }
}
