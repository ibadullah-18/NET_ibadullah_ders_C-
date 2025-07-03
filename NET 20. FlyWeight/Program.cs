// FlyWeight
List<UnitFlyWeight> units = new List<UnitFlyWeight>();
FlyWeightFactory factory = new FlyWeightFactory();

for (int i = 0; i < 10; i++)
{
    //Archer archer = new Archer();
    //Warrior werrior = new Warrior();

    UnitFlyWeight archer = factory.GetUnit("Archer");
    UnitFlyWeight werrior = factory.GetUnit("Archer");


    Console.WriteLine(archer.GetHashCode());
    Console.WriteLine(werrior.GetHashCode());


    units.Add(archer);
    units.Add(werrior);

}

abstract class UnitFlyWeight
{
    protected string Name;
    protected int AttackPoint;
    protected int Health;
    public abstract void Display();
}

class Archer : UnitFlyWeight
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 120;
        Health = 70;
    }
    public override void Display()
    {
        Console.WriteLine("Archer created");
    }
}

class Warrior : UnitFlyWeight
{
    public Warrior()
    {
        Name = "Werrior";
        AttackPoint = 120;
        Health = 70;
    }
    public override void Display()
    {
        Console.WriteLine("Werrior created");
    }
}

class FlyWeightFactory
{
    private Dictionary<string, UnitFlyWeight> _units = new();
    public UnitFlyWeight GetUnit(string key)
    {
        UnitFlyWeight unit = default;
        if(_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Werrior":
                    unit = new Warrior();
                    break;
            }
            _units.Add(key, unit);
        }
            return unit;
    }
}