using System;
namespace guessME
 {
    class program
    {
        static void Main(string[] args)
        {
           int secretNumber == new Random().Next(1,11);
            int attempts = 3;
            int myattempts = 0;
            Console.WriteLine("Welcome to the Game. Guess the correct number to win the match");

            while(attempts > myattempts)
            {
                Console.WriteLine("Choose a Number");
                int myGuess = Console.ReadLine();

                if(secretNumber > myGuess)
                {
                    Console.WriteLine("The number is Lower");
                }
                else if(secretNumber < myGuess)
                {
                    Console.WriteLine("The number is Higher");
                }
                else(secretNumber == myGuess)
                {
                    Console.WriteLine("You Guessed Right in" + myattempts + "attempts");
                }
                if(attempts == myattempts)
                {
                    Console.writeLine("You lost the match.The correct answer is"+ secretNumber + "Sharp your mind and play agains")
                }
            }

        }
    }
 }