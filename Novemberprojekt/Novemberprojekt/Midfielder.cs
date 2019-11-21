using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Midfielder : Player
    {
        public void DeBruyne()
        {
            name = "Kevin De Bruyne";
            ovr = 91;
            sho = 86;
            pas = 92;
            def = 61;
        }

        public void Modrić()
        {
            name = "Luka Modrić";
            ovr = 90;
            sho = 76;
            pas = 89;
            def = 72;
        }

        public void Kanté()
        {
            name = "N’Golo Kanté";
            ovr = 89;
            sho = 65;
            pas = 77;
            def = 87;
        }

        public void Busquets()
        {
            name = "Sergio Busquets";
            ovr = 89;
            sho = 62;
            pas = 80;
            def = 85;
        }

        public void Kroos()
        {
            name = "Toni Kroos";
            ovr = 88;
            sho = 80;
            pas = 90;
            def = 70;
        }
    }
}
