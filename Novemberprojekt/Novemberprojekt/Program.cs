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

            while(choice1 != "1" && choice1 != "2" && choice1 != "3" && choice1 != "4" && choice1 != "5")
            {
                Console.WriteLine("Chose one of the presented goalkeepers!");
                
                choice1 = Console.ReadLine();
            }

            Goalkeepers goalkeeper = new Goalkeepers();

            Console.WriteLine();

            Console.WriteLine("You chose: ");

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



            Console.ReadLine();
        }
    }
}
