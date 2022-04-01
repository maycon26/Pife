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
            Console.WriteLine(b.egarCartaBaralho());
            //Console.WriteLine();
        }
    }
}
