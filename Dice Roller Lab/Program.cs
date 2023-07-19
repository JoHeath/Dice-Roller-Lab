//Greeting

Console.WriteLine("Welcome to The Dice Roller Simulator");
Console.WriteLine();
Console.WriteLine("How many sides would you like your dice to have?");

//Declares variable

int sidesInput = -1;

//validation loop

while (int.TryParse(Console.ReadLine(), out sidesInput) == false)
{
    Console.WriteLine("invalid response. Try again");
}
if (sidesInput < 0)
{
    Console.WriteLine("number to low. Try again");
}
// creates bool variable

bool runProgram = true;

// loop to ask if user wants to roll the dice. doesn't continue without user agreement
    while (true)
    {
        Console.WriteLine("would you like to Roll the Dice? y/n");
        string userReply = (Console.ReadLine().ToLower().Trim());
    if (userReply == "y")
    {
        runProgram = true;
        break;
    }
    else if (userReply == "n")
    {
        Console.WriteLine("Goodbye");
        runProgram = false;
        break;
    }

    else
    {
        Console.WriteLine("invalid response, please enter y or n");
    }
    }

// Main loop 
while (runProgram)
{
    //Loop to run the game if user wishes to roll again
    while (true)
    {
        //declares variables and gives them value

        int diceRoll1 = Roll(sidesInput);
        int diceRoll2 = Roll(sidesInput);
        int totalRoll = diceRoll2 + diceRoll1;

// displays results of a roll

        Console.WriteLine($"Your first die is {diceRoll1}");
        Console.WriteLine($"Your second die is {diceRoll2}");
        Console.WriteLine($"Your total number is {totalRoll}");

// calls method to generate responses for a 6 sided die.

        HandleSixSidedDie(diceRoll1, diceRoll2);

   //asks if user wants to roll again
   
        Console.WriteLine("Would you like to roll again? y/n");
        string userInput = Console.ReadLine().ToLower().Trim();
        if (userInput == "y")
        {
            runProgram = true;
            break;
        }
        else if (userInput == "n")
        {
            Console.WriteLine("Goodbye");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("invalid, please enter y or n");
        }
    }
}

// Method for random dice roll
static int Roll(int sides)
{
    Random rnd = new Random();
    return rnd.Next(1, sides +1);
}
// Method for handling 6 sided dice results
static void HandleSixSidedDie(int roll1, int roll2)
{
    int totalRoll = roll2 + roll1;
    if (roll1 == 1 && roll2 == 1)
    {
        Console.WriteLine("Snake Eyes");
    }

    if (roll1 == 1 && roll2 == 2)
    {
        Console.WriteLine("Ace Deuce");
    }

    if (roll1 == 6 && roll2 == 6)
    {
        Console.WriteLine("Box Cars");
    }        

     if (totalRoll == 7 || totalRoll == 11)
     {
         Console.WriteLine("Win");
     }

     if (totalRoll == 2 || totalRoll == 3 || totalRoll == 12)
     {
         Console.WriteLine("Craps");
     }
}

