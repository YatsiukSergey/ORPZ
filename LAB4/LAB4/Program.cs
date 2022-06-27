using System;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree1 = new AppleTree("Яблуня",6,"Паперівка");
            
            tree1 = new AlichaCombineTree(tree1);
            
            Console.WriteLine("Імя {0}", tree1.Name);
            Console.WriteLine("Вид {0}", tree1.Type);
        }


    }
}
