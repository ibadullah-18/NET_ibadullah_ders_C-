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

internal class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Person()
    {
        Id = 0;
        Name = string.Empty;
    }
}