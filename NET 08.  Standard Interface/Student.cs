// Standard interface
class Student : IEnumerable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }

    public StudentCard StudentCard { get; set; }
    public int CompareTo(object? obj)
    {
        if (obj is Student)
        {
            return LastName.CompareTo((obj as Student).LastName);
        }
        throw new ArgumentException("Object is not a Student");
    }

    public override string ToString()
    {
        return $"""
            Name: {FirstName}, 
            Surname: {LastName} 
            BirtDay: {BirthDate.ToShortDateString()}
            Studen Cart Series: {StudentCard}
            """;  
    }

internal interface IEnumerable
{
}

}
