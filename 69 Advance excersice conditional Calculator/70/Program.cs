using System.Runtime.ConstrainedExecution;

namespace _70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalOutput = 0;
            bool invalid = false;

            Console.WriteLine("Enter the first number:");
            string num1 = Console.ReadLine();
            int intNum1 = int.Parse(num1);

            Console.WriteLine("Enter the second number:");
            string num2 = Console.ReadLine();
            int intNum2 = int.Parse(num2);

            Console.WriteLine("Choose an operation: +, -, *, /");
            var Operator = Console.ReadLine().Trim();
            
            if (Operator == "+" )
            {
                finalOutput = intNum1 + intNum2;
            }
            else if (Operator == "-" )
            {
                finalOutput = intNum1 - intNum2;
            }
            else if (Operator == "*" )
            {
                finalOutput = intNum1 * intNum2;
            }
            else if (Operator == "/" )
            {
                bool equalZero = intNum2 == 0;
                if (equalZero == true)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    invalid = true;
                }
                else
                {
                    finalOutput = intNum1 / intNum2;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                invalid = true;
            }

            if (invalid == false)
            {
                Console.WriteLine($"Result: {finalOutput}");
            } 

            Console.ReadLine();
        }
    }
}
