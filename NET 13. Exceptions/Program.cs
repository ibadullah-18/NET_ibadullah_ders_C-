// Exceptions

/*
     Exception
        - SystemException
        - ApplicationException
*/


int numb1 = 3;
int numb2 = 0;
int result = default;

try
{
    result = numb1 / numb2;
    Console.WriteLine(result);
}

catch (DivideByZeroException ex) // sifra boluneme exceptionsu
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}"); // Message ne oldugunu soyluyor
    Console.WriteLine();
    Console.WriteLine($"StackTrace - {ex.StackTrace}"); // StackTrace, nerede oldugunu soyluyor
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}"); // TargetSite, hangi metot oldugunu soyluyor
}
//catch (Exception ex)
//{
//    Console.WriteLine("Catch in Main - DivideByZeroException");
//    Console.WriteLine();
//    Console.WriteLine($"Message - {ex.Message}"); // Message ne oldugunu soyluyor
//    Console.WriteLine();
//    Console.WriteLine($"StackTrace - {ex.StackTrace}"); // StackTrace, nerede oldugunu soyluyor
//    Console.WriteLine();
//    Console.WriteLine($"Target site - {ex.TargetSite}"); // TargetSite, hangi metot oldugunu soyluyor
//}

//catch
//{
//    Console.WriteLine("Catch in Main - Any exception");

//}
finally
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("assalamu aleykum");
}




