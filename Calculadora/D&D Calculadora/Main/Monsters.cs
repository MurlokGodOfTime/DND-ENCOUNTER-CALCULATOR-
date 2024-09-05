namespace Calculadora
{
    internal class Monsters
    {
        public string CrN { get; private set; }
        public int CrX { get; private set; }
        public int Resposta { get; set; }
        public Monsters(string name, int xp)
        {
            CrN = name;
            CrX = xp;
        }
        public override string ToString()
        {
            if(Resposta == 1){return CrN;}
            else { return CrX.ToString(); }
        }
    }
}