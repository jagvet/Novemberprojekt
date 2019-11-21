using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Player
    {
        public string name;
        public int ovr;
        public int sho;
        public int pas;
        public int def;

        public void printStats()
        {
            Console.WriteLine(name);
            Console.WriteLine("OVR: " + ovr);
            Console.WriteLine("SHO: " + sho);
            Console.WriteLine("PAS: " + pas);
            Console.WriteLine("DEF: " + def);
        }

        public void printStatsGoalie()
        {
            Console.WriteLine(name);
            Console.WriteLine("OVR: " + ovr);
        }
    }
}
