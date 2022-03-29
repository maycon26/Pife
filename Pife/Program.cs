using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pife
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho b = new Baralho();
            b.GerarBaralho();
            Console.WriteLine();
            b.Embaralhar();
            Console.WriteLine();
            b.PegarCartaBaralho();
            Console.WriteLine();
        }
    }
}
