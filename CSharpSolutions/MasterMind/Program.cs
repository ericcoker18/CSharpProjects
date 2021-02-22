using System;
using System.Collections.Generic;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> colors = new List<string> {
            "yellow", "red", "blue"};
            List<string> UserChoice = new List<string> {"",""};
            List<string> CorrectColor = new List<string> {"",""};
            CorrectColor[0] = (colors[random.Next(0,2)]);
            CorrectColor[1] = (colors[random.Next(0,2)]);
            bool ColorCheck = true;
            Console.WriteLine(CorrectColor[0] + CorrectColor[1]);

            while (ColorCheck)
            {
                Console.WriteLine("Enter your first guess red, blue, or yellow?");
                UserChoice[0] = (Console.ReadLine());
                Console.WriteLine("Enter your second guess red, blue, or yellow?");
                UserChoice[1] = (Console.ReadLine());

                if (UserChoice[0] == CorrectColor[0] && UserChoice[1] == CorrectColor[1])
                {
                    Console.WriteLine("You Win");
                    ColorCheck = false;

                }
                
                else if (UserChoice[0] == CorrectColor[0] || UserChoice[1] == CorrectColor[1])
                {
                    Console.WriteLine("0-1");
                }

                else if(CorrectColor.Contains(UserChoice[0]) || CorrectColor.Contains(UserChoice[1]))
                {
                    if (UserChoice[0] == CorrectColor[1] && UserChoice[1] == CorrectColor[0])
                    {
                        Console.WriteLine("2-0");
                    }
                    else {
                        Console.WriteLine("1-0");
                    }
                }
                else 
                {
                    Console.WriteLine("0-0");
                }



            }

            
            //Will need a way to store the 2 random colors that are chosen
            
        }
    }
}
