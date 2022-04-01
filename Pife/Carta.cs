using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pife
{
    class Carta
    {
        public Naipe Naipe { get; private set; }
        public Valor Valor { get; private set; }
        public int Id { get; private set; }

        public Carta(Naipe naipe, Valor valor, int id)
        {
            Naipe = naipe;
            Valor = valor;
            Id = id;
        }

        public override string ToString()
        {
            return Valor + " " + ((char)Naipe).ToString();
        }
    }
}
