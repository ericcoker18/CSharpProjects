using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Choices = { "rock", "paper", "scissors" };
            Console.WriteLine("Pick Rock, Paper, or Scissors");
            string Pick = Console.ReadLine().ToLower();
            Random CPU = new Random();
            int RandomNumb = CPU.Next(0, 3);
            string cpu = Choices[RandomNumb];
            
            if (Pick == cpu)
            {
                Console.WriteLine("Tie");
            }

            else if (Pick == "rock")
            {
                if (cpu == "paper")
                {
                    Console.WriteLine("Cpu Wins!");
                }
                else if (cpu == "scissors")
                {
                    Console.WriteLine("Player wins!");
                }
            }
            else if (Pick == "paper")
            {
               if (cpu == "rock")
                {
                    Console.WriteLine("Player wins!");
                }
               else if (cpu == "scissors")
                {
                    Console.WriteLine("Cpu Wins!");
                }
                    
            }   
            else if (Pick == "scissors")
            {
                if (cpu == "rock")
                {
                    Console.WriteLine("Cpu Wins!");
                }
                else if (cpu == "paper")
                {
                    Console.WriteLine("Player Wins!");
                }
                


                 
            }
            else { Console.WriteLine("You did this wrong"); }
            


          
        }
    }
}
