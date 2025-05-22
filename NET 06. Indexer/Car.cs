
public class Car
{
    public string Model { get; set; }
    public string Price { get; set; }

    public override string ToString()
    {
        return $"Model: {Model}, Price: {Price}";
    }
}