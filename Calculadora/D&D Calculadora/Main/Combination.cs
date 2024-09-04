using System.ComponentModel;
using Calculadora;
class Combination
{
    public int start { get; set; }
    internal void Main(Monsters[] monsters, int calcAnsw, int calcCap, int quant)
    {
        List<List<Monsters>> combinations = FindCombinationsInRange(monsters, calcAnsw, calcCap, quant, start);

        Console.WriteLine($"Combinations of {quant} monsters that sum between {calcAnsw} and {calcCap}:");
        foreach (var combination in combinations)
        {
            Console.WriteLine(string.Join(", ", combination)); // Combination uses Monsters.ToString() to print the itens.
        }
    }

    static List<List<Monsters>> FindCombinationsInRange(Monsters[] monsters, int minSum, int maxSum, int combinationLength, int start)
    {
        List<List<Monsters>> result = new List<List<Monsters>>();
        List<Monsters> currentCombination = new List<Monsters>();

        // Array.Sort(crX); // Sort array to optimize the combination finding process
        for (int i = 0; minSum > combinationLength * monsters[i].CrX || i == 34; i++)
        { start = i - 1; }
        if (start < 0) { start = 0; }

        FindCombinationsInRangeHelper(monsters, minSum, maxSum, combinationLength, start, currentCombination, result);

        return result;
    }

    static void FindCombinationsInRangeHelper(Monsters[] monsters, int minSum, int maxSum, int k, int start,
                                              List<Monsters> currentCombination, List<List<Monsters>> result)
    {
        if (k == 0)
        {
            int sum = 0;
            foreach (Monsters m in currentCombination) { sum += m.CrX; }
            if (sum >= minSum && sum <= maxSum)
            {
                result.Add(new List<Monsters>(currentCombination));
            }
            return;
        }
        for (int i = start; i < monsters.Length; i++)
        {
            if (monsters[i].CrX < maxSum)
            {
                currentCombination.Add(monsters[i]);
                FindCombinationsInRangeHelper(monsters, minSum, maxSum, k - 1, i, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}