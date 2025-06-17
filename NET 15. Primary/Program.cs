// primary constructor -> new in C# 12
Dog dog = new("Max", 5, 1500.50f);
dog.Print();
class Dog(string namr,int age, float price)
{
    public void Print()
    {
        Console.WriteLine($"Name: {namr}, Age: {age}, Price: {price}");
    }
}
