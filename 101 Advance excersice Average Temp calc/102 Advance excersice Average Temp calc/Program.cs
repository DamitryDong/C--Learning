using System.Numerics;

namespace _102_Advance_excersice_Average_Temp_calc
{
    internal class Program
    {
        public void PrintAverage(double[] temperatures)
        {
            double average = CalculateAverage(temperatures); // Calculate the average temperature
            Console.WriteLine($"The average temperature is: {average}"); // Print the average temperature
        }

        public double CalculateAverage(double[] temperatures)
        {
            double sum = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i]; // Sum all temperatures
            }
            return sum / temperatures.Length; // Calculate and return the average
        }
    }
}

