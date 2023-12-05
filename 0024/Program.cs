List<string> digits = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
//List<string> digits = ["0", "1", "2"];

var permutations = permuteDigits(digits);

Console.WriteLine(permutations[999999]);

List<string> permuteDigits(List<string> digits)
{
    List<string> result = [];
    
    if (digits.Count == 1)
    {
        result.Add(digits[0]);
        return result;
    }

    for(int i = 0; i < digits.Count; i++)
    {
        var digit = digits[i];
        var remainingDigits = digits.Where(d => d != digit).ToList();
        var permutations = permuteDigits(remainingDigits);
        foreach(string permutation in permutations)
        {
            var appended = digit + permutation;
            result.Add(appended);
        }
    }
    return result;
}
