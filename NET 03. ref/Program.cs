/*
 
 */

using System.Text;

int number = 18;
int number2 = 156;
int[] arr = [1, 2, 3, 4, 5];
StringBuilder arrToString = new();
foreach (var item in arr)
{
    arrToString.Append($"{item} ");
}

Console.WriteLine($@"Befor call ChangeValue method:
number = {number}
number2 = {number2}
arr = {arrToString}");

ChangeValue(number, arr);
Console.WriteLine();

arrToString.Clear();
foreach (var item in arr)
{
    arrToString.Append($"{item} ");
}

Console.WriteLine($@"After call ChangeValue method:
number = {number}
number2 = {number2}
arr = {arrToString}");

void ChangeValue(int number, int[] arr)
{
    number += 23;
    arr[0] = number;
}