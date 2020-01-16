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
        public Day()
        {
            
        }
        public void displayWeather(int t1,string c1)
        {
            string condition = c1;
            int temperature = t1;
            Console.WriteLine("The weather condition for today is:" + condition);
            Console.WriteLine("The temperature for today is:" + temperature);
            Console.ReadLine();
           
        }
    }
}
