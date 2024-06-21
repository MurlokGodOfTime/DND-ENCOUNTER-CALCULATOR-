using static System.Console;
using System.Diagnostics;

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
            new("cr0", 10),      new("cr1_8", 25),    new("cr1_4", 50),     new("cr1_2", 100),    new("cr1", 200),      new("cr2", 450),     new("cr3", 700),     
            new("cr4", 1100),    new("cr5", 1800),    new("cr6", 2300),     new("cr7", 2900),     new("cr8", 3900),     new("cr9", 5000),    new("cr10", 5900),   
            new("cr11", 7200),   new("cr12", 8400),   new("cr13", 10000),   new("cr14", 11500),   new("cr15", 13000),   new("cr16", 15000),  new("cr17", 18000),  
            new("cr18", 20000),  new("cr19", 22000),  new("cr20", 25000),   new("cr21", 33000),   new("cr22", 41000),   new("cr23", 50000),  new("cr24", 62000), 
            new("cr25", 75000),  new("cr26", 90000),  new("cr27", 105000),  new("cr28", 120000),  new("cr29", 135000),  new("cr30", 155000)];
        

        // não apagar, para uso futuro

        public void Choice(Level levelStart, int resp)
        {
            //Escolhe e define qual nivel de dificuldade você quer mais detalhes
            switch (resp)
            {
                case 1:
                    Answ = levelStart.EasyR;
                    Cap  = levelStart.MediumR;
                    break;
                case 2:
                    Answ = levelStart.MediumR;
                    Cap  = levelStart.HardR;
                    break;
                case 3:
                    Answ = levelStart.HardR;
                    Cap  = levelStart.DeadlyR;
                    break;
                case 4:
                    Answ = levelStart.DeadlyR;
                    Cap  = levelStart.DeadlyR * 2;
                    break;
                default:
                    Console.WriteLine("Bruh..."); //mensagem de erro
                    return;
            }
        }
        // Encontra o nivel de dificuldade do inimigo
        public void Padrao(List<Xp> lstXp)
        {
            Console.Write("Write the number of monsters you want to use ( 1 - 15 ): ");
            int x = int.Parse(Console.ReadLine());
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            /*foreach (var item in lstXp)
            {
                //stopwatch.Stop();
                //WriteLine($"Tempo passado: {stopwatch.Elapsed}");
                //stopwatch.Restart();
                int calcAnsw = Convert.ToInt32(Math.Round(Answ / item.Mult / item.Quant));
                int calcCap = Convert.ToInt32(Math.Round(Cap / item.Mult / item.Quant) -1); //limita a dificuldade do monstro
                if (calcCap >= item.Quant * 10)
                {
                    
                    var Combination = new Combination();
                    Combination.Main(calcAnsw, calcCap, item.Quant);
                }
                else 
                {
                    Console.WriteLine($"Combinations of {item.Quant} elements from array that sum between {calcAnsw} and {calcCap}:");
                    Console.WriteLine("This is impossible");
                }
            }*/

            
            int calcAnsw = Convert.ToInt32(Math.Round(Answ / lstXp[x - 1].Mult / lstXp[x - 1].Quant));
            int calcCap = Convert.ToInt32(Math.Round(Cap / lstXp[x - 1].Mult / lstXp[x - 1].Quant) - 1); //limita a dificuldade do monstro
            if (calcCap >= lstXp[x - 1].Quant * 10)
            {
                var Combination = new Combination();
                Combination.Main(monsters, calcAnsw, calcCap, lstXp[x - 1].Quant);
            }
            else
            {
                Console.WriteLine($"Combinations of {lstXp[x - 1].Quant} elements from array that sum between {calcAnsw} and {calcCap}:");
                Console.WriteLine("This is impossible");
            }//*/

            stopwatch.Stop();
            WriteLine($"Tempo passado: {stopwatch.Elapsed}");
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