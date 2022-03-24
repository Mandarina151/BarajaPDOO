using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Jugador
    {
        //Atributs.
        int idJugador;
        List<Carta> mano = new List<Carta>();
        List<Carta> descartes = new List<Carta>();

        //Constructors
        public Jugador()
        {
            idJugador = 0;
            mano = null;
            descartes = null;
        }
        public Jugador(int idJugador,List<Carta> mano, List<Carta> descartes)
        {
            this.idJugador = idJugador;
            this.mano = mano;
            this.descartes = descartes;
        }
        //Getters y setters.
        public List<Carta> Mano { get => mano; set => mano = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }
        public List<Carta> Descartes { get => descartes; set => descartes = value; }

        //Funciones 
        public void escribeJugador()
        {
            Console.WriteLine("IdJugador: " + idJugador);
            if (this.mano != null)
            {
                Console.WriteLine("Mano: ");
                for (int i = 0; i < this.mano.Count; i++)
                {
                   this.mano[i].escribeCarta();
                }
            }
            if (this.descartes != null)
            {
                Console.WriteLine("descartes: ");
                for (int i = 0; i < this.descartes.Count; i++)
                {
                    this.descartes[i].escribeCarta();
                }
            }


        }

        public void eleminarCartaDeMano()
        {
            this.descartes.Add(this.mano[0]);
            this.mano.RemoveAt(0);
        }

        internal void añadirDescartes(List<Carta> cartasAComparar)
        {
            for (int i = 0; i < cartasAComparar.Count; i++)
            {
                Descartes.Add(cartasAComparar[i]);
            }
        }
    }
}
