using System.Text.Json.Serialization;

namespace _115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Public and Private class meaning 
            // PUBLIC means you can access it throughout other class 
            // PRIVATE means that you can only access it in that class
            
            // (usually you make your variables in classes private and property public since you want to place rules on get and set for variables) 
            // (logically methods and constructors are usually public too) 
            
            
            //----------------------------------------------------------------------------------------------------------------------------
            //naming parameters 
            //all of these return the same thing but we do this to make things more readable especially when there's alot of parameters.

            Console.WriteLine(AddNum(15, 25));

            Console.WriteLine(AddNum(firstnum: 23, secondNum: 25));  

            Console.WriteLine(AddNum(firstnum: 23, 25));

            Console.WriteLine(AddNum(23, secondNum: 25));

            Console.ReadKey();
            //----------------------------------------------------------------------------------------------------------------------------
            //computed properties using a class 

            Rectangle Rec1 = new Rectangle();

            Rec1.Width = 5;
            Rec1.Height = 5;
            Console.WriteLine($"The Area of Rec1 is {Rec1.Area}");


            //----------------------------------------------------------------------------------------------------------------------------  STATIC KEYWORD

            /*
             1. Static Fields: Used to store data that is shared among all instances of the class. For example, you might use a static field to count how many instances of a class have been created or to hold configuration information that applies to all objects of that type.

            2. Static Methods: Methods that do not operate on instance data. These methods belong to the class itself and can only access other static members of the class. They are typically used for utility functions that do not require any object state from the class to perform their tasks.

            3. Static Properties: Like static methods, these properties are related to the class, not to any instance. They can be used to control access to static data or to provide properties that apply globally to the class.

            4. Static Constructors: A special type of constructor that initializes static members of the class. This constructor is called automatically and exactly once, before any static members are accessed or an instance of the class is created.

            5. Static Classes: You can also declare an entire class as static. This is often done for utility classes where you want to group related static methods (like a mathematical utility class) without allowing instantiation of the class.
             */

            //satic Methods

            Rectangle.Dosomething();  //here we used the static method, note we don't even need to create a object to use this ** NOTE that therefore static methods cannot be called on objects 
                                      // also note that the Readkey and WriteLine are both static methods themself. 

            Doseomthinginsideprogram(); // this is also a static method but since its inside the cs we don't need to put the class name. 

            Console.ReadKey();

            //static Fields (variable)

            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            Rectangle rectangle3 = new Rectangle(17,16);

            Console.WriteLine($"Number of cars produced: {Rectangle.NumberOfRectangles}");    //here we used the static variable and called it 

        }

        static int AddNum(int firstnum, int secondNum)
        {
            return firstnum + secondNum;

           

        }

        public static void Doseomthinginsideprogram()
        {
            Console.WriteLine("this is the one called inside"); 
        }


    }

}
