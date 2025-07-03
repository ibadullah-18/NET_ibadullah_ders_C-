// Chain of Reponsibility - CoR


ICompile compile = new SyntaxAnalizer()
    .SetNext(new LexiceAnalizer()
    .SetNext(new Linker()));
compile.Handle();

Console.WriteLine();
Console.WriteLine();


ICompile compile2 = new LexiceAnalizer()
    .SetNext(new SyntaxAnalizer()
    .SetNext(new SomeSuperHandle()
    .SetNext(new Linker())));
compile2.Handle();