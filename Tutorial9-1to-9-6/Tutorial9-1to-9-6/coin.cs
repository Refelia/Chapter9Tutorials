using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9_1to_9_6
{
    class coin
    {
        //Field to represent to represent side facing up.
        private string sideUp;
        Random rand = new Random();

        //Constractor
        public coin()
        {
            sideUp = "Heads";
        }

        //The toss  method simulates to tossing the coin.
        public void Toss()
        {
            //Create a random object.
          // Random rand = new Random();

            //Use the random  number to determine the side of the coin is facing up.
             //Heads = 0;
             //tails = 1;

            if(rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        //The GetSidUp method returns the value of the sideUp field.
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
