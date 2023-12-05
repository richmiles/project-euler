using System.Numerics;

Console.WriteLine(fibonacci(1000));

//Find the first fibonacci number with 1000 digits
BigInteger fibonacci(int digits)
{
    BigInteger a = 1;
    BigInteger b = 1;
    BigInteger c = 0;
    var index = 2;
    while (c.ToString().Length < digits)
    {
        c = a + b;
        a = b;
        b = c;
        index++;
    }
    return index;
}