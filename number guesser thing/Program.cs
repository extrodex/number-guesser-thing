Console.WriteLine("Guess the number between 1-100, and I will tell you if it's higher or lower");
Random random = new();
bool game = true;
int rnd = random.Next(1,101);
int guess;
while (game) { 
    guess=int.Parse(Console.ReadLine());
if (guess > rnd)
    {
        Console.WriteLine("Your guess is higher");
    }
if (guess < rnd)
    {
        Console.WriteLine("Your guess is lower");
    }
if(guess == rnd)
    {
        Console.WriteLine("You got it right");
        game = false;
    }
}