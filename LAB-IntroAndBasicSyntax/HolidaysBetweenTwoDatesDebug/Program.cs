using System;
using System.Globalization;

/*
1.05.2016
15.05.2016
 */


var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

//string startDateInput = Console.ReadLine();
//int[] startDateSplit = Array.ConvertAll(startDateInput.Split('.'), int.Parse);
//startDateInput = $"{startDateSplit[0]:D2}.{startDateSplit[1]:D2}.{startDateSplit[2]}";
//var startDate = DateTime.ParseExact(startDateInput, "dd.mm.yyyy", CultureInfo.InvariantCulture);

//string endDateInput = Console.ReadLine();
//int[] endDateSplit = Array.ConvertAll(endDateInput.Split('.'), int.Parse);
//endDateInput = $"{endDateSplit[0]:D2}.{endDateSplit[1]:D2}.{endDateSplit[2]}";
//var endDate = DateTime.ParseExact(endDateInput, "dd.mm.yyyy", CultureInfo.InvariantCulture);

var holidaysCount = 0;

for (var date = startDate; date <= endDate; date = date.AddDays(1))
{
    if (startDate > endDate) {
        break;
    }
    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
    {
        holidaysCount++;
    }
    Console.WriteLine();
}

Console.WriteLine(holidaysCount);
