using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game Game = new Game();
            ////Game.StartGame();
            //Store store = new Store();

            Inventory inventory = new Inventory();
            inventory.AddLemonsToInventory(10);
            inventory.RemoveLemonsFromInventory(5);
            

        }
    }
}
