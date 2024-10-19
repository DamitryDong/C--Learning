using System.Runtime.ConstrainedExecution;

namespace _87_Advance_exercise_Two_dimensional_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int row1 = 0;
            int row2 = 0;
            int row3 = 0;

            foreach (int x in a)
            {
                if (x <= 3)
                {
                    row1 = row1 + x;
                }
                else if (x <= 6)
                {
                    row2 = row2 + x;
                }
                else
                {
                    row3 = row3 + x;
                }
            }

            Console.WriteLine(row1);
            Console.WriteLine(row2);
            Console.WriteLine(row3);
            Console.ReadLine();
        }
    }
}
