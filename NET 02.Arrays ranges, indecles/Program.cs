int[] arr = new int[20];
// Random random = new Random();
Random random = new();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(10, 99);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

// ranges - introduced in C# 8.0
// python - lst[1:5] - sliceing 1 den 5 e qeder

// C# - da
//int[] arr2 = arr[2..10]; // 2 den 5 e qeder

//foreach (var item in arr2)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

// indcies - introducing in C# 8.0
// python - lst[-1] - negative indexs -sonuncu element

// C# - da
//int[] arr3 = arr[2..^5]; // 2 ci elementden sonuncu 5 ci elemente qeder

//foreach (var item in arr3)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();