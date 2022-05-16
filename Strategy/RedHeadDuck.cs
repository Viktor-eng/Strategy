﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RedHeadDuck : BaseDuck, Flyable, Quackable
    {
        public void Fly()
        {
            Console.WriteLine("Лечууу");
        }

        public void Quack()
        {
            Console.WriteLine("Крякаю");
        }

        internal override void Display()
        {
            Fly();
            Quack();
            Swim();
            Console.WriteLine("Я красноголовая утка, я красивая");
        }
    }
}
