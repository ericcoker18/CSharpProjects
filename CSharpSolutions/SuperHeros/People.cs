using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros
{
    class People
    {
        public virtual string Name { get; set; }
        string NickName { get; set; }

        public People(string name, string nickname) {
            Name = name;
            NickName = nickname;
        }

        public override string ToString()
        {
            return Name;    
        }
       virtual public void PrintGreeting()
        {
            Console.WriteLine("Hi my name is " + Name + " you can call me " + NickName );

        }

    }
}
