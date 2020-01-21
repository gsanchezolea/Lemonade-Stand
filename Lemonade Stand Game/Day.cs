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

        public Weather weather;
        public List<Customer> customers;
        //Constructor

        //Member Methods (CAN DO)
        public Day(Random random)
        {
            weather = new Weather(random);
            customers = new List<Customer>();

        }

        public void RunDay(Weather weather, Store store, Player player, Recipe recipe, Random random)
        {
            weather.WeatherForTheDay();
            weather.ForecastedWeather();
            store.VisitStore(player, recipe);
            InstatiateCustomers(random);

            weather.DisplayWeather();


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

            iceCube = CompareRecipeIceCube(recipe, customer);
            lemon = CompareRecipeLemon(recipe, customer);
            sugar = CompareRecipeLemon(recipe, customer);

            if (iceCube && lemon && sugar)
            {
                return true;
            }
            else if (lemon & sugar)
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
            if (recipe.pricePerCup <= customer.customerPricePreference)
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
            if (weather.condition == customer.customerWeatherConditionPreference)
            {
                return true;
            }
            else
            {
                return true;

            }
            return false;
        }


        public void ComparePreferences(Recipe recipe, Weather weather, Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (recipe.amountOfIceCubes == customers[i].customerIceCubePreference && recipe.amountOfLemons == customers[i].customerLemonPreference && recipe.amountOfSugarCubes == customers[i].customerSugarCubePreference)
                {
                    if (weather.temperature >= customers[i].customerTemperaturePreference)
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

                            if (recipe.pricePerCup <= customers[i].customerPricePreference) ;

                        }
                    }
                }
            }
        }
        public void InstatiateCustomers(Random random)
        {
            int result;
            result = random.Next(1, 100);

            for (int i = 0; i < result; i++)
            {
                customers.Add(new Customer());
            }
        }
    }
}





