// boxing - unboxsing

// Boxing
// value type deyeri, reference type (object) deyisene yazmaqdir

object obj = 29.5;
Console.WriteLine($"Boxing - {obj}"); // obyektin icine yazdiq


// Unboxing
//obj + 25.6 - isdifade elemek olur
double number = (double)obj;
Console.WriteLine($"Unboxing - {number}"); // burdada eksidi


