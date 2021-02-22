using System;
using System.Collections.Generic;
using System.Linq;

namespace Towers_Of_Hanoi
{
    class Program
    {
        static Dictionary<String, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {

            intboard();

            while (board["C"].Count != 4)
            {
                printboard();
                gamemove();
            }

        }

        static void intboard()
        {


            board.Add("A", new Stack<int>());
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());

            board["A"].Push(4);
            board["A"].Push(3);
            board["A"].Push(2);
            board["A"].Push(1);
        }

        static void printboard() {

            foreach (string key in board.Keys)
            {
                Console.Write($"{key}:");
                PrintStack(board[key]);
                Console.WriteLine();
            }

        }

        private static void PrintStack(Stack<int> stacks)
        {
            int[] arrTower = stacks.ToArray();
            for (int i = arrTower.Length - 1; i >= 0; i--)
            {
                Console.Write(arrTower[i] + " ");
            }
        }
        static void gamemove() {

            Console.WriteLine("Which tower do you want to move from?");
            string FromStack = Console.ReadLine().ToUpper();
            Console.WriteLine("Which tower do you want to move too?");
            string ToStack = Console.ReadLine().ToUpper();

            if (MoveLegal(FromStack, ToStack)) {
                board[ToStack].Push(board[FromStack].Peek());
                board[FromStack].Pop();
            }
}

        private static bool MoveLegal(string fromStack, string toStack)
        {
            string[] stacks = { "A", "B", "C" };
            if (stacks.Contains(fromStack) && stacks.Contains(toStack))
            {

                if (board[fromStack].Count != 0 && (board[toStack].Count == 0 || board[fromStack].Peek() < board[toStack].Peek()))
                {

                    return true;

                }
            }
                Console.WriteLine("You have made an invalid move please try again");

                return false;
            
        }
        
    }
}
