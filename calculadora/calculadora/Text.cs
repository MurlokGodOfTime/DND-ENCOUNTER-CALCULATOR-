namespace calculadora
{
    internal class Text
    {
        public string Nome { get; set; }

        public int Corpo { get; set; }
        
        public void Tabela(List<Text> lstText) 
        {
            foreach (Text item in lstText) 
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine("1 monster with " + item.Corpo + " total XP");
                Console.WriteLine("2 monsters with " + item.Corpo / 1.5 + " total XP");
                Console.WriteLine("3-6 monsters with " + item.Corpo / 2 + " total XP");
                Console.WriteLine("7-10 monsters with " + item.Corpo / 2.5 + " total XP");
                Console.WriteLine("11-14 monsters with " + item.Corpo / 3 + " total XP");
                Console.WriteLine("15 or more monsters with " + item.Corpo / 4 + " total XP");
                Console.WriteLine();
            }
        }

        public List<Text> ListaNom(Level level)
        {
            
            var lst = new List<Text>()
            {
                new Text()
                {
                    Corpo = level.easyR,
                    Nome = "Easy"
                },
                new Text()
                {
                    Corpo = level.mediumR,
                    Nome = "Medium"
                },
                new Text()
                {
                    Corpo = level.hardR,
                    Nome = "Hard"
                },
                new Text()
                {
                    Corpo = level.deadlyR,
                    Nome = "Deadly"
                },
            };

            return lst;

        }

    }
}
