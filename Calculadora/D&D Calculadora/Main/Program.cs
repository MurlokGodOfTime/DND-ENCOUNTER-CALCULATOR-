// See https://aka.ms/new-console-template for more information


using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
//using Calculadora.Classes;

namespace Calculadora
{
    class Program
    {
        static void Main(String[] args)
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
            var xp = new Xp();
            int diff;
            if (progress == 1)
            {
                Console.WriteLine("Choose a difficulty: \n1 - Easy \n2 - Medium \n3 - Hard \n4 - Deadly \n");
                diff = Convert.ToInt32(Console.ReadLine());
                xp.Choice(levelStart, diff);
                xp.Padrao(xp.ListaDados());
            }
            else { return; }
            Console.Write("Quantos monstros deseja utilizar (1 - 15): ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            if (qtd < 1)
            {
                Console.WriteLine("Fala para todo mundo que o Xp ta de graça.");
                return;
            }
            else if (qtd > 15) { Console.WriteLine("Você está louco, mas aqui está sua lista de monstros: "); }
            else { Console.WriteLine("Sua lista de monstros: "); }

            var lista = new Lista(qtd);

            lista.Quantidade(xp, diff);
        }
    }
}
