using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Methods: a code block that contains a series of statememts Syntax:
             Think about it as setting a very long piece of code to equal a single word. 
            
            <Access Specifier> <Return Type> <Method Name>(Parameter List)
            {
                Method Body
            }

            Access specifier: determines visibility of a variable 
            Return type: the data type of the value the method returns. will be void if method is not returning something
            Method Name: unique identifier and it is case sensitive. CANNOt be the same as any other identifier in the class
            Parameter list: Used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. (its optional)
            Method body: This contains the set of instructions needed to complete the required activity 
            */


            //------------------------------------------------------------------------------------------------------------------------------

            // calling a method
            // note if you want to call a public method, it must go outside the current method since you cant call a public method inside a public method:
            
            int Add(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }
             Add(1, 2);  //this calls it 

            // non int methods and calling it

            void myFirstMethod()
            {
                Console.WriteLine("myFirstmethod was called");
                Console.WriteLine("some super complicated code");
            }

            myFirstMethod();  //this calls it 
            myFirstMethod();
            myFirstMethod();

            Console.WriteLine("this is outside the method");     //outside of the method 

            // passing data through method 
            // the parameter is something that must be inputed when you call the method

            void writeSomethingSpecial(string myString)
            {
                Console.WriteLine($"this word was used to call this method: {myString}");
            }

            writeSomethingSpecial("stupid");
            string stupid = "stupid";
            writeSomethingSpecial(stupid);  //you can also do this 

            //------------------------------------------------------------------------------------------------------------------------------

            //void method with a parameter (adding) 

            int AddTwoValues(int value1,int value2)
            {
               int result = value1 + value2;
               return result;               //you can use return to return only the "result" without writing it out since u can do that outside the method.
            }

            Console.WriteLine("give the first number to be added");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give the secibd number to be added");
            int num2 = int.Parse(Console.ReadLine()); 

            //note how we had to set num1 and num2 instead of using value1 and value2. this is because what ever is in the method is only applicable to whats inside {}

            int addedValuee = AddTwoValues(num1, num2); 
            Console.WriteLine(addedValuee); 

            Console.ReadLine();

            
        }


    }

        
}
