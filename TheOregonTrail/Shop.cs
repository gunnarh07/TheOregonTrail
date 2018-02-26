using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Shop
    {
        public string shopInput = "";
        public bool shoping = true;
        public bool spacebar = false;
        public bool playersMoney = true;
        public bool ToMuchFood = false;

        public int numberOfYokes = 0;
        public int numberOfOxs = 0;
        public int poundsOfFoods = 0;
        public int setsOfClothing = 0;
        public int boxOfAmmunition = 0;
        public int numberOfSpearParts = 0;
        public int wagonWheel = 0;
        public int wagonAxel = 0;
        public int wagonTounge = 0;
        public int spareParts;

        public decimal oxPrice = 20.00m;
        public decimal foodPrice = .20m;
        public decimal clothingPrice = 10m;
        public decimal ammunitionPrice = 2m;
        public decimal sparePartsPrice = 10m;


        public decimal totalOxPrice = 0;
        public decimal totalFoodPrice = 0;
        public decimal totalClothingPrice = 0;
        public decimal totalAmmunitionPrice = 0;
        public decimal totalSparePartsPrice = 0;

        public decimal billTotal = 0;
    }
}
