// bir nece class dan toremek mumkun deyil
public class GrandChild : Derived
{
    public string SomeProperty { get; set; }
    public GrandChild()
        : this("HI", 49, 54)
    {
        Console.WriteLine("GrandChild Deafult Constructor");
    }
    

    public GrandChild(string someProperty, int field1, int field2) 
        : base(someProperty, field1, field2)
    {
        Console.WriteLine("GrangChild class parametrized constructor ");
    }
    public void GrandChildFoo()
    {
        base.Foo();
    }
}