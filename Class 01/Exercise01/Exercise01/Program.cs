using Exercise01.Entities;

Teacher teacher1 = new Teacher(1, "Darko", "teacher1", "1234", "C#");
Teacher teacher2 = new Teacher(2, "Darko", "teacher2", "1234", "JavaScript");

Student student1 = new Student(1,"Darko", "student1", "1234", 8);
Student student2 = new Student(1, "Darko", "student1", "1234", 9);

teacher1.PrintUser();
teacher2.PrintUser();

student1.PrintUser();
student2.PrintUser();