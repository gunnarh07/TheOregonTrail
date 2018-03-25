using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Player
    {

        public bool GameIsOn = true;
        public bool GameMenu = true;
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
        
        public DateTime date;//date used for start time and track time 

        public decimal money; //players money
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
        public bool ArrivingLanmark = false;
        public bool ReadAtBeginingOfLeg = true;
        public int leg = 0;
        public int MilesTraveled = 0;
        public int MilesToNextLandmark = 0;
        public int pace = 50;
        public string Landmark;
        public bool AtFort = true;
        public bool InitLeg = true;
        public int LegMiles = 102;
        public int theLeg = 102;
        public int leg2 = 82;
        public int IndexForLandmarks = 14;//------------------------
        public int riverWidth = 642;   //655/649/644/640/636/632/629/626/623/621/619/617/615/614/612/611/610//609/608/607
        public float riverDepth = 6.7F;//8.4/7.6/7.0/6.4/5.8/5.3/4.9/4.5/4.2/3.8/3.6/3.3/3.1/2.9/2.7/2.5/2.4//2.2/2.1/2.0
        public string someName = "Someone";
        //legs comformation
        public bool krc = false;
        public bool alternateRoute = false;
        public bool gameEvent = false;
        //ration pounds per team member
        public int rations = 3;
        public int someInt = 2;
        public string playerInput;
        public bool LeavingALandmark = true;
        public bool insidecycle = false;
        //-------------alternative route-----//
        public bool greenRiverCrossing = false;
        public bool fortBridger = false;
        public bool fortWallaWalla = false;
        public bool theDalles = false;
        public bool BarlowTollRoad = false;
        public bool ColumbiaRiver = false;

        public string gameMenuInput = "";

        public static string getPace(Player player)
        {
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
