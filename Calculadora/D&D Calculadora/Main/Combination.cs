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
        if (minSum > combinationLength * monsters[10].CrX) { start = 10; }
        else if (minSum > combinationLength * monsters[9].CrX) { start = 9; }
        else if (minSum > combinationLength * monsters[8].CrX) { start = 8; }
        else if (minSum > combinationLength * monsters[7].CrX) { start = 7; }
        else if (minSum > combinationLength * monsters[6].CrX) { start = 6; }
        else if (minSum > combinationLength * monsters[5].CrX) { start = 5; }
        else if (minSum > combinationLength * monsters[4].CrX) { start = 4; }
        else if (minSum > combinationLength * monsters[3].CrX) { start = 3; }
        else if (minSum > combinationLength * monsters[2].CrX) { start = 2; }
        else if (minSum > combinationLength * monsters[1].CrX) { start = 1; }
        else { start = 0; }

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