// Chain of Reponsibility - CoR
class Linker : CompilerCor
{
    public override void Handle()
    {
        // soe magic code
        Console.WriteLine("Linker Analyzer");
        Next?.Handle();
    }
}