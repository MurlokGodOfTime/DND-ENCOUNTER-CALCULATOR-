
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
