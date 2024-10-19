using System.Diagnostics.Tracing;

namespace _93
{
    internal class Program
    {
        int myResult;  // this becomes global when you put it outside the method, this is a field which you can carry into each method
        static void Main(string[] args)
        {
            // It is not good practice to put methods inside another method, so instead put the method outside
            //instead this time we put the methods outside of the Main method.
            
            int myResult = AddTwoValues(1, 3);
            Console.WriteLine(myResult);

            
        }

        //we have to use static so we can run the method without degining the program as an instance. 
        static int AddTwoValues (int a, int b)
        {
            int myResult = a + b;
            return myResult;
        }

       static int SubtractTwoValues (int a, int b)
        {
            int result = a - b;
            return result;
        }


    }
}
