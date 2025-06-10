// delgates
// delegate return_datatype delegate_name([parameter list])


#region delagate
//double numb1 = default;
//double numb2 = default;

//Console.WriteLine("Birinci ededi daxil edin");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Ikinci ededi daxil edin");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Emeliyatlardan birini sechin: +, -, *, /");
//char.TryParse(Console.ReadLine(), out operation);

//CalculatorDelagate calculator = null!;

//switch ((arithmeticOperators)operation)
//{
//    case arithmeticOperators.ADD:
//        calculator = add;
//        break;
//    case arithmeticOperators.SUBTRACT:
//        calculator = subtract;
//        break;
//    case arithmeticOperators.MULTIPLE:
//        calculator = multiple;
//        break;
//    case arithmeticOperators.DIVIDE:
//        calculator = divide;
//        break;
//}

////if (calculator is not null) 
////    Console.WriteLine(calculator(numb1, numb2));

//if (calculator is not null)
//    Console.WriteLine(calculator.Invoke(numb1, numb2));


#endregion

#region Multicast delegate
//CalculatorDelagate operations = add;
//operations += subtract;
//operations += multiple;
//operations += divide;

//double number1 = 97, number2 = 3;

//Console.WriteLine(operations(number1, number2));

//foreach (CalculatorDelagate item in operations.GetInvocationList())
//{
//    Console.WriteLine(item(number1, number2));
//}

//var delegateList = operations.GetInvocationList();
//Console.WriteLine(delegateList[0].Method);
//Console.WriteLine(delegateList[1].Method);
//Console.WriteLine(delegateList[2].Method);
//Console.WriteLine(delegateList[3].Method);

//Console.WriteLine(delegateList[0].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[1].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[2].DynamicInvoke(number1, number2));
//Console.WriteLine(delegateList[3].DynamicInvoke(number1, number2));

#endregion

#region Generic delegates
//GenericCalculator<double> genericCalculator = add;
//GenericCalculator<int> genericCalculator1 = Foo;
//Console.WriteLine(genericCalculator(25, 36));
#endregion

#region Sdandard generic delegates
// Action<T>, Func<T>, Predicate<T>, Comparison<T>

// delgates
// delegate return_datatype delegate_name([parameter list])
internal class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} - > {Age}";
    }
}