using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializo
            Baraja baraja = new Baraja();
            List<Jugador> jugadores = new List<Jugador>();

            //Funciones
            baraja.Barajar();
            jugadores = nJugadoresByUser();

            contarJugadores(jugadores);
            MostrarIdJugadores(jugadores);

            jugadores = asignarCartas(baraja, jugadores);

            MostrarIdJugadores(jugadores);

            MostrarCartaYcomparar(jugadores);
            




        }

        private static void MostrarCartaYcomparar(List<Jugador> jugadores)
        {
            int nJugadores = jugadores.Count;
            List<Carta> CartaComparar = new List<Carta>();

            //Inicializo un objeto carta para asignar el valor de la carta optenida de cada jugador
            for (int i = 0; i < nJugadores; i++)
            {
                
                CartaComparar.Add(jugadores[i].Mano[0]);


                jugadores[i].Mano.RemoveAt(0);
            }


        }

        private static List<Jugador> asignarCartas(Baraja baraja, List<Jugador> jugadores)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                jugadores[i].Mano = baraja.asignarManoJugador(jugadores.Count);
            }
            return jugadores;
        }

        private static void MostrarIdJugadores(List<Jugador> jugadores)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                jugadores[i].escribeJugador();
            }
        }

        private static void contarJugadores(List<Jugador> jugadores)
        {
            Console.WriteLine("Se han asignado " + jugadores.Count + " jugadores");
        }

        private static List<Jugador> nJugadoresByUser()
        {
            bool flag = true;
            int nJugadores = 0;
            List<Jugador> jugadores = new List<Jugador>();
            Jugador jugador;

            while (flag)
            {
                Console.WriteLine("Inserte la cantidad de Jugadores deseados(Entre 2 y 5)");
                nJugadores = int.Parse(Console.ReadLine());

                if (nJugadores >= 2 && nJugadores <= 5)
                    flag = false;
                else
                    Console.WriteLine("Valor no valido.");
            }
            
            if (flag == false)
            {
                for (int i = 0; i < nJugadores; i++)
                {
                    jugador = new Jugador(i + 1, null);
                    jugadores.Add(jugador);
                }
            }
            return jugadores;
        }
    }
}