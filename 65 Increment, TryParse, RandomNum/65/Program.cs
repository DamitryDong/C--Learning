namespace _65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            // Incrementing 
            // ++ is used to increment you can put it before or after the variable, whether to put it before or after depends on whether you want the increment to happen before the line or after the line.
            Console.WriteLine($"Num is {num}");

            num++;
            Console.WriteLine($"Num is {num}");

            Console.WriteLine("Num is {0}", ++num);
            Console.WriteLine("Num is {0}", num++);  //in this case num will stay 2 until it is called upon again. 
            Console.WriteLine($"Num is {num}");


            //Decrementing 
            // -- is used to decrement, same rules appy

            Console.WriteLine($"Num is {num}");

            num--;
            Console.WriteLine($"Num is {num}");

            Console.WriteLine("Num is {0}", --num);
            Console.WriteLine("Num is {0}", num--);
            Console.WriteLine($"Num is {num}");

            // incrementing by amounts 
            // literally do +-*/ and add = and put how much
            num += 30;
            Console.WriteLine($"Num is {num}");

            num -= 10;
            Console.WriteLine($"Num is {num}");

            num *= 10;
            Console.WriteLine($"Num is {num}");

            num /= 10;
            Console.WriteLine($"Num is {num}");

            // % is Modulo which will divide and then give us remainder

            int num2 = 5;
            int num3 = 11;
            int ModuloResults = num3 % num2;
            Console.WriteLine($"Modulo of {num2} and {num3} is {ModuloResults}");

            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------

            //Try Parse 
            //TryPase will check / convert one variable intoanother, it will also return a bool depending on whether if the parse was successful. 
            Console.WriteLine("Give me a number");
            string inputString = Console.ReadLine();
            int num4;

            int.TryParse(inputString, out num4); // in this case if we put something that is a string this will result in num4 staying as 0 which is the default value of any int variable.

            //TryParse will output a bool as well (true/false) so you can set it like this 
            bool isNumber = int.TryParse(inputString, out num4);

            // we can then use this bool in a if statement and any other way you would use a bool
            if (isNumber == true)
            {
                Console.WriteLine("Well done, you entered a number");
                num4++;
                Console.WriteLine("User entered number +1 is " + num4);
            }
            else
            {
                Console.WriteLine("That was not a number");
            }


            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------

            //Generating random numbers / creating instance of the random class 
            Random random = new Random();

            //this will give us a random number between 1 and 10 
            int randomNumber = random.Next(1, 11);

            Console.WriteLine(randomNumber); 
            Console.ReadLine(); 

        }
    }
}
