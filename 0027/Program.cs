//Find the product of the coefficients, a and b, for the quadratic expression
//that produces the maximum number of primes for consecutive values of n, starting with n=0.

int maxN = 0;
int maxA = 0;
int maxB = 0;

for(var a = -999; a < 1000; a++)
{
    for (var b = -1000; b <= 1000; b++)
    {
        var n = 0;
        while (isPrime(quadratic(a, b, n)))
        {
            n++;
        }
        if (n > maxN)
        {
            maxN = n;
            maxA = a;
            maxB = b;
        }
    }
}

Console.WriteLine($"a: {maxA}, b:{maxB}, primes: {maxN}, product:{maxA * maxB}");

int quadratic(int a, int b, int n)
{
    return n * n + a * n + b;
}

bool isPrime(int n)
{
    if (n < 2) { return false; }
    if (n == 2) { return true; }
    if (n % 2 == 0) { return false; }
    for (var i = 3; i <= Math.Sqrt(n); i += 2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}