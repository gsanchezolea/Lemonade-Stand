using System;
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

            days = new List<Day>();

            random = new Random();

        }
        //Member Methods (CAN DO)

        public void StartGame()
        {
            PlayMode();        
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
