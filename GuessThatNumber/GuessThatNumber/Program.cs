using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    public class Program
    {
        //this is the number the user needs to guess.  Set its value in your code using a RNG.
        static Random rng = new Random();
        static bool gamePlaying = true;
        static int roundCounter = 0;
        static int numberToGuess = 0;
        static int userGuess = validInput;
       
        static void Main(string[] args)
        {

            numberToGuess = rng.Next(1, 101);
            
            
            Console.ReadKey();

          
        }
        
        public static void getUserInput()
        {
            Console.WriteLine("Enter any number from 1 - 100 Holmes!");
            string userInput = Console.ReadLine();

            if (ValidateInput(userInput))
            {
                
            }

        }

        public static bool ValidateInput(string userInput)
        {
            int validInput = 0;

            if (int.TryParse(userInput, out validInput))
            {
                if (validInput >= 1 && validInput <= 100)
                {
                    //is a number
                    return true;
                }
                else
                {
                    //not between 1 and 100
                    return false;
                }
            }
            else
            {
                //not a number 
                return false;
            }
        }




            //for (int i = 0; i < userInput.ToLower().Length; i++)
            //{
            //    if (char.IsNumber(userInput[i]))
            //    {
            //        //is a number
            //        return true;
            //    }
            //    else
            //    {
            //        //is not a number
            //        return false;
            //    }
            //}
            //    //check to make sure that the users input is a valid number between 1 and 100.
            //    return true;
        }

        public static void SetNumberToGuess(int number)
        {
            //TODO: make this function override your global variable holding the number the user needs to guess.  This is used only for testing methods.
            numberToGuess = number;
        
        }


       public static bool IsGuessTooHigh(int userGuess)
        {
            
           return validInput > numberToGuess;

            //while (gameIsPlaying)
            //{

            //        if (validInput == numberToGuess)
            //            {
            //                Console.WriteLne("Youre win dawg!!!")
            //                //player wins the game
            //                gamePlaying = false;
            //                return true,
            //            }
            //        else 
            //            {
            //                //number does not equal number to guess 
            //                 return false,
            //            }

            //        if (validInput > numberToGuess)
            //            {
            //                Console.WriteLine("seriously bro, youre too high!")
            //                return true;
            //            }
            //        else
            //            {
            //                //number is not too high
            //                return false;
            //            }
            //    //game is stil playing
            //    return true;
            //}
            //    //isGuessTooHigh is true 
            //    return true;
        }

        public static bool IsGuessTooLow(int userGuess)
        {
           return validInput < numberToGUess;
             
    //        while (gameIsPlaying)
    //        {

    //            if (validInput < numberToGuess)
    //                {
    //                    Console.WriteLine("Youre lower than a lowRider Homes!")
    //                    return true;
    //                }
    //            else
    //                {
    //                    //number is not too low
    //                    return false;
    //                }
           
            
    //        //TODO: return true if the number guessed by the user is too low
    //      }
    //return true; 
        }
}


