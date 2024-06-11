using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else if (Monstros.Length < 7) { mult = 1.5; }
            else if (Monstros.Length < 11) { mult = 2; }
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
                    if (Soma() >= xp.Answ / mult)
                    {
                        if (Soma() < xp.Cap / mult)
                        {
                            for (int k = 0; k < Monstros.Length; k++)
                            {
                                Console.WriteLine("Monstro " + Monstros[k].CrN);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível obter o Xp matendo a dificuldade.");
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

