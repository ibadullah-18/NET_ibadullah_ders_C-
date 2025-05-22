// Inheritance - toreme (OOP-nin 4 prnsipinnen biri)
// Derived class - balalar sinifi(toreyen class) Base class - ata sinifi (toreden class)
// hesabina funksionalliqni genislendirilmesi deyilir
public class Derived : Base
{
    public string SomeProperty { get; set; }
    public Derived()
        :this(string.Empty, 0, 0)
    {
        Console.WriteLine("Derived class Deafult Constructor");
    }

    public Derived(string someProperty, int field1,int field2)
        : base(field1, field2)
    {
        SomeProperty = someProperty;
        Console.WriteLine("Derived class Parametrized Constructor");
    }

    public void DerivedFoo()
    {
        base.Foo(); // base - ata sinifin metoduna gidecek
    }

}