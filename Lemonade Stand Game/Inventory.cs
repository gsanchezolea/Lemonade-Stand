using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Inventory
    {

        //Member Variables (HAS A)
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        //Constructor

        //Constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCube>();
        }

        
   

        //Methods for Removing from Pitcher Ingredients from Inventory
        public void RemoveLemonsFromInventory(int lemonsFromDay)
        {
            for (int i = 0; i < lemonsFromDay; i++)
            {
                lemons.Remove(lemons[0]);
            }
        }
        public void RemoveIceCubesFromInventory(int iceCubesFromDay)
        {
            for (int i = 0; i < iceCubesFromDay; i++)
            {
                iceCubes.Remove(iceCubes[0]);
            }
        }
        public void RemoveCupsFromInventory(int cupsFromDay)
        {
            for (int i = 0; i < cupsFromDay; i++)
            {
                cups.Remove(cups[0]);
            }
        }
        public void RemoveSugarCubesFromInventory(int sugarCubesFromDay)
        {
            for (int i = 0; i < sugarCubesFromDay; i++)
            {
                sugarCubes.Remove(sugarCubes[0]);
            }
        }

    }
}
