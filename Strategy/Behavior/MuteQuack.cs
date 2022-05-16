using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Тип утки не издает звуков");
        }
    }
}
