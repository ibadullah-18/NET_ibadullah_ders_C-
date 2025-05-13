//Arrays

// C++ arrays
// int arr[5] = { 1, 2, 3, 4, 5 }; C++ da

// dynamic array
// int* arr = new int[5]{ 1, 2, 3, 4, 5 }; C++ da


// C# arrays
//int[] arr = new int[5] { 1, 2, 3, 4, 5 }; // C# da arrays bele yaradilir
//int[] arr2 = { 1, 2, 3, 4, 5 }; // C# da arrays bele yaradilir
//int[] arr3 = [1, 2, 3, 4, 5]; // C# da arrays bele yaradilir
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr3[2]);
//Console.WriteLine(arr.Length); // uzunlugunu gosterir
//Console.WriteLine(arr.Rank); // arrayin nece diminsiyali oldugunu gosterir


// C++ da Cox olculu (multidimension) array 
//int arr[2][3] = { { 1, 2, 3 }, { 4, 5, 6 } }; C++ da

// C# da Cox olculu (multidimension) array
//int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // C# da
//Console.WriteLine(arr.Rank);

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.WriteLine($"{arr[i, j]}\t");
//    }
//    Console.WriteLine();
//}

Random random = new Random();
// Jagged array
//int[][] jArr = new int[3][];
//jArr[0] = new int[10];
//jArr[1] = new int[3];
//jArr[2] = new int[5];

//for (int i = 0; i < jArr.Length; i++)
//{
//    for (int j = 0; j < jArr.Length; j++)
//    {
//        jArr[i][j] = random.Next(10, 99);
//    }
//}
//for (int i = 0; i < jArr.Length; i++)
//{
//    for (int j = 0; j < jArr.Length; j++)
//    {
//        Console.WriteLine($"{jArr[i][j]}");
//    }
//    Console.WriteLine();
//}

//int[] arr2 = [15, 56, 43, 32];
//int i = 0;
//while (2 < arr2.Length)
//{
//    Console.WriteLine($"{arr2[i]}");
//}
//Console.WriteLine();

//for (int j = 0; j < arr2.Length; j++)
//{
//    Console.WriteLine($"{arr2[j]}");
//}
//Console.WriteLine();

//foreach (var item in arr2)
//{
//    Console.WriteLine($"{arr2[item]}");
//}
//Console.WriteLine();