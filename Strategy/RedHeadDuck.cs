using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RedHeadDuck : Duck
    {
        internal override void Display()
        {
            Quack();
            Swim();
            Console.WriteLine("Я красноголовая утка, я красивая");
            Fly();
        }
    }
}
