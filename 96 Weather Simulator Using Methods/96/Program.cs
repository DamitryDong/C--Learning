using System.Reflection.Metadata.Ecma335;

namespace _96
{
    internal class Program
    {
       // we are making a weather simulator which will take the days we input and generate random weather for the days 
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherCondition = new string[days];
            
            Random random = new Random();

            for (int i = 0; i < days; i++)     //we then run a randomizer for each of the days in the array and get a condition for it 
            {
                temperature[i] = random.Next(-10, 40);     //random temperature
                weatherCondition[i] = conditions[random.Next(conditions.Length)];      //this will return one of the strings inside the "conditions" array and put it into the weatherConditions arrary at random and we use Condition.Lengh so it will always be the exact amount of choices in the conditiona array.
            }


            Console.WriteLine($"{AverageTemp(temperature)} is the average temperature ");  //note we can directly call the method in Console.WriteLine() or you can set it to equal something what ever you want. 
            Console.WriteLine($"The maximum temperature is {temperature.Max()}");
            Console.WriteLine($"The minumum temperature is {temperature.Min()}");       //we can get max and min temp with this
            Console.WriteLine($"The most common condition is {MostCommonCondition(weatherCondition)}");
            Console.ReadKey();  
        }


        //here we made a method which will get us the average of the temperatures-------------------
        static double AverageTemp ( int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)   //use length as condition
            {
                sum += temperature[i];      //sum will be added and set equal to temperature for each number in array
            }

            double average = sum / temperature.Length;
            return average;

        }

        //here we made method which will get the most common condition for -------------------------
        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostcommon = conditions[0]; //we start with the first condition so we can loop through all 

            for (int i = 0; i < conditions.Length; i++)   //right here we loop through each condition
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)  //each condition will be compared to the other condition in array
                {                                            //think of this as condition 1 is compared with 2,3,4 and if they 
                    if (conditions[j] == conditions[i])     //equal each other, the temp count will increase
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)                        //This will set the count to the highest tempCount created in loop
                {
                    count = tempCount;
                    mostcommon = conditions[i];              //and this will make the array which has the highest temp count
                }                                            //the mostcommon 
            }

            return mostcommon;
        }
    }
}
