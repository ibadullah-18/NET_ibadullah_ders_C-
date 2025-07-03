// Singleton pattern

President president;

president = President.GetInstance("ibadulla", "Huseynzade", 17);
Console.WriteLine(president);
class President
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int age { get; set; }


    private static President _instance = null;

    private President(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        this.age = age;
    }

    static public President GetInstance(string name , string lastname,int age)
    {
        if(_instance is null)
        {
            _instance = new(name, lastname, age);
        }
        return _instance;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {age}";
    }

}
