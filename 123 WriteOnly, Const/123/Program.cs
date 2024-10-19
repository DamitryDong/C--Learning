namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write only property ------

            Customer cus1 = new Customer("Hedra", "red");
            Customer cus2 = new Customer("Shaleen", "Blue"); 
            
            cus1.Password = "password"; //note that since this is a read only property we cannot access it (get it)    UNLESS we make a method which will show the password

            //--------------------------

            cus1.DisplayDetail(); 
            cus2.DisplayDetail();
            Console.ReadKey();
        }
    }
}
