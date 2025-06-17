// regular exression

using System.Text.RegularExpressions;

string pass = "Ibo!2007";
string mail = "Husey_iz52@itstep.edu.az";
#region Classic Way

//bool lower = false;
//bool upper = false;
//bool number = false;
//List<bool> criteries =[false, false, false];
//for (int i = 0; i < pass.Length; i++)
//{
//    if (pass[i] >='A'&& pass[i]<='Z') criteries[0] = true;
//    if (pass[i] >='a'&& pass[i]<='z') criteries[1]= true;
//    if (pass[i] >='0'&& pass[i]<='9') criteries[2] = true;
//}
//if(criteries.All(x=>x==true)) Console.WriteLine("Passwrd is corret");
//else Console.WriteLine("Incorret password");



#endregion

#region RegEx
// RegEx - Regular Expression:
/*
.       - her hansi bir simvol
\w      - her hansi bir simvol, herf, reqem, alt cizgi
\W      - her hansi bir simvol, herf, reqem, alt cizgi xaric
\s      - her hansi bir simvol, bosluq, tab, yeni whitespace
\S      - her hansi bir simvol, bosluq, tab xaric
\d      - her hansi bir simvol, reqem
\D      - her hansi bir simvol, reqem xaric
[symbols] - moterize icindeki gosderilen her hansi bir simvol
[^symbols] - moterize icindeki gosderilen her hansi bir simvol xaric
[a-z]   - a dan z ye qeder olan herfler
[^a-z]   - a dan z ye qeder olan herfler hec biri

*       - 0 ve ya daha cox defe tekrarlanir
+       - 1 ve ya daha cox defe- tekrarlanir
?       - 0 ve ya 1 defe tekrarlanir
{n,m}   - n defeden az olmayaraq m defeden cox olmayaraq tekrarlanir
{n,}    - n defeden az olmayaraq tekrarlanir
{n}     - n defe tekrarlanir
^       - sblon evvelinde olmalidir
$       - sblon axirinda olmalidir
*/

string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
Regex regex = new(passwordPattern);
Console.WriteLine(regex.IsMatch(pass));
/*
 
(?=.*[a-z]) → Ən azı bir kiçik hərf olmalıdır.

(?=.*[A-Z]) → Ən azı bir böyük hərf olmalıdır.

(?=.*\d) → Ən azı bir rəqəm olmalıdır.

.{8,} → Ümumi uzunluğu ən az 8 simvol olmalıdır.

*/
#endregion