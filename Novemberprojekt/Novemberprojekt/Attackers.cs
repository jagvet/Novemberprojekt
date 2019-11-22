using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Attackers : Player
    {
        //Alla metoder är spelare som deklarerar deras stats och skriver ut dem.
        //Från klassen Player hämtas variablerna.
        //Varje fotbollsposition ärver av Player 

        public void Messi()
        {
            name = "Lionel Messi";
            ovr = 94;
            sho = 92;
            pas = 92;
            def = 39;
            printStats();
        }

        public void Ronaldo()
        {
            name = "Cristiano Ronaldo";
            ovr = 93;
            sho = 93;
            pas = 82;
            def = 35;
            printStats();
        }

        public void Neymar()
        {
            name = "Neymar Jr";
            ovr = 92;
            sho = 85;
            pas = 87;
            def = 32;
            printStats();
        }

        public void Hazard()
        {
            name = "Eden Hazard";
            ovr = 91;
            sho = 83;
            pas = 86;
            def = 35;
            printStats();
        }

        public void Salah()
        {
            name = "Mohamed Salah";
            ovr = 90;
            sho = 86;
            pas = 81;
            def = 45;
            printStats();
        }
    }
}
