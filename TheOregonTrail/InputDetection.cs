using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class InputDetection
    {
        public static void Spacebar(Shop shop)
        {
            Console.WriteLine("     Press SPACE BAR to continue");
            ConsoleKeyInfo info = Console.ReadKey();
            shop.shopInput = "";
            
        }

        public static void Spacebar(Player player)
        {
            Console.WriteLine("     Press SPACE BAR to continue");
            ConsoleKeyInfo info = Console.ReadKey();
            player.playerInput = "";
            //shop.shopInput = "";

        }
        public static void DetectKeyStroke(Shop shop)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Spacebar)
            {
                shop.shopInput = ConsoleKey.Spacebar.ToString();
            }
            //if(info.Key != ConsoleKey.Spacebar)
            //{
            //    var returning = DetectKeyStroke();
            //}
            if (info.Key == ConsoleKey.D1)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    shop.shopInput = ConsoleKey.D1.ToString();
                }

            }
            if (info.Key == ConsoleKey.D2)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    shop.shopInput = ConsoleKey.D2.ToString();
                }
            }
            if (info.Key == ConsoleKey.D3)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    shop.shopInput = ConsoleKey.D3.ToString();
                }
            }
            if (info.Key == ConsoleKey.D4)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    shop.shopInput = ConsoleKey.D4.ToString();
                }
            }
            if (info.Key == ConsoleKey.D5)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    shop.shopInput = ConsoleKey.D5.ToString();
                }
            }
        }
    }
}
