namespace _70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loops are used to run a code on repeat 
           
            /*this is a for loop which has the format for (initialization ; condition ; iteration) {code to apply for each} 
             initialization is executed once before the loop begins and usually sets a control variable
             condition is evaluated beore each iteration, and if the condition is "true" the loop will execute until it is false
             Iteration is what is done after the condition is executed, most of the time it increments the variable to repeat the loop*/

            for (int counter = 0; counter <= 10 ; counter++) // so here the counter will +1 each time the console.writeLine is run until counter is not <= 10. 
            {
                Console.WriteLine("I is " + counter); 
            }
            Console.ReadKey();


            // count down for loop
            for (int counter = 10; counter >= 1; counter--) 
            {
                Console.WriteLine("I is " + counter);
            }
            Console.ReadKey();

            //--------------------------------------------------------------------------------------------------------------------

            string myString = "hi \nHi"; // the \n is like pressing the enter key going to the next line this is called a "escape character"
            Console.Write(myString);
            
            // Thread.sleep will freeze the system from doing anything in milliseconds
            Thread.Sleep(1000);

            //--------------------------------------------------------------------------------------------------------------------
            
            //rocket loop fun (landing a rocket)
            string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

            for (int counter = 0; counter <= 10; counter++)
            {
                Console.Clear();
                Console.Write($"counter leve {counter}"); 
                Console.Write(rocket);
                rocket = "\n" + rocket;              //this part makes sure that rocket goes down one line for each time the loop runs
                Thread.Sleep(1000); 
            }

            Console.WriteLine("\nBooooom it landed"); 

            Console.ReadKey();



        }
    }
}
