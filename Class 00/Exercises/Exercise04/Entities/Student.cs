using Exercise04.Interfaces;


namespace Exercise04
{
    public class Student : User, IStudent
    {
        public bool QuizTaken { get; set; }
        public int Grade { get; set; }
    }
}
