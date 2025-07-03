// Builder pattern 

// Product
// Bulder
// Builder: Concrete
// Director

IBuilder builder = new StoneBuilder();

var stoneHouse = builder
    .SetWindow()
    .SetWindow()
    .SetWindow()
    .GetHouse();

Console.WriteLine(stoneHouse);