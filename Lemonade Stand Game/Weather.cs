using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Weather
    {

        //Member Variables (HAS A)
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        public  Random ran;
        public string predictedForecast;
        public int predictedTemperature;


        //Constructor
        public Weather()
        {
           
            weatherConditions = new List<string> { "Sunny", "Rainy", "Cloudy", "Overcast", "Hazy" }; 
        }
        public void WeatherForTheDay(Random random)
        {
            int result;
            result = random.Next(0, 5);
            condition = weatherConditions[result];
        }
        public void TemperatureForTheDay(Random random)
        {
            temperature = random.Next(50, 90);
            
        }

        //Member Methods (CAN DO)
       
        
        public void  ForecastedCondition(Random random)
        {
            int condition = ran.Next(1,6);
            switch (condition)
            {
                case 1:
                    this.condition = "Sunny";
                    break;
                case 2:
                    this.condition = "Rainy";
                    break;
                case 3:
                    this.condition = "cloudy";
                    break;
                case 4:
                    this.condition = "Overcast";
                    break;
                case 5:
                    this.condition = "Hazy";
                    break;
                default:
                    break;
            }
        }
        public void ForecastedWeather()
        {
            ///to do random choose a days weather//
            int result;
            result = temperature + 5;
            Console.WriteLine("The forecast for tomorrow is: " + condition +" and " + result + " degrees. ");
            temperature = result - 5;

        }

        public void DisplayWeather()
        {
            Console.WriteLine("The weather condition for today is:" + condition);
            Console.WriteLine("The temperature for today is:" + temperature);
           
            Console.ReadLine();
            
            
        }

    }
}
