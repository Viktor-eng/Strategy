using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MallardDuck : Duck
    {
        internal override void Display()
        {
            Quack();
            Swim();
            Console.WriteLine("Я дикая утка, я дерусь с другими утками");
            Fly();
        }
    }
}
