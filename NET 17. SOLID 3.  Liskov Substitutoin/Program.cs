// Liskov Substituion

Rectangle rectangle = new(width: 22, heigth: 30);
Console.WriteLine(Calculate.RectangleArea(rectangle));
rectangle.Width = 20;
Console.WriteLine(Calculate.RectangleArea(rectangle));
Console.WriteLine();

Square square = new(20);
Console.WriteLine(Calculate.RectangleArea(square));
square = new(10);
Console.WriteLine(Calculate.RectangleArea(square));
#region Bad example

//Square square = new(20);
//Console.WriteLine(Calculate.RectangleArea(square));
//square = new(10);
//Console.WriteLine(Calculate.RectangleArea(square));
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Heigth { get; set; }
//    public Rectangle(double width, double heigth)
//    {
//        Width = width;
//        Heigth = heigth;
//    }
//}
//class Square : Rectangle
//{
//    public Square(double side) : base(side, side)
//    {

//    }
//}

//class Calculate
//{
//    public static double RectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Heigth;
//}

#endregion

#region Good example

class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Heigth { get; set; }
    public Rectangle(double width, double heigth)
    {
        Width = width;
        Heigth = heigth;
    }
}
class Square : Rectangle
{
    public override double Heigth 
    { 
        get => base.Heigth;

        set { base.Heigth = value; base.Width = value; }
    }
    public override double Width
    {
        get => base.Width;
        set { base.Heigth = value; base.Width = value; }
    }
    public Square(double side) : base(side, side)
    {

    }
}

class Calculate
{
    public static double RectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Heigth;
}
#endregion