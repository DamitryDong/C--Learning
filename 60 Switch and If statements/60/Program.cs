namespace _60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can also use IF statments like this for defining a variable
            // If statements works better with complex conditions involving multiple comparisons or Boolean expressions

            int month = 5;
            string monthName;

            if (month == 1)
            {
                monthName = "January";
            }
            else if (month == 2)
            {
                monthName = "February";
            }
            else if (month == 3)
            {
                monthName = "March";
            }
            else
            {
                monthName = null; 
            }

            //----------------------------------------------------------------------------------------------

            // Switch statement 
            // serve similar function as a If statement but you give it cases
            // break is used to to stop the rest of the cases from activating if the previous one is true. 
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                default:
                    monthName = "Unknown";
                    break;
            }

            Console.WriteLine(monthName);
            Console.ReadKey();

        }  
    }
}
