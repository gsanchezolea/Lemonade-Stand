using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Player
    {

        //Member Variables (HAS A)
        public string name;

        
        public Wallet wallet;
        public Inventory inventory;
        public Pitcher pitcher;


        //Constructor
        public Player()
        {
            name = "JOE";

            //wallet = 
            wallet = new Wallet();
            inventory = new Inventory();
            pitcher = new Pitcher();
        }
        //Member Methods (CAN DO)
       
        
    }
}
