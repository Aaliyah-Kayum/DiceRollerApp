public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Welcome to the Grand Circus Casino!");
        int dice = diceNum();
        bool runAgain = true;
        while (runAgain)
        {
            int side = ranNum(dice);
            int side2 = ranNum(dice);
            Console.WriteLine($"You got {side} and {side2}!");
            Console.WriteLine($"That equals: ({side + side2})");
            {
                if (dice == 6)
                {
                    ShowSides(side, side2);
                }
            }
            runAgain = keepRolling();
          
        }
    }
    static int diceNum()
    {
        Console.WriteLine("How many sides should each die have?");
        int eachSide = 0;
        while (true)
        {
            try
            {
                eachSide = int.Parse(Console.ReadLine());

                if (eachSide >= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a higher number. That one was out of range");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return eachSide;
    }

    static int ranNum(int sides)
    {
        Random rand = new Random();
        return rand.Next(sides);
    }

    //two 1s = snake eyes 
    //1 + 2 = ace deuce 
    // two 6s = box cars 
    // result is 7 or 11 = Win
    // result is 2, 3, 12 = craps 
    static void ShowSides(int num, int num2)
    {
        if (num == 1 && num2 == 1)
        {
            Console.WriteLine("You got Snake Eyes!");
        }
        else if ((num == 1 && num2 == 2) || (num == 2 && num2 == 1))
        {
            Console.WriteLine("You got Ace Deuce!");
        }
        else if (num == 6 && num2 == 6)
        {
            Console.WriteLine("You got Box Cars!");
        }
        int result = num + num2;
        if (result == 7 || result == 11)
        {
            Console.WriteLine("Congrats! You Won!!");
        }
        else if (result == 2 || result == 3 || result == 12)
        {
            Console.WriteLine("Craps!");
        }
        //extra challenge 
        else if (result == 5 || result == 10)
        {
            Console.WriteLine("It's your lucky day!");
        }
        else
        {
            Console.WriteLine("Oof, nothing special");
        }
    }
    static bool keepRolling()
    {
        bool answer = true; 
        while(true)
        { 
            Console.WriteLine("Do you want to play again? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                answer = true;
                break;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thanks for playing!");
                answer = false;
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand");
            }
        }
        return answer;  
    }
}