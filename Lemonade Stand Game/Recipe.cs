using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Recipe
    {

        //Member Variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        
        //Constructor
        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0.00;
        }

        //Member Methods (CAN DO)
        public void ChangeRecipe()
        {
            Console.WriteLine("Select Ingredient to Change in your Recipe: \n1. Lemons \n2. Sugar Cubes \n3. Ice Cubes \n4. Price per Cup");
            double selection = 0;
            double.TryParse(Console.ReadLine(), out selection);

            switch (selection)
            {
                case 1:
                    ChangeLemonQuantity();
                    ChangeRecipe();
                    return;
                case 2:
                    ChangeSugarCubeQuantity();
                    ChangeRecipe();
                    return;
                case 3:
                    ChangeIceCubeQuantity();
                    ChangeRecipe();
                    return;
                case 4:
                    ChangePricePerCup();
                    ChangeRecipe();
                    return;
                default:
                    Console.WriteLine("Incorrect Selection! Please try again...");
                    break;          
            }
        }
        public void ChangeLemonQuantity()
        {
            Console.WriteLine("How many Lemons do you want per cup?");
            int selection = 0;
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            amountOfLemons = selection;
        }
        public void ChangeSugarCubeQuantity()
        {
            Console.WriteLine("How many Sugar Cubes do you want per cup?");
            int selection = 0;
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            amountOfSugarCubes = selection;
        }
        public void ChangeIceCubeQuantity()
        {
            Console.WriteLine("How many Ice Cubes do you want per cup?");
            int selection = 0;
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            amountOfIceCubes = selection;
        }
        public void ChangePricePerCup()
        {
            Console.WriteLine("What Price do you want to change the Cups to?");
            double selection = 0;
            try
            {
                double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            pricePerCup = selection;
        }
        public void PitcherCreated()
        {
            
        }
    }
    
}

