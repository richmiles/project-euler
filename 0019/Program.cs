var sundays = 0;
for(int year = 1901; year <= 2000; year++)
{
    for(int month = 1; month <= 12; month++)
    {
        var date = new DateTime(year, month, 1);
        if(date.DayOfWeek == DayOfWeek.Sunday)
        {
            sundays++;
        }
    }
}

Console.WriteLine(sundays);