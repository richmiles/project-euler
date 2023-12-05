using Lib;

var sumOfAmicableNumbers = 0;
foreach (var amicableNumber in amicableNumbers(10000))
{
    sumOfAmicableNumbers += amicableNumber;
}
Console.WriteLine(sumOfAmicableNumbers);


HashSet<int> amicableNumbers(int max)
{
    HashSet<int> amicableNumbers = new HashSet<int>();
    for (var i = 1; i < max; i++)
    {
        if (amicableNumbers.Contains(i)) { continue; }
        var sum = DataUtilities.SumOfDivisors(i);
        if (DataUtilities.SumOfDivisors(sum) == i && sum != i)
        {
            amicableNumbers.Add(i);
            amicableNumbers.Add(sum);
        }
    }
    return amicableNumbers;
}