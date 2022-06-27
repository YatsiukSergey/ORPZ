using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class LateDrink:AbstractDrink
    {
        public string MainIngrediante="Coffe";
        public int VolumeMilk = 200;
        private string _recipe;
        public override string Recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }
        

        
        public LateDrink()
        {
            Recipe = "Main ingrediante is" + MainIngrediante + "with volume milk" + VolumeMilk;
        }
    }
}
