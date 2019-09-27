using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    abstract class Player
    {

        //member variables (Has A)
        public int score;
        public string name;
        public List<string> Gestures;
        public string ChosenGesture;

        // Constructor
        public Player()
        {
            Gestures = new List<string>();
            Gestures.Add("Rock");
            Gestures.Add("Scissors");
            Gestures.Add("Paper");
            Gestures.Add("Lizard");
            Gestures.Add("Spock");
            
        }





        // member methods (can do)


        public abstract void choosenGesture();
    
            
        public abstract void chooseName();






    }
}
