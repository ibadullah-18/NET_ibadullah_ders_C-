// Params  - method - da "sonsuz" sayda element elave ede bilersen

int[] arr = [1, 2, 3, 4, 5, 6, 7, -9];
Console.WriteLine(Summ(arr));
Console.WriteLine(Summ(new int[] { 1, 2, 3, 4, 5, 6, 7, -9 }));
Console.WriteLine(Summ([ 1, 2, 3, 4, 5, 6, 7, -9 ]));
Console.WriteLine(ParamsSumm(1, 2, 3, 4, 5, 6, 7, -9,23,21,45));
int Summ(int[] ints)
{
    int result = default;
    foreach (var item in ints)
    {
        result += item;

    }
    return result;
}

int ParamsSumm(params int[] ints) // params - moterzeye falan hecneye lazim olmadan metoda bir basa arr yazib ata bilersen
{
    int result = default;
    foreach (var item in ints)
    {
        result += item;

    }
    return result;
}

