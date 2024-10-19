using System.Security.Cryptography;

namespace _75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The While Loop
            // you can do same thing as a IF loop but while loops excel at certain tasks
            int counter = 0;
            while (counter < 10)         //condition
            {
                Console.WriteLine(counter);         //way to cancel condition
                counter++;
            }

            //this is where counter statements really shine: when what needs to be check to countinue the loop is evaluated during runtime. 
            // his case we wrote a code that allows for the loop "go for a mile" until the user stops saying "go" 

            Console.WriteLine("Enter go or stay"); 

            string userChoice = Console.ReadLine(); 

            while (userChoice == "go")
            {
                Console.WriteLine("Go for a mile");
                Console.WriteLine("Wanna keep going? Enter go"); 
                userChoice = Console.ReadLine(); 
            }

            Console.WriteLine("you've stayed!"); 
            Console.ReadKey();

            //Here we are using the same concept but for looping a guess the number game. 
            //we generate a random number and prompt user to guess. the systems is coded to tell if the number is low or high 
            Random random = new Random();

            int secretNumber = random.Next(1,101);
            int userguess = 0;
            int guessCounter = 1;
            Console.WriteLine("Guess the number I'm thinking of between 1 and 100");

            userguess = int.Parse(Console.ReadLine());

            while (userguess != secretNumber)
            {
                guessCounter++;
                Console.WriteLine("Incorrect");
                Console.WriteLine("Try again!");
                if (userguess < secretNumber)
                {
                    Console.WriteLine("try guessing a larger number");
                }
                else
                {
                    Console.WriteLine("try guessing a lower number");
                }
                userguess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"That is correct, {secretNumber} is the right nummber! You took {guessCounter} guesses total.");
            Console.ReadKey();
        }
    }
}
