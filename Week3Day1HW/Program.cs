using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day1HW
{
    class Program
    {
        static void Main(string[] args)
        {
            GameIdeas gameIdeas = new GameIdeas();
            try
            {
                gameIdeas.GameChoices();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Thank you, I hope these ideas were good");
            }
        }


    }

    class GameIdeas
    {
        public void GameChoices()
        {
            int choice = GetUserInput();

            try
            {

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("This is the first game:");
                            Console.WriteLine("This game is a 2 player shooter Vs game.");
                            Console.WriteLine("You get upgrades and weapons as you play,");
                            Console.WriteLine("And once a player wins, the game is over");
                            Console.ReadLine();

                            break;
                        }

                    case 2:
                        Console.WriteLine("The second game, This game is a matching game");
                        Console.WriteLine("where the items on the cards will match a card that the player, and they'll need to find it.");
                        Console.WriteLine("And I could introduce a counter to speed up the process (like a timer that counts down");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("This one could be a simple Naughts and Crosses game");
                        Console.WriteLine("Since we only have a week and I have no idea how far my skills");
                        Console.WriteLine("Will take me or how hard the work will be");
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("If all fails, I'd go with a text-based console game");
                        Console.WriteLine("It wouls just be there to show my basic capabilities");
                        Console.WriteLine("But I could try to save it with satire or a special feature");
                        Console.ReadLine();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thats my game ideas");
            }
            }


        public int GetUserInput()
        {
            return Console.Read();
        }
    }
}
