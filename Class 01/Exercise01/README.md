
# Exercise

*   Create an interfaces called IUser, ISTudent, ITeacher
    *   IUser: Id, Name, Username, Password, PrintUser() - Prints Id, Name and Username
    
    *   ISTudent: Grades, override PrintUser() to show Grades
    *   ITeacher: Subject, override PrintUser() to show Subject
* Create an abstract class User and inherits from IUser
* Create a class Student that inherits from User and ISTudent
* Create a class Teacher that inherits from User and Teacher
* Create 2 Teacher and 2 Student objects and call PrintUser() on all of them

