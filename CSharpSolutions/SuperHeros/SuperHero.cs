using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros
{
    class SuperHero: People
    {
        String RealName { get; set; }
        String SuperPower { get; set; }
        public override String Name { get; set; }

        public SuperHero(string name1, string realname, string superpower) : base(name1, null)
        {
            RealName = realname;
            SuperPower = superpower;

        }
        public override void PrintGreeting()
        {
            Console.WriteLine("I am" + RealName + ". When I am" + Name + ", my super power is" + SuperPower + "!");

        }
    }
}
