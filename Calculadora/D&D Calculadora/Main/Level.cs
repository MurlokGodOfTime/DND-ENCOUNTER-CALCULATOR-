namespace Calculadora;

public class Level
{
    public int EasyM { get; set; }
    public int MediumM { get; set; }
    public int HardM { get; set; }
    public int DeadlyM { get; set; }
    public int EasyR { get; private set; }
    public int MediumR { get; private set; }
    public int HardR { get; private set; }
    public int DeadlyR { get; private set; }
    public void SetLevel(int level)
    {
        // Define multiplicador de xp por nivel de personagem
        switch (level)
        {
            case 1:
                EasyM = 25;MediumM = 50;HardM = 75;DeadlyM = 100;
                break;
            case 2:
                EasyM = 50;MediumM = 100;HardM = 150;DeadlyM = 200;
                break;
            case 3:
                EasyM = 75;MediumM = 150;HardM = 225;DeadlyM = 400;
                break;
            case 4:
                EasyM = 125;MediumM = 250;HardM = 375;DeadlyM = 500;
                break;
            case 5:
                EasyM = 250;MediumM = 500;HardM = 750;DeadlyM = 1100;
                break;
            case 6:
                EasyM = 300;MediumM = 600;HardM = 900;DeadlyM = 1400;
                break;
            case 7:
                EasyM = 350;MediumM = 750;HardM = 1100;DeadlyM = 1700;
                break;
            case 8:
                EasyM = 450;MediumM = 900;HardM = 1400;DeadlyM = 2100;
                break;
            case 9:
                EasyM = 550;MediumM = 1100;HardM = 1600;DeadlyM = 2400;
                break;
            case 10:
                EasyM = 600;MediumM = 1200;HardM = 1900;DeadlyM = 2800;
                break;
            case 11:
                EasyM = 800;MediumM = 1600;HardM = 2400;DeadlyM = 3600;
                break;
            case 12:
                EasyM = 1000;MediumM = 2000;HardM = 3000;DeadlyM = 4500;
                break;
            case 13:
                EasyM = 1100;MediumM = 2200;HardM = 3400;DeadlyM = 5100;
                break;
            case 14:
                EasyM = 1250;MediumM = 2500;HardM = 3800;DeadlyM = 5700;
                break;
            case 15:
                EasyM = 1400;MediumM = 2800;HardM = 4300;DeadlyM = 6400;
                break;
            case 16:
                EasyM = 1600;MediumM = 3200;HardM = 4800;DeadlyM = 7200;
                break;
            case 17:
                EasyM = 2000;MediumM = 3900;HardM = 5900;DeadlyM = 8800;
                break;
            case 18:
                EasyM = 2100;MediumM = 4200;HardM = 6300;DeadlyM = 9500;
                break;
            case 19:
                EasyM = 2400;MediumM = 4900;HardM = 7300;DeadlyM = 10900;
                break;
            default:
                EasyM = 2800;MediumM = 5700;HardM = 8500;DeadlyM = 12700;
                break;
        }
    }
    // Faz o calculo de multiplicador de xp e numero de jogadores
    public void SetLevelResult(int players)
    {
        EasyR = players * EasyM;
        MediumR = players * MediumM;
        HardR = players * HardM;
        DeadlyR = players * DeadlyM;
    }
}
