using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pife
{
    class Jogador
    {
        public int Id { get; set; }
        public List<Carta> Mao { get; set; }

        public Jogador(int id)
        {
            Id = id;
            Mao = new List<Carta>();
        }

        private Carta Descartar(int idCarta)
        {
            foreach(Carta c in Mao)
            {
                if(c.Id == idCarta)
                {
                    return c;
                }
            }

            return null;
        }

        public void PegarCarta(Carta carta)
        {
            Mao.Add(carta);
        }
    }
}
