using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class RPS
    {
        public void play()
        {
            Console.Clear();
            string computer = "";

            Random random = new Random();

            bool playAgain = true;
            
            while (playAgain)
            {
                Console.Clear();
                Console.WriteLine("ROCK PAPER SCISSORS GAME!!!");
                Console.WriteLine("choose either of\n1:ROCK\n2:PAPER\n3:SCISSORS");
                string player = Console.ReadLine();

                int myRandom = random.Next(1, 4);

                switch (myRandom)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                    default:
                        computer = "NUL";
                        break;
                }

                player = player.ToUpper();

                if (player == "ROCK")
                {
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("computer choose ROCK\nA TIE!!");
                        ;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("computer choose PAPER\nYOU LOOSE!!");
                    }
                    else
                    {
                        Console.WriteLine("computer choose SCISSORS\nYOU WIN!!!");
                    }
                }
                else if (player == "PAPER")
                {
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("computer choose ROCK\nYOU WIN!!!");
                        ;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("computer choose PAPER\nA TIE!!");
                    }
                    else
                    {
                        Console.WriteLine("computer choose SCISSORS\nYOU LOOSE!!");
                    }
                }
                else if (player == "SCISSORS")
                {
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("computer choose ROCK\nYOU LOOSE!!");
                        ;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("computer choose PAPER\nYOU WIN!!!");
                    }
                    else
                    {
                        Console.WriteLine("computer choose SCISSORS\nA TIE!!");
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }

                Console.Write("Do you wish to play Again?  ");
                string Answer = Console.ReadLine();
                Answer = Answer.ToUpper();

                //guesses = 1;

                if (Answer == "YES" || Answer == "Y")
                {

                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

        }
    }
}
