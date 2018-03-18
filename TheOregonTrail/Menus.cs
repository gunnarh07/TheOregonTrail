using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Menus
    {
        public static int StartScreenMenu()           
        {       
           
            Console.WriteLine("-----THE  OREGON  TRAIL-------");
            Console.WriteLine("    You may:");
            Console.WriteLine("        1. Travel the trail");
            Console.WriteLine("        2. Learn about the trail");
            Console.WriteLine("        3. See the Oregon Top Ten");
            Console.WriteLine("        4. Turn sound off");
            Console.WriteLine("        5. Choose Management Options");
            Console.WriteLine("        6. End");
            Console.WriteLine("    What is your choice?");

            
            var input = int.Parse(Console.ReadLine());
            
            Console.Clear();
            return input;    
        }

        public static void OccupationMenu(Player player, Shop shop)
        {
            Console.WriteLine("Many kinds of people made the trip to Oregon.");
            Console.WriteLine("You may:");
            Console.WriteLine("1. Be a banker from Boston");
            Console.WriteLine("2. Be a carpenter from Ohio");
            Console.WriteLine("3. Be a farmer from Illinois");
            Console.WriteLine("4. Find out the differences between these choice?");
            Console.WriteLine("What is your choice?");

            int input;
            if(player.debug)
            {
                input = 3;
            }
            else
            {
                input = int.Parse(Console.ReadLine());
            }
            
            Console.Clear();
            if (input == 1)
            {
                player.occupation = "Banker";
                player.money = 1600;
            }
            if (input == 2)
            {
                player.occupation = "Carpenter";
                player.money = 800;
            }
            if (input == 3)
            {
                player.occupation = "Farmer";
                player.money = 0;//TODO change to 400 for not debuging
            }
            if (input == 4)
            {
                DifferenceMenu(player, shop);
            }

        }

        public static void DifferenceMenu(Player player, Shop shop)
        {
            Console.WriteLine("     Traveling to Oregon isn't easy!");
            Console.WriteLine("     But if you're a banker, you'll");
            Console.WriteLine("     have more money for supplies");
            Console.WriteLine("     and services than a carpenter");
            Console.WriteLine("     or a farmer.");
            Console.WriteLine("");
            Console.WriteLine("     However, harder you have");
            Console.WriteLine("     to try, the more points you");
            Console.WriteLine("     deserve! Therefore, the");
            Console.WriteLine("     farmer earns the greatest");
            Console.WriteLine("     number of points and the");
            Console.WriteLine("     banker earns the least.");
            Console.WriteLine("");
            InputDetection.Spacebar(shop);
            Menus.OccupationMenu(player, shop);
        }

        public static void NameMenuNames(Player player)
        {
            Console.Clear();
            Console.WriteLine("what are the first names of the four other members in your party?");
            Console.WriteLine("1. " + player.name1);
            Console.WriteLine("2. " + player.name2);
            Console.WriteLine("3. " + player.name3);
            Console.WriteLine("4. " + player.name4);
            Console.WriteLine("5. " + player.name5);
        }

        public static void NameMenu(Player player)
        {
            if(player.debug)
            {
                player.name1 = "Gunni";
                player.name2 = "Liney";
                player.name3 = "Birta";
                player.name4 = "Victor";
                player.name5 = "Margret";
            }
            else
            { 
                Console.WriteLine("What is the first name of the wagon leader?");
                string inputName1 = Console.ReadLine();
                player.name1 = inputName1;
                Console.Clear();

                bool namesCorrect = false;

                while (!namesCorrect)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        NameMenuNames(player);

                        var input = Console.ReadLine();

                        if (i == 0)
                        {
                            player.name2 = input;
                        }
                        if (i == 1)
                        {
                            player.name3 = input;
                        }
                        if (i == 2)
                        {
                            player.name4 = input;
                        }
                        if (i == 3)
                        {
                            player.name5 = input;
                            NameMenuNames(player);
                        }


                    }
                    Console.WriteLine("Are these names correct?");
                    string nameCorrect = Console.ReadLine();

                    if (nameCorrect == "y" || nameCorrect == "Y" || nameCorrect == "yes")
                    {
                        namesCorrect = true;
                    }
                }
            }
        }

        public static void DateOfDeparture(Player player)
        {
            string date = "01-03-1848";
            DateTime dateOfDeparture = Convert.ToDateTime(date);
            if (player.debug)
            {
                player.date = dateOfDeparture;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("    It is 1848.Your jumping off");
                Console.WriteLine("    place for Oregon is Independence,");
                Console.WriteLine("    Missouri.You must decide which");
                Console.WriteLine("    month to leave Independence.");
                Console.WriteLine("");
                Console.WriteLine("       1. March");
                Console.WriteLine("       2. April");
                Console.WriteLine("       3. May");
                Console.WriteLine("       4. June");
                Console.WriteLine("       5. July");
                Console.WriteLine("       6. Ask for advice");
                Console.WriteLine("    What is your choice ?");

                var input = Console.ReadLine();

                if (input == "1")
                {
                    player.date = dateOfDeparture;
                }
                if (input == "2")
                {
                    date = "01-04-1848";
                    dateOfDeparture = Convert.ToDateTime(date);
                    player.date = dateOfDeparture;
                }
                if (input == "3")
                {
                    date = "01-05-1848";
                    dateOfDeparture = Convert.ToDateTime(date);
                    player.date = dateOfDeparture;
                }
                if (input == "4")
                {
                    date = "01-06-1848";
                    dateOfDeparture = Convert.ToDateTime(date);
                    player.date = dateOfDeparture;
                }
                if (input == "5")
                {
                    date = "01-07-1848";
                    dateOfDeparture = Convert.ToDateTime(date);
                    player.date = dateOfDeparture;
                }
            }
            

            Console.Clear();
        }
    }
}

