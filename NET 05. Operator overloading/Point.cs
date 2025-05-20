class Point
    {
    public int X { get; set; }
    public int Y { get; set; }
    
    public Point()
    : this(default, default)  // Default constructor initializes to (0, 0)
    { }
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    // Binary overloading the + operator
    public static Point operator +(Point p1, Point p2)
    {
        return new() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
    }
    
    // Unary overloading the - operator 
    //public static double operator -(Point p1, Point p2)
    //{
    //    Point tpm = new Point(p1.X, p2.Y);
    //    return Math.Sqrt(Math.Pow(p1.Y-p2.Y),2.0+Math.Pow(p1.X - p2.X));
    //}
    
    // Overloading the * operator
    public static Point operator *(Point p, int scalar)
    {
        return new Point(p.X * scalar, p.Y * scalar);
    }

    //addition assignment operator
    public static Point operator++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }

    // decrement operator
    public static Point operator--(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }
    
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

}

