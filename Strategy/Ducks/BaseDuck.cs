using System;

namespace Strategy
{
    abstract class BaseDuck
    {
        protected IFlyBehavior _flyBehavior;

        protected IQuackBehavior _quackBehavior;

        protected void Swim()
        {
            Console.WriteLine("Умею плавать");
        }

        internal virtual void Display()
        {
            DuckBehavior();
            PerformFly();
            PerformQuack();
            Swim();
        }

        protected abstract void DuckBehavior();

        protected void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        protected void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }
    }
}
