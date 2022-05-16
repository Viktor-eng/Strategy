using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class BaseDuck
    {
        internal void Swim()
        {
            Console.WriteLine("Я утка, я плыву");
        }
        
        internal abstract void Display();
    }
}
