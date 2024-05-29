namespace calculadora
{
    public class Level
    {
        public int easyM { get; set; }
        public int mediumM { get; set; }
        public int hardM { get; set; }
        public int deadlyM { get; set; }

        public int easyR { get; private set; }
        public int mediumR { get; private set; }
        public int hardR { get; private set; }
        public int deadlyR { get; private set; }

        public void SetLevel(int level)
        {

            switch (level)
            {
                case 1:
                    easyM = 25;
                    mediumM = 50;
                    hardM = 75;
                    deadlyM = 100;
                    break;
                case 2:
                    easyM = 50;
                    mediumM = 100;
                    hardM = 150;
                    deadlyM = 200;
                    break;
                case 3:
                    easyM = 75;
                    mediumM = 150;
                    hardM = 225;
                    deadlyM = 400;
                    break;
                case 4:
                    easyM = 125;
                    mediumM = 250;
                    hardM = 375;
                    deadlyM = 500;
                    break;
                case 5:
                    easyM = 250;
                    mediumM = 500;
                    hardM = 750;
                    deadlyM = 1100;
                    break;
                case 6:
                    easyM = 300;
                    mediumM = 600;
                    hardM = 900;
                    deadlyM = 1400;
                    break;
                case 7:
                    easyM = 350;
                    mediumM = 750;
                    hardM = 1100;
                    deadlyM = 1700;
                    break;
                case 8:
                    easyM = 450;
                    mediumM = 900;
                    hardM = 1400;
                    deadlyM = 2100;
                    break;
                case 9:
                    easyM = 550;
                    mediumM = 1100;
                    hardM = 1600;
                    deadlyM = 2400;
                    break;
                case 10:
                    easyM = 600;
                    mediumM = 1200;
                    hardM = 1900;
                    deadlyM = 2800;
                    break;
                case 11:
                    easyM = 800;
                    mediumM = 1600;
                    hardM = 2400;
                    deadlyM = 3600;
                    break;
                case 12:
                    easyM = 1000;
                    mediumM = 2000;
                    hardM = 3000;
                    deadlyM = 4500;
                    break;
                case 13:
                    easyM = 1100;
                    mediumM = 2200;
                    hardM = 3400;
                    deadlyM = 5100;
                    break;
                case 14:
                    easyM = 1250;
                    mediumM = 2500;
                    hardM = 3800;
                    deadlyM = 5700;
                    break;
                case 15:
                    easyM = 1400;
                    mediumM = 2800;
                    hardM = 4300;
                    deadlyM = 6400;
                    break;
                case 16:
                    easyM = 1600;
                    mediumM = 3200;
                    hardM = 4800;
                    deadlyM = 7200;
                    break;
                case 17:
                    easyM = 2000;
                    mediumM = 3900;
                    hardM = 5900;
                    deadlyM = 8800;
                    break;
                case 18:
                    easyM = 2100;
                    mediumM = 4200;
                    hardM = 6300;
                    deadlyM = 9500;
                    break;
                case 19:
                    easyM = 2400;
                    mediumM = 4900;
                    hardM = 7300;
                    deadlyM = 10900;
                    break;
                case 20:
                    easyM = 2800;
                    mediumM = 5700;
                    hardM = 8500;
                    deadlyM = 12700;
                    break;
                default:
                    easyM = 0;
                    mediumM = 0;
                    hardM = 0;
                    deadlyM = 0;
                    break;
            }


        }

        public void SetLevelResult(int players)
        {
            easyR = players * easyM;
            mediumR = players * mediumM;
            hardR = players * hardM;
            deadlyR = players * deadlyM;

        }
    }
}
