using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    class Game
    {

        //Member Variables (HAS A)
        private Player player;
        private int currentDay;
        private List<Day> days;
        //Constructor
       
        public Game()
        {
            Random random = new Random();
            days = new List<Day>(7);
        }
        //Member Methods (CAN DO)


    }
}
