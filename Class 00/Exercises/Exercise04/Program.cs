using Exercise04;
using Exercise04.Enums;

int loginCounter = 0;
while (true)
{
    Console.WriteLine("Enter your username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter your password");
    string password = Console.ReadLine();

    if (Services.ValidateUser(username, password).Item1 == false) {
        ++loginCounter;
        if (loginCounter >= 3)
        {
            break;
        }
        Console.WriteLine("Enter valid username and password");
        continue;
    }
    else
    {
        Console.Clear();
        if(Services.ValidateUser(username, password).Item2 == Roles.Student)
        {
           bool takenQuiz = Services.StudentQuiz(username);
            if (takenQuiz)
            {
                Console.WriteLine("You already did the test");
                continue;
            }
        }
        else
        {
            foreach (var student in Database.students)
            {
                if (student.QuizTaken)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine( $" username = {student.Username} - grade ={student.Grade}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" username = {student.Username}");

                }
            }
            Console.ResetColor();
        }
        Console.WriteLine("Press enter to log out");
        ConsoleKeyInfo c = Console.ReadKey();
        if (c.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}
