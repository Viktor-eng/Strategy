using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DecoyDuck : Duck
    {
        internal override void Display()
        {
            Quack();
            Swim();
            Console.WriteLine("Я деревянная утка");
            Fly();
        }

        internal override void Fly()
        {

        }

        internal override void Quack()
        {
            
        }
    }
}
