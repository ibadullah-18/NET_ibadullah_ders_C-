// Abstract classes
// is elaqesidi - Mesuliyyet bildirir
// (Student is Human, Car is Transport)

#region Abstract calsses introduction
//Some some = new();
//Other other = new();

//other.SomeMethod();
//abstract class Some // abstract yazandan sonra artiq onun Some some = new() yarada bilmirsen
//{
//    public int SomeIntFiled;

//    public string SomeStringProperty { get; set; }

//    public virtual void SomeMethod()
//    {
//        Console.WriteLine("Some Method");
//    }

//    public abstract void SomeAbstractMethod();

//}

//abstract class Other : Some
//{
//    //public override void SomeAbstractMethod()
//    //{
//    //    Console.WriteLine("Other class SomeAbstractMethod() implementation");
//    //}
//}

#endregion


abstract class Pokemon
{
    public string Name { get; set; }
    public int Level { get; set; } = 0;

    protected Pokemon(string name)
    {
        Name = name;
    }

    public abstract void Sound();
    public abstract void Attack();

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} level up. Level: {Level}");
    }
}

