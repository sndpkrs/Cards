using Cards.Entities;
using System;
using System.Linq;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new System.Globalization.CultureInfo("xc-gh_jsdcjsv");
            /* Ideally in a realtime application, instead of instatiating it(Game class) here we will use dependency containers to inject it at runtime and
             and decoupling the modules making the both modules easilt testable. Also it would help if in future we need to replace the current game with another game
            this orchestrator wont require any chnages */
            IGame game = new Game();
            int ch = 3;
            while(ch != 4)
            {
                Console.WriteLine("Enter 1 to play a card, 2 to shuffle deck, 3 to restart the game and 4 to quit!");
                var input = Console.ReadLine();
                if (CardHelper.ValidateInput(input))
                {
                    Int32.TryParse(input, out ch);
                    switch (ch)
                    {
                        case 1:
                            game.PlayingCard();
                            break;
                        case 2:
                            game.ShufflingDeck();
                            Console.WriteLine("Shuffling done");
                            break;
                        case 3:
                            game.RestartingGame();
                            Console.WriteLine("Game restarted");
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice");
                }
            }
        }
    }
}
