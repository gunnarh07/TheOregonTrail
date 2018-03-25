using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class GameMenu
    {
        //public static void PlaceAt(Player player)
        //{
        //    Console.Clear();
        //    Console.WriteLine("            {0}", player.Landmark);
        //}

        public static void headerWithDate(Player player)
        {
            string dateFormat = "MMMM d yyyy";
            Console.WriteLine("            {0}      ", player.date.ToString(dateFormat));            
        }

        public static void StatusBar(Player player)
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

        public static void Message(Player player, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            if (player.AtLandmark)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                //Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                ///Console.WriteLine("     miles to the {0}", listOfLandmarks[player.IndexForLandmarks + 1].Name);
                if (player.greenRiverCrossing || player.fortWallaWalla || player.theDalles)
                {
                    if (player.greenRiverCrossing)
                    {
                        Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                        Console.WriteLine("     miles to the {0}", listOfLandmarks[8].Name);
                        //player.greenRiverCrossing = false;
                    }
                    if (player.fortWallaWalla)
                    {
                        Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                        Console.WriteLine("     miles to the {0}", listOfLandmarks[player.IndexForLandmarks + 1].Name);
                        player.fortWallaWalla = false;
                    }
                    //TODO taka burt og setja upp 'i fortwalllawalla
                    if (player.theDalles)
                    {
                        Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                        Console.WriteLine("     miles to the {0}", listOfLandmarks[player.IndexForLandmarks + 2].Name);
                        player.theDalles = false;
                    }
                    
                }
                else
                {
                    Console.WriteLine("     From {0} it is {1}", player.Landmark, player.theLeg);
                    Console.WriteLine("     miles to the {0}", listOfLandmarks[player.IndexForLandmarks + 1].Name);

                }

                player.ArrivingLanmark = false;
                
                
            }
            if(player.ArrivingLanmark)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     You are now at the {0}.", player.Landmark);
                Console.WriteLine("     Would you like to look around");
                player.AtLandmark = true;
                player.LeavingALandmark = true;
                
                
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Impassable trail. Lose 4 days.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Heavy fog. Lose 1 day.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     One of the oxen has died..");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Severe blizzard. Lose 1 day.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     {0} has a broken arm." , player.someName);
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     {0} has a broken arm.", player.someName);
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Lose trail. Lose {0} days.", player.someInt);
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Rought trail.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     inadequate grass.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Bad water.");
            }
            if (player.gameEvent)
            {
                Console.WriteLine("     Very little water.");
            }
            if (player.gameEvent)
            {
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

        public static void Alternate1(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("The trail divides here. You may:");
            Console.WriteLine("");
            Console.WriteLine("1. head for Green River crossing");
            Console.WriteLine("2. head for Fort Bridger");
            Console.WriteLine("3. see the map");
            Console.WriteLine("");
            Console.WriteLine("What is your choice?");
            InputDetection.DetectGameMenuInputOneTwoOrThree(player, shop);
            if(player.gameMenuInput == "D1")
            {
                //DoNothing
                player.alternateRoute = true;
                player.greenRiverCrossing = true;
            }
            if (player.gameMenuInput == "D2")
            {
                //index for landmarks +1
                player.greenRiverCrossing = false;
                player.fortBridger = true;
            }
            if (player.gameMenuInput == "D3")
            {
                Map(player);//TODO
            }

        }

        public static void Alternate2(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("The trail divides here. You may:");
            Console.WriteLine("");
            Console.WriteLine("1. head for Fort Walla Walla");
            Console.WriteLine("2. head for The Dalles");
            Console.WriteLine("3. see the map");
            Console.WriteLine("");
            Console.WriteLine("What is your choice?");
            InputDetection.DetectGameMenuInputOneTwoOrThree(player, shop);
            if (player.gameMenuInput == "D1")
            {
                //DoNothing
                player.alternateRoute = true;
                player.fortWallaWalla = true;
            }
            if (player.gameMenuInput == "D2")
            {
                //index for landmarks +1
                player.fortWallaWalla = false;
                player.theDalles = true;
            }
            if (player.gameMenuInput == "D3")
            {
                Map(player);//TODO
            }
        }

        public static void Alternate3(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("The trail divides here. You may:");
            Console.WriteLine("");
            Console.WriteLine("1. float down the Columbia River");
            Console.WriteLine("2. take the Barlow Toll Road");
            Console.WriteLine("");
            Console.WriteLine("What is your choice?");
            InputDetection.DetectGameMenuInputOneOrTwo(player, shop);
            if (player.gameMenuInput == "D1")
            {
                player.ColumbiaRiver = true;
            }
            if (player.gameMenuInput == "D2")
            {
                player.BarlowTollRoad = true;
            }
        }

        public static void Cycle(Player player, Shop shop, List<Landmarks> listOfLandmarks)//, Program program)
        {   
            player.AtFort = false;
            
            while (player.Traveling)
            {
                if(player.InitLeg)
                {
                    player.theLeg = listOfLandmarks[player.IndexForLandmarks].DistanceToNextLandmark;
                    player.InitLeg = false;
                }
                else
                {
                    if (player.theLeg <= 0)
                    {
                        player.IndexForLandmarks += 1;
                        var i = listOfLandmarks[player.IndexForLandmarks].DistanceToNextLandmark;
                        player.MilesToNextLandmark = i;
                        player.Landmark = listOfLandmarks[player.IndexForLandmarks].Name;
                        player.InitLeg = true;
                        player.ArrivingLanmark = true;
                        player.LegMiles = player.MilesToNextLandmark;
                        if (player.greenRiverCrossing)
                        {
                            player.IndexForLandmarks += 2;
                            //player.theLeg = listOfLandmarks[7].DistanceToNextLandmark;
                            player.Landmark = listOfLandmarks[player.IndexForLandmarks].Name;
                            player.greenRiverCrossing = false;
                        }
                    }
                    else
                    {
                        //calculates miles traveled
                        //player.pace = player.
                        //food consumed
                        player.date = player.date.AddDays(1);
                        player.poundsOfFoods -= player.teamSize * player.rations;
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
                        player.AtLandmark = false;
                    }
                }

                
                if (player.fortBridger)
                {
                    player.IndexForLandmarks += 1;
                    player.theLeg = listOfLandmarks[9].Distance;
                    player.fortBridger = false;
                }

                if (player.fortWallaWalla)
                {
                    //player.IndexForLandmarks += 1;
                    player.theLeg = listOfLandmarks[14].DistanceToNextLandmark;
                    //player.fortWallaWalla = false;
                }
                if (player.theDalles)
                {
                    player.IndexForLandmarks += 1;
                    player.theLeg = listOfLandmarks[15].DistanceToNextLandmark;
                    player.theDalles = false;
                }
                
                if (player.ShowMessage)
                {
                    Message(player, listOfLandmarks);
                }
                
                if(!player.AtLandmark)
                {
                    Console.WriteLine("  Press ENTER to size up the situation");
                }
                
                Status(player);
                if (player.LeavingALandmark)
                {
                    InputDetection.SpaceOrYes(player, shop, listOfLandmarks);
                    player.LeavingALandmark = false;
                }
                
                
                if (!player.AtLandmark)
                {

                    while (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            player.insidecycle = true;
                            PrintGameMenu(player, shop, listOfLandmarks);
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
        

        public static void RiverCrossing(Player player, Shop shop, List<Landmarks> listOfLandmarks)
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

            InputDetection.DetectGameMenuInput(player, shop);
            
            if (player.gameMenuInput == "D1")
            {
               Ford(player, shop);
            }
            if (player.gameMenuInput == "D2")
            {
                CaulkTheWagon(player, shop, listOfLandmarks);
            }
            if (player.gameMenuInput == "D3")
            {
                TakeFerry(player, shop, listOfLandmarks);
            }
            if (player.gameMenuInput == "D4")
            {
                WaitToSee(player);                
            }
            if (player.gameMenuInput == "D5")
            {
                GetMoreInfo(player, shop, listOfLandmarks);
            }
            RiverCrossing(player, shop, listOfLandmarks);
        }

        public static void Ford(Player player, Shop shop)
        {
            Console.Clear();
            Console.WriteLine("Ford");
            InputDetection.Space();
        }
        public static void CaulkTheWagon(Player player, Shop shop, List<Landmarks> listOfLandmarks)
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
            Cycle(player, shop, listOfLandmarks);
        }


        public static void TakeBarlowTollRoad(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            Console.Clear();
            Console.WriteLine("You must pay $8.00 to travel the");
            Console.WriteLine("Barlow road. Are you willing to do");
            Console.WriteLine("this?");
            string TakeTollRoad = Console.ReadLine();
            if (TakeTollRoad == "y" || TakeTollRoad == "yes")
            {
                if (player.money < 8)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    headerWithDate(player);
                    Console.WriteLine("");
                    Console.WriteLine("You do not have enough");
                    Console.WriteLine("money to pay for the Road.");
                    Console.WriteLine("");
                    InputDetection.Space();
                }
                else
                {
                    Cycle(player, shop, listOfLandmarks);
                }
            }
        }

        public static void TakeFerry(Player player, Shop shop, List<Landmarks> listOfLandmarks)
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
                    Cycle(player, shop, listOfLandmarks);
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
        public static void GetMoreInfo(Player player, Shop shop, List<Landmarks> listOfLandmarks)
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
            RiverCrossing(player, shop, listOfLandmarks);
        }

        public static void PrintGameMenu(Player player, Shop shop, List<Landmarks> listOfLandmarks)
        {
            while (player.GameMenu)
            {
                Console.Clear();
                //if(player.AtLandmark)
                //{
                //    PlaceAt(player);
                //}
                Console.WriteLine("          {0}", listOfLandmarks[player.IndexForLandmarks].Name);

                headerWithDate(player);
                StatusBar(player);
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

                InputDetection.DetectGameMenuInput(player, shop);
                if (player.gameMenuInput == "D1" && player.insidecycle == true)
                {
                    break;
                }
                if (player.gameMenuInput == "D1")
                {
                    if(player.Landmark == "Independence")
                    {
                        Cycle(player, shop, listOfLandmarks);
                    }
                    if(player.Landmark == "Kansas River crossing")
                    {
                        RiverCrossing(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Big Blue River crossing")
                    {
                        RiverCrossing(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Kearney")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Chimney Rock")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Laramie")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Indipendence Rock")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "South Pass")
                    {
                        Alternate1(player, shop, listOfLandmarks);
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Green River")
                    {
                        RiverCrossing(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Bridger")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Soda Springs")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Hall")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Snake River")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort Boise")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Blue Mountains")
                    {
                        Alternate2(player, shop, listOfLandmarks);
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Fort WALLA WALLA")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "The Dalles")
                    {
                        Alternate3(player, shop, listOfLandmarks);
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Columbia River George")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Barlow Road")
                    {
                        
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }
                    if (player.Landmark == "Willameete Valley Oregon")
                    {
                        Cycle(player, shop, listOfLandmarks);
                        break;
                    }

                }
                if (player.gameMenuInput == "D2")
                {
                    CheckSupplies(player);
                }
                if (player.gameMenuInput == "D3")
                {
                    Map(player);
                }
                if (player.gameMenuInput == "D4")
                {
                    ChangePace(player);
                }
                if (player.gameMenuInput == "D5")
                {
                    ChangeFoodRations(player);
                }
                if (player.gameMenuInput == "D6")
                {
                    StopToRest(player);
                }
                if (player.gameMenuInput == "D7")
                {
                    AttemptToTrade(player);
                }
                if (player.gameMenuInput == "D8")
                {
                    TalkToPeople(player);
                }
                if (player.gameMenuInput == "D9")
                {
                    BuySupplies(player, shop);
                }
            }            
        }
    }
}
