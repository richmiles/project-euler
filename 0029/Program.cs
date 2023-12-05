using System.Numerics;

var distinctTerms = new HashSet<BigInteger>();
for (BigInteger a = 2; a <= 100; a++)
{
    for (BigInteger b = 2; b <= 100; b++)
    {
        var result = BigInteger.Pow(a, (int)b);
        distinctTerms.Add(result);
    }
}
Console.WriteLine(distinctTerms.Count);