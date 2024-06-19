namespace Calculadora
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Number of Players: ");
            if(!int.TryParse(Console.ReadLine(), out int players))
            {
                Console.WriteLine("Favor inserir um numero maior que 0.");
                return;
            }
            Console.Write("Player's Level (1 - 20): "); 
            if (!int.TryParse(Console.ReadLine(), out int level))
            {
                Console.WriteLine("Favor inserir um numero de 1 a 20.");
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
                Console.WriteLine("Qualquer valor diferente de 1 fecha o programa");
                return;
            }
            if (progress == 1)
            {
                var xp = new Xp();
                int diff;
                Console.WriteLine("Choose a difficulty: \n1 - Easy \n2 - Medium \n3 - Hard \n4 - Deadly \n");
                diff = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine( "\nMédia de dificuldade dos montros: " );
                xp.Choice(levelStart, diff);
                xp.Padrao(xp.ListaDados());
            }
            else { return; }
            
        }
    }
}
