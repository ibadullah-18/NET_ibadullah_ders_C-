// Chain of Reponsibility - CoR
interface ICompile
{
    CompilerCor SetNext(CompilerCor nextHandle);
    void Handle();
}
