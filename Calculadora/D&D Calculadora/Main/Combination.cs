using System.ComponentModel;
using System.Diagnostics;
using Calculadora;
class Combination
{
    public int Start { get; set; }
    internal void Main(Monsters[] monsters, int calcAnsw, int calcCap, int quant)
    {
        List<List<Monsters>> combinations = FindCombinationsInRange(monsters, calcAnsw, calcCap, quant, Start);
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine($"Combinations of {quant} monsters that sum between {calcAnsw} and {calcCap}:");
        foreach (var combination in combinations)
        {
            Console.WriteLine(string.Join(", ", combination)); // Combination uses Monsters.ToString() to print the itens.
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo do print: {stopwatch.Elapsed}");
    }
    static List<List<Monsters>> FindCombinationsInRange(Monsters[] monsters, int minSum, int maxSum, int combinationLength, int start)
    {
        List<List<Monsters>> result = [];
        List<Monsters> currentCombination = [];
        // Limitando as combinações para otimizar o calculo
        for (int i = 0; minSum > combinationLength * monsters[i].CrX || i == 34; i++)
        { start = i; }
        FindCombinationsInRangeHelper(monsters, minSum, maxSum, combinationLength, start, currentCombination, result);
        return result;
    }
    static void FindCombinationsInRangeHelper(Monsters[] monsters, int minSum, int maxSum, int k, int start,List<Monsters> currentCombination, List<List<Monsters>> result)
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
            if (monsters[i].CrX + ((k - 1) * monsters[start].CrX) <= maxSum)
            {
                currentCombination.Add(monsters[i]);
                FindCombinationsInRangeHelper(monsters, minSum, maxSum, k - 1, i, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}