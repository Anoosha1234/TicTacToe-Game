using System;
using System.Threading;

namespace C__Game
{

    class Program

    {

        //making array

        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int playerInstance = 1; 

        static string player1, player2;

        static int userInput;  
        static int flag = 0;

 

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Pick a number to select a space. Type 0 to quit. ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            Console.Write("Player 1 name: ");
            player1 = Console.ReadLine();

            Console.Write("Player 2 name: ");
            player2 = Console.ReadLine();

            do
            {

                Console.Clear(); 
                Console.WriteLine("{0} is X and {1} is O!", player1, player2);
                Console.WriteLine("\n");
                if (playerInstance % 2 == 0)
                {
                    Console.WriteLine("{0}'s turn", player2);
                }
                else
                {
                    Console.WriteLine("{0}'s turn", player1);
                }

                Console.WriteLine("\n");

                TictactoeBoard();

                userInput = int.Parse(Console.ReadLine());  

                if (userInput == 0)
                {
                Environment.Exit(0);
                }  

                if (array[userInput] != 'X' && array[userInput] != 'O')
                {
                    if (playerInstance % 2 == 0) 
                    {
                        array[userInput] = 'O';
                        playerInstance++;
                    }
                    else
                    {
                        array[userInput] = 'X';
                        playerInstance++;
                    }
                }
                else 
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", userInput, array[userInput]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please choose a different option...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin(); 
            } while (flag != 1 && flag != -1);

            Console.Clear();
            TictactoeBoard(); //display board

            if (flag == 1 && ((playerInstance % 2) + 1 == 1))
            {
                Console.WriteLine("{0} wins!", player1);
            }
            else if (flag == 1 && ((playerInstance % 2) + 1 != 1))
            {
                Console.WriteLine("{0} wins!", player2);
            }
            else  
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        private static void TictactoeBoard()

        {
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", array[1], array[2], array[3]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", array[4], array[5], array[6]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", array[7], array[8], array[9]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
        }

        private static int CheckWin()
        {
            // horizontal row checking

            if (array[1] == array[2] && array[2] == array[3])
            {
                return 1;
            }
            else if (array[4] == array[5] && array[5] == array[6])
            {
                return 1;
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                return 1;
            }


            // vertical row checking
    
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }


            // diagonal row checking

            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }

            // draw condition checking

            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

    }

}
