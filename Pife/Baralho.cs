using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pife
{
    class Baralho
    {
        private List<Carta> CartasBaralho;
        private List<Carta> Pilha;

        public Baralho()
        {
            CartasBaralho = new List<Carta>();
            Pilha = new List<Carta>();
        }

        public void GerarBaralho()
        {
            int idCont = 0;
            foreach(Naipe naipe in Enum.GetValues(typeof(Naipe)))
            {
                foreach(Valor valor in Enum.GetValues(typeof(Valor)))
                {
                    CartasBaralho.Add(new Carta(naipe, valor, idCont));
                    idCont++;
                }
            }
        }

        public void Embaralhar()
        {
            var random = new Random();

            Console.WriteLine(random.Next());

            var query =
                from i in CartasBaralho
                let r = random.Next()
                orderby r
                select i;

            CartasBaralho = query.ToList();
        }

        //Carta
        public Carta PegarCartaBaralho()
        {
            Carta primeiraCarta = CartasBaralho[0];
            CartasBaralho.RemoveAt(0);
            return primeiraCarta;
        }

        //Carta
        public Carta PegarCartaPilha()
        {
            if(Pilha.Count() > 0)
            {
                Carta primeiraCarta = Pilha[0];
                Pilha.RemoveAt(0);
                return primeiraCarta;
            }
            return null;
        }

        public void DevolverCartaPilha(Carta carta)
        {
            Pilha.Insert(0, carta);
        }
    }
}
