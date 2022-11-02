using Exercise04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public static class Database
    {
        public static List<Student> students = new List<Student>()
        {
            new Student()
            {
                Username = "Dare",
                Password = "1234",
                UserRole = Roles.Student,
            },
                        new Student()
            {
                Username = "Student",
                Password = "1234",
                UserRole = Roles.Student,
            }
        };
        public static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher()
            {
                Username = "Darko",
                Password = "1234",
                UserRole = Roles.Teacher
            },
        };

        public static List<QuizQuestion> QuizQuestions = new List<QuizQuestion>()
        {
              new QuizQuestion()
              {
                  Question = "Q: What is the capital of Tasmania?",
                  PossibleAnwser = new List<Tuple<string,bool>>()
                  {
                        Tuple.Create("Dodoma", false),
                        Tuple.Create("Hobart ", true),
                        Tuple.Create("Launceston", false),
                        Tuple.Create("Wellington", false)

                  }
              },
              new QuizQuestion()
              {
                  Question = "Q: What is the tallest building in the Republic of the Congo?",
                  PossibleAnwser = new List<Tuple<string,bool>>()
                  {
                        Tuple.Create("Kinshasa Democratic Republic of the Congo Temple", false),
                        Tuple.Create(" Palais de la Nation ", false),
                        Tuple.Create("Kongo Trade Centre", false),
                        Tuple.Create("Nabemba Tower", true)

                  }
              },
              new QuizQuestion()
              {
                  Question = "Q: Which of these is not one of Pluto's moons",
                  PossibleAnwser = new List<Tuple<string,bool>>()
                  {
                        Tuple.Create("Styx", false),
                        Tuple.Create("Hydra", false),
                        Tuple.Create("Nix", true),
                        Tuple.Create("Lugia", false)
                  }
              },
              new QuizQuestion()
              {
                  Question = "Q: What is the smallest lake in the world?",
                  PossibleAnwser = new List<Tuple<string,bool>>()
                  {
                        Tuple.Create("Onega Lake", false),
                        Tuple.Create("Benxi Lake", true),
                        Tuple.Create("Kivu Lake", false),
                        Tuple.Create("Wakatipu Lake", false)

                  }
              },
              new QuizQuestion()
              {
                  Question = "Q: What country has the largest population of alpacas?",
                  PossibleAnwser = new List<Tuple<string,bool>>()
                  {
                        Tuple.Create("Chad", false),
                        Tuple.Create("Peru", true),
                        Tuple.Create("Australia", false),
                        Tuple.Create("Niger", false)
                  }
              },
        };
    }
}
