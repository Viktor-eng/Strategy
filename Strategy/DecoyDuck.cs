using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DecoyDuck : BaseDuck
    {
        internal override void Display()
        {
            Swim();
            Console.WriteLine("Я деревянная утка");
        }
    }
}
