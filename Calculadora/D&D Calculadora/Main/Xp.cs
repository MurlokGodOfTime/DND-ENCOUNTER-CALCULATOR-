using static System.Console;
using System.Diagnostics;

namespace Calculadora
{
    internal class Xp
    {
        public int Cap { get; set; }
        public int Answ { get; set; }
        public double Mult { get; set; }
        public int Number { get; set; }
        public Monsters[] monsters = [
            new("cr0", 10),      new("cr1_8", 25),    new("cr1_4", 50),     new("cr1_2", 100),      //  0  -  3
            new("cr1", 200),     new("cr2", 450),     new("cr3", 700),      new("cr4", 1100),     new("cr5", 1800),         //  4  -  8 
            new("cr6", 2300),    new("cr7", 2900),    new("cr8", 3900),     new("cr9", 5000),     new("cr10", 5900),        //  9  -  13
            new("cr11", 7200),   new("cr12", 8400),   new("cr13", 10000),   new("cr14", 11500),   new("cr15", 13000),       // 14  -  18
            new("cr16", 15000),  new("cr17", 18000),  new("cr18", 20000),   new("cr19", 22000),   new("cr20", 25000),       // 19  -  23
            new("cr21", 33000),  new("cr22", 41000),  new("cr23", 50000),   new("cr24", 62000),   new("cr25", 75000),       // 24  -  28
            new("cr26", 90000),  new("cr27", 105000), new("cr28", 120000),  new("cr29", 135000),  new("cr30", 155000)];     // 29  -  34
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
                    return;
            }
        }
        // Encontra o nivel de dificuldade do inimigo
        public void Padrao()
        {
            int quant = 0;
            while (quant < 1)
            {
                Console.Write("Write the number of monsters you want to use: ");
                int.TryParse(Console.ReadLine(), out quant);
            }
            if (quant == 1) { Mult = 1; }
            else if (quant == 2) { Mult = 1.5; }
            else if (quant <= 6) { Mult = 2; }
            else if (quant <= 10) { Mult = 2.5; }
            else if (quant <= 14) { Mult = 3; }
            else { Mult = 4; }
            int resposta = 0;
            while (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Select:\n1 - Cr \n2 - Xp\n");
                int.TryParse(Console.ReadLine(), out resposta);
            }
            foreach (var monstro in monsters){ monstro.Resposta = resposta; }
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int calcAnsw = Convert.ToInt32(Math.Round(Answ / Mult));
            int calcCap = Convert.ToInt32(Math.Round(Cap / Mult)); //limita a dificuldade do monstro
            if (calcCap >= quant * 10)
            {
                var Combination = new Combination();
                Combination.Main(monsters, calcAnsw, calcCap, quant);
            }
            else
            {
                Console.WriteLine($"Combinations of {quant} elements from array that sum between {calcAnsw} and {calcCap}:");
                Console.WriteLine("This is impossible.");
            }
            stopwatch.Stop();
            WriteLine($"Tempo passado: {stopwatch.Elapsed}");
        }
    }
}