using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Store
    {
        public static void headerWithDate(Player player)
        {
            string dateFormat = "MMMM d yyyy";

            Console.Clear();
            Console.WriteLine("        -------------------------------");
            Console.WriteLine("            Matt's General Store");
            Console.WriteLine("            Independence, Missouri");
            Console.WriteLine("                 {0}", player.date.ToString(dateFormat));
            //Console.WriteLine("                 March 1, 1848");TODO english date
            Console.WriteLine("        -------------------------------");
        }

        public static void headerWithOutDate()
        {
            Console.Clear();
            Console.WriteLine("        -------------------------------");
            Console.WriteLine("            Matt's General Store");
            Console.WriteLine("            Independence, Missouri");
            Console.WriteLine("        -------------------------------");
        }

        public static void SparePartHeader()
        {
            Console.WriteLine("          It's a good idea to have a");
            Console.WriteLine("          few spare parts for your");
            Console.WriteLine("          wagon.Here are the prices:");
            Console.WriteLine("");
            Console.WriteLine("            wagon wheel -  $10 each");
            Console.WriteLine("            wagon axle -  $10 each");
            Console.WriteLine("            wagon tounge -  $10 each");
            Console.WriteLine("");
        }

        public static void printBill(Shop shop, decimal billTotal)
        {
            var oxString = string.Format("           1.  Oxen              ${0:###0.00}", shop.totalOxPrice);
            var foodString = string.Format("           2.  Food              ${0:###0.00}", shop.totalFoodPrice);
            var clothingString = string.Format("           3.  Clothing          ${0:###0.00}", shop.totalClothingPrice);
            var ammunitionString = string.Format("           4.  Ammunition        ${0:###0.00}", shop.totalAmmunitionPrice);
            var sparePartsString = string.Format("           5.  Spear Parts       ${0:###0.00}", shop.totalSparePartsPrice);

            Console.WriteLine(oxString);
            Console.WriteLine(foodString);
            Console.WriteLine(clothingString);
            Console.WriteLine(ammunitionString);
            Console.WriteLine(sparePartsString);
            Console.WriteLine("        ---------------------------------");

            shop.billTotal = shop.totalOxPrice + shop.totalFoodPrice + shop.totalClothingPrice + shop.totalAmmunitionPrice + shop.totalSparePartsPrice;
            var billSoFar = string.Format("                  Total bill:    ${0:###0.00}", shop.billTotal);
            Console.WriteLine(billSoFar);
        }

        public static void AmountYouHave(Player player)
        {
            var money = string.Format("         Amount you have:     ${0:###0.00}", player.money);
            Console.WriteLine(money);
        }

        public static void WichItemToBuy()
        {
            Console.WriteLine("          Which item would you?");
            Console.WriteLine("          like to buy?");
            Console.WriteLine("");
        }

        public static void DontForgetToBuyOx()
        {
            Console.WriteLine("");
            Console.WriteLine("          Don't forget, you'll need");
            Console.WriteLine("          oxen to pull your wagon");
            Console.WriteLine("");
        }

        public static void BillSoFar(Shop shop)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            var billSoFarString = string.Format("          Bill so far: ${0:0.00}", shop.billTotal);
            Console.WriteLine(billSoFarString);
        }

        public static void NotEnoughMoney(Player player, Shop shop)
        {
            Console.WriteLine("          Okay, that comes to a total");
            Console.WriteLine("          of ${0}.But I see that", shop.billTotal);
            Console.WriteLine("          you only have ${0}.", player.money);
            Console.WriteLine("          We'd better go over the");
            Console.WriteLine("          list again");
            Console.WriteLine("");
        }

        public static void HowManyOxen(Player player, Shop shop, string shopInput)
        {
            Console.Clear();
            do
            {
                headerWithOutDate();

                Console.WriteLine("          There are 2 oxen in a yoke");
                Console.WriteLine("          I recommend at least 3 yoke.");
                Console.WriteLine("          I charge $40 a yoke.");
                Console.WriteLine("");
                Console.WriteLine("          How many yoke do how");
                Console.WriteLine("          want!");

                BillSoFar(shop);

            
                shop.numberOfYokes = int.Parse(Console.ReadLine());
                Console.Clear();
             } while (shop.numberOfYokes > 9);
            
            shop.totalOxPrice = shop.numberOfYokes * shop.oxPrice * 2;
            //shop.billTotal += shop.totalOxPrice;

            shop.shopInput = "";
            PrintStoreMenu(player, shop);
        }

        public static void HowMuchFood(Player player, Shop shop)
        {
            Console.Clear();
            headerWithOutDate();

            Console.WriteLine("          I recommend you take at");
            Console.WriteLine("          least 200 pounds of food");
            Console.WriteLine("          for each person in your");
            Console.WriteLine("          family.I see that you have");
            Console.WriteLine("          5 people in all.You'll need");
            Console.WriteLine("          flour, sugar, bacon, and");
            Console.WriteLine("          coffee.My price is 20");
            Console.WriteLine("          cents a pound.");
            Console.WriteLine("");
            Console.WriteLine("          How many pounds of food do");
            Console.WriteLine("          you want?");
            BillSoFar(shop);

            shop.poundsOfFoods = int.Parse(Console.ReadLine());
            if(shop.poundsOfFoods > 2000)
            {
                shop.ToMuchFood = true;
                ToMuchFood(player, shop);
            }
            shop.totalFoodPrice = shop.poundsOfFoods * shop.foodPrice;
            shop.billTotal = shop.totalFoodPrice;

            shop.shopInput = "";
            PrintStoreMenu(player, shop);
        }

        public static void ToMuchFood(Player player, Shop shop)
        {
            //This prints out if to much food are bought

            headerWithOutDate();
            Console.WriteLine("");
            Console.WriteLine("          Your wagon may only carry");
            Console.WriteLine("          2000 pounds of food");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            InputDetection.Spacebar(shop);
            HowMuchFood(player, shop);
        }

        public static void HowManySetsOfClothes(Player player, Shop shop, string shopInput)
        {
            do
            {
                Console.Clear();
                headerWithOutDate();
                Console.WriteLine("          You'll need warm clothing in");
                Console.WriteLine("          the mountains. I recomenmend");
                Console.WriteLine("          taking at least 2 sets of");
                Console.WriteLine("          clothes per person.Each");
                Console.WriteLine("          sets is $10.00.");
                Console.WriteLine("");
                Console.WriteLine("          How many sets of clothes do");
                Console.WriteLine("          you want?");
                BillSoFar(shop);
                shop.setsOfClothing = int.Parse(Console.ReadLine());

            }while (shop.setsOfClothing > 100);
            shop.totalClothingPrice = shop.setsOfClothing * shop.clothingPrice;
            shop.billTotal = shop.totalClothingPrice;

            shop.shopInput = "";
            PrintStoreMenu(player, shop);
        }

        public static void HowMuchAmmo(Player player, Shop shop, string shopInput)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("          I sell ammunition in boxes");
                Console.WriteLine("          of 20 bulleta.Each box");
                Console.WriteLine("          costs $2.00.");
                Console.WriteLine("");
                Console.WriteLine("          How many boxes do you");
                Console.WriteLine("          want?");
                BillSoFar(shop);
                shop.boxOfAmmunition = int.Parse(Console.ReadLine());

            } while (shop.boxOfAmmunition > 100);
            shop.totalAmmunitionPrice = shop.boxOfAmmunition * shop.ammunitionPrice;
            shop.billTotal = shop.totalAmmunitionPrice;

            shop.shopInput = "";
            PrintStoreMenu(player, shop);
        }

        public static void HowManySpareParts(Player player, Shop shop, string shopInput)
        {
            while(!shop.shopSpareParts)
            {
                if(!shop.wheel)
                {
                    headerWithOutDate();
                    SparePartHeader();
                    if (!shop.ToManySpearParts)
                    {
                        Console.WriteLine("          How many wagon wheels ?");
                        BillSoFar(shop);
                        shop.wagonWheel = int.Parse(Console.ReadLine());
                    }
                    if (shop.ToManySpearParts)
                    {
                        Console.WriteLine("          Your wagon may only carry 3");
                        Console.WriteLine("          wagon wheels");
                        Console.WriteLine("");
                        InputDetection.Spacebar(shop);
                        shop.wagonWheel = 0;
                        shop.ToManySpearParts = false;
                    }
                    if (shop.wagonWheel < 4)
                    {
                        shop.wheel = true;
                        shop.axel = true;                      
                    }                                   
                }

                if (shop.axel)
                {
                    
                    headerWithOutDate();
                    SparePartHeader();
                    if (!shop.ToManySpearParts)
                    {
                        Console.WriteLine("          How many wagon axles ?");
                        BillSoFar(shop);
                        shop.wagonAxel = int.Parse(Console.ReadLine());
                    }
                    if (shop.ToManySpearParts)
                    {
                        Console.WriteLine("          Your wagon may only carry 3");
                        Console.WriteLine("          wagon axles.");
                        Console.WriteLine("");
                        InputDetection.Spacebar(shop);
                        shop.wagonWheel = 0;
                        shop.ToManySpearParts = false;
                    }
                    if (shop.wagonAxel < 4)
                    {
                        shop.axel = false;
                        shop.tongue = true;
                    }
                }

                if (shop.tongue)
                {
                    headerWithOutDate();
                    SparePartHeader();
                    if (!shop.ToManySpearParts)
                    {
                        Console.WriteLine("          How many wagon tounge ?");
                        BillSoFar(shop);
                        shop.wagonTounge = int.Parse(Console.ReadLine());
                    }
                    if (shop.ToManySpearParts)
                    {
                        Console.WriteLine("          Your wagon may only carry 3");
                        Console.WriteLine("          wagon tounge.");
                        Console.WriteLine("");
                        InputDetection.Spacebar(shop);
                        shop.wagonTounge = 0;
                        shop.ToManySpearParts = false;
                    }
                    if (shop.wagonTounge < 4)
                    {
                        shop.tongue = false;
                        shop.shopSpareParts = true;
                    }                    
                }
            }
            
            shop.spareParts = shop.wagonWheel + shop.wagonAxel + shop.wagonTounge;

            shop.totalSparePartsPrice = shop.spareParts * shop.sparePartsPrice;
            shop.billTotal = shop.totalSparePartsPrice;

            shop.shopInput = "";
            PrintStoreMenu(player, shop);
        }

        public static void GodbyeShop()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("          Well then, you're ready");
            Console.WriteLine("          to start. Good luck!");
            Console.WriteLine("          You have a long and");
            Console.WriteLine("          difficult journey ahead");
            Console.WriteLine("          of you");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void DetectIfSpaceBarIsHit(Player player, Shop shop)
        {
            Console.WriteLine("          Press SPACE BAR to");
            Console.WriteLine("          leave store");

            InputDetection.DetectKeyStroke(shop);
            if (shop.shopInput == "Spacebar" && shop.numberOfYokes > 0)
            {                
                if (player.money < shop.billTotal)
                {
                    shop.playersMoney = false;
                    PrintStoreMenu(player, shop);
                }
                if (player.money > shop.billTotal)
                {
                    shop.playersMoney = true;
                    shop.shoping = false;
                    shop.shopInput = "";
                    player.money -= shop.billTotal;
                    GodbyeShop();

                    //move stuff to wagon
                    player.numberOfOxs = shop.numberOfYokes * 2;
                    player.numberOfYokes = shop.numberOfYokes;
                    player.poundsOfFoods = shop.poundsOfFoods;
                    player.setsOfClothing = shop.setsOfClothing;
                    player.spareParts = shop.spareParts;
                    player.wagonAxel = shop.wagonAxel;
                    player.wagonTounge = shop.wagonTounge;
                    player.wagonWheel = shop.wagonWheel;
                }                
            }
            else
            {
                Console.Clear();
                PrintStoreMenu(player, shop);
            }
        }

        public static void PrintStoreMenu(Player player, Shop shop)
        {            
            while (shop.shoping)
            {
                if (shop.shopInput == "" || shop.shopInput == "Spacebar")
                {
                    headerWithDate(player);
                }
                if (shop.shopInput == "D1" || shop.shopInput == "D2" || shop.shopInput == "D3" || shop.shopInput == "D4" || shop.shopInput == "D5")
                {
                    headerWithOutDate();
                }
                if(shop.shopInput == "D1")
                {
                    HowManyOxen(player, shop, shop.shopInput);
                    break;
                }
                if (shop.shopInput == "D2")
                {
                    HowMuchFood(player, shop);
                    break;
                }
                if (shop.shopInput == "D3")
                {
                    HowManySetsOfClothes(player, shop, shop.shopInput);
                    shop.shopInput = "";
                    break;
                }
                if (shop.shopInput == "D4")
                {
                    HowMuchAmmo(player, shop, shop.shopInput);
                    shop.shopInput = "";
                    break;
                }
                if (shop.shopInput == "D5")
                {
                    HowManySpareParts(player, shop, shop.shopInput);
                    shop.shopInput = "";
                    break;
                }
                if (shop.shopInput == "" || shop.shopInput == "Spacebar")
                {
                    printBill(shop, shop.billTotal);
                }                
                if (shop.shopInput == "")
                {
                    AmountYouHave(player);
                }
                if (shop.shopInput == "")
                {
                    WichItemToBuy();
                }
                if (shop.shopInput == "")
                {
                    DetectIfSpaceBarIsHit(player, shop);
                }
                if (shop.shopInput == "Spacebar" && shop.playersMoney == true)
                {
                    DontForgetToBuyOx();
                    InputDetection.Spacebar(shop);
                }
                if (shop.shopInput == "Spacebar" && shop.playersMoney == false)
                {
                    NotEnoughMoney(player, shop);
                    InputDetection.Spacebar(shop);
                }
            }
        }

        public static void TheStore(Player player, Shop shop)
        {
            if (!player.debug)
            {
                Console.WriteLine("Before leaving Independence you");
                Console.WriteLine("should buy equipment and");
                Console.WriteLine("supplies.you have $1600.00 in");
                Console.WriteLine("cash, but don't have to");
                Console.WriteLine("spend it all now.");
                Console.WriteLine("");
                InputDetection.Spacebar(shop);
                Console.Clear();

                Console.WriteLine("You can buy whatever you need at");
                Console.WriteLine("Matt's General Store.");
                Console.WriteLine("");
                InputDetection.Spacebar(shop);
                Console.Clear();

                Console.WriteLine("Hello, I'm Matt. So you're going");
                Console.WriteLine("to Oregon!I can fix you up with");
                Console.WriteLine("what you need:");
                Console.WriteLine("");
                Console.WriteLine("-a team of oxen to pull your wagon");
                Console.WriteLine("- clothing for both summer and winter");
                Console.WriteLine("");
                InputDetection.Spacebar(shop);
                Console.Clear();

                Console.WriteLine("Hello, I'm Matt. So you're going");
                Console.WriteLine("to Oregon!I can fix you up with");
                Console.WriteLine("what you need:");
                Console.WriteLine("");
                Console.WriteLine("- plenty of food for the trip");
                Console.WriteLine("- ammunition for your rifles");
                Console.WriteLine("- spare parts for your wagon");
                Console.WriteLine("");
                InputDetection.Spacebar(shop);
                Console.Clear();
            }
     
            PrintStoreMenu(player, shop);                           
                
            if (shop.shopInput == "D1")
            {
                HowManyOxen(player, shop, shop.shopInput);                
            }
            if (shop.shopInput == "D2")
            {
                HowMuchFood(player, shop);
            }
            if (shop.shopInput == "D3")
            {
                HowManySetsOfClothes(player, shop, shop.shopInput);
            }
            if (shop.shopInput == "D4")
            {
                HowMuchAmmo(player, shop, shop.shopInput);
            }
            if (shop.shopInput == "D5")
            {
                HowManySpareParts(player, shop, shop.shopInput);
            }
        }
    }
}
