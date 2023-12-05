using Lib;

var lines = DataUtilities.ReadLinesFromFile("data_live.txt");

List<List<int>> rows = [];
foreach(var line in lines)
{
    rows.Add([]);
    var numbers = line.Split(' ');
    foreach (string number in numbers)
    {
        rows[rows.Count -1].Add(int.Parse(number));
    }
}

// Start from the second to last row and word up to the top
// Add the max of the two numbers below to the current number
for (var rowIndex = rows.Count - 2; rowIndex >= 0; rowIndex--)
{
    for (var numberIndex = 0; numberIndex < rows[rowIndex].Count; numberIndex++)
    {
        var currentNumber = rows[rowIndex][numberIndex];
        var leftNumber = rows[rowIndex + 1][numberIndex];
        var rightNumber = rows[rowIndex + 1][numberIndex + 1];
        rows[rowIndex][numberIndex] = currentNumber + Math.Max(leftNumber, rightNumber);
    }
}
Console.WriteLine(rows[0][0]);