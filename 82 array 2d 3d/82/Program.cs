namespace _82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;

            //Declaring arrays

            int[] myIntArray = new int[5];  //just add [] to int and you make an array, the [5] dictates how large the array is.
            myIntArray[0] = 5;
            myIntArray[1] = 12;
            myIntArray[2] = 13;
            myIntArray[3] = 14;
            myIntArray[4] = 15;

            // Indexes [0][ 1][ 2][ 3][ 4]
            // Content [5][12][13][14][15]

            //you cannot put more int into the array than the amount stated.

            //array values can be shown as 
            Console.WriteLine(myIntArray[0]);

            Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------------------

            //declearing and setting an array together 

            int[] myIntArray2 = [5,12,13,14,15];

            string[] myStrArray = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

            Console.WriteLine(myIntArray2[0]);
            Console.WriteLine(myStrArray[1]);
            //array has properties you can use. Example is using it to find length of the array 
            Console.WriteLine(myStrArray.Length);

            Console.ReadKey();
            
            //-----------------------------------------------------------------------------------------------------------------

            //For-Each Loop

            foreach (string i in myStrArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------------------

            //Two Dimensional Arrays
            
            int[,] array2DDeclaration = new int[3, 3];

            // [0] [0] [0]
            // [0] [0] [0]           
            // [0] [0] [0]

            int[,] array2DInizilized = 
            { 
                { 1, 2 }, 
                { 3, 4 } 
            };                     //does same thing 

            // [1] [2]    row 0
            // [3] [4]    row 1

            //to access the variables inside a 2d array

            Console.WriteLine(array2DInizilized[0,0]); // [row,column]  therefore [1,0] will give us the 3 

            array2DInizilized[0, 0] = 5;   //how you update a array 

            Console.WriteLine(array2DInizilized[0, 0]);

            Console.ReadLine() ;

            //------------------------------------------------------------------------------------------------------------------

            //Three Dimensional Arrays

            string[,,] array3DDeclaration = new string[3, 3, 3];

            //this would be a cube shape
            //don't usually used

            string[,,] array3DInizilized =
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };


        
        }
    }
}
