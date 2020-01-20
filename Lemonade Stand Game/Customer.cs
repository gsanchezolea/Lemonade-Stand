using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Customer
    {

        //Member Variables (HAS A)
        public string name = "customer";
        public int numOfLemons;
        public int numOfIceCubes;
        public int numOfSugarCubes;
        //Constructor
        public Customer(Random random)
        {

        }
        //Member Methods (CAN DO)

            /// <summary>
            /// have a method that takes in the recipe and weather for the current day
            /// if the weather is poor then generate less of a random chance to buy
            /// if the weather is nice generate high chance to buy
            /// if the price per cup is overpriced dont buy
            /// if the price per cup is priced well higher chance of buyings
            /// 
            /// </summary>
            /// 
        public void StandardRecipe()
        {
            numOfLemons = 4;
            numOfIceCubes = 4;
            numOfSugarCubes = 4;
        }
        public void randomTemp(Random random)
        {
            
        }
        public void randomCondition(Random random)
        {
            
        }
        public void randomMoney(Random random)
        {
            if ()
            {

            }
        }
        public void randomRecipe(Random random)
        {
        
        }
    }
}
