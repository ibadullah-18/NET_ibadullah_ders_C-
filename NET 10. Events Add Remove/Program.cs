// Events

List<Student> students = new()
{
    new Student { FirstName = "ibadulla", LastName = "Huseynzade", Age = 17,MarkAvearage = 8 },
    new Student { FirstName = "Mirtalib", LastName = "Huseynzade", Age = 19,MarkAvearage = 6.8 },
    new Student { FirstName = "Asya", LastName = "Huseynzade", Age = 11,MarkAvearage = 15 },
    new Student { FirstName = "Sufiye", LastName = "Huseynzade", Age = 16,MarkAvearage = 7 },
    new Student { FirstName = "Ulviyye", LastName = "Huseynzade", Age = 14,MarkAvearage = 6.4 },
    new Student { FirstName = "Ziya", LastName = "Huseynzade", Age = 12,MarkAvearage = 12 },
    new Student { FirstName = "Mirnuh", LastName = "Huseynzade", Age = 10,MarkAvearage = 3.7 }
};

Teacher teacher = new Teacher();

foreach (var student in students)
{
    teacher.ExamEvent += student.Exam;
}


teacher.Exam("Sayt yazmaq");
public delegate void ExamDelegate(string task);

