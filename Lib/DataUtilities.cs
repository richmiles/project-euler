namespace Lib
{
    public static class DataUtilities
    {
        public static List<string> ReadLinesFromFile(string path)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        public static int SumOfDivisors(int n)
        {
            var sum = 0;
            for (var i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

}
