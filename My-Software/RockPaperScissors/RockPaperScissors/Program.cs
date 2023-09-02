using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                int totalRounds = 0;
                int currentRound = 0;
                int ties = 0;
                int userWins = 0;
                int computerWins = 0;
                int usersChoice,
                    computersChoice;
                Random rng = new Random();

                Console.Write("Please enter the number of rounds you would like to play: ");
                totalRounds = int.Parse(Console.ReadLine());

                if (!(totalRounds <= 10 && totalRounds > 0))
                {
                    Console.WriteLine("Please enter a value between 1 and 10. Quitting...");
                }
                else
                {
                    while (currentRound < totalRounds)
                    {
                        Console.WriteLine("Round #:" + (currentRound + 1));
                        Console.WriteLine(
                            "[User's turn] - Enter choice: 1 [for Rock], 2 [for Paper], 3 [for Scissors]: "
                        );
                        usersChoice = int.Parse(Console.ReadLine());
                        if (usersChoice == 1)
                        {
                            Console.WriteLine("You chose Rock");
                        }
                        else if (usersChoice == 2)
                        {
                            Console.WriteLine("You chose Paper");
                        }
                        else if (usersChoice == 3)
                        {
                            Console.WriteLine("You chose Scissors");
                        }

                        computersChoice = rng.Next(1, 4);

                        if (computersChoice == 1)
                        {
                            Console.WriteLine("Computer chose Rock");
                        }
                        else if (computersChoice == 2)
                        {
                            Console.WriteLine("Computer chose Paper");
                        }
                        else if (computersChoice == 3)
                        {
                            Console.WriteLine("Computer chose Scissors");
                        }

                        if (!(usersChoice != computersChoice))
                        {
                            Console.WriteLine("Tie");
                            ties += 1;
                        }
                        else
                        {
                            if (
                                (usersChoice == 1 & computersChoice == 3)
                                || (usersChoice == 2 & computersChoice == 1)
                                || (usersChoice == 3 & computersChoice == 2)
                            )
                            {
                                Console.WriteLine("User Wins");
                                userWins += 1;
                                if (usersChoice == 1 & computersChoice == 3)
                                {
                                    Console.WriteLine("Rock Crushes Scissors");
                                }
                                if (usersChoice == 2 & computersChoice == 1)
                                {
                                    Console.WriteLine("Paper wraps Rock");
                                }
                                if (usersChoice == 3 & computersChoice == 2)
                                {
                                    Console.WriteLine("Scissors Cuts Paper");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Computer Wins");
                                computerWins += 1;
                                if (computersChoice == 1 & usersChoice == 3)
                                {
                                    Console.WriteLine("Rock Crushes Scissors");
                                }
                                if (computersChoice == 2 & usersChoice == 1)
                                {
                                    Console.WriteLine("Paper wraps Rock");
                                }
                                if (computersChoice == 3 & usersChoice == 2)
                                {
                                    Console.WriteLine("Scissors Cuts Paper");
                                }
                            }
                        }

                        currentRound += 1;
                    } //end while

                    if (!(userWins != computerWins))
                    {
                        Console.WriteLine("Overall Score: Tie");
                    }
                    else
                    {
                        if (userWins > computerWins)
                        {
                            Console.WriteLine("Overall Score: User Wins!");
                        }
                        else
                        {
                            Console.WriteLine("Overall Score: Computer Wins!");
                        }
                    }
                    Console.WriteLine(
                        "User wins: "
                            + userWins
                            + " - Computer wins: "
                            + computerWins
                            + " - Ties: "
                            + ties
                    );
                } // End if (totalRounds (1 to 10))

                Console.Write("Press 1 to play again or enter to quit...");
                answer = Console.ReadLine();
            } while (answer == "1");
        } //end main
    } //end class
} //end namespace
