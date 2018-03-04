﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOregonTrail
{
    class Game
    {
        //public string weather = "cold";

        
        public bool GameIsOn = true;
        public bool gameMenu = true;

        //List<int> Legs = new List<int>(new int[] { 102, 82, 118, 250, 86, 190, 102, 57 });
        
        Dictionary<string, int> Leg = new Dictionary<string, int>();
        public void InitLegs()
        {
            Leg.Add("Independence", 0);
            Leg.Add("Kansas River", 102);
            Leg.Add("Big Blue River", 82);
            Leg.Add("Fort Kearney", 118);
            Leg.Add("Chimney Rock", 250);
            Leg.Add("Fort Laramie", 86);
            Leg.Add("Indipendence Rock", 190);
            Leg.Add("South Pass", 102);//from
            Leg.Add("Green river", 57);//or
            Leg.Add("Fort Bridger", 125);//or
            Leg.Add("Soda Springs", 143);
            Leg.Add("Fort Hall", 57);
            Leg.Add("Snake River", 182);
            Leg.Add("Fort Boise", 113);
            //Leg.Add("Grande Ronde Valley", 999);//not in therre
            Leg.Add("Blue Mountains", 160);//from
            Leg.Add("Fort WALLA WALLA", 55);//or
            Leg.Add("The Dalles", 999);//or
            Leg.Add("Columbia River George", 999);
            Leg.Add("Barlow Road", 999);
            Leg.Add("Willameete Valley Oregon", 100); 
        }
        
        public string gameMenuInput = "";

 
        /*
         weather affects pace 
         terain affect pace
         weather: terain  health   pace     mile per day
         cold      gras    good   steady       15
         cool                                  12 
         warm                                  10
         hot             
         */


        /*LANDMARKS AND THE WAY                                                                              Meat
        START Independence, Missouri                                                                         400
        102 miles        17 miles per day + 2 day wrong trail total 9 days 3 pounds a day per people         280
        Kansas River     You are now at the Kansas River crossing. Would you like to look araound?           120 pund used 9 days 5 people
        82 miles         Kansas River crossing March 9, 1848 **You must cross the river in order to continue. the river at this point is currently 636 feet across, and 5.8 feet deep in the middle
        Big Blue River
        118
        Fort Kearney
        250
        Chimney Rock
        86
        Fort Laramie
        190
        Indipendence Rock
        102
        South pass
        57 miles           x miles
        Green river  or  Fort Bridger
        143 miles
        Soda Springs
        57 miles
        Fort Hall
        182 miles
        Snake River
        
        Fort Boise
        
        Grande Ronde Valley
        
        Blue Mountains
        
        Fort WALLA WALLA
        
        The Dalles
        
        Williamette Valley
        
        Columbia River George
        
        Barlow Road
        
        Willameete Valley Oregon
         */
        /*POSSIBLE DEATHS
        measles
        snakebite
        exhaustion typhoid
        cholera
        dysentery
        drowning
        accidental gunshot
         
         */

    }
}