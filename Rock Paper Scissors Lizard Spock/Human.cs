using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
        
{
    class Human : Player
    {
        //member variables (Has A)
     



        // Constructor






        // member methods

        public override void chooseGesture()
        {
            Console.WriteLine(" Choose a gesture");
                gesture = Console.ReadLine();

        }
        public override void chooseName()
        {
            Console.WriteLine("Choose a Name");
                name = Console.ReadLine();
            
            
            }




    }
}
