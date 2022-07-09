using System;
int playerRandomNum;
int enemyRandomNum;
int playerWins = 0;
int enemyWins = 0;
int rounds = 10;
Random random = new Random();

Console.WriteLine("WELCOME TO THE 'ROLL THE DICE GAME'");

for(int i = 0; i < rounds; i++)
{
    Console.WriteLine("Press any key to roll the dice. Round #" + (i + 1) + ". Rounds to the end : " + (rounds - i));

    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    for(int j = 0; j < 10; j++){}
    loadingDots(10, 20); 
    Console.WriteLine("You rolled a " + playerRandomNum);
    loadingDots(10, 20); 
    enemyRandomNum = random.Next(1, 7);
    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);
    loadingDots(10, 20);
    if (playerRandomNum > enemyRandomNum) {
        playerWins++;
        Console.WriteLine("Player wins this round!");
    } else if (playerRandomNum < enemyRandomNum) {
        enemyWins++;
        Console.WriteLine("AI wins this round!");
    } else {
        Console.WriteLine("Draw!");
    }
    
    Console.WriteLine("The score is now - Player : " + playerWins + ". Enemy : " + enemyWins);
    Console.WriteLine();    
}

loadingDots(10, 20);
if (playerWins > enemyWins) {
    Console.WriteLine("You win!");
} else if (playerWins < enemyWins) {
    Console.WriteLine("AI win!");
} else {
    Console.WriteLine("It's a Draw!");
}

void loadingDots(int ms, int num) 
{
    for (int i = 0; i < num; i++)
    {
        Console.Write(".");
        System.Threading.Thread.Sleep(ms);        
    } 
}