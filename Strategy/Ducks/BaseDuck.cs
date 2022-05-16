﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}