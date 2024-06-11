using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Calculadora
{
    internal class Xp
    {
        public int Cap { get; set; }

        public int Answ { get; set; }

        public double Mult { get; set; }

        public int Quant { get; set; }

        public int Number { get; set; }

        public readonly Monsters[] monsters = [
            new("cr0", 10),      new("cr1_8", 25),    new("cr1_4", 50),    new("cr1_2", 100),  new("cr1", 200),    new("cr2", 450),
            new("cr3", 700),     new("cr4", 1100),    new("cr5", 1800),    new("cr6", 2300),   new("cr7", 2900),   new("cr8", 3900),
            new("cr9", 5000),    new("cr10", 5900),   new("cr11", 7200),   new("cr12", 8400),  new("cr13", 10000), new("cr14", 11500),
            new("cr15", 13000),  new("cr16", 15000),  new("cr17", 18000),  new("cr18", 20000), new("cr19", 22000), new("cr20", 25000),
            new("cr21", 33000),  new("cr22", 41000),  new("cr23", 50000),  new("cr24", 62000), new("cr25", 75000), new("cr26", 90000),
            new("cr27", 105000), new("cr28", 120000), new("cr29", 135000), new("cr30", 155000)
        ];

        public void Choice(Level levelStart, int resp)
        {
            //Escolhe e define qual nivel de dificuldade você quer mais detalhes
            switch (resp)
            {
                case 1:
                    Answ = levelStart.EasyR;
                    Cap = levelStart.MediumR;
                    break;
                case 2:
                    Answ = levelStart.MediumR;
                    Cap = levelStart.HardR;
                    break;
                case 3:
                    Answ = levelStart.HardR;
                    Cap = levelStart.DeadlyR;
                    break;
                case 4:
                    Answ = levelStart.DeadlyR;
                    Cap = levelStart.DeadlyR * 2;
                    break;
                default:
                    Console.WriteLine("Bruh..."); //mensagem de erro
                    return;
            }
        }
        // Encontra o nivel de dificuldade do inimigo
        public void Padrao(List<Xp> lstXp)
        {
            foreach (var item in lstXp)
            {
                var calcAnsw = Answ / item.Mult / item.Quant;
                var calcCap = Cap / item.Mult / item.Quant; //limita a dificuldade do monstro
                for (Number = 33; monsters[Number].CrX > calcAnsw; Number--)
                {
                    if (10 > calcAnsw) // se muitos inimigos para confronto justo, colocar o inimigo mais fácil
                    {
                        Number = 1;
                        break;
                    };
                }
                if (calcCap <= monsters[Number].CrX) { Number--; } // coloca um limite para que não suba o nível de dificuldade
                Console.WriteLine(item.Quant + monsters[Number].ToString());
            }
        }
        //Lista baseada em multiplicador de dificuldade baseado numero de inimigos
        public List<Xp> ListaDados()
        {

            var lst2 = new List<Xp>()
            { // perguntar como que a quantidade e o multiplicador deveriam influenciar
                new()
                {Quant = 1, Mult = 1},
                new()
                {Quant = 2, Mult = 1.5},
                new()
                {Quant = 3, Mult = 2},
                new()
                {Quant = 4, Mult = 2},
                new()
                {Quant = 5, Mult = 2},
                new()
                {Quant = 6, Mult = 2},
                new()
                {Quant = 7, Mult = 2.5},
                new()
                {Quant = 8, Mult = 2.5},
                new()
                {Quant = 9, Mult = 2.5},
                new()
                {Quant = 10, Mult = 2.5},
                new()
                {Quant = 11, Mult = 3},
                new()
                {Quant = 12, Mult = 3},
                new()
                {Quant = 13, Mult = 3},
                new()
                {Quant = 14, Mult = 3},
                new ()
                {Quant = 15, Mult = 4},
            };

            return lst2;
        }
    }
}