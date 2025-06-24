// Dependency inversion
Application application = new(new JsonSerialization());
application.CRUD();
#region Bad example

//class MSSQL
//{
//    // CRUD
//    public void Cerate() => Console.WriteLine("Crate with MSSQL");
//    public void Read() => Console.WriteLine("Read with MSSQL");
//    public void Update() => Console.WriteLine("Update with MSSQL");
//    public void Delete() => Console.WriteLine("Delete with MSSQL");
//}

//class MySQL
//{
//    public void Cerate() => Console.WriteLine("Crate with MySQL");
//    public void Read() => Console.WriteLine("Read with MySQL");
//    public void Update() => Console.WriteLine("Update with MySQL");
//    public void Delete() => Console.WriteLine("Delete with MySQL");
//}

//class Postagree
//{
//    public void Cerate() => Console.WriteLine("Crate with Postagree");
//    public void Read() => Console.WriteLine("Read with Postagree");
//    public void Update() => Console.WriteLine("Update with Postagree");
//    public void Delete() => Console.WriteLine("Delete with Postagree");
//}

//class Application
//{
//    private Postagree _db;

//    public Application(Postagree db)
//    {
//        _db = db;
//    }
//    public void CRUD()
//    {
//        _db.Cerate();
//        _db.Read();
//        _db.Update();
//        _db.Delete();
//    }
//}

#endregion

#region Good exapmle
interface IDb
{
    public void Cerate();
    public void Read();
    public void Update();
    public void Delete();
}

class MSSQL : IDb
{
    // CRUD
    public void Cerate() => Console.WriteLine("Crate with MSSQL");
    public void Read() => Console.WriteLine("Read with MSSQL");
    public void Update() => Console.WriteLine("Update with MSSQL");
    public void Delete() => Console.WriteLine("Delete with MSSQL");
}

class MySQL: IDb
{
    public void Cerate() => Console.WriteLine("Crate with MySQL");
    public void Read() => Console.WriteLine("Read with MySQL");
    public void Update() => Console.WriteLine("Update with MySQL");
    public void Delete() => Console.WriteLine("Delete with MySQL");
}

class Postagree : IDb
{
    public void Cerate() => Console.WriteLine("Crate with Postagree");
    public void Read() => Console.WriteLine("Read with Postagree");
    public void Update() => Console.WriteLine("Update with Postagree");
    public void Delete() => Console.WriteLine("Delete with Postagree");
}

class JsonSerialization :   IDb
{
    public void Cerate() => Console.WriteLine("Crate with JsonSerialization");
    public void Read() => Console.WriteLine("Read with JsonSerialization");
    public void Update() => Console.WriteLine("Update with JsonSerialization");
    public void Delete() => Console.WriteLine("Delete with JsonSerialization");
}

class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }
    public void CRUD()
    {
        _db.Cerate();
        _db.Read();
        _db.Update();
        _db.Delete();
    }
}
#endregion