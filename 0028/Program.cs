//Determine the n for which a spiral will be 1001 x 1001
int maxN = 500;
var diagonalSum = 1;
for(int n = 1; n <= maxN; n++)
{
    diagonalSum += calculateCorners(n).Sum();
}
Console.WriteLine(diagonalSum);

int calculateSpiralWidth(int n)
{
    return 2 * n + 1;
}

List<int> calculateCorners(int n)
{
    if (n == 0) { throw new ArgumentException("n must be greater than 0"); }

    var width = calculateSpiralWidth(n);
    var corner1 = width * width;
    var corner2 = corner1 - width + 1;
    var corner3 = corner2 - width + 1;
    var corner4 = corner3 - width + 1;
    return [corner1, corner2, corner3, corner4];
}