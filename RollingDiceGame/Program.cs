using System;

namespace DiceRolling
{
    class Program
    {
        // int userDiceSideInput;


        static void Main(string[] args)
        {

            RollingDiceGame();

        }

        //Methods

        static void RollingDiceGame()
        {

            //int userDiceSideInput;
            string userDiceSideInput;
            int outputValue;
            // Console.WriteLine("Welcome to the Grand Circus Casino!");
            bool yn = false;

            while (yn != true)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("How many side should each dice have?");
                // userDiceSideInput = Int32.Parse(Console.ReadLine());
                userDiceSideInput = Console.ReadLine();

                //if (userDiceSideInput>0)
                //{

                if (int.TryParse(userDiceSideInput, out outputValue))
                {
                    DiceSides(outputValue);
                    //  Console.WriteLine("Would you like to roll the dice again? (y/n) ");

                    //string rollAgain = Console.ReadLine().ToLower();
                    bool invalidInput = false;
                    while (invalidInput != true)
                    {
                        Console.WriteLine("Would you like to roll the dice again? (y/n) ");
                        string rollAgain2 = Console.ReadLine().ToLower();
                        if (rollAgain2 == "n")
                        {
                            yn = true;
                            invalidInput = true;
                        }
                        else if (rollAgain2 == "y")
                        {
                            invalidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invaid option please input only Y or N");
                        }

                        //}
                    }
                }
                else
                {
                    Console.WriteLine("That was an invalid integer Please choose only numbers between 1 and 6");
                }








                //if (rollAgain == "n")
                //{
                //    yn = true;
                //}

            }

        }


        static int DiceSides(int diceSideInput)
        {



            if (diceSideInput >= 1 && diceSideInput <= 6)
            {
                var rand = new Random();

                int firstDice = rand.Next(diceSideInput);

                int secondDice = rand.Next(diceSideInput);

                int total = firstDice + secondDice;

                Console.WriteLine($"You rolled a {firstDice} and a {secondDice} and the Total is {total}");

                if (firstDice == 1 && secondDice == 1)
                {
                    Console.WriteLine("Snake Eyes: Two 1s");
                }

                if (firstDice == 1 && secondDice == 2)
                {
                    Console.WriteLine("Ace Deuce: A 1 and 2");
                }

                if (firstDice == 6 && secondDice == 6)
                {
                    Console.WriteLine("Box Cars: Two 6s");
                }
                if (total == 7 || total == 11)
                {
                    Console.WriteLine("Win A total of 7 or 11");
                }

                if (total == 2 || total == 3 || total == 12)
                {
                    Console.WriteLine("Craps: A total of 2,3 or 12");
                }
            }
            else
            {
                Console.WriteLine("Sorry the input was not in the range between 1 and 6");
            }
            return diceSideInput;
        }

    }


}











