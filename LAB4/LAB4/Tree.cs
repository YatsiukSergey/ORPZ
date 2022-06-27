using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    abstract class Tree
    {

        public string Name { get; protected set; }
        public int Age { get; set; }
        //public abstract string GetType(string type);
        public string Type { get; set; }
        public Tree(string name,int age,string type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
        }

    }
}
