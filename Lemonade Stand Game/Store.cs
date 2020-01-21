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
            pricePerLemon = 0.06;
            pricePerSugarCube = 0.07;
            pricePerIceCube = 0.03;
            pricePerCup = 0.03;


        }


        public void VisitStore(Player player, Recipe recipe, Inventory inventory)
        {
            Console.WriteLine("What would you like to buy? 1. Lemons, 2. Cups, 3.Ice Cubes, 4. Sugar Cubes, 5. To Recipe, 6. Run Day");


            int buyItems = 0;
            int.TryParse(Console.ReadLine(), out buyItems);
          
           


            switch (buyItems)
            {
                case 1:
                    int lemonsBought = LemonQuantitySelected(player);
                    AddLemonsToInventory(lemonsBought,inventory);
                    RemoveMoneyFromWallet(lemonsBought, pricePerLemon, player);
                    VisitStore(player, recipe, inventory);
                    return;

                case 2:
                    int cupsBought = CupQuantitySelected(player);
                    AddCupsToInventory(cupsBought, player);
                    RemoveMoneyFromWallet(cupsBought, pricePerCup, player);
                    VisitStore(player, recipe, inventory);
                    return;

                case 3:
                    int iceCubesBought = IceCubeQuantitySelected(player);
                    AddIceCubesToInventory(iceCubesBought, player);
                    RemoveMoneyFromWallet(iceCubesBought, pricePerIceCube, player);
                    VisitStore(player, recipe, inventory);
                    return;

                case 4:
                    int sugarCubesBought = SugarCubeQuantitySelected(player);
                    AddSugarCubesToInventory(sugarCubesBought, player);
                    RemoveMoneyFromWallet(sugarCubesBought, pricePerSugarCube, player);
                    VisitStore(player, recipe, inventory);
                    return;
                case 5:
                    recipe.ChangeRecipe();
                    VisitStore(player, recipe, inventory);
                    return;

                case 6:
                
                default:
                    Console.WriteLine("You have selected an incorrect option please try again");
                    break;
            }
        }
        public int LemonQuantitySelected(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine($"10 Lemons for $" + pricePerLemon * 10 + ", 20 Lemons for " + pricePerLemon * 20 + ", 50 Lemons for " + pricePerLemon * 50);
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            switch (number)
            {
                case 10:
                    Console.WriteLine(player + " has added " + number + " lemons to his inventory.");
                    break;
                case 20:
                    Console.WriteLine(player + " has added " + number + " lemons to his inventory.");
                    break;

                case 50:
                    Console.WriteLine(player + " has added " + number + " lemons to his inventory.");
                    break;

                default:
                    Console.WriteLine(player + "has selected an incorrect number, please try again.");
                    break;
            }
            return number;
        }
        public int CupQuantitySelected(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            Console.WriteLine($"25 Cups for " + pricePerCup * 25 + ", 35 Cups for " + pricePerCup * 35 + ", 55 Cups for " + pricePerCup * 55);
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            switch (number)
            {
                case 10:
                    Console.WriteLine(player + " has added " + number + "cups to his inventory.");
                    break;
                case 20:
                    Console.WriteLine(player + " has added " + number + "cups to his inventory.");
                    break;

                case 50:
                    Console.WriteLine(player + " has added " + number + "cups to his inventory.");
                    break;

                default:
                    Console.WriteLine(player + "has selected an incorrect number, please try again.");
                    break;
            }
            return number;
        }
        public int IceCubeQuantitySelected(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy?");
            Console.WriteLine($"60 Ice Cubes for " + pricePerIceCube * 60 + ", 100 Ice Cubes for " + pricePerIceCube * 100 + ", 120 Ice Cubes for " + pricePerIceCube * 120);
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            switch (number)
            {
                case 10:
                    Console.WriteLine(player + " has added " + number + "ice cubes to his inventory.");
                    break;
                case 20:
                    Console.WriteLine(player + " has added " + number + "ice cubes to his inventory.");
                    break;

                case 50:
                    Console.WriteLine(player + " has added " + number + "ice cubes to his inventory.");
                    break;

                default:
                    Console.WriteLine(player + "has selected an incorrect number, please try again.");
                    break;
            }
            return number;
        }
        public int SugarCubeQuantitySelected(Player player)
        {
            Console.WriteLine("How many sugar cubes would you like to buy?");
            Console.WriteLine($"60 Sugar Cubes for " + pricePerSugarCube * 60 + ", 120 Sugar Cubes for " + pricePerSugarCube * 120 + ", 200 Sugar Cubes for " + pricePerSugarCube * 200);
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            switch (number)
            {
                case 10:
                    Console.WriteLine(player + " has added " + number + "sugar cubes to his inventory.");
                    break;
                case 20:
                    Console.WriteLine(player + " has added " + number + "sugar cubes to his inventory.");
                    break;

                case 50:
                    Console.WriteLine(player + " has added " + number + "sugar cubes to his inventory.");
                    break;

                default:
                    Console.WriteLine(player + "has selected an incorrect number, please try again.");
                    break;
            }
            return number;
        }
        //Add Items to their respective list.
        public void AddLemonsToInventory(int lemonsBought, Inventory inventory)
        {
            for (int i = 0; i < lemonsBought; i++)
            {
                inventory.lemons.Add(new Lemon());
            }
            //Create a method that removes money from wallet.
        }
        public void AddCupsToInventory(int cupsBought, Inventory inventory)
        {
            for (int i = 0; i < cupsBought; i++)
            {
                inventory.cups.Add(new Cup());
            }
        }
        public void AddIceCubesToInventory(int iceCubesBought, Inventory inventory)
        {
            for (int i = 0; i < iceCubesBought; i++)
            {
                inventory.iceCubes.Add(new IceCube());
            }
        }
        public void AddSugarCubesToInventory(int sugarCubesBought, Inventory inventory)
        {
            for (int i = 0; i < sugarCubesBought; i++)
            {
                inventory.sugarCubes.Add(new SugarCube());
            }
        }

        //Remove Money from Wallet      
        //SOLID:  Used the Open/Closed Principle.  Lines 213-219
        //Will need to add verification for this to work based on if you have money or not.
        public void RemoveMoneyFromWallet(int itemsBought, double priceOfItem, Player player)
        {
            double result;
            result = itemsBought * priceOfItem;
            player.wallet.Money -= result;
        }

    }

}
