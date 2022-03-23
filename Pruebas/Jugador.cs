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

        //Constructors
        public Jugador()
        {
            idJugador = 0;
            mano = null;
        }
        public Jugador(int idJugador,List<Carta> mano)
        {
            this.idJugador = idJugador;
            this.mano = mano;
        }
        //Getters y setters.
        public List<Carta> Mano { get => mano; set => mano = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }

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

            
        }
    }
}
