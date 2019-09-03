using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls_project
{
    class Game
    {
        // member variables
        string Scissors = "Scissors";
        string Paper = "Paper";
        string Rock = "Rock";
        string Lizard = "Lizard";
        string Spock = "Spock";

        Player Player1;
        Player Player2;

        // constructor

        public void NumberOfPlayer()
        {
           Player1 = new Player();


            Console.WriteLine("NumberOfPlayer");
            Console.WriteLine("TwoPlayers");
        }
        public void RunGame()
        {

            Console.WriteLine("Player 1 Turn");
            //Player 1 choose gesture

            switch (Player1.move)
            {
                case "scissors":
                    CompareMoveScissors();
                    break;
                default:
                    break;
            }

            if (Player1.move == "scissors" && Player2.move == "paper") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "rock" && Player2.move == "Scissors") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "Paper" && Player2.move == "Rock") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "rock" && Player2.move == "lizard") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "lizard" && Player2.move == "Spock") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "Spock" && Player2.move == "scissors") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "scissors" && Player2.move == "Lizard") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "Lizard" && Player2.move == "Paper") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "Paper" && Player2.move == "Spock") ;
            Console.WriteLine("PlayerOne Wins");
            if (Player1.move == "Spock" && Player2.move == "Rock")
            Console.WriteLine("playerOne Wins");

            Console.WriteLine("Player 2 Turn");  
            playerTwo = "choose gesture";
            playerOne = "choose gesture";
            if (Player2.move == "scissors" && Player1.move == "paper");
            Console.WriteLine("PlayerTwoWin");



            if (Player2.move == "paper" && Player1.move == "rock")
            {
                Console.WriteLine("PlayerTwoWin");

            } else if (Player2.move == "rock" && Player1.move == "Lizard")
            {
                Console.WriteLine("playerTwoWins");
            }
            else
            {

            }


            if (Player2.move == "Lizard" && Player1.move == "Spock") ;
            Console.WriteLine("PlayerTwoWins");
            if (Player2.move == "Spock" && Player1.move == "Scissors") ;
            Console.WriteLine("PlayerTwoWins");
            if (Player2.move == "Scissors" && Player1.move == "Lizard") ;
            Console.WriteLine("PlayerTwoWins");
            if (Player2.move == "Lizard" && Player1.move == "paper") ;
            Console.WriteLine("PlayerTwoWins");
            if (Player2.move == "Paper" && Player1.move == "Spock") ;
            Console.WriteLine("PlayerTwoWins");
            if (Player2.move == "Spock" && Player1.move == "Rock")
            Console.WriteLine("PlayerTwoWins");

            
            
            
            

            //player 2 choose gesture
            //Compare?
            //Award victor points
            //check to see if won
            //do it again if not

            //end game

        }
        

        public void CompareMoveScissors()
        {
            switch (Player2.move)
            {
                case "rock":
                    // Player 2 wins
                    break;
                case "paper":
                    // Player 1 wins
                    break;
                default:

                    break;
            }
        }

        // member methods
        public void DisplayRules()
        {
            string option = "Scissor cuts paper";
            option += "paper cover rock";
            option += "Rock crushes lizard";
            option += "Lizard poisons Spock";
            option += "Spock smashs scissors";
            option += "scissors decapitates lizard";
            option += "lizard eats paper";
            option += "paper disproves spock";
            option += "spock vaporizes rock";

            Console.WriteLine(option);
        }
    } 
}  