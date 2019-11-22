using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Goalkeepers : Player
    {
        //Alla metoder är spelare som deklarerar deras stats och skriver ut dem.
        //Från klassen Player hämtas variablerna.
        //Varje fotbollsposition ärver av Player 
        //Målvakter har bara en overall stat och hämtar en metod från player som bara skriver ut OVR

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

        public void Choose()
        {
            Console.WriteLine("Choose a goalkeeper");
            Console.WriteLine();

            string choice1 = "";

            Console.WriteLine("1. Jan Oblak");
            Console.WriteLine("2. Marc-André ter Stegen");
            Console.WriteLine("3. Alisson Becker");
            Console.WriteLine("4. David De Gea");
            Console.WriteLine("5. Manuel Neuer");
            Console.WriteLine();

            choice1 = Console.ReadLine();

            while (choice1 != "1" && choice1 != "2" && choice1 != "3" && choice1 != "4" && choice1 != "5")
            {
                Console.WriteLine("Chose one of the presented goalkeepers!");

                choice1 = Console.ReadLine();
            }
            Goalkeepers goalkeeper = new Goalkeepers(); //Skapar goalkeeper och kopplar till Goalkeepers klassen


            Console.WriteLine();

            Console.WriteLine("You chose: ");

            //Det valet man gör kör metoden för den spelare man valt, vilket i sin tur kör printStats på den spelaren och man statsen skrivs ut.
            //Har försökt komma på ett sätt som gör att man kan spara statsen som deklareras i metoden så man kan bara köra den senare när man byggt sitt lag.


            if (choice1 == "1")
            {
                goalkeeper.Oblak();
                string golie = "oblak";
            }

            if (choice1 == "2")
            {
                goalkeeper.TerStegen();

                string golie = "terstegen";
            }

            if (choice1 == "3")
            {
                goalkeeper.Alisson();
                string golie = "alisson";
            }

            if (choice1 == "4")
            {
                goalkeeper.DeGea();
                string golie = "degea";
            }

            if (choice1 == "5")
            {
                goalkeeper.Neuer();
                string golie = "neuer";
            }

        }

    }
}
