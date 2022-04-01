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
        public Baralho Baralho { get; set; }
        public int Vez { get; set; }

        public Jogo()
        {
            Jogadores = new List<Jogador>();
            Vez = 0;
    }

        public void AddJogador(Jogador j)
        {
            Jogadores.Add(j);
        }

        public void Controller()
        {

        }

        private void DistribuirCartas()
        {
            
        }

        private void PassarVez()
        {
            Vez++;
        }

        public void MostrarMao(Jogador j)
        {
            Console.WriteLine("Mão do jogador " + j.Id);
        }

        private void ReorganizarMao(Jogador j)
        {

        }

        private void Ganhou(Jogador j)
        {

        }

    }
}
