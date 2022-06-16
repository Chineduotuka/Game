using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Menu
    {
        guessingGame guessingGame = new guessingGame();

        RPS RPS = new RPS();
        public bool actualMenu()
        {
            Console.Clear();
            Console.WriteLine("choose the game you want to play from the options");

            Console.WriteLine("1: Guessing game\n2: Rock Paper Scissor\n3: EXit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                guessingGame.game();
                return true;
            }
            else if (input == "2")
            {
                RPS.play();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
