namespace Calculadora
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Number of Players: ");
            if(!int.TryParse(Console.ReadLine(), out int players))
            {
                Console.WriteLine("Please select a number higher then 0.");
                return;
            }
            Console.Write("Player's Level (1 - 20): "); 
            if (!int.TryParse(Console.ReadLine(), out int level))
            {
                Console.WriteLine("Please select a number between 1 and 20.");
                return;
            }
            Console.WriteLine();

            var levelStart = new Level();
            levelStart.SetLevel(level);
            levelStart.SetLevelResult(players);

            var texto = new Text();
            var lst = texto.ListaNom(levelStart);
            texto.Tabela(lst);

            Console.Write("\n 0 - Stop\n 1 - Desmember\n");
            if (!int.TryParse(Console.ReadLine(), out int progress))
            {
                Console.WriteLine("Any number other then 1 closes this aplication.");
                return;
            }
            if (progress == 1)
            {
                var xp = new Xp();
                int diff;
                Console.WriteLine("Choose a difficulty: \n1 - Easy \n2 - Medium \n3 - Hard \n4 - Deadly \n");
                diff = Convert.ToInt32(Console.ReadLine());
                xp.Choice(levelStart, diff);
                xp.Padrao(xp.ListaDados());
            }
            else { return; }
            
        }
    }
}
