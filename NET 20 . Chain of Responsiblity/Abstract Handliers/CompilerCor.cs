// Chain of Reponsibility - CoR
abstract class CompilerCor : ICompile
{
    protected CompilerCor Next { get; set; }

    public CompilerCor SetNext(CompilerCor nextHandle)
    {
        Next = nextHandle;
        return this;
    }

    public abstract void Handle();
}