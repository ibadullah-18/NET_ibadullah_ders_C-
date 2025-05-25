// Interface bir contract(muqaviledir) ve mutleq implementation olum=nmalidir

// Interface ler bali bir nece
// Interface ler icinde sade fieldler yaradmaq mumkun deyil, amma property yaradmaq mumkundur
// Interface in icindeki properytler ve methol=d descriptionlar public olmur


Iwalk walkobj = new Student();

Bar(walkobj);
Bar(new Cat());
Foo(new AI());
Foo(new Student());
Foo(new Cat());
void Foo(Ithink think)
{
    think.Think();
}

void Bar(Iwalk walk)
{
    walk.Walk();    
}

abstract class Human
{
    public string Name { get; set; }    
    public string Surname { get; set; }

    public int age { get; set; }
}

interface Ithink
{
    public void Think();
}

interface Iwalk 
{
    void Walk();
}

interface IHomeSapiens : Ithink , Iwalk
{}

class Student : Human, IHomeSapiens
{
    public float[] Marks { get; set; }

    public void Think()
    {
        Console.WriteLine("I think like student");
    }

    public void Walk()
    {
        Console.WriteLine("I walk like Human");
    }
}

class AI : Ithink
{
    public void Think()
    {
        Console.WriteLine("I think like IT");
    }
}

class Cat : Iwalk,Ithink
{
    public void Think()
    {
        Console.WriteLine("I think like Cat");
    }

    public void Walk()
    {
        Console.WriteLine("I walk like Cat");
    }
}