using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Store
    {

        //Member Variables (HAS A)
       public double pricePerLemon;
        public double pricePerSugarCube;
       public double pricePerIceCube;
       public double pricePerCup;
        public string stockUpOption;
        //Constructor
        public Store()
        {
            pricePerLemon = 0.05;
            pricePerSugarCube = 0.06;
            pricePerIceCube = 0.04;
            pricePerCup = 0.03;
            

        }

        //Member Methods (CAN DO)
        public void VisitStore(Player player)
        {
            Console.WriteLine(player.name + "would you like to stock up on supplies? type yes or no to continue.");
            string stockUpOption = Console.ReadLine();
            if (stockUpOption == "yes")
            {
                Console.WriteLine("Great! What would you like to buy? 1. cups, 2. lemons, 3.sugar cubes, 4. ice cubes" );

            }
            
                
            
        }

    }
}
