
using System.Numerics;

BigInteger result = factorial(100);
Console.WriteLine(result.ToString().Sum(c => c - '0'));

BigInteger factorial(int n)
{
    BigInteger result = 1;
    for (var i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}