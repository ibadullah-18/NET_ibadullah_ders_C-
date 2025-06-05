// LINQ - Language Integrated Query
// Kolleksiyalarla işləmək üçün istifadə olunur.
/*
LINQ to Objects 
LINQ to Dataset 
LINQ to SQL 
LINQ to XML
LINQ to Entities
PLINQ - Parallel LINQ
*/


int[] arr = { -21, 552, -73, 24, -58, 62, -700, 84, -29, -110 };
ShowArray(arr);
IEnumerable<int> query = from i in arr // from neyden gotureceyini gosderir'
                         select i; // select neyi gotureceyini gosderir

#region from , select
//ShowArray(query);
//arr[0] = 3;
//ShowArray(query);
#endregion

#region where

query = from i in arr // from neyden gotureceyini gosderir
        where i % 2 == 0 // where neyi gotureceyini gosderir
        select i; // select neyi gotureceyini gosderir
ShowArray(query); // -24 552 24 62 84 -110
#endregion




void ShowArray(IEnumerable<int> arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}





