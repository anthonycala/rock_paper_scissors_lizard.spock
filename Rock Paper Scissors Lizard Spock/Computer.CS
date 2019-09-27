using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Computer : Player
    {
        
        //member variables (Has A)


        public override void chooseGesture()
        {
            Random rng = new Random();
            int num = rng.Next(5);
            ChosenGesture = Gestures[num];

        }
        public override void chooseName()
        {

        }
        
        // Constructor






        // member methods
    }
}
