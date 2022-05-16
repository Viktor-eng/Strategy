using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MallardDuck: BaseDuck
    {
        public MallardDuck() 
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }


        protected override void DuckBehavior()
        {
            Console.WriteLine("Я дикая утка, дерусь с другими утками");
        }
    }
}
