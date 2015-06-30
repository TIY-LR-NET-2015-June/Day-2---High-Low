using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            // ! Generate a Random number between 1 and 100 called 'generatedNumber'
            Random numberGenerator = new Random();
            int generatedNumber = numberGenerator.Next(1, 101);

            Console.WriteLine("High/low guessing game copyrighted 2015 by Daniel Pollock");


            while (true)
            {
                Console.WriteLine("Please make a guess:");
                string userNumber = Console.ReadLine();
                int parsedNumber = int.Parse(userNumber);
                if (parsedNumber < generatedNumber)
                {
                    Console.WriteLine("Your guess is to low. Try Again.");
                    continue;
                    //print a message to low and continue
                }

                if (parsedNumber > generatedNumber)
                {
                    Console.WriteLine("Your guess is to damn HIGH. Try Again.");
                    continue;
                    //print a message to high and continue
                }

                if (parsedNumber == generatedNumber)
                {
                    Console.WriteLine("BINGO! You guessed it.");
                    Console.ReadLine();
                    break;
                    //print a message that they guessed right and break out of the loop
                }

            }

            Console.WriteLine("Game Over Man!");
            Console.ReadLine();

            // ! LOOP
            // ! Ask for a number from the user and store that to a variable called 'userNumber'
            // ! conver that userNumber to an actual number
            // ! Check if 'usernumber' is high or lower and print message if so and continue loop "continue;"
            //  ! If usernumber is equal to generated number then say "Bingo" and exit this loop "break;"

            //END LOOP 

            //!Game exit message
        }
    }
}
