//using static System.Runtime.InteropServices.JavaScript.JSType;

//In the United Kingdom the currency is made up of pound (£) and pence (p). There are eight coins in general circulation:

//1p, 2p, 5p, 10p, 20p, 50p, £1 (100p), and £2 (200p).
//It is possible to make £2 in the following way:

//1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
//How many different ways can £2 be made using any number of coins?

List<int> coins = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
int target = 200;
int ways = 0;
for (int i = 0; i <= target / coins[0]; i++)
{
    for (int j = 0; j <= target / coins[1]; j++)
    {
        for (int k = 0; k <= target / coins[2]; k++)
        {
            for (int l = 0; l <= target / coins[3]; l++)
            {
                for (int m = 0; m <= target / coins[4]; m++)
                {
                    for (int n = 0; n <= target / coins[5]; n++)
                    {
                        for (int o = 0; o <= target / coins[6]; o++)
                        {
                            for (int p = 0; p <= target / coins[7]; p++)
                            {
                                if (coins[0] * i + coins[1] * j + coins[2] * k + coins[3] * l + coins[4] * m + coins[5] * n + coins[6] * o + coins[7] * p == target)
                                {
                                    ways++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

Console.WriteLine(ways);