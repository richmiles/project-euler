
using Lib;
HashSet<string> abundantNumbers = new HashSet<string>();
for (var i = 1; i < 28123; i++)
{
    if (isAbundantNumber(i))
    {
        abundantNumbers.Add(i.ToString());
    }
}

// Find all numbers that can be written as the sum of two abundant numbers
HashSet<string> numbersThatCanBeWrittenAsTheSumOfTwoAbundantNumbers = new HashSet<string>();
foreach (var abundantNumber in abundantNumbers)
{
    foreach (var otherAbundantNumber in abundantNumbers)
    {
        var abundantSum = int.Parse(abundantNumber) + int.Parse(otherAbundantNumber);
        if (abundantSum < 28123)
        {
            numbersThatCanBeWrittenAsTheSumOfTwoAbundantNumbers.Add(abundantSum.ToString());
        }
    }
}

// Find all numbers that cannot be written as the sum of two abundant numbers
HashSet<string> numbersThatCannotBeWrittenAsTheSumOfTwoAbundantNumbers = new HashSet<string>();
for (var i = 1; i < 28123; i++)
{
    if (!numbersThatCanBeWrittenAsTheSumOfTwoAbundantNumbers.Contains(i.ToString()))
    {
        numbersThatCannotBeWrittenAsTheSumOfTwoAbundantNumbers.Add(i.ToString());
    }
}

// Sum all numbers that cannot be written as the sum of two abundant numbers
var sum = 0;
foreach (var number in numbersThatCannotBeWrittenAsTheSumOfTwoAbundantNumbers)
{
    sum += int.Parse(number);
}
Console.WriteLine(sum);
bool isAbundantNumber(int n)
{
    return DataUtilities.SumOfDivisors(n) > n;
}