using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class guessingGame
    {
        public void game()
        {
            Console.Clear();
            Random random = new Random();   

            int guesses = 1;

            bool play = true;
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                int myRandom = random.Next(1, 11);

                do
                {
                    Console.WriteLine("Guessing Game!!!!");
                    Console.Write("make a guess: ");
                    string player1 = Console.ReadLine();

                    int player = int.Parse(player1);
                    guesses++;

                    if (guesses > 6)
                    {
                        Console.WriteLine("you have exceded the number of guesses\"you LOOSE!!!!\"");
                        play = false;
                    }

                    else if (myRandom == player)
                    {
                        Console.WriteLine("you Guessed right!!!");
                        play = false;
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong");
                        play = true;
                    }
                } while (play);

                Console.Write("Do you wish to play Again?  ");
                string Answer = Console.ReadLine();
                Answer = Answer.ToUpper();

                guesses = 1;

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
