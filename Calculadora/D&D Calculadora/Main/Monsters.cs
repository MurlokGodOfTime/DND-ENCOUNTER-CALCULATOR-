using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    internal class Monsters
    {
        public string CrN { get; private set; }
        public int CrX { get; private set; }

        public Monsters(string name, int xp)
        {
            CrN = name;
            CrX = xp;
        }

        public override string ToString()
        {
            return " monsters " + CrN + ": " + CrX + "xp";
        }
    }
}
