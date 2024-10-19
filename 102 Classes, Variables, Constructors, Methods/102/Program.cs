namespace _102
{
    internal class Program
    {
        static void Main(string[] args)
        {   //------------------------------------------------------------------------------------------------------Car section 

            //A Class is a blue print of an Object
            //it has actions/abilities - so called member functions or methods 
            //and it has properties -so called member variables 
            //inheritance is possible 
            //Can be used like a Data type 

            //-----------------------------------------------

            //A Object has has properties and abilities and inheritance. 

            //----------------------------------------------- creating objects with constructor

            //here we are creating a object that follows the bluprint of our class "Car" use new to indicate a new addition 
            //this means whenever a object is made with the class "Car" it will execute the code in Car.cs 

            Car audi = new Car("A3","Audi",false);
            Car bmw = new Car("i7","Bmw",true);


            //----------------------------------------------- modifying variables for a object made

            Console.WriteLine($"Please enter the Brand name");
            
            //SETTING BRAND    (Will follow the rules in the class as we change the name of bmw to what we want. 
            bmw.Brand = Console.ReadLine();

            //GETTING BRAND
            Console.WriteLine($"Brand is {audi.Brand}");
            Console.WriteLine($"Brand is {bmw.Brand}");


            Console.ReadKey();

            //----------------------------------------------- using a method on a object created 

            
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Car myBmw = new Car("i7", "Bmw", true);
            myBmw.Drive();


            //-------------------------------------------------------------------------------------------------- New section for Customer.cs

            Customer earl = new Customer("Earl");
            Customer frank = new Customer("Frank","111 street", "1111111111");  //this showcases 2 different Customer Constructors being used for Customer class 
            Customer defaultTest = new Customer();                              // our default method, 

            defaultTest.SetDetails("Frank", "123 street", "1111111111");        //here we used a method to update the default details which has no value.
            defaultTest.SetDetails("Frank", "123 street");                      //this part showcase our optional parameter as the default value is "NA" if we leave it empty

            Console.WriteLine($"Name of Customer is {earl.Name}");              //remember everything can be populated in the future 
            Console.WriteLine(frank.Name );
            Console.WriteLine(defaultTest.Name );
            Console.ReadKey();

            //---------------------------------------------

            Customer customer1 = new Customer("CustomerNumber1");
            Console.WriteLine($"Address of customer1 is {customer1.Address}");  //this should return the line we set = to for address in our constructor
            Console.ReadKey();

            //----------------------------------------------------------------------------------------------------------------------- 


        }
    }
}
