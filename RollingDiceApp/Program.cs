/*Class name: Rolling Dice Application
  Programmer: Ivoire Morrell
  Date: October 16th, 2019
  Description: The rollin dice application is a dice rollin simulator that 
  allows the user to enter the number of sides on a dice and return the dice numbers when rolled
 */

using System;

namespace RollingDiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            int diceOne;
            int diceTwo;
            int sides;
            string userChoice;
            bool ok = true;
            bool reRoll = true;
            int rollNumber = 0;

            //Welcome the user to the program
            Console.WriteLine("Welcome to the World Series of rolling dice! \n");

            //use while loop to see if user wants to continue program
            while(ok)
            {
                //bool reRoll = true;
                while (reRoll == true)
                {

                    //ask the user if they would like to roll the dice
                    Console.WriteLine("Would you like to roll the dice? (y/n) \n");

                    //gather the users input
                    userChoice = Console.ReadLine();

                    Console.WriteLine();

                    //verify the users input using switch statement
                    if (userChoice == "y" || userChoice == "Y")
                    {
                        //ask the user how many side are their for the dice
                        Console.WriteLine("How many sides should each die have? \n");

                        //enter the number of sides
                        sides = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        //call the rollDice method to roll the dice
                        diceOne = rollDice(sides);
                        diceTwo = rollDice(sides);

                        //increment the roll number
                        rollNumber += 1;

                        //display the dice roll
                        Console.WriteLine("Roll: " + rollNumber + "\n");
                        Console.WriteLine(diceOne);
                        Console.WriteLine(diceTwo);

                        Console.WriteLine();

                        //switch reroll to false
                        reRoll = false;
                    }
                    else if (userChoice == "n" || userChoice == "N")
                    {
                        //Display message
                        Console.WriteLine("No roll! Guess you're scared to lose! \n");
                        reRoll = false;
                    }
                    else
                    {
                        //user enter the wrong input. Prompt them to enter again
                        Console.WriteLine("Wrong input! Try again. \n");
                        reRoll = true;

                    }
                }

                // set reRoll back to true
                reRoll = true;

                //ask the user if they would like to roll again
                ok = getContinue();

                Console.WriteLine();

            }

        }

        //the static roll dice method generates random numbers based off the number of sides entered by the user
        public static int rollDice(int sides)
        {
            //create varible to return number of sides
            int number;

            //create Random variable which will be used to generate random number
            var Random = new Random();

            //use the Random class to create dice rolling simulation
            number = Random.Next(1, sides + 1);

            return number;
        }

        //this method is used to determine if the user wants to continue within a loop
        public static bool getContinue()
        {
            //create variables
            String choice;
            bool ok = true;
            bool result = true;

            //create while loop to determine if user wants to continue
            while (ok)
            {
                Console.WriteLine("Roll again? (y/n): \n");

                //retrieve user input
                choice = Console.ReadLine();

                //determine the users input and return corresponding message
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    //user wants to continue. exit the while loop and return true
                    ok = false;
                    result = true;
                }
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    //user does not want to continue
                    ok = false;
                    result = false;
                }
                else
                {
                    //user did not enter y or n
                    Console.WriteLine("Error! Please enter Y or N. Please enter correct input \n");

                }

            }

            return result;
        }
    }
}
