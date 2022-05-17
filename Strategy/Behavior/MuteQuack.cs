using System;

namespace Strategy
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Тип утки не издает звуков");
        }
    }
}
