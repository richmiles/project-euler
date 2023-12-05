using Lib;
using System.Xml.Linq;

var names = File.ReadAllText("0022_names.txt");
var lines = names.Split(',').Select(s => s.Trim('"')).ToList();
lines.Sort();
var totalScore = 0L;
for(var nameIndex = 0; nameIndex < lines.Count; nameIndex++)
{
    var name = lines[nameIndex];
    var nameScore = score(name);
    var position = nameIndex + 1;
    totalScore += nameScore * position;
}
Console.WriteLine($"{totalScore}");

int score(string name)
{
    var sum = 0;
    foreach (var c in name)
    {
        sum += c - 'A' + 1;
    }
    return sum;
}