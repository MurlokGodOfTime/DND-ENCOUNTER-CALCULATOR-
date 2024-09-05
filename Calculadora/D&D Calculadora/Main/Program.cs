namespace Calculadora
{
    class Program
    {
        static void Main(String[] args)
        {
            int players = 0;
            int level = 0;
            while (players < 1 || players > 10)
            {
                Console.Write("Number of Players: ");
                int.TryParse(Console.ReadLine(), out players);
            }
            while (level < 1 || level > 20)
            {
                Console.Write("Player's Level (1 - 20): ");
                int.TryParse(Console.ReadLine(), out level);
            }
            var levelStart = new Level();
            levelStart.SetLevel(level);
            levelStart.SetLevelResult(players);
            var texto = new Text();
            var lst = texto.ListaNom(levelStart);
            texto.Tabela(lst);
            var xp = new Xp();
            int diff = 0;
            while (diff < 1 || diff > 4)
            {
                Console.WriteLine("Choose a difficulty: \n1 - Easy \n2 - Medium \n3 - Hard \n4 - Deadly \n");
                int.TryParse(Console.ReadLine(), out diff);
            }
            xp.Choice(levelStart, diff);
            xp.Padrao();
        }
    }
}