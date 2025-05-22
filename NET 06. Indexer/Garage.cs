
public class Garage
{
    private Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }

    public int Count
    {
        get => cars.Length;
        // => arrow methods - oxlu funksiya get { return cars.Length; } qisa formasidi;
    }

    public Car this[int index]
    {
        get
        {
            if(index>=0&& index < cars.Length)
            {
                return cars[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < cars.Length)
                cars[index] = value;
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
    }
    // indexer -> with string parametrs
    public Car this[string model]
    {
        get
        {
            if(Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }
        set
        {
            cars[(int)Enum.Parse(typeof(Models), model)] = value;
        }
    }
}