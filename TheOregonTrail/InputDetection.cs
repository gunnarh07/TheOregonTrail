using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheOregonTrail
{
    class InputDetection
    {
        public static void SpaceOrEnter()
        {
            Console.WriteLine("     Press SPACE BAR to continue");
            ConsoleKeyInfo info = Console.ReadKey();
        }

        public static void Space()
         {
            Console.WriteLine("     Press SPACE BAR to continue");
            ConsoleKeyInfo info = Console.ReadKey();
        }

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
        }

        public static void SpaceOrYes(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.WriteLine("     Press SPACE BAR to continue");
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();
            if (GameMenuInput.Key == ConsoleKey.Spacebar)
            {
                //GameMenu.ShowRiverCrossing(player);
                //GameMenu.PrintGameMenu(game, player, shop, listOfLandmarks);
            }

            if (GameMenuInput.Key == ConsoleKey.Y)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    GameMenu.ShowRiverCrossing(player);
                    GameMenu.PrintGameMenu(player, shop, listOfLandmarks);
                }
            }
        }


        public static void YesOrNo(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();


            if (GameMenuInput.Key == ConsoleKey.Y)
            {
                player.gameMenuInput = ConsoleKey.Y.ToString();
            }
            if (GameMenuInput.Key == ConsoleKey.N)
            {
                player.gameMenuInput = ConsoleKey.N.ToString();
            }
            if(GameMenuInput.Key != ConsoleKey.Y && GameMenuInput.Key != ConsoleKey.N)
            {
                player.AtLandmark = false;
                player.LeavingALandmark = false;
                GameMenu.Message(player, listOfLandmarks);
                GameMenu.Status(player);
                YesOrNo(player, shop, listOfLandmarks);
            }          
        }

        public static void DetectGameMenuInputOneOrTwo(Player player, Shop shop)
        {
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();


            if (GameMenuInput.Key == ConsoleKey.D1)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D1.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D2)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D2.ToString();
                }
            }
        }

        public static void DetectGameMenuInputOneTwoOrThree(Player player)
        {
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();


            if (GameMenuInput.Key == ConsoleKey.D1)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D1.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D2)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D2.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D3)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D3.ToString();
                }
            }
        }

        public static void DetectGameMenuInputOneTwoThreeOrFour(Player player)
        {
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();



            if (GameMenuInput.Key == ConsoleKey.D1)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D1.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D2)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D2.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D3)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D3.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D4)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D4.ToString();
                }
            }
        }

        public static void DetectGameMenuInput(Player player, Shop shop)
        {
            ConsoleKeyInfo GameMenuInput = Console.ReadKey();

            if (GameMenuInput.Key == ConsoleKey.D1)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D1.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D2)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D2.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D3)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D3.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D4)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D4.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D5)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D5.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D6)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D6.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D7)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D7.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D8)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D8.ToString();
                }
            }
            if (GameMenuInput.Key == ConsoleKey.D9)
            {
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Enter)
                {
                    player.gameMenuInput = ConsoleKey.D9.ToString();
                }
            }

        }

        public static void DetectKeyStroke(Shop shop)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Spacebar)
            {
                shop.shopInput = ConsoleKey.Spacebar.ToString();
            }
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
