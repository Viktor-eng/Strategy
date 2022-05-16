using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RubberDuck : BaseDuck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }


        protected override void DuckBehavior()
        {
            Console.WriteLine("Я резиновая утка");
        }
    }
}
