string input;
int userWins = 0;
int appWins = 0;
int draws = 0;
int gamesPlayed = 0;
string[] options = new string[] { "rock", "paper", "scissors" };

while (true)
{
    Console.WriteLine("* Play");
    Console.WriteLine("* Stats");
    Console.WriteLine("* Exit");

    input = Console.ReadLine().Trim();
    if (!input.ToLower().Equals("play") && !input.ToLower().Equals("stats") && !input.ToLower().Equals("exit"))
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    if (input.ToLower().Equals("play"))
    {
        while (true)
        {
            Console.WriteLine("Choose: \n Rock \n Paper \n Scissors");
            string userWinsOption = Console.ReadLine().Trim().ToLower();

            if (!userWinsOption.Equals("rock") && !userWinsOption.Equals("paper") && !userWinsOption.Equals("scissors"))
            {
                Console.WriteLine("Invalid input");
                continue;
            }
            Random rnd = new Random();
            int num = rnd.Next(0, 3);

            if (options[num].Equals("paper") && userWinsOption.Equals("rock"))
            {
                appWins++;
                Console.WriteLine("App wins");
                    
            }
            else if (options[num].Equals("paper") && userWinsOption.Equals("scissors"))
            {
                userWins++;
                Console.WriteLine("User wins");

            }
            else if (options[num].Equals("scissors") && userWinsOption.Equals("rock"))
            {
                userWins++;
                Console.WriteLine("User wins");
            }
            else
            {
                Console.WriteLine("Draw");
                draws++;
            }
            gamesPlayed++;
            break;
        }
        Console.WriteLine("Press Enter  to return to the Menu");
        ConsoleKeyInfo c = Console.ReadKey();
        if(c.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            continue;
        }
        break;

    }
    if (input.ToLower().Equals("stats"))
    {
        Console.WriteLine($"User wins = ${userWins}.  Computer wins {appWins} wins. Draws {draws}");
        if(gamesPlayed == 0)
        {
            Console.WriteLine($"The percantage of the wins is 0");

        }
        else
        {
            var result = ((float)userWins / gamesPlayed) * 100;
            Console.WriteLine($"Wining percantage is {result}");

        }
        Console.WriteLine("Press Enter  to return to the Menu");
        ConsoleKeyInfo c = Console.ReadKey();
        if (c.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            continue;
        }
        break;
    }
    if (input.ToLower().Equals("exit"))
    {
        break;
    }
}