using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pife
{
    class Jogo
    {
        public List<Jogador> Jogadores { get; set; }
        
        public Jogo()
        {
            Jogadores = new List<Jogador>();
        }

        public void AddJogador(Jogador j)
        {
            Jogadores.Add(j);
        }

        //Carta
        public void PegarCartaBaralho()
        {

        }
    }
}
