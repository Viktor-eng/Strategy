using System;

namespace Strategy
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Умею летать");
        }
    }
}
