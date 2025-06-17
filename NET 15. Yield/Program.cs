// yield return, yield break

var hellos = GetResult();
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);

//while (hellos.MoveNext()) // MoveNext() metodu, IEnumerator interfeysinin bir hissesi olaraq, false verene qeder chap edir
//{
//    Console.WriteLine(hellos.Current);
//}

//var Goodbyes = GetValues();
//Console.WriteLine(Goodbyes.MoveNext());



IEnumerator<string> GetResult()
{
    yield return "salam";
    yield return "Aloha";
    yield return "Alo";
    yield return "Hi";
    yield return "salam Aleykum";
    yield return "Hello";
}

IEnumerator<string> GetValues()
{
    List<string> strings = ["Hello", "World", "C#", "Programming", "Yield"];
    for (global::System.Int32 i = 0; i < strings.Count; i++)
    {
        yield return strings[i].ToUpper();
    }
}
