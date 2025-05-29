// Delegates
// delegate return_datatype delegate_name([parameter_list]);


#region delegate
//double numb1 = default;
//double numb2 = default;
//Console.WriteLine("Birinci ededi daxil edin: ");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Ikinci ededi daxil edin: ");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Emeliyatlarda birini secin: +, -, *, /");
//char.TryParse(Console.ReadLine(), out operation);

//CalculatorDelegate calculator = null;
//switch((arithmeticOperations)operation)
//{
//    case arithmeticOperations.ADD:
//        calculator = add;
//        break;
//    case arithmeticOperations.SUBTRACT:
//        calculator = subtrasct;
//        break;
//    case arithmeticOperations.MULTIPL:
//        calculator = multipl;
//        break;
//    case arithmeticOperations.DIVIDE:
//        calculator = divide;
//        break;
//    default:
//        Console.WriteLine("Duzgun emeliyat secilmedi");
//        return;
//}
////if (calculator is not null)
////{
////    Console.WriteLine(calculator(numb1,numb2));
////}
//if (calculator is not null)
//{
//    Console.WriteLine(calculator.Invoke(numb1,numb2));// Invoke() metodu delegate-in icra olunmasini tetikler
//}

//double add(double left, double right) { return left + right; }
//double subtrasct(double left, double right) {return left - right; }
//double multipl(double left, double right) {return left * right; }
//double divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

#endregion

#region Multicast delegate
//CalculatorDelegate operations = add;
//operations += subtrasct;
//operations += multipl;
//operations += divide;

//double numb1 = 13, numb2 = 10;

//Console.WriteLine(operations(numb1,numb2));
//foreach (CalculatorDelegate item in operations.GetInvocationList()) // GetInvocationList() metodu delegate-in icra siyahisini qaytarir
//{
//    Console.WriteLine(item(numb1,numb2));
//}

//var delegatesList = operations.GetInvocationList();
//Console.WriteLine(delegatesList[0].Method);
//Console.WriteLine(delegatesList[1].Method);
//Console.WriteLine(delegatesList[2].Method);
//Console.WriteLine(delegatesList[0].Method);
//Console.WriteLine();
//Console.WriteLine(delegatesList[0].DynamicInvoke(numb1, numb2)); // DynamicInvoke() metodu delegate-in icra olunmasini tetikler ve parametrlere ehtiyac duymur
//Console.WriteLine(delegatesList[1].DynamicInvoke(numb1, numb2));
//Console.WriteLine(delegatesList[2].DynamicInvoke(numb1, numb2));
//Console.WriteLine(delegatesList[0].DynamicInvoke(numb1, numb2));
#endregion

#region Generic delegate
//GenericDelegate<double> genericAdd = add;
//GenericDelegate<int> genericIntAdd = Foo;
//Console.WriteLine(genericAdd(25,36)); 
#endregion

#region Sdandart generic delegate
// Action<T> - void qaytaran delegate
// Func<T, TResult> - TResult qaytaran delegate
// Predicate<T> - bool qaytaran delegate
// Compare<T> - iki parametrli delegate

List<int> ints =[ 36,43,-12,76,-52,79,-90];

#region Action<T>
//var lst = Fillter(ints, isOdd);
//foreach (var item in lst)
//{
//    Console.WriteLine($"{item} ");
//}

//var lst = Fillter(ints, delegate(int x) { return x < 0; });
//foreach (var item in lst)
//{
//    Console.WriteLine($"{item} ");
//}

// Action<T> - 16-ya qeder parametr qebul eden ve void qaytaran methodlari saxlaya bilen delegatedir
//int[] arr = new int[17];
//Random rnd = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = rnd.Next(-99, 99);
//}
//foreach (var item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

// Action<int, int> <=> public delegate void del_name(int x, int y);
#endregion

#region Func<T>
// Func<T> 16-ya qeder ede bilen ve return type olan generate delegate dir
// Func<double, double,doubl> func <=> public delegate double delegate_name(double left, double right, double up);

//Console.WriteLine(Calculator(5,78,divide));
//double Calculator(double numb1,double numb2, Func<double, double,double> func)
//{
//    return func(numb1,numb2);
//}
#endregion

#region Comparison<T>
// Comparison<T> - iki parametrli delegatedir ve int qaytarir
// Comparison<int> compare = (x, y) => x - y;
//List<Hunam> hunams = [
//    new Hunam(){ Name = "Aysel", Age = 25 },
//    new Hunam(){ Name = "Elvin", Age = 30 },
//    new Hunam(){ Name = "Zlvin", Age = 20 },
//    new Hunam(){ Name = "Blvin", Age = 34 },
//    new Hunam(){ Name = "Nlvin", Age = 19 },

//    ];
//foreach (var item in hunams)
//{
//    Console.WriteLine(item);
//}
////hunams.Sort(NameComparison);
////hunams.Sort(AgeComparison);
//Console.WriteLine();
//foreach (var item in hunams)
//{
//    Console.WriteLine(item);
//}
//Func<Hunam, Hunam, int> func = NameComparison;
//Func<int,bool> func1 = isNegative;
//int NameComparison(Hunam hunam1,Hunam hunam2)
//{
//    return hunam1.Name.CompareTo(hunam2.Name);
//}
//int AgeComparison(Hunam hunam1, Hunam hunam2)
//{
//    return hunam1.Age.CompareTo(hunam2.Age);
//}

#endregion

#region Predicate<T>
// Predicate<T> - bir parametrli ve bool qaytaran generate delegate-dir
// Predicate<int> <=> public delegate bool delegate_name(int x);
//var negative = FillterPredicate(ints, isNegative);
//negative.ForEach(Console.WriteLine);

#endregion

#endregion
List<int> FillterPredicate(List<int> ints, FillterDelegate fillterDelegate)
{
    List<int> tmp = [];
    foreach (var item in ints)
    {
        if (fillterDelegate(item)) tmp.Add(item);
    }
    return tmp;
}
//void FillteringShow(int[]arr, Action<int>) { }
double add(double left, double right) { return left + right; }
int Foo(int left, int right) { return left + right; }
bool isNegative(int x) => x < 0;
bool isOdd(int x) => x % 2 == 0;
void ShowNegative(int x){
    if (isNegative(x))
    {
        Console.WriteLine(x);
    }
}
double subtrasct(double left, double right) { return left - right; }
double multipl(double left, double right) { return left * right; }
double divide(double left, double right)
{
    if (right != 0) return left / right;
    throw new DivideByZeroException();
}

public delegate double CalculatorDelegate(double left, double right);
public delegate bool Predic(int x);

// Generic(teplate) delegate
public delegate T GenericDelegate<T>(T left, T right);
public delegate bool FillterDelegate(int a);
enum arithmeticOperations
{
    ADD = '+',
    SUBTRACT = '-',
    MULTIPL = '*',
    DIVIDE = '/'
}

