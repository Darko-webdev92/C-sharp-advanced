using Exercise04.Enums;

namespace Exercise04
{
    public static class Services
    {
        public static Tuple<bool, Roles> ValidateUser(string username, string password)
        {

            bool userDoesExists = Database.students.Any(user => user.Username.ToLower() == username.ToLower() && user.Password == password);
            Student student = null;
            Teacher teacher = null;
            if (userDoesExists)
            {
                student = Database.students.Where(user => user.Username.ToLower() == username.ToLower()).FirstOrDefault();
            }
            else
            {
                userDoesExists = Database.teachers.Any(user => user.Username.ToLower() == username.ToLower() && user.Password == password);
                teacher = Database.teachers.Where(user => user.Username.ToLower() == username.ToLower()).FirstOrDefault();
            }
            Roles role = new Roles();
            if (student != null)
            {
                role = Roles.Student;
            }
            if (teacher != null)
            {
                role = Roles.Teacher;
            }
            return Tuple.Create(userDoesExists, role);
        }

        public static bool StudentQuiz(string username)
        {
            int correctAnswers = 0;
            int QuestionNumber = 0;
            int question = 0;
            Student student = Database.students.Where(student => student.Username.ToLower() == username.ToLower()).FirstOrDefault();
            
            if(student.QuizTaken == true)
            {
                return true;
            }

            var StudentIndex = Database.students.IndexOf(student);

            foreach (var item in Database.QuizQuestions)
            {
                bool corectAnswer = false;
                Console.WriteLine(item.Question);

                foreach (var answer in item.PossibleAnwser)
                {
                    Console.WriteLine($"{++QuestionNumber} {answer.Item1}");
                }

                while (true)
                {
                    string input = Console.ReadLine().Trim();
                    if (!int.TryParse(input, out int index))
                    {
                        Console.WriteLine("Please enter number from 1 to 4 number");
                        continue;
                    }

                    if (index != 1 && index != 2 && index != 3 && index != 4)
                    {
                        Console.WriteLine("Choose from 1 to 4");
                        continue;
                    }

                    Console.Clear();
                    if (Database.QuizQuestions[question].PossibleAnwser[index - 1].Item2)
                    {
                        correctAnswers++;
                    }
                    break;
                }
                ++question;
                QuestionNumber = 0;
                if(correctAnswers == 0)
                {
                    Database.students[StudentIndex].Grade = 1;

                }
                else
                {
                    Database.students[StudentIndex].Grade = correctAnswers;
                }
                Database.students[StudentIndex].QuizTaken = true;



            }
            Console.WriteLine($"Your grade is {student.Grade}");
            return false;
        }
    }
}
