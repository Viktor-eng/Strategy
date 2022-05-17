using System;

namespace Strategy
{
    class DecoyDuck : BaseDuck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }


        protected override void DuckBehavior()
        {
            Console.WriteLine("Я деревянная утка");
        }
    }
}
