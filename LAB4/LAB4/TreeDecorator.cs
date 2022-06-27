using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    abstract class TreeDecorator:Tree
    {
        protected Tree tree;
        public TreeDecorator(string name,int age,string type, Tree tree) : base(name,age,type)
        {
            
            this.tree = tree;
        }
    }
}
