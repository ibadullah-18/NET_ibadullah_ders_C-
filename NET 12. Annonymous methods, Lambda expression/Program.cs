// Annonymous methods
List<int> numbers = new();
FillList(numbers);
ShowList(numbers);

#region method and delegate
//Func<int,bool> predicate = IsEven;

//var evens = numbers.Where(predicate).ToList();
//var evens = numbers.Where(IsEven).ToList();

//ShowList(evens);
//bool IsEven(int number)
//{
//    return number % 2 != 0;
//}
#endregion

#region Anonymous method
// Anonymous method
// delegate(parameter_list){some_code_block; return value}
/*
    delegate (int x) { return x % 2 != 0; }).ToList(); 
    asaqdakini evez edir
    bool IsEven(int number)
    {
        return number % 2 != 0;
    }
*/

//var evenNumbers = numbers.Where(delegate (int x) { return x % 2 != 0; }).ToList();

//ShowList(evenNumbers);
#endregion

#region Lambda expression
// (parametrs_list) => { some_code_block; return value; }
/*
 (x) => x % 2 != 0
  bunun evezini edir
 (int x) => { return x % 2 != 0; }
lambda => anonim method => delegate
 */

//var evenNumbers = numbers.Where((x) => x % 2 != 0).ToList();
//ShowList(evenNumbers);
#endregion

/*
Lambda expressions

C++:     [](int x) { return x % 2 != 0; }

Python:  lambda x: x % 2 != 0

C#:      (x) => x % 2 != 0

*/


void FillList(List<int> lst)
{
    Random random = new();
    for (int i = 0; i < 10; i++)
    {
        lst.Add(random.Next(1, 100));
    }
}

void ShowList(List<int> lst)
{
    foreach (var item in lst)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

