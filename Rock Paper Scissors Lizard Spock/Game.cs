using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Game
    {
        //member variables (Has A)
        Player p1;
        Player p2;



        // Constructor
        





        // member methods
        public void GameType()
        {
            Console.WriteLine("Game Type? (PVP, PVC, CVC)");
            string gameType = Console.ReadLine();
            if (gameType == "PVP")
            {
                p1 = new Human();
                p2 = new Human();

            }
            else if (gameType == "PVC")
            {

                p1 = new Human();
                p2 = new Computer();
            }
        }
        public void RunGame()
        {
            GameType();
            p1.chooseGesture();
            p2.chooseGesture();
            Console.WriteLine(p1.ChosenGesture);
            Console.WriteLine(p2.ChosenGesture);
            Compare();
            Console.ReadLine();


        }
        public void Compare()
        {
            //p1 ChosenGesture
            if (p1.ChosenGesture == "Rock" && p2.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Rock Crushes Scissors");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Scissors" && p2.ChosenGesture == "Paper")
            {
                Console.WriteLine("Scissors Cuts Paper");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Paper" && p2.ChosenGesture == "Rock")
            {
                Console.WriteLine("Paper Covers Rock");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Rock" && p2.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Rock Crushes Lizard");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Lizard" && p2.ChosenGesture == "Spock")
            {
                Console.WriteLine("Lizard Poisons Spock");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Spock" && p2.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Spock Smashes Scissors");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Scissors" && p2.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Scissors Decapitates Lizard");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Lizard" && p2.ChosenGesture == "Paper")
            {
                Console.WriteLine("Lizard Eats Paper");
                p1.score++;
            }
            else if (p1.ChosenGesture == "Paper" && p2.ChosenGesture == "Spock")
            {
                Console.WriteLine("Paper Disapproves Spock");
                p1.score++;
            }
            else if(p1.ChosenGesture == "Spock" && p2.ChosenGesture == "Rock")
            {
                Console.WriteLine("Spock Vaprozies Lizard");
                p1.score++;
            }
            //p2 ChosenGestures
            if (p2.ChosenGesture == "Rock" && p1.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Rock Crushes Scissors");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Scissors" && p1.ChosenGesture == "Paper")
            {
                Console.WriteLine("Scissors Cuts Paper");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Paper" && p1.ChosenGesture == "Rock")
            {
                Console.WriteLine("Paper Covers Rock");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Rock" && p1.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Rock Crushes Lizard");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Lizard" && p1.ChosenGesture == "Spock")
            {
                Console.WriteLine("Lizard Poisons Spock");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Spock" && p1.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Spock Smashes Scissors");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Scissors" && p1.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Scissors Decapitates Lizard");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Lizard" && p1.ChosenGesture == "Paper")
            {
                Console.WriteLine("Lizard Eats Paper");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Paper" && p1.ChosenGesture == "Spock")
            {
                Console.WriteLine("Paper Disapproves Spock");
                p2.score++;
            }
            else if (p2.ChosenGesture == "Spock" && p1.ChosenGesture == "Rock")
            {
                Console.WriteLine("Spock Vaprozies Rock");
                p2.score++;
            }
            //p1 == p2 Draw
            else if(p1.ChosenGesture == p2.ChosenGesture)
            {
                Console.WriteLine("Draw Go Again");
            }

        }

        //public int GetNumberOfPlayer()
        //{
        //    Console.WriteLine("How many?");
        //    int numberOfPlayers = int.Parse(Console.ReadLine());
        //    return numberOfPlayers;
        //}
        //public void CreatePlayers(int numberOfPlayers)
        //{
        //    if (numberOfPlayers == 1)
        //    {
        //        p1 = new Human();
        //        p2 = new Computer();
        //    }
        //    else if (numberOfPlayers == 2)
        //    {
        //        p1 = new Human();
        //        p2 = new Human();
        //    }
        //}



    }




}
