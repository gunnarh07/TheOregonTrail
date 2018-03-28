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
            //INIT
            Player player = new Player();
            Shop shop = new Shop();
            Game game = new Game();
            //init each lanmarks
            Landmarks L1 = new Landmarks();
            L1.Name = "Independence";
            L1.Shop = true;
            L1.Ferry = true;
            L1.Distance = 0;
            L1.DistanceToNextLandmark = 102;

            Landmarks L2 = new Landmarks();
            L2.Name = "Kansas River crossing";
            L2.Shop = false;
            L2.Ferry = true;
            L2.Distance = 102;
            L2.DistanceToNextLandmark = 82;

            Landmarks L3 = new Landmarks();
            L3.Name = "Big Blue River crossing";
            L3.Shop = false;
            L3.Ferry = false;
            L3.Distance = 82;
            L3.DistanceToNextLandmark = 118;

            Landmarks L4 = new Landmarks();
            L4.Name = "Fort Kearney";
            L4.Shop = true;
            L4.Ferry = false;
            L4.Distance = 118;
            L4.DistanceToNextLandmark = 250;

            Landmarks L5 = new Landmarks();
            L5.Name = "Chimney Rock";
            L5.Shop = false;
            L5.Ferry = false;
            L5.Distance = 250;
            L5.DistanceToNextLandmark = 86;

            Landmarks L6 = new Landmarks();
            L6.Name = "Fort Laramie";
            L6.Shop = true;
            L6.Ferry = false;
            L6.Distance = 86;
            L6.DistanceToNextLandmark = 190;

            Landmarks L7 = new Landmarks();
            L7.Name = "Indipendence Rock";
            L7.Shop = false;
            L7.Ferry = false;
            L7.Distance = 190;
            L7.DistanceToNextLandmark = 102;
        
            Landmarks L8 = new Landmarks();
            L8.Name = "South Pass";
            L8.Shop = false;
            L8.Ferry = false;
            L8.Distance = 102;
            L8.Alternate = true;
            L8.DistanceToNextLandmark = 57;

            Landmarks L9 = new Landmarks();
            L9.Name = "Green River";
            L9.Shop = false;
            L9.Ferry = true;
            L9.Distance = 57;
            L9.DistanceToNextLandmark = 143; 
            L9.RiverWidth = 402;
            L9.RiverDepth = 20.3F;
            

            Landmarks L10 = new Landmarks();
            L10.Name = "Fort Bridger";
            L10.Shop = true;
            L10.Ferry = false;
            L10.Distance = 125;
            L10.DistanceToNextLandmark = 162;

            Landmarks L11 = new Landmarks();
            L11.Name = "Soda Springs";
            L11.Shop = false;
            L11.Ferry = false;
            L11.Distance = 162;
            //L11.DistanceAlt = 143
            L11.DistanceToNextLandmark = 57;

            Landmarks L12 = new Landmarks();
            L12.Name = "Fort Hall";
            L12.Shop = true;
            L12.Ferry = false;
            L12.Distance = 57;
            L12.DistanceToNextLandmark = 182;

            Landmarks L13 = new Landmarks();
            L13.Name = "Snake River";
            L13.Shop = false;
            L13.Ferry = false;
            L13.Distance = 182;
            L13.DistanceToNextLandmark = 113;
            L9.RiverWidth = 1000;//random
            L9.RiverDepth = 6.0F;//random

            Landmarks L14 = new Landmarks();
            L14.Name = "Fort Boise";
            L14.Shop = true;
            L14.Ferry = false;
            L14.Distance = 113;
            L14.DistanceToNextLandmark = 160;
                
            Landmarks L15 = new Landmarks();
            L15.Name = "Blue Mountains";
            L15.Shop = false;
            L15.Ferry = false;
            L15.Distance = 160;
            L15.DistanceToNextLandmark = 55;

            Landmarks L16 = new Landmarks();
            L16.Name = "Fort WALLA WALLA";
            L16.Shop = true;
            L16.Ferry = false;
            L16.Distance = 55;
            L16.DistanceToNextLandmark = 120;

            Landmarks L17 = new Landmarks();
            L17.Name = "The Dalles";
            L17.Shop = false;
            L17.Ferry = false;
            L17.Distance = 125;
            L17.DistanceToNextLandmark = 100;

            Landmarks L18 = new Landmarks();
            L18.Name = "Willameete Valley Oregon";
            L18.Shop = false;
            L18.Ferry = false;
            L18.Distance = 100;
            L18.DistanceToNextLandmark = 0;

            List <Landmarks> listOfLandmarks = new List<Landmarks>();
            listOfLandmarks.Add(L1);
            listOfLandmarks.Add(L2);
            listOfLandmarks.Add(L3);
            listOfLandmarks.Add(L4);
            listOfLandmarks.Add(L5);
            listOfLandmarks.Add(L6);
            listOfLandmarks.Add(L7);
            listOfLandmarks.Add(L8);
            listOfLandmarks.Add(L9);
            listOfLandmarks.Add(L10);
            listOfLandmarks.Add(L11);
            listOfLandmarks.Add(L12);
            listOfLandmarks.Add(L13);
            listOfLandmarks.Add(L14);
            listOfLandmarks.Add(L15);
            listOfLandmarks.Add(L16);
            listOfLandmarks.Add(L17);
            //listOfLandmarks.Add(L18);
            //listOfLandmarks.Add(L19);
            listOfLandmarks.Add(L18);



            TeamMembers Team = new TeamMembers();
            
            var input = 1;
            if (player.debug)
            {
                player.occupation = "Farmer";
                player.money = 4;
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
                player.money = 500;
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

            while (player.GameIsOn)
            {
                //Console.Clear();
                //Console.WriteLine("Independence");
                //Console.WriteLine(player.date);
                //InputDetection.Spacebar(player);

                //setupgame


                player.Landmark = listOfLandmarks[player.IndexForLandmarks].Name;


                GameMenu.PrintGameMenu(player, shop, listOfLandmarks);
            } 
        }
    }
}