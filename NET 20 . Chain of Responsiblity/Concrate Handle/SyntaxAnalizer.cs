// Chain of Reponsibility - CoR
class SyntaxAnalizer : CompilerCor
{
    public override void Handle()
    {
        // soe magic code
        Console.WriteLine("Systex Analyzer");
        Next?.Handle();
    }
}
