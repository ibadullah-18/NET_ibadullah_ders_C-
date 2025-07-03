// Chain of Reponsibility - CoR
class LexiceAnalizer : CompilerCor
{
    public override void Handle()
    {
        // soe magic code
        Console.WriteLine("Lexica Analyzer");
        Next?.Handle();
    }
}
