using calculadora;
namespace calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Number of Players: ");
            int players = Convert.ToInt32(Console.ReadLine());
            Console.Write("Player's Level (1 - 20): ");
            int level = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var levelStart = new Level();
            levelStart.SetLevel(level);
            levelStart.SetLevelResult(players);

            var texto = new Text();
            var lst = texto.ListaNom(levelStart);
            texto.Tabela(lst);

            Console.Write("\n 0 - Stop\n 1 - Desmember\n");
            int progress = Convert.ToInt32(Console.ReadLine());
            if (progress == 1)
            {
                Console.WriteLine("Choose a difficulty: \n1 - Easy \n2 - Medium \n3 - Hard \n4 - Deadly \n");

                var xp = new Xp();
                xp.Choice(levelStart);
                xp.Padrao(xp.ListaDados());
            }
            else { return; }
        }
    }
}