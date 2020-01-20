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
        public void RemoveLemonsFromInventory(Inventory inventory, Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfLemons; i++)
            {
                inventory.lemons.Remove(inventory.lemons[0]);
            }
        }
        public void RemoveSugarFromInventory(Inventory inventory,Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                inventory.sugarCubes.Remove(inventory.sugarCubes[0]);
            }

        }
        public void MakePitcher(Recipe recipe)
        {
          
        }
        public void PitcherForSell(Player player)
        {
            if(cupsLeftInPitcher == 0)
            {
                player.pitcher.pitchers.Add(new Pitcher());
            } 
        }

    }
}
