// Extension methondds

string word = "Lorem ipsun dolor sit amet. assalamu aleykum";
//Console.WriteLine( CountWords(word));
Console.WriteLine(word.CountWords());

static class StringExtension
{
    public static int CountWords(this string word)
    {
        if(string.IsNullOrEmpty(word))
        {
            return 0;
        }
        var words = word.Split(' ');
        return words.Length;
    }
}
//int CountWords(string word)
//{
//    var words = word.Split(' ');
//    return words.Length;
//}  