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
            Console.WriteLine("");
        }

        public static void StatusBar(Game game, Player player)
        {
            Console.WriteLine("   Weather: {0}", player.weather);
            Console.WriteLine("   Health: {0}", player.health);
            Console.WriteLine("   Pace: {0}", player.steady);
            Console.WriteLine("   Rations: {0}", player.getRation(player));
        }

        public static void Message()
        {
            Console.WriteLine("        Message");
        }

        public static void CalculateMilesOfLeg(Game game, Player player)
        {
            player.NextLandmark = player.NextLandmark - player.pace;
            
            player.MilesTraveled += player.pace;
        }

        public static void Cycle(Game game, Player player)
        {
            game.GetMiles(player);
            game.GetLegs(player);

            while(player.Cycle)
            {
                
                Console.Clear();
                Message();
                Console.WriteLine(player.date);
                Console.WriteLine("           Weather: {0}", player.weather);
                Console.WriteLine("            Health: {0}", player.health);
                Console.WriteLine("              Food: {0}", player.poundsOfFoods);
                Console.WriteLine("     Next Landmark: {0}", player.NextLandmark);
                Console.WriteLine("    Miles Traveled: {0}", player.MilesTraveled);
                //Calculates all things over a day
                //ads a day
                player.date = player.date.AddDays(1);
                //calculates miles traveled
                //player.pace = player.
                //food consumed
                player.poundsOfFoods -= player.teamSize * player.rations;
                //
                CalculateMilesOfLeg(game, player);
                System.Threading.Thread.Sleep(3000);
            }

        }

        public static void Supplies(Player player)
        {
            Console.Clear();
            Console.WriteLine("             Your Supplies");
            Console.WriteLine("");
            Console.WriteLine("          oxen                   {0}", player.numberOfOxs);
            Console.WriteLine("          sets of clothing       {0}", player.setsOfClothing);
            Console.WriteLine("          bullets                {0}", player.ammo);
            Console.WriteLine("          wagon wheels           {0}", player.wagonWheel);
            Console.WriteLine("          wagon axles            {0}", player.wagonAxel);
            Console.WriteLine("          wagon tongue           {0}", player.wagonTounge);
            Console.WriteLine("          pounds of food         {0}", player.poundsOfFoods);
        }

        public static void CheckSupplies(Player player)
        {
            Supplies(player);
            Console.WriteLine("          money left             ${0}", player.money);
            Console.WriteLine("");
            InputDetection.Space();
        }

        public static void Map(Player player)
        {
            Console.Clear();
            Console.WriteLine("             Map of the");
            Console.WriteLine("            Oregon Trail");
            Console.WriteLine("");
            InputDetection.Space();
        }

        public static void ChangePace(Player player)
        {
            Console.Clear();
            Console.WriteLine("             Change pace");
            Console.WriteLine("            (currently {0})", player.pace);
            Console.WriteLine("");
            Console.WriteLine("     The pace at which you travel");
            Console.WriteLine("     can change. Your choices are:");
            Console.WriteLine("      1. a steady pace");
            Console.WriteLine("      2. a strenous pace");
            Console.WriteLine("      3. a grueling pace");
            Console.WriteLine("      4. find out what these");
            Console.WriteLine("         different paces mean");
            Console.WriteLine("");
            Console.WriteLine("     what is your choice?");
        }

        public static void ChangeFoodRations(Player player)
        {

        }

        public static void StopToRest(Player player)
        {
            Console.Clear();
            Console.WriteLine("     How many days would you");
            Console.WriteLine("     like to rest*");
            int daysToRest = int.Parse(Console.ReadLine());
            player.date = player.date.AddDays(daysToRest);
        }

        public static void AttemptToTrade(Player player)
        {
            //example of trade
            Supplies(player);
            Console.WriteLine("");
            Console.WriteLine("You meet another emigrant who");
            Console.WriteLine("wants 1 wagon axle. He will trade");
            Console.WriteLine(" you 1 wagon");
            Console.WriteLine("");
            Console.WriteLine("Are you Willing to trade?");
            string toTrade = Console.ReadLine();
            if (toTrade == "y" || toTrade == "yes")
            {
                player.wagonAxel -= 1;
                player.wagonTounge += 1;
            }

        }

        public static void TalkToPeople(Player player)
        {
            Console.WriteLine("A trader named Jim tells you:");
            Console.WriteLine("");
            Console.WriteLine("Better take extra set of");
            Console.WriteLine("clothing. Trade'em to Indians");
            Console.WriteLine("for fresh vegetables, fish, or");
            Console.WriteLine("meat. It's well worth hiring");
            Console.WriteLine("an Indian guide at river");
            Console.WriteLine("crossings. Expect to pay them!");
            Console.WriteLine("They're sharp traders, not");
            Console.WriteLine("easily cheated.");
            Console.WriteLine("");
            Console.WriteLine("");

            InputDetection.Space();
        }

        public static void BuySupplies(Player player, Shop shop)
        {
            Console.Clear();
            headerWithDate(player);
            
            Console.WriteLine("   1. Oxen            {0} per ox ", shop.oxPrice);
            Console.WriteLine("   2. Clothing        {0} per set", shop.clothingPrice);
            Console.WriteLine("   3. Ammuntition     {0} per box", shop.ammunitionPrice);
            Console.WriteLine("   4. Wagon wheels    {0} per wheel", shop.wheelsPrice);
            Console.WriteLine("   5. Wagon Axles     {0} per wheel", shop.axlesPrice);
            Console.WriteLine("   6. Wagon tongues   {0} per tongues", shop.tonguesPrice);
            Console.WriteLine("   7. Food            {0} per pound", shop.foodPrice);
            Console.WriteLine("   8. Leave Store");
            Console.WriteLine("");
            Console.WriteLine("You have ${0} to spend.", player.money);
            Console.WriteLine("Which number?");
        }

        public static void PrintGameMenu(Game game, Player player, Shop shop)
        {
            while(game.GameMenu)
            {
                headerWithDate(player);
                StatusBar(game, player);
                Console.WriteLine("You may:");
                Console.WriteLine("     1. Continue on trail");
                Console.WriteLine("     2. Check supplies");
                Console.WriteLine("     3. Look at map");
                Console.WriteLine("     4. Change pace");
                Console.WriteLine("     5. Change food rations");
                Console.WriteLine("     6. Stop to rest");
                Console.WriteLine("     7. Attempt to trade");
                Console.WriteLine("     8. Talk to people");
                Console.WriteLine("     9. Buy supplies");
                Console.WriteLine("");
                Console.WriteLine("What is your choice?");

                InputDetection.DetectGameMenuInput(game, player, shop);
                if (game.gameMenuInput == "D1")
                {
                    Cycle(game, player);
                }
                if (game.gameMenuInput == "D2")
                {
                    CheckSupplies(player);
                }
                if (game.gameMenuInput == "D3")
                {
                    Map(player);
                }
                if (game.gameMenuInput == "D4")
                {
                    ChangePace(player);
                }
                if (game.gameMenuInput == "D5")
                {
                    ChangeFoodRations(player);
                }
                if (game.gameMenuInput == "D6")
                {
                    StopToRest(player);
                }
                if (game.gameMenuInput == "D7")
                {
                    AttemptToTrade(player);
                }
                if (game.gameMenuInput == "D8")
                {
                    TalkToPeople(player);
                }
                if (game.gameMenuInput == "D9")
                {
                    BuySupplies(player, shop);
                }
            }            
        }
    }
}
