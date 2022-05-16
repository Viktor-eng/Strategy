using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RubberDuck : BaseDuck, Quackable
    {
        public void Quack()
        {
            Console.WriteLine("Пищу");
        }

        internal override void Display()
        {
            Swim();
            Console.WriteLine("Я резиновая утка");
        }
    }
}
