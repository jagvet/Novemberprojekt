using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Goalkeepers goalkeeper = new Goalkeepers(); //Skapar goalkeeper och kopplar till Goalkeepers klassen, detsamma för de andra men med respektive klass
            Defender defender = new Defender();
            Midfielder midfielder = new Midfielder();
            Attackers attackers = new Attackers();

            //Hämtar choose metoden som är till för att välja vilken spelare man vill ha men försökte komma på hur man sparar utanför metoden så man kan ta med sig spelaren
            //Var meningen att det skulle finnas samma variabler för resterande positioner också och i slutet så sätter man ihop laget som valts.
            goalkeeper.Choose();

            







            Console.ReadLine();
        }
    }
}
