namespace _78_Text_Adventure_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This part sets up the game with questions for name and class
            Console.WriteLine("Welcome to the Adventure game!");
            Console.WriteLine("Enter your character's name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Choose your character type (Warrior, Wizard, Archer");
            string characterType = Console.ReadLine();

            Console.WriteLine($"You, {playerName} the {characterType} has took a quest to find treasures and now stood before the forest where it resides.");
            Console.WriteLine("Do you enter the forrest or camp outside until sunrise to proceed? (Enter/Camp)");
            string choice1 = Console.ReadLine();


            //This starts the game with entering the forest
            if (choice1.ToLower() == "enter")
            {
                Console.WriteLine("You bravely enter the forest");
            }
            else
            {
                Console.WriteLine("You decide to camp out and wait for the sunrise to continue into the forrest"); 
            }

            //This is a loop for choosing the pathways and the outcomes of a fight
            bool gameContinues = true; 
            
            while (gameContinues)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?");
                string direction = Console.ReadLine();
                if (direction.ToLower() == "left")
                {
                    Console.WriteLine("You find a treausre chest!");
                    gameContinues = false;
                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");    //This section uses random number to determine if you win!
                    Console.WriteLine("Fight or flee? (fight/flee");
                    string fightChoice = Console.ReadLine();
                    if(fightChoice.ToLower() == "fight")
                    {
                        Random random = new Random();
                        int luck = random.Next(1, 10);
                        if (luck > 5)
                        {
                            Console.WriteLine("You beat the wild beast!");
                            if (luck >8)
                            {
                                Console.WriteLine("The wild beast dropped a treasure!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The beast attacked you where you didn't expect it!");
                            Console.WriteLine("It rammed it's tusks into your chest and you bleed out"); 
                            gameContinues = false;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
