using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Text
    {
        public string? Nome { get; set; }

        public int Corpo { get; set; }

        // Escreve os valores e os nomes das dificuldades de inimigos do jogo
        public void Tabela(List<Text> lstText)
        {
            foreach (Text item in lstText)
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine("1 monster with " + (item.Corpo).ToString("F2") + " total XP");
                Console.WriteLine("2 monsters with " + (item.Corpo / 1.5).ToString("F2") + " total XP");
                Console.WriteLine("3-6 monsters with " + (item.Corpo / 2).ToString("F2") + " total XP");
                Console.WriteLine("7-10 monsters with " + (item.Corpo / 2.5).ToString("F2") + " total XP");
                Console.WriteLine("11-14 monsters with " + (item.Corpo / 3).ToString("F2") + " total XP");
                Console.WriteLine("15 or more monsters with " + (item.Corpo / 4).ToString("F2") + " total XP");
                Console.WriteLine();
            }
        }
        // Muda valores e nomes nas linhas de texto
        public List<Text> ListaNom(Level level)
        {

            var lst = new List<Text>()
            {
                new ()
                {
                    Corpo = level.EasyR,
                    Nome = "Easy"
                },
                new ()
                {
                    Corpo = level.MediumR,
                    Nome = "Medium"
                },
                new ()
                {
                    Corpo = level.HardR,
                    Nome = "Hard"
                },
                new ()
                {
                    Corpo = level.DeadlyR,
                    Nome = "Deadly"
                },
            };

            return lst;
        }
    }
}
