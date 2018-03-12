using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Player
    {
        //Default Constructor

        public string occupation;
        //name of the team members and info
        public string name1;//teamleader
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public int teamSize = 5;
        public string weather = getWeather();
        public string health = "good";
        public string steady = "steady";
        //date used for start time and track time 
        public DateTime date;
        //players money
        public decimal money;
        //player stuff!
        public int numberOfYokes = 0;
        public int numberOfOxs = 0;
        public int poundsOfFoods = 0;
        public int setsOfClothing = 0;
        public int ammo = 0;
        public int wagonWheel = 0;
        public int wagonAxel = 0;
        public int wagonTounge = 0;
        public int spareParts;

        public bool ShowMessage = true;
        /// <summary>
        /// debug
        /// </summary>
        public bool debug = true;
        public bool shop = true;
        public bool Traveling = true;
        public bool AtLandmark = true;
        //public bool ArriveAtLandmark = false;
        public bool ReadAtBeginingOfLeg = true;
        public int leg = 0;
        public int MilesTraveled = 0;
        public int MilesToNextLandmark = 0;
        public int pace = 20;
        public string Landmark;
        public bool AtFort = true;
        public bool InitLeg = true;
        public int LegMiles = 102;
        public int leg1 = 102;
        public int leg2 = 82;
        public int IndexForMiles = 0;
        public int IndexForLegs = 0;
        public int riverWidth = 642;
        public float riverDepth = 6.7F;
        //legs comformation
        public bool krc = false;

        //ration pounds per team member
        public int rations = 3;

        public string playerInput;
        public string GameInput;
        
        public bool insidecycle = false; 

        public static string getPace(Player player)
        {
            //if()

            return "";
        }

        public static string getWeather()
        {

            string weather = "cold";
            return weather;
        }

        public string getRation(Player player)
        {
            if(player.rations == 3)
            {
                return "filling";
            }
            if (player.rations == 2)
            {
                return "meager";
            }
            if (player.rations == 1)
            {
                return "bare bones";
            }
            else
            {
                return "";
            }
        }
    }
}
