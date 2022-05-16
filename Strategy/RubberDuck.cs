using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RubberDuck : Duck
    {
        internal override void Display()
        {
            Quack();
            Swim();
            Console.WriteLine("Я резиновая утка");
            Fly();
        }

        internal override void Fly()
        {
            
        }

        internal override void Quack()
        {
            Console.WriteLine("ПищУУуууу противным писком");
        }
    }
}
