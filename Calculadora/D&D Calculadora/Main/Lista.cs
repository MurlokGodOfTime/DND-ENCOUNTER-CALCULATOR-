
namespace Calculadora
{
    internal class Lista
    {
        public Monsters[] Monstros;

        public Lista(int num)
        {
            Monstros = new Monsters[num];
        }

        public void Quantidade(Xp xp, int diff)
        {
            double mult;
            if (Monstros.Length <= 1) { mult = 1; }
            else if (Monstros.Length < 3) { mult = 1.5; }
            else if (Monstros.Length < 7) { mult = 2; }
            else if (Monstros.Length < 12) { mult = 2.5; }
            else if (Monstros.Length < 15) { mult = 3; }
            else { mult = 4; }

            for (int i = 0; i < Monstros.Length; i++)
            {
                Monstros[i] = xp.monsters[0];
            }

            for (int i = 1; i < xp.monsters.Length; i++)
            {
                for (int j = 0; j < Monstros.Length; j++)
                {
                    if (Soma() >= xp.Answ / mult) // descobrir como fazer um resultado mais exato e com um maior alcance dos níveis de monstros 
                    {

                        for (int k = 0; k < Monstros.Length; k++)
                        {
                            Console.WriteLine("Monstro " + Monstros[k].CrN);
                        }

                        if (Soma() > xp.Cap / mult)
                        {
                            Console.WriteLine("O nível de dificuldade pode estár acima do requisitado"); // mensagem para conscientização 
                        }
                        return;
                    }
                    else
                    {
                        Monstros[j] = xp.monsters[i];
                    }
                }
            }
        }

        public int Soma()
        {
            int sum = 0;
            for (int i = 0; i < Monstros.Length; i++)
            {
                sum += Monstros[i].CrX;
            }
            return sum;
        }
    }
}

