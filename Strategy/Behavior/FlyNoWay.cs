using System;

namespace Strategy
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Этот тип уток не может летать");
        }
    }
}
