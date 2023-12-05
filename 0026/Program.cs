//Find the value of d < 1000 for which contains the longest recurring cycle in its decimal fraction part.

var maxCycleLength = 0;
for (int d = 1; d < 1000; d++)
{
    var cycleLength = getCycleLength(d);
    if (cycleLength > maxCycleLength)
    {
        maxCycleLength = cycleLength;
        Console.WriteLine($"{d}: {cycleLength}");
    }
}

int getCycleLength(int d)
{
    var numerator = 1;
    var numeratorHistory = new List<int>();
    while (true)
    {
        while (numerator < d)
        {
            numerator *= 10;
        }
        var remainder = numerator % d;
        if (remainder == 0)
        {
            return 0;
        }
        if (numeratorHistory.Contains(remainder))
        {
            return numeratorHistory.Count - numeratorHistory.IndexOf(remainder);
        }
        numeratorHistory.Add(remainder);
        numerator = remainder;
    }
}