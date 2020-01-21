using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Day
    {

        //Member Variables (HAS A)

        //public Weather weather;
        public List<Customer> customers;
        //Constructor

        //Member Methods (CAN DO)
        public Day(Random rng)
        {
            weather = new Weather(rng);
            customers = new List<Customer>();

        }

        public void RunDay()
        {
           // weather.displayWeather();
            //// mini master setup the day /////
            ///


        }
        public void CheckEachCustomer(Customer customer)
        {
            foreach(string customertype in customers)
            {

            }
        }
        public bool CompareRecipeLemon(Recipe recipe, Customer customer)
        {
            if (recipe.amountOfLemons == customer.customerLemonPreference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CompareRecipeIceCube(Recipe recipe, Customer customer)
        {
            if (recipe.amountOfIceCubes == customer.customerIceCubePreference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CompareRecipeSugarCube(Recipe recipe, Customer customer)
        {
            if (recipe.amountOfSugarCubes == customer.customerSugarCubePreference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CompareRecipe(Recipe recipe, Weather weather, Customer customer)
        {
            bool iceCube;
            bool lemon;
            bool sugar;

            iceCube = CompareRecipeIceCube(recipe,customer);
            lemon = CompareRecipeLemon(recipe,customer);
            sugar = CompareRecipeLemon(recipe, customer);

            if (iceCube && lemon && sugar)
            {
                return true;
            }
            else if(lemon & sugar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ComparePrice(Recipe recipe, Customer customer)
        {
            if(recipe.pricePerCup <= customer.customerPricePreference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CompareWeather(Weather weather, Customer customer)
        {
            if(weather.condition == customer.customerWeatherConditionPreference)
            {
                return true;
            }
        }

        public void CheckPreferences()
        {
            if()
        }
        public void ComparePreferences(Recipe recipe, Weather weather, Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (recipe.amountOfIceCubes == customers[i].customerIceCubePreference && recipe.amountOfLemons == customers[i].customerLemonPreference && recipe.amountOfSugarCubes == customers[i].customerSugarCubePreference)
                {
                    if  (weather.temperature >= customers[i].customerTemperaturePreference)
                    {
                        if (weather.condition == "Sunny")
                        {
                            if (recipe.pricePerCup <= customers[i].customerPricePreference)
                            {
                                //transaction happens
                            }
                            
                        }
                    }
                }
                else if (recipe.amountOfIceCubes == customers[i].customerIceCubePreference && recipe.amountOfLemons == customers[i].customerLemonPreference)
                {
                   if (weather.temperature >= customers[i].customerTemperaturePreference)
                    {
                        if (weather.condition == "Rainy")
                        {
                            if (recipe.pricePerCup <= customers[i].customerPricePreference)
                        }
                    }
                }
            }
        }

        public void 
        if(actual price is <= customer price)
            if(actual weather condition is == sunny)
                if(actual temperature is >= 68)
                    if(actual recipe == customer recipe)
                    else if(actual recipe + 1 == customer recipe)
                            {gives money to player}
                    else 
                            player doesnt receive money
            else if(actual weather condition is == customer customer)//cloudy
                    if(actual temperature is >=72)
                        if(actual recipe == customer recipe)
                        else if(actual recipe + 1== customer recipe)
                    
        else
            customer doesnt buy
}
}
