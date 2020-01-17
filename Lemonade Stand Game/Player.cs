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
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;


        //Constructor
        public Player()
        {
            //name = "JOE";
            //inventory = ""; 
            //wallet = 

        }
        //Member Methods (CAN DO)

        public int LemonQuantityRequested()
        {
            int lemonQuantity = 0;

            if (wallet.Money > 0)
            {
                Console.WriteLine("How many Lemons do you want?");
                try
                {
                    int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            else if (wall)
            {
                Console.WriteLine("You do not have enough money to buy that many Lemons");

            }
            return lemonQuantity;
        }
    }
}
