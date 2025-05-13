// switch

using System.Diagnostics;
using System.Threading.Channels;

int.TryParse(Console.ReadLine(), out int weekDay);
// break sozu mutleq yazilmalidi
switch ((WeekDays)weekDay)
{
    case WeekDays.Monday:
        Console.WriteLine("Monday");
        break;
    case WeekDays.Tuesday:
        Console.WriteLine("Tuesday");
        break;
    case WeekDays.Wednesday:
        Console.WriteLine("Wednesday");
        break;
    case WeekDays.Thursday:
        Console.WriteLine("Thursday");
        break;
    case WeekDays.Friday:
        Console.WriteLine("Friday");
        break;
    case WeekDays.Saturday:
        Console.WriteLine("Saturday");
        break;
    case WeekDays.Sunday:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

double.TryParse(Console.ReadLine(), out double number);
switch(number)
{
    case 1.0:
        Console.WriteLine("One");
        break;
    case 2.0:
        Console.WriteLine("Two");
        break;
    case 3.0:
        Console.WriteLine("Three");
        break;
    default:
        Console.WriteLine("Invalid number");
        break;
}// burada istenile tipde case yazmaq mumkundu!!

string name = Console.ReadLine();
switch (name)
{
    case "ibadulla":
        Console.WriteLine("ibadulla");
        break;
    case "huseynzade":
        Console.WriteLine("huseynzade");
        break;
    default:
        Console.WriteLine("Invalid name");
        break;
}// burada istenile tipde case yazmaq mumkundu!!

int.TryParse(Console.ReadLine(), out int month);

switch((Months)month)
{
    case Months.January:
    case Months.March:
    case Months.May:
    case Months.July:
    case Months.August:
        goto case Months.December;
    case Months.April:
    case Months.June:
    case Months.September:
    case Months.October:
        goto case Months.November;

    case Months.February:
        Console.WriteLine("28 gundur");
        break;
      
    case Months.November:
        Console.WriteLine("30 gundur");
        break;
    case Months.December:
        Console.WriteLine("31 gundur");
        break;
    default:
        Console.WriteLine("Invalid month");
        break;
    }

enum WeekDays
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}


