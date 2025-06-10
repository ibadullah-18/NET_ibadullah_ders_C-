// LINQ Methods
List<Group> groups = [
    new Group { Id = 1, Name = "Group A", Faculty = "Programming" },
    new Group { Id = 2, Name = "Group B", Faculty = "Design" },
    new Group { Id = 3, Name = "Group C", Faculty = "Cybercecurity" },
    new Group { Id = 4, Name = "Group D", Faculty = "Programming" },
    new Group { Id = 5, Name = "Group E", Faculty = "Design" },
    new Group { Id = 6, Name = "Group F", Faculty = "Cybercecurity" },
    new Group { Id = 7, Name = "Group G", Faculty = "Programming" },
    new Group { Id = 8, Name = "Group H", Faculty = "Design" },
    new Group { Id = 9, Name = "Group I", Faculty = "Cybercecurity" }
    ];
List<Student> students = [
    new Student
    {
        FirstName = "Alice",
        LastName = "Alisson",
        Age = 20,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Bob",
        LastName = "Bobby",
        Age = 22,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Charlie",
        LastName = "Charlson",
        Age = 21,
        GroupId = 3
    },
    new Student
    {
        FirstName = "David",
        LastName = "Davidson",
        Age = 23,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Eve",
        LastName = "Everson",
        Age = 19,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Frank",
        LastName = "Franklin",
        Age = 24,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Grace",
        LastName = "Gracely",
        Age = 20,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Hank",
        LastName = "Hankson",
        Age = 22,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Ivy",
        LastName = "Iverson",
        Age = 21,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Jack",
        LastName = "Jackson",
        Age = 23,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Kathy",
        LastName = "Katherson",
        Age = 19,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Leo",
        LastName = "Leonard",
        Age = 24,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Mia",
        LastName = "Miller",
        Age = 20,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Nina",
        LastName = "Nixon",
        Age = 22,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Oscar",
        LastName = "Oswald",
        Age = 21,
        GroupId = 9
    },
    new Student
    {
        FirstName = "Paul",
        LastName = "Parker",
        Age = 23,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Quinn",
        LastName = "Quinnson",
        Age = 19,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Rita",
        LastName = "Richardson",
        Age = 24,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Sam",
        LastName = "Sampson",
        Age = 20,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Tina",
        LastName = "Thompson",
        Age = 22,
        GroupId = 9
    },
    new Student
    {
        FirstName = "Uma",
        LastName = "Underwood",
        Age = 21,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Vera",
        LastName = "Vasquez",
        Age = 23,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Will",
        LastName = "Williams",
        Age = 19,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Xena",
        LastName = "Xavier",
        Age = 24,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Yara",
        LastName = "Young",
        Age = 20,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Zane",
        LastName = "Zimmerman",
        Age = 22,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Aaron",
        LastName = "Anderson",
        Age = 21,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Bella",
        LastName = "Brown",
        Age = 23,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Cody",
        LastName = "Clark",
        Age = 112,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Diana",
        LastName = "Davis",
        Age = 102,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Ethan",
        LastName = "Edwards",
        Age = 20,
        GroupId = 9
    }

    ];

#region First, FirstOrDefault
//var stud = students.First();
//Console.WriteLine(stud);

// First deyer olmayanda exception atir
//var student1 = students.First(s => s.GroupId == 12);
//Console.WriteLine(student1);

// FirstOrDefault deyer olmayanda null qaytarir
//var student2 = students.FirstOrDefault(s => s.GroupId == 12);
//if(student2 == null)
//{
//    Console.WriteLine("No student found in group 12.");
//}
//else
//{
//    Console.WriteLine(student2);
//}

#endregion

#region Single, SingleOrDefault
//var stud = students.Single(s => s.Age == 105); // eyer telebenin 105 yasi olan sadece 1 dene telebe varsa bu elementi biza qaytarir amma 1 den cox ve ya hec yoxdusa exception atir
//Console.WriteLine(stud);

