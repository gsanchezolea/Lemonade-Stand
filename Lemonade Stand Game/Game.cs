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
        private Player player;
        private int currentDay;
        private List<Day> days;
        Random random;
        //Constructor

        public Game()
        {
            days = new List<Day>(7);

            random = new Random();

        }
        //Member Methods (CAN DO)

        public void StartGame()
        {

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
        }
        public void PickStoreItems()
        {

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
    }
}
