namespace _64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we are making a questions and answer score program. we set up eat variable first  
            string Question1 = "What is the capital of Germany";
            string Answer1 = "Berlin";

            string Question2 = "What is 2+2";
            string Answer2 = "4";

            string Question3 = "What color do you get by mixing blue and yellow";
            string Answer3 = "green";
            
            int score = 0;

            //Question 2 
            Console.WriteLine(Question1);
            string userAnswer1 = Console.ReadLine(); 
            if (userAnswer1.Trim().ToLower() == Answer1.ToLower())                  // here we also used the Trim method which remove all leading and trailing space characters from string), we also added another method To Lower() which makes he answer all lowercase
            {
                Console.WriteLine("correct");
                score++;  // this is the increment function which adds +1 to the int. (you can also do score = score+1 
            }
            else
            {
                Console.WriteLine($"wrong, the correct answer is {Answer1}"); 
            }

            //Question 2
            Console.WriteLine(Question2);
            string userAnswer2 = Console.ReadLine();
            if (userAnswer2.Trim() == Answer2)
            {
                Console.WriteLine("correct");
                score++;  // this is the increment function which adds +1 to the int. (you can also do score = score+1 
            }
            else
            {
                Console.WriteLine($"wrong, the correct answer is {Answer2}");
            }

            //Question 3
            Console.WriteLine(Question3);
            string userAnswer3 = Console.ReadLine();
            if (userAnswer3.Trim().ToLower() == Answer3.ToLower())
            {
                Console.WriteLine("correct");
                score++;  // this is the increment function which adds +1 to the int. (you can also do score = score+1 
            }
            else
            {
                Console.WriteLine($"wrong, the correct answer is {Answer3}");
            }

            // here we show the results (score) 
            Console.WriteLine($"your score is {score}/3"); 
            if (score ==3)
            {
                Console.WriteLine("Congrats on getting all answers correct"); 
            }
            Console.ReadKey(); 
        }
    }
}
