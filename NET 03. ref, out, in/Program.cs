/*
   ref - metodlarin icindeki value type deyisenlerin reference olaraq gondermek ucundur
            Method-da gonderilmezden qabaq mutleq initilaze olunmalidir(deyer verilmelidi)
   
   out - metodlarin icindeki value type deyisenlerin reference olaraq gondermek ucundur
            Method-da gonderilmezden qabaq initilaze elemek vacib deyil

   in -  metodlarin icindeki value type deyisenlerin reference olaraq gondermek ucundur
            Amma deyiseni metodun icindeki yalniz oxumaq mumkun olacaq(readonly) 
*/

using System.Text;

//int number1 = 18;
//int number2 = 156; 
//int[] arr = [1, 2, 3, 4, 5];
//StringBuilder arrToString = new();
//foreach (var item in arr)
//{
//    arrToString.Append($"{item} ");
//}

//Console.WriteLine($@"Befor call ChangeValue method:
//number = {number1}
//number2 = {number2}
//arr = {arrToString.ToString()}");

//ChangeValue(number1, arr, ref number1, out number2);
//Console.WriteLine();

//arrToString.Clear();
//foreach (var item in arr)
//{
//    arrToString.Append($"{item} ");
//}

//Console.WriteLine($@"After call ChangeValue method:
//number = {number1}
//number2 = {number2}
//arr = {arrToString.ToString()}");

int numb;
MyIntTryParse(Console.ReadLine()!, out numb);
MyIntTryParse(Console.ReadLine()!, out int numb2);

Console.WriteLine($"numb = {numb}, numb2 = {numb2}");

void ChangeValue(int number, int[] arr, ref int numb1,out int numb2 )
{
    number += 23;
    arr[0] = numb1;
    numb1++;
    numb2 = 12;
};

bool MyIntTryParse(string value, out int outValue)
{
    try
    {
        outValue = int.Parse(value);
        return true;
    }
    catch
    {
        outValue = default;
        return false;
    }
}
