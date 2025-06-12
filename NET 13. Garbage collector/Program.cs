// Garbage collector
/*
1. stack - FILO (First In Last Out) prinsipi ile isleyir. Gorunme zonasi bitdiyi zaman
    obyekt stack - den avtomatik olaraq silinir.
2. Heap
     - Managed Heap
         * Generation 0
         * Generation 1
         * Generation 2
     Heap - da yaradilan obyektler silinmesinde GarbageCollector cavabdehdir.

     - LOH (Large Object Heap)
         * 85.000 byte - dan boyuk obyektler LOH - da yaradilir.
         * GarbageCollector - bu obyektleri silmir, cunku bu obyektler tez-tez istifade olunur.
     
     - Pinned Heap: Garbage Collector terefinden obyetktin yeri deyishdirile bilmir
                   Adeten unmanaged kodlarda istifade olunur.

     - Unmanaged Heap: .NET - in idarə etmədiyi obyektlerdir. Məsələn, C++ dilində yaradılan obyektlər.
*/

//Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new();
//garbageHelper.MakeGarbage();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//Console.WriteLine($"Memory {GC.GetTotalMemory(false)} bytes");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
var genNumber = 0;
Person person = new Person();
Console.WriteLine();
for (int i = 1; i < 1_000_000; i++)
{
    garbageHelper.MakeGarbage();
    if (genNumber != GC.GetGeneration(garbageHelper))
    {
        Console.WriteLine($"{i * 1000} - Generation {GC.GetGeneration(garbageHelper)}");
        genNumber++;
    }
}