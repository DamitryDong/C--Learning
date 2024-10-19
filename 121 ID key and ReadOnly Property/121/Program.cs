namespace _121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here we are going to test our Customer ID readonly class
            //** you cannot loop through individual objects without very complicated things... 

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer(); 
            //---------------------------------------------------------------------------
            //Sahej (chat gpt this) (this is how we would do it to map actual Json data with list of class. 
            
            List<Customer> cust = new List<Customer>();      //this means we have created a list that can hold the object type of Customer. 

            cust.Add(new Customer() { Address = "ASD", City = "ERT", Name = "WERT" });   //then we initialize a add of a new customer into the list with the following variables. 

            //note that this list item only contains whats been added into the list 

            //---------------------------------------------------------------------------

            customer1.GetDetailForID();    //we call the method and this will return each customers id
            customer2.GetDetailForID(); 
            customer3.GetDetailForID();
            customer4.GetDetailForID(); 

            Console.WriteLine($"Customer 3 Id is {customer3.ID}");  //here we are using the readonly (get only) property we made 

            Console.ReadKey();  
            
            
        }
    }
}
