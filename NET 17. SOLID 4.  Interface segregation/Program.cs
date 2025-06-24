//Interfae segregation

#region Bad example

//abstract class Animal
//{
//    public abstract void Feed(); 
//    public abstract void Groom(); 
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog feed");
//    }
//    public override void Groom()
//    {
//        Console.WriteLine("Dog groom");
//    }
//}

//class Cat: Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Cat feed");
//    }
//    public override void Groom()
//    {
//        Console.WriteLine("Cat groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger Feed");

//    }
//    public override void Groom()
//    {
//        Console.WriteLine("Duxun catir sigalla! ");
//    }
//}

#endregion

#region Good example
List<IFeed> feedables = [new Tiger(), new Dog(), new Cat()];
//List<IGroom> groomables = [new Tiger(), new Dog(), new Cat()];
//List<Ipet> ipetables = [new Tiger(), new Dog(), new Cat()];
abstract class Animal
{
}
interface IFeed
{
    public void Feed();
}
interface IGroom
{
    public void Groom();
}
interface Ipet : IFeed, IGroom 
{ }
class Dog : Animal , IFeed, IGroom
{
    public void Feed()
    {
        Console.WriteLine("Dog feed");
    }
    public void Groom()
    {
        Console.WriteLine("Dog groom");
    }
}
class Cat : Animal, IFeed, IGroom, Ipet
{
    public void Feed()
    {
        Console.WriteLine("Cat feed");
    }
    public void Groom()
    {
        Console.WriteLine("Cat groom");
    }
}
class Tiger : Animal , IFeed
{
    public void Feed()
    {
        Console.WriteLine("Tiger Feed");

    }
}
#endregion