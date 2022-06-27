using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class StepAside : IMovable
    {
        public string Move(int distance)
        {
            string move = "Фігуру переміщено в бік на" + distance;
            return move;        
        }
    }
}
