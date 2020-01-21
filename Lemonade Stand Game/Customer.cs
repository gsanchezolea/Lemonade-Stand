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
        public int customerLemonPreference;
        public int customerIceCubePreference;
        public int customerSugarCubePreference;
        public List<int> customerRecipe;
        public double customerPricePreference;
        public string customerWeatherConditionPreference;
        public List<string> customerWeatherCondition;
        public int customerTemperaturePreference;
        //Constructor   

        public Customer()

        {
            customerWeatherCondition = new List<string> { "Sunny", "Rainy", "Cloudy", "Overcast", "Hazy" };
            customerRecipe = new List<int> { customerLemonPreference, customerIceCubePreference, customerSugarCubePreference };
            customerPricePreference = 0;
            customerWeatherConditionPreference = null;
            customerTemperaturePreference = 0;
            customerSugarCubePreference = 0;
            customerLemonPreference = 0;
            customerSugarCubePreference = 0;

           
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
        //public void StandardRecipe()
        //{
        //    customerLemonPreference = 4;
        //    customerIceCubePreference = 4;
        //    customerSugarCubePreference = 4;
        //}
        public void randomCustomerTemperature(Random random)
        {
            int result;
            result = random.Next(50, 90);
            customerTemperaturePreference = result;
        }
        public void randomCustomerWeatherCondition(Random random)
        {
            int result;
            
            result = random.Next(0, 5);
            customerWeatherConditionPreference = customerWeatherCondition[result];           
        }
        public void randomCustomerPrice(Random random)
        {
            int result;
            result = random.Next(0, 3);
            if(result == 0)
            {
                customerPricePreference = 0.05; 
            }
            else if(result == 1)
            {
                customerPricePreference = 0.15;
            }
            else
            {
                customerPricePreference = 0.20;
            }
        }           
        public void randomCustomerRecipe(Random random)
        {
            for (int i = 0; i < customerRecipe.Count; i++)
            {
               customerRecipe[i] = random.Next(0, 8);
            }
        }
    }
}
