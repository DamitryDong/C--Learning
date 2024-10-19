using System.Runtime.CompilerServices;

namespace _48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we can use bools for logic conditioning, in this case we set a variable to either equal false or true
            // Booleans are super valuable in deciding whether something should or should not be executed. 
            bool isRainy = false;
            bool hasUmbrella = false; 


            // When we use the if statement, if it's false, actions inside the brackets won't be execute viseversa,
            if (isRainy)
            {
                Console.WriteLine("it's rainy");
            }
            Console.WriteLine("Ay Ok!");

            /* Logical Operators: 
                    And &&
                    Or ||
                    Not !  
            */
            if (isRainy && hasUmbrella);
            {
                Console.WriteLine("I'll be protected from rain");
            }
            Console.WriteLine("Ay Ok!");

            if (!isRainy || hasUmbrella);
            {
                Console.WriteLine("I'm not getting wet");
            }
            Console.WriteLine("Ay Ok!");
            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------

            // Relational Operators < <= > >=
            int num1 = 5;
            int num2 = 6;

            // this bool will respond a true or false depending on whether the statement after the = is true or false.
            bool isGreater = num1 > num2;

            // the usecase is this 

            Console.WriteLine("how old are you?");
            int age = 0;
            age = int.Parse(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine("Go party in club!");
            }
            else if (age > 6)
            {
                Console.WriteLine("go to school");
            }
            else //else statement is exactly what is sounds like
            {
                Console.WriteLine("go to kindergarden");
            }

            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------

            // Here we can also do a Nested IF statement (if inside of a if) 
           

            Console.WriteLine("how old are you?");
            int age2 = 0;
            age2 = int.Parse(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine("Go party in club!");
                if ( age < 21 ) 
                {
                    Console.WriteLine("you can't drink though"); 
                } 
            }
            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------

            // Understanding the Scope of a variable
            // Variables inside of a If statement can only be access inside the If statement unless it was created outside the If statement in the first place
            
            //you can reset a variable just by this 
            age = 0;

            //this applies to every varible types
            // note that sometimes it's better to set variables not at the beggining to take up lest uage space since our system don't even have to think about it.

            //------------------------------------------------------------------------------------------------------------------

            //Here we combine all the skills learn together: 

            Console.WriteLine("how old are you?");
            int age3 = 0;
            age3 = int.Parse(Console.ReadLine());
           


            if (age3 >= 18)  //if they're 18 they can go party
            {
                Console.WriteLine("Go party in club!");
            }
            else if (age3 >=13)   //if they're 13 or younger we have to see if they're with their parents 
            {
                Console.WriteLine("are you with your parent answer with y or n");
                string isWithParents = Console.ReadLine();
                if (isWithParents == "y")
                {
                    Console.WriteLine("Go party with your parents!!");
                }
                else
                {
                    Console.WriteLine("go home"); 
                }
            }
            else
            {
                Console.WriteLine("go home"); 
            }
            Console.ReadKey();
        }
    }
}
