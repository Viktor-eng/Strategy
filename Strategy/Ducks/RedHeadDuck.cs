using System;

namespace Strategy
{
    class RedHeadDuck : BaseDuck
    {
        public RedHeadDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }


        protected override void DuckBehavior()
        {
            Console.WriteLine("Я красноголовая утка, красивая");
        }
    }
}
