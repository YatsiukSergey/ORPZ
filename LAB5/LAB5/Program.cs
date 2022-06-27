using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure( "Ферзь", new StepAside());
            figure.Move(5);
            Console.WriteLine(figure.Move(5));
            figure.Movable = new StepDiagonally();
            Console.WriteLine(figure.Move(5));
            Console.ReadLine();
        }
    }
}
