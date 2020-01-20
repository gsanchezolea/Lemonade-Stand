using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Game
{
    public class Pitcher
    {

        //Member Variables (HAS A)
        public int cupsLeftInPitcher;
        
        //Constructor
        
        public Pitcher()
        {
            cupsLeftInPitcher = 15;
        }
        //Member Methods (CAN DO)
        public void MakePitcher()
        {
            
        }
        public void PitcherForSell()
        {
            if(cupsLeftInPitcher == 0)
            {
                
            } 
        }

    }
}
