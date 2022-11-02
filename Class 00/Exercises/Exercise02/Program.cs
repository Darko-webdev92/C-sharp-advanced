
List<DateTime> dates = new List<DateTime>()
{
    new DateTime(2001, 1, 1),
    new DateTime(2001, 1, 7),
    new DateTime(2001, 4, 20),
    new DateTime(2001, 5, 1),
    new DateTime(2001, 5, 25),
    new DateTime(2001, 8, 3),
    new DateTime(2001, 9, 8),
    new DateTime(2001, 10, 12),
    new DateTime(2001, 10, 23),
    new DateTime(2001, 12, 8)
};
int dayParsed;
int monthParsed;
int yearParsed;
while (true)
{
    Console.WriteLine("Enter day for date");
    string dayInput = Console.ReadLine();

    bool isDayParsed = int.TryParse(dayInput, out dayParsed);

    if (!isDayParsed)
    {
        Console.WriteLine("Invalid input for day");
        continue;
    }
    if (dayParsed > 31)
    {
        Console.WriteLine("Invalid input for day");
        continue;

    }
    break;
}

while (true)
{
    Console.WriteLine("Enter month for date");

    string monthInput = Console.ReadLine();
    bool isMonthParsed = int.TryParse(monthInput, out monthParsed);

    if (!isMonthParsed)
    {
        Console.WriteLine("Invalid input for month");
        continue;
    }
    if (monthParsed > 12)
    {
        Console.WriteLine("Invalid input for month");
        continue;

    }
    break;
}

while (true)
{
    Console.WriteLine("Enter a year for date");

    string yearInput = Console.ReadLine();
    bool isYearParsed = int.TryParse(yearInput, out yearParsed);

    if (!isYearParsed)
    {
        Console.WriteLine("Invalid input for month");
        continue;
    }
    break;
}

DateTime date = new DateTime(yearParsed, monthParsed, dayParsed);
bool ifItsNotWorkingDay = false;
foreach (DateTime nonWorkingDay in dates)
{
    if (nonWorkingDay.Day == date.Day && nonWorkingDay.Month == date.Month)
    {
        Console.WriteLine($"{date.ToString("MM/dd/yyyy")} is a non working day");
        ifItsNotWorkingDay = true;
        break;
    }
}

if ((date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) && ifItsNotWorkingDay == false)
{
    Console.WriteLine($"{date.ToString("MM/dd/yyyy")} is a non working day");

}
else
{
    Console.WriteLine($"{date.ToString("MM/dd/yyyy")} is a working day");
}
 