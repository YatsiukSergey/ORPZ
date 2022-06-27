using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class TeaDrink:AbstractDrink

    {
        public string MainIngrediante = "Tea";
        public int VolumeWater = 200;
        private string _recipe;
        public override string Recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }
        public TeaDrink()
        {
            Recipe = "Main ingrediante is" + MainIngrediante + "with volume water" + VolumeWater;
        }

    }
}
