using System.ComponentModel;

class Combination
{
    public int start { get; set; }
    internal void Main(int calcAnsw, int calcCap, int quant)
    {
        int[] crX = { 10, 25, 50, 100, 200, 450, 700, 1100, 1800, 2300, 2900, 3900, 5000, 5900, 7200, 8400, 10000, 11500, 
        13000, 15000, 18000, 20000, 22000, 25000, 33000, 41000, 50000, 62000, 75000, 90000, 105000, 120000, 135000, 155000 };

        List<List<int>> combinations = FindCombinationsInRange(crX, calcAnsw, calcCap, quant, start);

        Console.WriteLine($"Combinations of {quant} monsters that sum between {calcAnsw} and {calcCap}:");
        foreach (var combination in combinations)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }

    static List<List<int>> FindCombinationsInRange(int[] crX, int minSum, int maxSum, int combinationLength, int start)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> currentCombination = new List<int>();

        Array.Sort(crX); // Sort array to optimize the combination finding process

        if (minSum > combinationLength * crX[5]) { start = 5; }
        else if (minSum > combinationLength * crX[4]) { start = 4; }
        else if (minSum > combinationLength * crX[3]) { start = 3; }
        else if (minSum > combinationLength * crX[2]) {start = 2;}
        else if (minSum > combinationLength * crX[1]) { start = 1; }
        else { start = 0; }

        FindCombinationsInRangeHelper(crX, minSum, maxSum, combinationLength, start, currentCombination, result);

        return result;
    }

    static void FindCombinationsInRangeHelper(int[] crX, int minSum, int maxSum, int k, int start,
                                              List<int> currentCombination, List<List<int>> result)
    {
        if (k == 0)
        {
            int sum = currentCombination.Sum();
            if (sum >= minSum && sum <= maxSum)
            {
                result.Add(new List<int>(currentCombination));
            }
            return;
        }
        for (int i = start; i < crX.Length; i++)
        {
            if (crX[i] < maxSum)
            {
                currentCombination.Add(crX[i]);
                FindCombinationsInRangeHelper(crX, minSum, maxSum, k - 1, i, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}