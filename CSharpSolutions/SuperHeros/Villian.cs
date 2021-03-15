using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros
{
    class Villian : People
    {
        String Nemesis { get; set; }
        public override String Name { get; set; }

        public Villian(string name1, string nemesis): base(name1, null)
        {
            Nemesis = nemesis;


        }
        public override void PrintGreeting()
        {
            Console.WriteLine("I am The " + Name + " Have you seen" + Nemesis + "?");


        }
    }
}
