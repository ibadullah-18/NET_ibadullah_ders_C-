// Struckts
// 1. Struct obyektleri stack-de yaranir

// 2. Parametrli constructor yaratdiqda,
//    defolt constructor silinmir

// 3. Structlarda copy hemin deep copy-dir
//    (yeni value-leri copy edir)

// 4. Structlar toremek mumkun deyil


Point point = new Point();
//point.x = 10;
//point.y = 20;   
Console.WriteLine($"x = {point.x}, y = {point.y}");
Point point1 = point;
Console.WriteLine($"x = {point1.x}, y = {point1.y}");

point.y = 8;
Console.WriteLine($"x = {point.x}, y = {point.y}");
Console.WriteLine($"x = {point1.x}, y = {point1.y}");
