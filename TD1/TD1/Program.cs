// Commentaire N°12 Guy ZAEGEL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Veuillez entrer la somme d'argent : ");
            int montant = int.Parse(Console.ReadLine());

            int billet100 = montant / 100;
            montant %= 100;

            int billet50 = montant / 50;
            montant %= 50;

            int billet10 = montant / 10;
            montant %= 10;

            int billet5 = montant / 5;
            montant %= 5;

            int piece1 = montant;

            Console.WriteLine("{0} billet(s) de 100", billet100);
            Console.WriteLine("{0} billet(s) de 50", billet50);
            Console.WriteLine("{0} billet(s) de 10", billet10);
            Console.WriteLine("{0} billet(s) de 5", billet5);
            Console.WriteLine("{0} pièce(s) de 1", piece1);
            Console.ReadLine();

        }
    }
}
