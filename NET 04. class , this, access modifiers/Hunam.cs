// class
// internal - yalniz elen edildiyi assembly daxilinde elcatandir
// public - istenilen assembly daxilinde elcatandir
public class Hunam
{
    #region access modifiers
    // access modifiers
    // private - yalniz class daxilinde elcatandir
    // public -  istenilen yerde elcatandir
    // protected - class - in daxilinde ve toremes classlarda el catandir class xaricinde el catan deyil
    // internal - yalniz bizim assembly daxilinde elcatandir
    // protecded internsl - yalniz bizim asambly daxilinde toreyen class-larda elcatandir
    #endregion


    public string name;
    public string surname;
    public int age;

    public static int count;
    public const int field1 = 265;
    public readonly int field2 = 456;

    public Hunam(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    // maksimum derecede method - larin daxilinde her hansi platformaaya bagli methodlar istifade etmeliyik
    // Meselen Show methodunun icerisindeki consola baglidi
    public void Show()
    {
        Console.WriteLine(@$"Name:    {name},
Surname: {surname},
Age:     {age}");
    }
    public string Info()
    {
        return @$"Name:    {name},
Surname: {surname},
Age:     {age}";
    }

    public override string ToString() // en pecat budu bunu isdifade ele funksiya cagirmadan icindeki stringleri ekrana chap ede bilersen
    {
        return @$"Name:    {name},
Surname: {surname},
Age:     {age}";
    }

}