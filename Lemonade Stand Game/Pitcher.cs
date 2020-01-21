using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Pitcher
    {


        //Member Variables (HAS A)
        public int cupsLeftInPitcher;
        List<Pitcher> pitchers;
        //Constructor
        public Pitcher()
        {
            pitchers = new List<Pitcher>();
            cupsLeftInPitcher = 15;
            
        }
        //Member Methods (CAN DO)
        //SOLID: Used the Single Responsibility Principle.  Lines 24-62
        public void RemoveLemonsFromInventory(Inventory inventory, Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfLemons; i++)
            {
                inventory.lemons.Remove(inventory.lemons[0]);
            }
        }
        public void RemoveSugarCubesFromInventory(Inventory inventory,Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                inventory.sugarCubes.Remove(inventory.sugarCubes[0]);
            }

        }
        public void RemoveIceCubesFromInventory(Inventory inventory, Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfIceCubes; i++)
            {
                inventory.iceCubes.Remove(inventory.iceCubes[0]);
            }
        }
        public void RemoveCupsFromInventory(Inventory inventory, Recipe recipe)
        {
            for (int i = 0; i < cupsLeftInPitcher; i++)
            {
                inventory.cups.Remove(inventory.cups[0]);
            }
        }

        
            public void RemoveItemsFromInventory(Inventory inventory, Recipe recipe)
        {
            RemoveLemonsFromInventory(inventory, recipe);
            RemoveSugarCubesFromInventory(inventory, recipe);
            RemoveIceCubesFromInventory(inventory, recipe);
            RemoveCupsFromInventory(inventory, recipe);
        }
        

    }
}
