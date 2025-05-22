// Indexer - indeksator
// class e ya structur instanse-nin(obyektinin, numunesinin) ozunu massiv(array) kimi aparmasi

// public return_type this[params]{get; set;}

Garage garage = new Garage(7);
garage[0] = new Car { Model = "BMW", Price = "10000" };
garage[1] = new Car { Model = "Mercedes", Price = "20000" };
garage[2] = new Car { Model = "Audi", Price = "30000" };
garage[3] = new Car { Model = "Toyota", Price = "40000" };
garage[4] = new Car { Model = "Honda", Price = "50000" };
garage[5] = new Car { Model = "Ford", Price = "60000" };
garage[6] = new Car { Model = "Lexus", Price = "70000" };

//Console.WriteLine("Cars in garage: ");
//for (int i = 0; i < garage.Count; i++)
//{
//    Console.WriteLine(garage[i]);
//}

//Console.WriteLine(garage[1]);
//garage[1].Model = "Xezer";
//Console.WriteLine(garage[1]);
//garage[1] = new Car { Model = "BYD", Price = "10000" };
//Console.WriteLine(garage[1]);

// indexsatr haqqinda sual gelecek basqa dilde

//Console.WriteLine(garage["Lexus"]);

MultiArray multiArray = new(3, 3);
Random random = new();

//for (int i = 0; i < multiArray.Rows; i++)
//{
//    for (int j = 0; j < multiArray.Columns; j++)
//    {
//        multiArray[i,j] = random.Next(10, 99);                  
//    }
//}


//for (int i = 0; i < multiArray.Rows; i++)
//{
//    for (int j = 0; j < multiArray.Columns; j++)
//    {
//        Console.Write($"{multiArray[i , j]} ");
//    }
//    Console.WriteLine();
//}