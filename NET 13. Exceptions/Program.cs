// Exceptions

/*
     Exception
        - SystemException
        - ApplicationException
*/


//int numb1 = 3;
//int numb2 = 0;
//int result = default;

//try
//{
//    result = numb1 / numb2;
//    Console.WriteLine(result);
//}

//catch (DivideByZeroException ex) // sifra boluneme exceptionsu
//{
//    Console.WriteLine("Catch in Main - DivideByZeroException");
//    Console.WriteLine();
//    Console.WriteLine($"Message - {ex.Message}"); // Message ne oldugunu soyluyor
//    Console.WriteLine();
//    Console.WriteLine($"StackTrace - {ex.StackTrace}"); // StackTrace, nerede oldugunu soyluyor
//    Console.WriteLine();
//    Console.WriteLine($"Target site - {ex.TargetSite}"); // TargetSite, hangi metot oldugunu soyluyor
//}
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
//finally
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("assalamu aleykum");
//}

// oz exceptions yaradmaq
/*
vacib olmayan qayda:
    isdifadeci terefinnen yaradilan excetionlar 
    ApplicationException sinifinden miras almalidir
vacib qayda:
   1. Exception ucun [Serializable] atributu tetbiq olunmalidir
   2. Exception-un defaut constructoru olmalidir
   3. Message propertisini teyin elemek ucun constructor olmalidir
   4. Inner exceptionlari handle etmek ucun overlod olmus constructor olmalidi
   5. Tipi riazisasiya elemek ucun Exception sinifinden miras almalıdır
*/

using System.Runtime.Serialization;

[Serializable]
class MyExceptions : ApplicationException
{
    public MyExceptions(){ }

    public MyExceptions(string? message) : base(message){ }

    public MyExceptions(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }

    protected MyExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}


