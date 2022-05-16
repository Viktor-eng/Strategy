using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Я ненастоящая утка и умею пищать");
        }
    }
}
