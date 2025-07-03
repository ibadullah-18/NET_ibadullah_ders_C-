// Open/Closed principle

#region Bad example
//object[] shapes= [
//    new Rectangle(){Height=34,Width=30},
//    new Rectangle(){Height=78.3,Width=15.6},
//    new Circle(){}
//    new Rectangle(){Height=7,Width=22}
//    ];

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));

//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}
//class Circle {
//    public double Radius { get; set; }
//}

//class Tring


//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (var shape in shapes)
//        {
//            if (shapes is Rectangle rect) areas += rect.Width * rect.Height;
//            else if (shapes is Circle circle) areas ;

//        }
//        return areas;
//    }
//}


#endregion

#region Good example

using System.Globalization;

Shape[] shapes = [
    new Rectangle(){Height=34,Width=30},
    new Rectangle(){Height=78.3,Width=15.6},
    new Circle(){Radius=36},
    new Rectangle(){Height=7,Width=22},
    new Triangle(){Heigth=12,Base=12},
    new Trapezoid(){Heigth=12,SideA=34,SideB=45},
    new NeneminTendiri(){Faun=67,Klabulat=23,Zafa=81}
   ];

Calculate calculate = new Calculate();
Console.WriteLine(calculate.Areas(shapes));

abstract class Shape
{
    public abstract double Area();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
     return Width*Height;
    }
}
class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return 0;
    }
}

class Triangle : Shape
{
    public double Heigth { get; set; }
    public double Base { get; set; }
    public override double Area()
    {
        return 0.5 * Base * Heigth;
    }
}

class Trapezoid : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double Heigth { get; set; }
    public override double Area()
    {
        return 0.5 * (SideA + SideB) * Heigth;
    }
}

class NeneminTendiri : Shape
{
    public double Faun { get; set; }
    public double Zafa { get; set; }
    public double Klabulat { get; set; }

    public override double Area()
    {
        return Math.Sin(Klabulat) / Math.Pow(Zafa, 3) + Faun;
    }
}


class Calculate
{
    public double Areas(Shape[] shapes)
    {
        return shapes.Sum(x => x.Area());
    }
}



#endregion