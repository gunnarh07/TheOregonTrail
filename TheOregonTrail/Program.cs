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

            var input = 1;
            if (player.debug)
            {
                input = 1;
            }
            else { input = Menus.StartScreenMenu(); }         

            
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
            Console.WriteLine("Next the game begins...TODO");
            Console.ReadKey(true);
        }

    }
}