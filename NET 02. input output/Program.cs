// output
//Console.BackgroundColor = ConsoleColor.Red; // arxa reng elave edir
//Console.WriteLine("HELLO Masalli");
//Console.BackgroundColor = ConsoleColor.Yellow;

//Console.ReadKey();

//Console.Clear();// ozunnen sonrasini entere qeder temizeyir
//Console.Write("HELLO");
//Console.BackgroundColor = ConsoleColor.Blue;
//Console.Write("World");


// consoldan beep diye ses cixarir
//Console.Beep(250000, 100);
//Thread.Sleep(1000);


// input
//var data = Console.Read(); // aksi cedvelindeki qarsiligin verecek
//Console.WriteLine(data); // aksi cedvelindeki qarsiligin verecek

//var str = Console.ReadLine(); // string tipinde alir
//Console.WriteLine(str); // string tipinde alir
/*int a = (int)str;*/ // bunu C# da tycasting ede bilmeyecik

// Eded tipli deyerleri input olunmasi

// .Parse() - stringi int tipine cevirir
//var age = int.Parse(Console.ReadLine());
//Console.WriteLine(2025 - age);

// Convert.ToInt32() - stringi int tipine cevirir
//var number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number * 25);

//.TryParse() - stringi int tipine cevirir ve eger cevirse true deyerini qaytarir
//int numb;
//int.TryParse(Console.ReadLine()!, out numb);  
//Console.WriteLine(numb);

//int.TryParse(Console.ReadLine()!, out int numb); // deyiseni bir basa burda elave edirik
//Console.WriteLine(numb);  

// .Readkey() - bir simvol alir
//var key = Console.ReadKey(); // bir simvol alir
//Console.WriteLine(key);

//while (true)
//{
//    var key = Console.ReadKey();
//    Console.WriteLine();
//    Console.WriteLine($"key name = { key.Key}");
//    Console.WriteLine($"key char = {key.KeyChar}");
//}

//salam
//using System.Net.NetworkInformation;

//
//
//
//NetworkAddressChangedEventHandler sen men 