namespace calculadora
{
    internal class Xp
    {
        public int Cap { get; set; }

        public int Answ { get; set; }

        public double Mult { get; set; }

        public int Quant { get; set; }

        public int Number { get; set; }

        int[] crX = { 10, 25, 50, 100, 200, 450, 700, 1100, 1800, 2300, 2900, 3900, 5000, 5900, 7200, 8400, 10000,
                    11500, 13000, 15000, 18000, 20000, 22000, 25000, 33000, 41000, 50000, 62000, 75000, 90000, 105000, 120000, 135000, 155000 };
        string[] crN = { "cr0", "cr1_8", "cr1_4", "cr1_2", "cr1", "cr2", "cr3", "cr4", "cr5", "cr6", "cr7", "cr8", "cr9", "cr10", "cr11", "cr12", "cr13",
                    "cr14", "cr15", "cr16", "cr17", "cr18", "cr19", "cr20", "cr21", "cr22", "cr23", "cr24", "cr25", "cr26", "cr27", "cr28", "cr29", "cr30" };

        public void Choice(Level levelStart)
        {
            int resp = Convert.ToInt32(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Answ = levelStart.easyR;
                    Cap = levelStart.mediumR;
                    break;
                case 2:
                    Answ = levelStart.mediumR;
                    Cap = levelStart.hardR;
                    break;
                case 3:
                    Answ = levelStart.hardR;
                    Cap = levelStart.deadlyR;
                    break;
                case 4:
                    Answ = levelStart.deadlyR;
                    Cap = levelStart.hardR * 2;
                    break;
                default:
                    Console.WriteLine("Bruh...");
                    return;
            }
        }
        public void Padrao(List<Xp> lstXp)
        {
            foreach (var item in lstXp)
            {
                var calcAnsw = Answ / item.Mult / item.Quant;
                var calcCap = Cap / item.Mult / item.Quant;

                for (int i = 33; crX[i] >= calcAnsw; i--)
                {
                    if (10 > calcAnsw) 
                    { 
                        i = 1;
                        Number = i;
                        break; 
                    };
                    Number = i;
                }
                if (calcCap < crX[Number]) { Number--; }
                Console.WriteLine(item.Quant + " monsters " + crN[Number] + ": " + crX[Number] + "xp");
            }
        }
        /// <summary>
        /// testando especificação do metodo
        /// </summary>
        /// <returns></returns>
        public List<Xp> ListaDados()
        {

            var lst2 = new List<Xp>()
            {
                new Xp()
                {
                    Quant = 1,
                    Mult = 1
                },
                new Xp()
                {
                    Quant = 2,
                    Mult = 1.5
                },
                new Xp()
                {
                    Quant = 3,
                    Mult = 2
                },
                new Xp()
                {
                    Quant = 4,
                    Mult = 2
                },
                new Xp()
                {
                    Quant = 5,
                    Mult = 2
                },
                new Xp()
                {
                    Quant = 6,
                    Mult = 2
                },
                new Xp()
                {
                    Quant = 7,
                    Mult = 2.5
                },
                new Xp()
                {
                    Quant = 8,
                    Mult = 2.5
                },
                new Xp()
                {
                    Quant = 9,
                    Mult = 2.5
                },
                new Xp()
                {
                    Quant = 10,
                    Mult = 2.5
                },
                new Xp()
                {
                    Quant = 11,
                    Mult = 3
                },
                new Xp()
                {
                    Quant = 12,
                    Mult = 3
                },
                new Xp()
                {
                    Quant = 13,
                    Mult = 3
                },
                new Xp()
                {
                    Quant = 14,
                    Mult = 3
                },
                new Xp()
                {
                    Quant = 15,
                    Mult = 4
                },
            };

            return lst2;
        }
    }
}

