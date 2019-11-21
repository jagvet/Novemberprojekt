using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Goalkeepers : Player
    {
        

        public void Oblak()
        {
            name = "Jan Oblak";
            ovr = 91;
            printStatsGoalie();
        }

        public void TerStegen()
        {
            name = "Marc-André ter Stegen";
            ovr = 91;
            printStatsGoalie();
        }

        public void Alisson()
        {
            name = "Alisson Becker";
            ovr = 89;
            printStatsGoalie();
        }

        public void DeGea()
        {
            name = "David De Gea";
            ovr = 89;
            printStatsGoalie();
        }

        public void Neuer()
        {
            name = "Manuel Neuer";
            ovr = 88;
            printStatsGoalie();
        }
    }
}
