using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Wallet
    {

        //Member Variables (HAS A)
        private double money;
        public double Money;
        //Constructor
        public Wallet()
        {

            money = 20;
        }
        //Member Methods (CAN DO)
        public void PointOfSale(Player player, double moneyIn)
        {
            money = money + moneyIn; 
                
        }
        


        
    }
}
