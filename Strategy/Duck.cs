using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Duck
    {
        internal virtual void Quack()
        {
            Console.WriteLine("Кря-кря");
        }

        internal void Swim()
        {
            Console.WriteLine("Я утка, я плыву");
        }
        internal virtual void Fly()
        {
            Console.WriteLine("Я ЛЕЧУ, ЮХУУУ");
        }

        internal abstract void Display();
    }
}
