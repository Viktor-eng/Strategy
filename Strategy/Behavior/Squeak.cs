using System;

namespace Strategy
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Я ненастоящая утка и умею пищать");
        }
    }
}
