// C# Genric <=> C++ template
/*
- Class
- Sturuct
- Interface
- Method
- Delegate
- collection
 */

//Some<int> some = new();
//some.Foo();
//Some<double> some2 = new(); //  artiq idediyin tipde olur
//some.Foo();

//some.Bar("salam", 123); // burdada ikiside ozune aid olan tipde olacaq


Some<List<int>> some;

class Some<T>where T: class, IEnumerable<int>, new() // burda sert qoya bilirem where T :
{
    public T Property { get; set; }
    public Some(T property)
    {
        Property = property;
    }

    public void Foo()
    {
        Console.WriteLine(Property.GetType());
    }
    public T2 Bar<T2,T3>(T2 value1, T3 value2)
    {
        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        return value1;
    }
}
