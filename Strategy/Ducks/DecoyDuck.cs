using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DecoyDuck : BaseDuck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }


        protected override void DuckBehavior()
        {
            Console.WriteLine("Я деревянная утка");
        }
    }
}
