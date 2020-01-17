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

        //Methods for Adding to Inventory
        public void AddingLemonsToInventory(int lemonsFromStore)
        {            
            for (int i = 0; i < lemonsFromStore; i++)
            {
                lemons.Add(new Lemon());
            }
            
        }
        public void AddingIceCubesToInventory(int iceCubesFromStore)
        {
            for (int i = 0; i < iceCubesFromStore; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }
        public void AddingCupsToInventory(int cupsFromStore)
        {
            for (int i = 0; i < cupsFromStore; i++)
            {
                cups.Add(new Cup());
            }
        }
        public void AddingSugarCubesToInventory(int sugarCubesFromStore)
        {
            for (int i = 0; i < sugarCubesFromStore; i++)
            {
                sugarCubes.Add(new SugarCube());
            }
        }

        //Methods for Removing from Pitcher Ingredients from Inventory
       
    }
}
