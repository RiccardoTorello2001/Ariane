using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariane
{
    class Program
    {
        static void Main(string[] args)
        {
            double errore = 0;
            double tempo = 0;
            double ore = 100;
            double spazio = 0;
            double velocità = 1676;
            Console.WriteLine("inserire l'errore");
            errore = Convert.ToDouble(Console.ReadLine());
            tempo = errore * ore * 60 * 60 * 10;
            Console.WriteLine("l'errore in secondi è {0}", tempo);
            spazio = velocità * tempo;
            Console.WriteLine("lo spazio è di {0}", spazio);
            Console.ReadLine();

        }
    }
}
