using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string playerTurn2 = "O";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
            board[row][column] = playerTurn;
            switchTurn();
        }
        public static void switchTurn()
        {
            if (playerTurn == "X")
            {
                playerTurn = playerTurn2;
            }
            else
            {
                playerTurn = "X";
            }

        }
        public static bool CheckForWin()
        {
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                switchTurn();
                Console.WriteLine(playerTurn + " Won!");
                return true;
            }


            return false;
        }

        public static bool CheckForTie()
        {
            int markCount = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board[x][y] != " ")
                    {
                        markCount++;
                    }
                }
            }
            if (markCount == 9 && !CheckForWin())
            {
                return true;
            }


            return false;
        }

        public static bool HorizontalWin()
        {
            for (int x = 0; x < 3; x++)
            {
                if (board[x][0] == board[x][1] && board[x][0] == board[x][2] && (board[x][0] != " "))
                {
                    return true;
                }

            }

            return false;
        }

        public static bool VerticalWin()
        {
            for (int x = 0; x < 3; x++)
            {
                if (board[0][x] == board[1][x] && board[0][x] == board[2][x] && (board[0][x] != " "))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            {
                if ((board[0][0] == board[1][1] && board[2][2] == board[0][0] && (board[0][0] != " ")) ||
                    board[2][0] == board[1][1] && board[0][2] == board[2][0] && (board[2][0] != " ")
                    )
                {
                    return true;
                }
            }
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }


    }
}