//var sut2 = students.SingleOrDefault(s => s.Age == 105); // eyer telebenin 105 yasi olan sadece 1 dene telebe varsa bu elementi biza qaytarir amma 1 den coxdusa exception atir, hec yoxdusa null qaytarir
//if (sut2 == null)
//{
//    Console.WriteLine("No student found with age 105.");
//}
//else
//{
//    Console.WriteLine(sut2);
//}

#endregion

#region Contains
//var student = new Student
//{
//    FirstName = "Ibadullah",
//    LastName = "Huseynzade",
//    Age = 17,
//    GroupId = 4
//};
//Console.WriteLine(students.Contains(student));
//students.Add(student);
//Console.WriteLine(students.Contains(student)); // Bu zaman true qaytaracaq cunku studenti elave etdik
// Contains metodu obyektin referansini yoxlayir, eyer referanslar eynidirsə true qaytaracaq, yoxsa false qaytaracaq

#endregion

#region  Where
//var result = students.Where(s => s.Age > 20).ToList();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
// Where metodu, verilen kriteriyalara uygun olan elementleri filtreleyir ve yeni bir koleksiyon qaytarir.
#endregion

#region Min, Max, Average, Sum
//var minResult = students.Min(s => s.Age);// Min  yaşı olan telebeni tapir
//Console.WriteLine(minResult);
//var maxResult = students.Max(s => s.Age);// Max yaşı olan telebeni tapir
//Console.WriteLine(maxResult);

//var avgResult = students.Average(s => s.Age);// Average yaşı olan telebelerin ortalamasını tapir
//Console.WriteLine(avgResult);

//var sumResult = students.Sum(s => s.Age);// Sum yaşı olan telebelerin cəmini tapir
//Console.WriteLine(sumResult);

#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var Students = students.OrderBy(s => s.Age).ToList(); // Age ye gore artan sirayla siralayir
//Students.ForEach(Console.WriteLine);

//var Students2 = students.OrderByDescending(s => s.Age).ToList(); // Age ye gore azalan sirayla siralayir
//Students2.ForEach(Console.WriteLine);

//var Students3 = students.OrderBy(s => s.Age).ThenBy(s => s.FirstName).ToList(); // Age ye gore artan sirayla siralayir, Age ler eyni oldugu halda FirstName e gore artan sirayla siralayir
//Students3.ForEach(Console.WriteLine);

//var Students4 = students.OrderByDescending(s => s.Age).ThenByDescending(s => s.FirstName).ToList(); // Age ye gore azalan sirayla siralayir, Age ler eyni oldugu halda FirstName e gore azalan sirayla siralayir
//Students4.ForEach(Console.WriteLine);


#endregion

#region Count
//var count = students.Count(s =>s.Age == 24); // Telebelerin sayini tapir
//Console.WriteLine(count);

#endregion

#region Take, Skip, SkipWhile, TakeWhile,SkipLast, TakeLast
//var studs = students.Skip(3).Take(3).ToList(); // 3 telebeni atlayir ve sonraki 3 telebeni alir
//studs.ForEach(Console.WriteLine);

//var studs2 = students.Take(3).ToList(); // Ilk 3 telebeni alir`
//studs2.ForEach(Console.WriteLine);

// skipLast, TakeLast ise ilk yox axirdan 3 denesini goturecek ve ya atlayacaq

//var studs3 = students.SkipWhile(s => s.Age < 20).Take(3).ToList(); // Age si 20 den kicik olan telebeleri atlayir ve sonraki 3 telebeni alir
//studs3.ForEach(Console.WriteLine);

//var studs4 = students.TakeWhile(s => s.Age < 20).ToList(); // Age si 20 den kicik olan telebeleri alir, Age si 20 den boyuk olan telebeleri almayacaq
//studs4.ForEach(Console.WriteLine);
#endregion

#region All, Any
//var allResult = students.All(s => s.Age > 18); // Butun telebelerin Age si 18 den boyukdursa true qaytarir, yoxsa false qaytarir
//Console.WriteLine(allResult);

//var anyResult = students.Any(s => s.Age < 18); // Herhangi bir telebenin Age si 18 den kicikse true qaytarir, yoxsa false qaytarir
//Console.WriteLine(anyResult);
#endregion