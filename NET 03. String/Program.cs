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

// intern pool
string name1 = "Ali";
string name2 = "Ali";
string myName = name1;
string name3 = new string("Ali");
// yeni bunnarin hamsi bir yaddas sahesi saxlayir
Console.WriteLine($@"name1  = {name1}
name2  = {name2} 
myName = {myName} 
name3  = {name3}");
Console.WriteLine(name1[0]);

name1 += 'a';
Console.WriteLine($@"name1  = {name1}
name2  = {name2} 
myName = {myName} 
name3  = {name3}");
