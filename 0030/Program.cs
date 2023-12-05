
var sumsOfFifthPowers = new List<int>();
for (int i = 2; i < 1000000; i++)
{
    var digits = getDigits(i);
    var sumOfFifthPowers = 0;
    for (var digitIndex = 0; digitIndex < digits.Count; digitIndex++)
    {
        sumOfFifthPowers += (int)Math.Pow(digits[digitIndex], 5);
    }
    if (sumOfFifthPowers == i)
    {
        sumsOfFifthPowers.Add(i);
    }
}

Console.WriteLine(sumsOfFifthPowers.Sum());

List<int> getDigits(int n)
{
    var digits = new List<int>();
    while (n > 0)
    {
        digits.Add(n % 10);
        n /= 10;
    }
    digits.Reverse();
    return digits;
}