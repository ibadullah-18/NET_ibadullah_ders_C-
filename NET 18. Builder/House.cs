// Builder pattern 

// Product
// Bulder
// Builder: Concrete
// Director

class House 
{
    public string Name { get; set; }
    public int Wall { get; set; }
    public int Door { get; set; }
    public int Window { get; set; }
    public int Pool { get; set; }
    public int Garage { get; set; }
    public int Garden { get; set; }
    public bool HasRoof { get; set; }


    public override string ToString()
    {
        return @$"
House:      {Name}
Wall:       {Wall}
Door:       {Door}
Window:     {Window}
Pool:       {Pool}
Garage:     {Garage}
Garden:     {Garden}
HasRoof:    {(HasRoof ? "Has Roof" : "Withhouf Roof")}";
    }

}
