using System;

namespace Strategy
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Умею крякать");
        }
    }
}
