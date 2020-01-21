using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Game Game = new Game();
            Weather weather = new Weather();
            Random random1 = new Random();
            weather.ForecastedTemp(random1);
            Game.StartGame();
            Store store = new Store();



        }
    }
}
