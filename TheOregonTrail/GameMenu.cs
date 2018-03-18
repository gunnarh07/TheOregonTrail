using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class GameMenu
    {
        public static void PlaceAt(Player player)
        {
            Console.Clear();
            Console.WriteLine("            {0}", player.Landmark);
        }

        public static void headerWithDate(Player player)
        {
            string dateFormat = "MMMM d yyyy";
            Console.WriteLine("            {0}      ", player.date.ToString(dateFormat));            
        }

        public static void StatusBar(Game game, Player player)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   Weather: {0}              ", player.weather);
            Console.WriteLine("   Health:  {0}              ", player.health);
            Console.WriteLine("   Pace: {0}               ", player.steady);
            Console.WriteLine("   Rations: {0}           ", player.getRation(player));
            Console.ResetColor();
        }

        public static void ViewKansasRiver(Player player)
        {
            Console.WriteLine("     {0}", player.Landmark);
            headerWithDate(player);
        }

        public static void Message(Player player)
        {
            if(player.AtLandmark)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                Console.WriteLine("     miles to the {0}", player.NextLandmark);
                player.ArrivingLanmark = false;
                
                
            }
            if(player.ArrivingLanmark)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     You are now at the {0}.", player.NextLandmark);
                Console.WriteLine("     Would you like to look around");
                player.AtLandmark = true;
                player.LeavingALandmark = true;
                
                
            }
            if (player.gameEvent)
            {
                Console.WriteLine("");
                Console.WriteLine("     Severe blizzard. Lose 1 day.");
                Console.WriteLine("");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("");
                Console.WriteLine("     {0} has a broken arm." , player.someName);
                Console.WriteLine("");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("");
                Console.WriteLine("     {0} has a broken arm.", player.someName);
                Console.WriteLine("");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("");
                Console.WriteLine("     Lose trail. Lose {0} days.", player.someInt);
                Console.WriteLine("");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("");
                Console.WriteLine("     Broken wagon wheel. Would you like");
                Console.WriteLine("     to try to repair it?");
                //Todo yes or no
                //if able
                Console.WriteLine("     You where able to repair the wagon wheel.");
                //if not able have to change it
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }          
        }

        public static void NoMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void GetNextLandmark()
        {
            Console.WriteLine("");
        }

        public static void CalculateMilesOfLeg(Game game, Player player)
        {
            var TempNextLandmark = player.theLeg;
            var tempMiles = TempNextLandmark - player.pace;
            if (tempMiles <= 0)
            {
                player.MilesTraveled += player.theLeg;
                player.theLeg = 0;
                
            }
            else
            {
                player.theLeg = player.theLeg - player.pace;
                player.MilesTraveled += player.pace;
                
            }            
        }
       
        public static void Status(Player player)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            headerWithDate(player);
            Console.WriteLine("           Weather: {0}     ", player.weather);
            Console.WriteLine("            Health: {0}     ", player.health);
            Console.WriteLine("              Food: {0}      ", player.poundsOfFoods);
            Console.WriteLine("     Next Landmark: {0}      ", player.theLeg);
            Console.WriteLine("    Miles Traveled: {0}        ", player.MilesTraveled);
            Console.ResetColor();
        }

        public static void Alternate(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("The trail divides here. You may:");
            Console.WriteLine("");
            Console.WriteLine("1. head for Green River crossing");
            Console.WriteLine("2. head for Fort Bridger");
            Console.WriteLine("3. see the map");
            Console.WriteLine("");
            Console.WriteLine("What is your choice?");
            InputDetection.DetectGameMenuInputOneTwoOrThree(game, player, shop);
            if(game.gameMenuInput == "D1")
            {
                //DoNothing
                player.alternateRoute = true;
            }
            if (game.gameMenuInput == "D2")
            {
                //index for landmarks +1
                player.IndexForLandmarks += 1;
                
            }
            if (game.gameMenuInput == "D3")
            {
                Map(player);//TODO
            }

        }

    public static void Cycle(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)//, Program program)
        {
            //List<Landmarks> TempLandmarks = new List<Landmarks>;
            //TempLandmarks = 
            if(player.alternateRoute)
            {
                player.IndexForLandmarks += 1;
                player.alternateRoute = false;
            }
            List<int> TempMiles = game.GetMiles(player);
            List<string> TempLegs = game.GetLegs(player);
            player.MilesToNextLandmark = TempMiles[player.IndexForLandmarks];
            player.Landmark = TempLegs[player.IndexForLandmarks];
            player.NextLandmark = TempLegs[player.IndexForLandmarks + 1];

            player.AtFort = false;
            
            while (player.Traveling)
            {
                if(player.InitLeg)
                {
                    player.theLeg = TempMiles[player.IndexForLandmarks];
                    player.InitLeg = false;
                }
                Console.Clear();
                if (player.ShowMessage)
                {
                    Message(player);
                    //player.ShowMessage = false;
                }
                if(!player.AtLandmark)
                {
                    Console.WriteLine("  Press ENTER to size up the situation");
                }
                
                Status(player);
                if (player.LeavingALandmark)
                {
                    InputDetection.SpaceOrYes(game, player, shop, listOfLandmarks);
                    player.LeavingALandmark = false;
                }
                if (player.theLeg <= 0)
                {
                    player.IndexForLandmarks += 1;
                    var i = TempMiles[player.IndexForLandmarks];
                    player.MilesToNextLandmark = i;
                    player.Landmark = TempLegs[player.IndexForLandmarks];
                    player.InitLeg = true;
                    player.ArrivingLanmark = true;
                    player.LegMiles = player.MilesToNextLandmark;
                }
                
                else
                {
                    //calculates miles traveled
                    //player.pace = player.
                    //food consumed
                    player.date = player.date.AddDays(1);
                    player.poundsOfFoods -= player.teamSize * player.rations;
                    CalculateMilesOfLeg(game, player);
                    player.AtLandmark = false;

                }
                
                if (!player.AtLandmark)
                {

                    while (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            player.insidecycle = true;
                            PrintGameMenu(game, player, shop, listOfLandmarks);
                        }
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
            player.insidecycle = false;
        }

        public static void ShowRiverCrossing(Player player)
        {
            Console.Clear();
            Console.WriteLine("Beautiful Picture of {0}", player.Landmark);
            Console.WriteLine("         {0}", player.Landmark);
            headerWithDate(player);
            InputDetection.Space();
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
        

        public static void RiverCrossing(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            if (player.Landmark.EndsWith("crossing"));
            {
                Console.Clear();
                Console.WriteLine("{0}", player.Landmark);
                headerWithDate(player);
                Console.WriteLine("");
                Console.WriteLine("You must cross the river in");
                Console.WriteLine("order to continue. The");
                Console.WriteLine("river at this point is ");
                Console.WriteLine("currently {0} feet across,", player.riverWidth);
                Console.WriteLine("and {0} feet deep in the", player.riverDepth);
                Console.WriteLine("middle");
                Console.WriteLine("");
                InputDetection.Space();
                player.krc = true;
            }
            

            Console.Clear();
            Console.WriteLine("{0}", player.Landmark);
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("Weather: {0}     ", player.weather);
            Console.WriteLine("River width: {0}     ", player.riverWidth);
            Console.WriteLine("River depth: {0}     ", player.riverDepth);
            Console.WriteLine("");
            Console.WriteLine("You may:");
            Console.WriteLine("");
            Console.WriteLine("1. attempt to ford the river.");
            Console.WriteLine("2. caulk the wagon and float it accross");
            if(listOfLandmarks[player.IndexForLandmarks].Ferry)
            {
                Console.WriteLine("3. take a ferry across");
                Console.WriteLine("4. wait to see if condition improve");
                Console.WriteLine("5. get more information");
            }
            else
            {
                Console.WriteLine("3. wait to see if condition improve");
                Console.WriteLine("4. get more information");
            }

            Console.WriteLine("");
            Console.WriteLine("What is your choice?");

            InputDetection.DetectGameMenuInput(game, player, shop);
            
            if (game.gameMenuInput == "D1")
            {
               Ford(game, player, shop);
            }
            if (game.gameMenuInput == "D2")
            {
                CaulkTheWagon(game, player, shop, listOfLandmarks);
            }
            if (game.gameMenuInput == "D3")
            {
                TakeFerry(game, player, shop, listOfLandmarks);
            }
            if (game.gameMenuInput == "D4")
            {
                WaitToSee(player);                
            }
            if (game.gameMenuInput == "D5")
            {
                GetMoreInfo(game, player, shop, listOfLandmarks);
            }
            RiverCrossing(game, player, shop, listOfLandmarks);
        }

        public static void Ford(Game game, Player player, Shop shop)
        {
            Console.Clear();
            Console.WriteLine("Ford");
            InputDetection.Space();
        }
        public static void CaulkTheWagon(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("Caulk the wagon!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("You had no trouble");
            Console.WriteLine("floating the wagon");
            Console.WriteLine("across.");
            InputDetection.Space();
            player.LeavingALandmark = true;
            player.InitLeg = true;
            Cycle(game, player, shop, listOfLandmarks);
        }
        public static void TakeFerry(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("Kansas River crossing");
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("The ferry operator says that");
            Console.WriteLine("he will charge you $5.00 and");
            Console.WriteLine("that you will have to wait 2");
            Console.WriteLine("days. Are you willing to do ");
            Console.WriteLine("this?");
            string takeFerry = Console.ReadLine();
            if (takeFerry == "y" || takeFerry == "yes")
            {
                if(player.money < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Kansas River crossing");
                    headerWithDate(player);
                    Console.WriteLine("");
                    Console.WriteLine("You do not have enough");
                    Console.WriteLine("money to pay for the ferry.");
                    Console.WriteLine("");
                    InputDetection.Space();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Taking the ferry!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("The Ferry got your party");
                    Console.WriteLine("and wagon safely across.");
                    InputDetection.Space();
                    player.LeavingALandmark = true;
                    player.InitLeg = true;
                    Cycle(game, player, shop, listOfLandmarks);
                }                
            }
        }
        public static void WaitToSee(Player player)
        {
            Console.Clear();
            Console.WriteLine("{0}", player.Landmark);
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("You camp near the river for a day.");
            Console.WriteLine("");
            InputDetection.Space();
            player.date = player.date.AddDays(1);

        }
        public static void GetMoreInfo(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("{0}", player.Landmark);
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("To ford a river means to");
            Console.WriteLine("pull your wagon across a");
            Console.WriteLine("shallow part of the river,");
            Console.WriteLine("with the oxen still");
            Console.WriteLine("attached");
            Console.WriteLine("");
            InputDetection.Space();

            Console.Clear();
            Console.WriteLine("{0}", player.Landmark);
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("To caulk the wagon means to");
            Console.WriteLine("seal it so that no water can");
            Console.WriteLine("get in. The wagon can then");
            Console.WriteLine("be floated across like a");
            Console.WriteLine("boat");
            Console.WriteLine("");
            InputDetection.Space();

            Console.Clear();
            Console.WriteLine("{0}", player.Landmark);
            headerWithDate(player);
            Console.WriteLine("");
            Console.WriteLine("To use ferry means to put");
            Console.WriteLine("your wagon on top of a flat");
            Console.WriteLine("boat that belongs to someone");
            Console.WriteLine("else. The owner of the");
            Console.WriteLine("ferry will take your wagon");
            Console.WriteLine("across the river");
            Console.WriteLine("");
            InputDetection.Space();
            RiverCrossing(game, player, shop, listOfLandmarks);
        }

        public static void PrintGameMenu(Game game, Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            while (game.GameMenu)
            {
                Console.Clear();
                if(player.AtLandmark)
                {
                    PlaceAt(player);
                }
                
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
                if(listOfLandmarks[player.IndexForLandmarks].Shop)
                {
                    Console.WriteLine("     9. Buy supplies");
                }
                
                Console.WriteLine("");
                Console.WriteLine("What is your choice?");

                InputDetection.DetectGameMenuInput(game, player, shop);
                if (game.gameMenuInput == "D1" && player.insidecycle == true)
                {
                    break;
                }
                if (game.gameMenuInput == "D1")
                {
                    if(player.Landmark == "Independence")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                    }
                    if(player.Landmark == "Kansas River crossing")
                    {
                        RiverCrossing(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Big Blue River crossing")
                    {
                        RiverCrossing(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Kearney")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Chimney Rock")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Laramie")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Indipendence Rock")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "South Pass")
                    {
                        Alternate(game, player, shop, listOfLandmarks);
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Green river")
                    {
                        RiverCrossing(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Bridger")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Soda Springs")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Hall")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Snake River")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Boise")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Blue Mountains")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort WALLA WALLA")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "The Dalles")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Columbia River George")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Barlow Road")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Willameete Valley Oregon")
                    {
                        Cycle(game, player, shop, listOfLandmarks);
                        break;
                    }

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
