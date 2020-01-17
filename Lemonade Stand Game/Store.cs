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
                Console.WriteLine("Great! What would you like to buy? 1. lemons, 2. cups, 3.ice cubes, 4. sugar cubes");
                int buyItems = int.Parse(Console.ReadLine());
                switch (buyItems)
                {
                    case 1:
                         string lemonBought = qtyOfLemons();
                        addLemonsToInventory(lemonBought, player);
                        break;
                    case 2:
                        string cupsBought = qtyOfCups();
                        addCupsToInventory(cupsBought, player);
                        break;
                    case 3:
                        string iceCubesBought = qtyOfIceCubes();
                        addIceCubesToInventory(iceCubesBought, player);
                        break;
                    case 4:
                        string sugarCubesBought = qtyOfSugarCubes();
                        addSugarCubesToInventory(sugarCubesBought, player);
                        break;

                }
               

            }
                  
            
        }
        public string qtyOfLemons()
        {
            
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine("10 lemons price = " + pricePerLemon * 10);
            Console.WriteLine("20 lemons price = " + pricePerLemon * 20);
            Console.WriteLine("50 lemons price = " + pricePerLemon * 50);
            return Console.ReadLine();
        }
        public void addLemonsToInventory(string lemonBought, Player player)
        {
            //TODO Create a for loop that will run lemonBought number of times
            //Inside the for loop, there will be a single line of code that adds 
            //a single lemon to the player's inventory's lemon list
            //Then, subtract money from player's wallet that equals lemonbought times priceperlemon
        }
         public string qtyOfCups()
        {
            Console.WriteLine("How many Cups would you like to buy?");
            Console.WriteLine("25 cups price = " + pricePerCup * 25);
            Console.WriteLine("35 cups price = " + pricePerCup * 35);
            Console.WriteLine("55 cups price = " + pricePerCup * 55);
            return Console.ReadLine();
        }
        public void addCupsToInventory(string cupsBought, Player player)
        {

        }
        public string qtyOfIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to buy?");
            Console.WriteLine("60 ice cubes price = " + pricePerCup * 60);
            Console.WriteLine("100 ice cubes price = " + pricePerCup * 100);
            Console.WriteLine("120 ice cubes price = " + pricePerCup * 120);
           return Console.ReadLine();
        }
        public void addIceCubesToInventory(string IceCubesBought, Player player)
        {

        }

        public string qtyOfSugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to buy?");
            Console.WriteLine("60 sugar cubes price = " + pricePerCup * 60);
            Console.WriteLine("120 sugar cubes price = " + pricePerCup * 120);
            Console.WriteLine("200 sugar cubes price = " + pricePerCup * 200);
            return Console.ReadLine();
        }
        public void addSugarCubesToInventory(string sugarCubesBought, Player player)
        {

        }
    }
    
}
