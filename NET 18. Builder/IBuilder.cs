// Builder pattern 

// Product
// Bulder
// Builder: Concrete
// Director
interface IBuilder
{
   public House House { get; set; }
    IBuilder Reset();
    IBuilder SetWall();
    IBuilder SetDoor();
    IBuilder SetWindow();
    IBuilder SetPool();
    IBuilder SetGarage();
    IBuilder SetGarden();
    IBuilder SetHasRoof();
    IBuilder GetHouse();

}
