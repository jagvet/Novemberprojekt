using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Player
    {
        //Deklarerar några variabler som ska användas av de olika positionerna


        public string name;
        public int ovr;
        public int sho;
        public int pas;
        public int def;

        //printStats är en metod som skriver ut namn och stats som kan hämtas i spelarens metod

        public void printStats()
        {
            Console.WriteLine(name);
            Console.WriteLine("OVR: " + ovr);
            Console.WriteLine("SHO: " + sho);
            Console.WriteLine("PAS: " + pas);
            Console.WriteLine("DEF: " + def);
        }

        //samma som printStats men skriver bara overall

        public void printStatsGoalie()
        {
            Console.WriteLine(name);
            Console.WriteLine("OVR: " + ovr);
        }
    }
}
