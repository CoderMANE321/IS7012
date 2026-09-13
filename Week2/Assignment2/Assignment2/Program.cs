int winningNumber = 1;
string name = "Deonta Williams";


static void RecursiveRolls(int winningNumber, string name)
{
    int randomNumber = new Random().Next(1, 7); //GENERATES NUMBER BETWEEN 1 and 6
    Console.WriteLine($"You rolled a {randomNumber}.");
    // Base case
    if (randomNumber == winningNumber)
    {
        Console.WriteLine($"Congratulations, {name}! You won!");
        return;
    }

    Console.WriteLine($"Sorry, {name} you lose. The winning number was {winningNumber}.\n Try again!");

    // Recursive call
    RecursiveRolls(winningNumber, name);
}

RecursiveRolls(winningNumber, name);