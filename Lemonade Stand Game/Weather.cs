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


        //Constructor
        public Weather(Random random)
        {
            int result;
           
            ran = random;
            weatherConditions = new List<string> { "Sunny", "Rainy", "Cloudy", "Overcast", "Hazy" };
            result = ran.Next(0, 5);
            condition = weatherConditions[result];
             
            temperature = ran.Next(50,90);
            

        }

        //Member Methods (CAN DO)
        public void determineWeather()
        {
            ///to do random choose a days weather//
           

        }

        public void displayWeather()
        {
            Console.WriteLine("The weather condition for today is:" + condition);
            Console.WriteLine("The temperature for today is:" + temperature);
            Console.ReadLine();
            //foreach (string weathercondition in weatherConditions)
            //{
            //    Console.WriteLine(weathercondition);
            //}
            ///
            ////////////////still need to setup predicted forecast////////////
        }

    }
}
