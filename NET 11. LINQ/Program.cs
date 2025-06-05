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


int[] arr = { -21, 552, -73, 98, -58, 62, -700, 84, -29, -110 };
ShowArray(arr);
IEnumerable<int> query = from i in arr // from neyden gotureceyini gosderir'
                         select i; // select neyi gotureceyini gosderir

#region from , select
//ShowArray(query);
//arr[0] = 3;
//ShowArray(query);
#endregion

#region where

//query = from i in arr // from neyden gotureceyini gosderir
//        where i % 2 == 0 // where neyi gotureceyini gosderir
//        select i; // select neyi gotureceyini gosderir
//ShowArray(query); // -24 552 24 62 84 -110
#endregion

#region orderby ascending(by default) / descending
//query = from i in arr  // from neyden gotureceyini gosderir
//        where i > 0
//        orderby i descending // orderby nece siraya gotureceyini gosderir
//        select i; // select neyi gotureceyini gosderir
//ShowArray(query); 

#endregion

#region group by
//IEnumerable<IGrouping<int,int>> group = from i in arr
//            where i > 0
//            group i by i % 2; // group i by i % 2 - i % 2 ile qruplandirir, 0 ve 1 qrupuna
//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"      {value}");
//    }
//}
#endregion

#region into
//var query_into = from i in arr
//                 where i > 0
//                 group i by i % 2 into result // into ile yeni bir ad verilir ve yeni bir sorgu yaradilir
//                 from j in result // yeni bir sorgu yaradilir
//                 group j by j % 10;
//foreach (var item in query_into)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"      {value}");
//    }
//}
#endregion


void ShowArray(IEnumerable<int> arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}





