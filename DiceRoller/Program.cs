using System;

namespace DiceRoller
{
    class Program
    {
        //Random instance that is going to be used throughout the program. 
        public static Random rnd = new Random();


        static void Main(string[] args)
        {
            //Welcome the user to Grand Circus 
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            //Ask the user how many dies they want
            Console.Write("How many sides should each die have? ");
            //Create the variable the users input will be stored in
            int userFinalInput;
            var userInput = Console.ReadLine();
            //Create the statement to receive their input and check for incorrect inputs
            bool userConvert = int.TryParse(userInput, out userFinalInput);

            if (userConvert)
            {

            }
            else
            {
                Console.WriteLine("Please enter a number 1 - 12."); 
            }



            //First roll
            Console.Write("Roll 1: ");
            Console.WriteLine();
            //Create a loop to repeat rolls if the user wants to
            bool choice = true;
            do
            {
                var firstDie = Program.firstNumber(userFinalInput);
                var secondDie = Program.firstNumber(userFinalInput);
                var sum = firstDie + secondDie;
 
                //Insert what the user rolled below
                Console.WriteLine($"You rolled a {firstDie} and a {secondDie} ({sum} total)");
                //Ask the user if they want to roll again
                Console.Write("Roll again? (y/n): ");

                //Record the users response
                var userResponse = Console.ReadLine();

                //Print out a statement if user selects 6 
                if (userFinalInput == 6)
                {
                    var six = SixSide(firstDie, secondDie);
                    Console.Write(six);

                }
                if (userFinalInput >= 1 && userFinalInput <= 12)
                {
                    var random = DiceCombo(firstDie, secondDie);
                    Console.Write(random);
                }


   

                //Create a rule for if they enter y or n
                if (userResponse == "y")
                {

                }
                else if (userResponse == "n")
                {
                    Console.WriteLine("Thanks for playing!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");
                }

                //Second Roll
                Console.WriteLine("Roll 2: ");





            } while (choice == true);

            
            
        }

        

        //Use a static method to generate the first random number
         public static int firstNumber(int userInput)
        {

            return rnd.Next(1, userInput); 
            
        }


        //Method for six-sided dice only that takes into dice values as parameters
        public static string SixSide(int dice1, int dice2)
        {
         
            int sum = dice1 + dice2; 
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes"); 
            }
            else if (dice1 == 1 && dice2 == 2)
            {
                Console.WriteLine("Ace Deuce"); 
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("Box Cars"); 
            }
            else if (sum == 7 || sum == 11)
            {
                Console.WriteLine("Win"); 
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                Console.WriteLine("Craps"); 
            }
            else
            {
                Console.WriteLine(" "); 
            }
            return "";    
        
        }

        public static string DiceCombo(int combo1, int combo2)
        {
            int sum = combo1 + combo2; 
            int comboSum = combo1 + combo2;
            if (combo1 == 1 && combo2 == 6)
            {
                Console.WriteLine("You are a lucky person"); 
            }
            else if (combo1 == 3 && combo2 == 7)
            {
                Console.WriteLine("You are the best!"); 
            }
            else if(combo1 == 6 && combo2 == 6)
            {
                Console.WriteLine("You got this!"); 
            }
            else if(combo1 == 2 && combo2 == 2)
            {
                Console.WriteLine("Doubles"); 
            }
            else if(combo1 == 3 && combo2 == 3)
            {
                Console.WriteLine("Triple"); 
            }
            else if(combo1 == 1 && combo2 == 2)
            {
                Console.WriteLine("Lucky you"); 
            }
            else if (combo1 == 1 && combo2 == 1)
            {
                Console.WriteLine("Keep rolling"); 
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                Console.WriteLine("Luck is not on your side");
            }
            return ""; 
        }
    }
}
