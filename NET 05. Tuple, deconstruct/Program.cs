// tuple - new feature in C# 7.0
//(int, double) myTuple = (1, 2.0);
//Console.WriteLine(myTuple.Item1);
//Console.WriteLine(myTuple.Item2);

// -- -- -- --

//(int summ, double price, string name) myTuple2 = (1, 2.0, "test");
//Console.WriteLine(myTuple2.summ);
//Console.WriteLine(myTuple2.price);
//Console.WriteLine(myTuple2.name);

// -- -- -- --

//var result = CalculateSummAndAverage(1, 2);

//Console.WriteLine(result.Item1);
//Console.WriteLine(result.Item2);
//Console.WriteLine(result.Item3);

//  eger bir element isdeyirsense _ qoy
//(_,float aver1,_) = CalculateSummAndAverage(1, 2);
//Console.WriteLine(aver1);

Car car = new Car("LX 570", "Lexus", 2020);
//Console.WriteLine(car);
//var model = car.Model;
//var manufacturer = car.Manufacturer;
//var year = car.Year;

(string model, string manufacturer, int year) = car;
Console.WriteLine(model);
Console.WriteLine(manufacturer);
Console.WriteLine(year);

(int, float, int) CalculateSummAndAverage(int a, int b)
{
    int summ = a + b;
    float average = summ / 2.0f;
    return (summ, average, 143);
}

