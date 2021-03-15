using System.Collections.Generic;

namespace SuperHeros
{
    class Program
    {
        static void Main(string[] args)
        {
             List<People> Get = new List<People>();
            
             Get.Add(new People("Eric", "E"));
            Get.Add(new Villian("Bane", "Batman"));
            Get.Add(new SuperHero("Bruce Wayne","Batman", "Bane"));

            foreach (People people in Get)
            {
                people.PrintGreeting();
            }

            

         
        }
    }


}
