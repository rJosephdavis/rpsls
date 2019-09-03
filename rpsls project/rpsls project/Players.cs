using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls_project
{
    public class Player
    {
        public string name;
        public string move;
        public Player()
        {
            Console.WriteLine("PlayerOne.turn");
            Console.WriteLine("PlayerTwo.turn");
            Console.WriteLine("ForTheWin");
        }

        public void ChooseGesture()
        {
            List<string> Player1Gesture = new List<string>();
            Player1Gesture.Add("Scissor");
            Player1Gesture.Add("Paper");
            Player1Gesture.Add("Rock");
            Player1Gesture.Add("Lizard");
            Player1Gesture.Add("Spock");
            Console.WriteLine(Player1Gesture);

            List<string> Player2Gesture = new List<string>();
            Player2Gesture.Add("Scissor");
            Player2Gesture.Add("Paper");
            Player2Gesture.Add("Rock");
            Player2Gesture.Add("Lizard");
            Player2Gesture.Add("Spock");
            Console.WriteLine(Player2Gesture);


            // Need to assign players gesture
            // Dont forget to override in Human an AI
        }





    }
}










    




        

        

        



















    





















     