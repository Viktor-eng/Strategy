using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            Console.WriteLine();

            RedHeadDuck redHeadDuck = new RedHeadDuck();
            redHeadDuck.Display();
            Console.WriteLine();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            Console.WriteLine();

            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
        }
    }
}
