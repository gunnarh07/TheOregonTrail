using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class GameMenu
    {
        public static void headerWithDate(Player player)
        {
            string dateFormat = "MMMM d yyyy";

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                 Independence");
            Console.WriteLine("                 {0}", player.date.ToString(dateFormat));
            //Console.WriteLine("                 March 1, 1848");TODO english date
            Console.WriteLine("");
        }

        public static void StatusBar(Game game)
        {
            Console.WriteLine("Weather: {}", game.weather);
            Console.WriteLine("Health: {}", game.health);
            Console.WriteLine("Pace: {}", game.steady);
            Console.WriteLine("Rations: {}", game.rations);
        }

        public static void PrintGameMenu(Game game, Player player)
        {
            headerWithDate(player);
            StatusBar(game);
            Console.WriteLine("You may:");
            Console.WriteLine("1. Continue on trail");
            Console.WriteLine("2. Check supplies");
            Console.WriteLine("3. Look at map");
            Console.WriteLine("4. Change pace");
            Console.WriteLine("5. Change food rations");
            Console.WriteLine("6. Stop to rest");
            Console.WriteLine("7. Attempt to trade");
            Console.WriteLine("8. Talk to people");
            Console.WriteLine("9. Buy supplies");
            Console.WriteLine("");
            Console.WriteLine("What is your choice?");
        }
    }
}
