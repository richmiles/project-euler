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
        var sum = sumOfDivisors(i);
        if (sumOfDivisors(sum) == i && sum != i)
        {
            amicableNumbers.Add(i);
            amicableNumbers.Add(sum);
        }
    }
    return amicableNumbers;
}

int sumOfDivisors(int n)
{
    var sum = 0;
    for (var i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum;
}