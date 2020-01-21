﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Game
    {

        //Member Variables (HAS A)
        public Player player;
        public int currentDay;
        public List<Day> days;
        public Random random;
        public int playModeSelected;
        //Constructor

        public Game()
        {

            days = new List<Day>(7);
            Day day = new Day(random);
            random = new Random();

        }
        //Member Methods (CAN DO)

        public void StartGame()
        {
            PlayMode();        
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("Hello and Welcome to the game Lemonade Stand!");
            Console.WriteLine("Hit enter to play");
            Console.ReadLine();
        }
        public void Instructions()
        {
            Console.WriteLine("Instructions\nYour goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand.");
            Console.ReadLine();
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions. \nStart with the basic recipe but, try to vary the recipe and see if you can do better. \nLastly, set your price and sell your lemonade at the stand. \nTry changing up the price based on the weather conditions as well");
            Console.ReadLine();
            Console.WriteLine("At the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!");
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\nStart with the basic recipe, but try to vary the recipe and see if you can do better.\nLastly, set your price and sell your lemonade at the stand. Try changing up the price based on the weather conditions as well.");
            Console.ReadLine();
            Console.WriteLine("At the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!");
            Console.WriteLine("Hit enter when you are ready to play Lemonade Stand!");
            Console.ReadLine();
        }
        public void PlayMode()
        {  
            Console.WriteLine("Select Playing Mode: \n1. 7 Days \n2. 14 Days \n3. 21 Days \n4. Help");
            int selection = 0;
            int.TryParse(Console.ReadLine(), out selection);

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have selected 7 Days");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("You have selected 14 Days");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("You have selected 21 Days");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("You have selected Help");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Wrong selection please try again");
                    Console.ReadLine();
                    break;
            }
            playModeSelected = selection;
        }
        
        public void ShowCurrentStats(string condition, int temperature, double Money, Day day)
        {

        }
        public void DisplayDailyPL()
        {

        }
        public void DisplayRunningTotalPL()
        {

        }
        public void InstatiatePlayMode()
        {
            if (playModeSelected == 1)
            {

            }
            else if (playModeSelected == 2)
            {

            }
            else
            {
                Console.WriteLine("Error 414");
            }
        }
    }
}
