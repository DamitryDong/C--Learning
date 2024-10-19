using System.Transactions;

namespace _79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //This is a do-while loop.The test for conditions afters post-test which means it will run the code at lease once. 
            // This loop right here will prompt the user to enter a positive whole number and will keep asking until they do. 
            int number;
            do
            {
                Console.WriteLine("Enter a positive whole number");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);  //condition
            Console.ReadKey();


            //here we are making a average calculator
            int currentScore;
            int sum = 0;
            int counter = 0;

            do
            {
                Console.WriteLine("Enter your students score. Enter -1 to finish");
                currentScore = int.Parse(Console.ReadLine());
                if (currentScore != -1)     //this if statement will makesure -1 (finish) won't be added in for the average.
                {
                    sum = sum + currentScore;
                    counter++;
                }
            }
            while (currentScore != -1);   // this loop will keep going until we put -1 

            int average = sum / counter;

            Console.WriteLine($"The average is {average}");
            Console.ReadKey();

            //--------------------------------------------------------------------------------------------------------
            //here we will talk about breaks and continues in loops

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i== 3)
                {
                    Console.WriteLine("I've had enough");
                    break;       // break will stop the rest of the loop from running so his will wned at 3
                }
            }
            //here we will be using a continue
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("I've had enough");
                    continue;    // continue will stop everything happening after this line for the loop but will not stop the whole loop from finishing.
                }
            Console.WriteLine("only if not continue");
            }
            Console.ReadKey();
        }
    }
}
