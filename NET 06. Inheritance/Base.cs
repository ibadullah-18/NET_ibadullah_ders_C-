// Inheritance - toreme (OOP-nin 4 prnsipinnen biri)
// Derived class - balalar sinifi(toreyen class) Base class - ata sinifi (toreden class)
// hesabina funksionalliqni genislendirilmesi deyilir
public class Base
{
    public int Field1 { get; set; }
    private int Field2;

    public Base(int field1, int field2)
    {
        Field1 = field1;
        Field2 = field2;
        Console.WriteLine("Base class Parametrized Constructor");
    }

    public Base()
        :this(5,78)
    {
        Console.WriteLine("Base class deofult Constructor");
    }

    public void Show()
        => Console.WriteLine($"Base Show() Field1 = {Field1}, Field2 = {Field2}");

    protected void Foo()
    {
        Console.WriteLine("Protected method Foo()");
        Bar();
    }

    private void Bar()
    {
        Console.WriteLine("Private method Foo()");
   
    }
}
