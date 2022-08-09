static double powEquation(int x)
{
    return -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
}

static double funWithAbs(int x)
{
    return Math.Abs(x) * Math.Sin(x);
}

static double equationWithPi(int x)
{
    return 2 * Math.PI * x;
}
static int maxValue(int number1, int number2)
{
    return Math.Max(number1, number2);
}


static TimeSpan daysPassedFromNY()
{
    DateTime newYear = new DateTime(2022, 1, 1);
    DateTime today = DateTime.Today;
    TimeSpan daysPassed = today - newYear;

    return daysPassed;
}

static TimeSpan daysLeftToNY()
{
    DateTime future = new DateTime(2023, 1, 1);
    DateTime today = DateTime.Today;
    TimeSpan daysLeft = future - today;

    return daysLeft;
}

Console.WriteLine("Pow equation: {0}", powEquation(x: -6));
Console.WriteLine("Fun with Math.Abs(): {0}", funWithAbs(x: -637));
Console.WriteLine("Pi equation: {0}", equationWithPi(x: 900));
Console.WriteLine("Max value is: {0}", maxValue(number1: 89, number2: 71));
// Extra
Console.WriteLine("Days passed from New Year: {0}", daysPassedFromNY());
Console.WriteLine("Days left to New Year: {0}", daysLeftToNY());

Console.ReadLine();
//checked
