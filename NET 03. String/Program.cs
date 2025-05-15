// String

#region string initialization and compare
//string str = "Hello, World!";
//string str2 = new string("Hello, World!");
//Console.WriteLine(str == str2);
//Console.WriteLine(str.Equals(str2));
//Console.WriteLine(str.CompareTo(str2));
#endregion

#region string constructors with char parametrs 
//char[] chars = { 'H', 'e', 'l', 'l', 'o' };
//Console.WriteLine(chars);
//string str3 = new string(chars);
//Console.WriteLine(str3);
//string str4 = new string('H', 50); // bele yazanda o sinvoldan ne qeder cixartmaq isdeyirsen onu yazirsan
//Console.WriteLine(str4);
#endregion

#region inter pool
// intern pool
//string name1 = "Ali";
//string name2 = "Ali";
//string myName = name1;
//string name3 = new string("Ali");
//string a = "A";
//string li = "li";
//string name4 = a + li; // string concatenation
// yeni bunnarin hamsi bir yaddas sahesi saxlayir
// na goreki eyni yazilardi deye ancaq name3 ile name4 eyni yaddas sahesinde olmayacaq

//Console.WriteLine($@"name1  = {name1}
//name2  = {name2} 
//myName = {myName} 
//name3  = {name3}");
//Console.WriteLine(name1[0]);

//name1 += 'a';
//Console.WriteLine($@"name1  = {name1}
//name2  = {name2} 
//myName = {myName} 
//name3  = {name3}");


//Console.WriteLine(object.ReferenceEquals(name1,name2));
//Console.WriteLine(object.ReferenceEquals(name1,name3));
//Console.WriteLine(object.ReferenceEquals(name1,name4));
//Console.WriteLine(object.ReferenceEquals(name1,myName));

#endregion

#region string range, indices
//string word = "lorem ipsum dolor";
//Console.WriteLine(word[0]);
//Console.WriteLine(word[0..5]);
//Console.WriteLine(word[^1]);

//string new_word = word[0].ToString().ToUpper();
//for (int i = 0; i < word.Length; i++)
//{
//    new_word += word[i];
//}
//Console.WriteLine(new_word);

//string new_word = word[0].ToString().ToUpper()+word[1..];
//Console.WriteLine(new_word);
#endregion

string word = "Lorem,   ipsum ,,   dolor, sit, amet";
//Console.WriteLine(word.Length); // uzunuq qaytarir
//Console.WriteLine(word.ToUpper()); // butun herifleri boyuk edir
//Console.WriteLine(word.ToLower()); // butun herifleri kicik edir

//var strings = word.Split(','); // her velgulde diger stre kecir
//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}

//var strings2 = word.Split(',', StringSplitOptions.RemoveEmptyEntries); // iki velgul arasindaki olan stri silir
//foreach (var item in strings2)
//{
//    Console.WriteLine(item);
//}

//var strings3 = word.Split(',', StringSplitOptions.TrimEntries); // velgulden evvel olan bosluqlari silir 
//foreach (var item in strings3)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(word.IndexOf('a')); // qeyd olunan herfi setirde tapsa indexsin, tapmasa -1 verecek

Console.WriteLine();
// Raw string literals - introducid in C# 11
//string code = """
    
//Console.WriteLine(word.Length); // uzunuq qaytarir
    
//Console.WriteLine(word.ToUpper()); // butun herifleri boyuk edir
//Console.WriteLine(word.ToLower()); // butun herifleri kicik edir

//var strings = word.Split(','); // her velgulde diger stre kecir
//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}

//var strings2 = word.Split(',', StringSplitOptions.RemoveEmptyEntries); // iki velgul arasindaki olan stri silir
//foreach (var item in strings2)
//{
//    Console.WriteLine(item);
//}

//var strings3 = word.Split(',', StringSplitOptions.TrimEntries); // velgulden evvel olan bosluqlari silir 
//foreach (var item in strings3)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(word.IndexOf('a')); // qeyd olunan herfi setirde tapsa indexsin, tapmasa -1 verecek
    
//""";

//Console.WriteLine(code); // """""" bu nece yazirsan elede cap edir
// $$ goyanda yazdigin metinde isdediyin kodu gondere bilersen mes {{name1}}


