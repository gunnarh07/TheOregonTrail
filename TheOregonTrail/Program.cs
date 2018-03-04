using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Program
    {
          static void Main(string[] args)
        {
            Player player = new Player();
            Shop shop = new Shop();
            Game game = new Game();

            var input = 1;
            if (player.debug)
            {
                player.occupation = "Farmer";
                player.money = 400;
                player.name1 = "Gunni";
                player.name2 = "Liney";
                player.name3 = "Birta";
                player.name4 = "Victor";
                player.name5 = "Margret";
                string date = "01-03-1848";
                DateTime dateOfDeparture = Convert.ToDateTime(date);
                player.date = dateOfDeparture;
                player.numberOfOxs = 4;
                player.numberOfYokes = 2;
                player.poundsOfFoods = 300;
                player.setsOfClothing = 10;
                player.ammo = 100;
                player.spareParts = 3;
                player.wagonWheel = 1;
                player.wagonAxel = 1;
                player.wagonTounge = 1;

               
            }
            else
            {
                input = Menus.StartScreenMenu();
            

            
                if (input == 1)
                {
                    Menus.OccupationMenu(player, shop);    
                }

                if (input == 1 || input == 2 || input == 3)
                {
                    Menus.NameMenu(player);                
                }

                Menus.DateOfDeparture(player);

                Console.Clear();

                Store.TheStore(player, shop);
                //Gameloop
                InputDetection.Spacebar(shop);
            }

            while (game.GameIsOn)
            {
                //Console.Clear();
                //Console.WriteLine("Independence");
                //Console.WriteLine(player.date);
                //InputDetection.Spacebar(player);


                GameMenu.PrintGameMenu(game, player, shop);
            } 
        }
    }
}