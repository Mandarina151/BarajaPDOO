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
            List<Carta> CartasAComparar = new List<Carta>();
            Carta cartaMasAlta;


            //Funciones
            baraja.Barajar();
            jugadores = nJugadoresByUser();

            contarJugadores(jugadores);
            MostrarIdJugadores(jugadores);

            jugadores = asignarCartas(baraja, jugadores);

            MostrarIdJugadores(jugadores);

            while (jugadores[0].Mano.Count != 0)
            {
                CartasAComparar = MostrarCarta(jugadores);

                /*
                cartaMasAlta = compararCartas(CartasAComparar);
                mostrarGanadorRonda(jugadores, cartaMasAlta, CartasAComparar);*/
            }

            MostrarGanador(jugadores);








        }

        private static void MostrarGanador(List<Jugador> jugadores)
        {
            int ganador = jugadores[0].Descartes.Count;
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i].Descartes.Count > ganador)
                    ganador = jugadores[i].Descartes.Count;
            }

            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i].Descartes.Count == ganador)
                    Console.WriteLine("El jugador " + jugadores[i].IdJugador + " ha ganado la partida. Felicidades");
            }
        }

        private static void mostrarGanadorRonda(List<Jugador> jugadores, Carta cartaMasAlta, List<Carta> cartasAComparar)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i].Descartes.Contains(cartaMasAlta))
                {
                    cartasAComparar.Remove(cartaMasAlta);
                    jugadores[i].añadirDescartes(cartasAComparar);
                    Console.WriteLine("El jugador " + jugadores[i].IdJugador + " ha ganado la ronda.");
                }
            }
        }

        private static Carta compararCartas(List<Carta> cartasAComparar)
        {
            Carta ganadora = cartasAComparar[0];
            for (int i = 0; i < cartasAComparar.Count; i++)
            {
                if (cartasAComparar[i].Numero > ganadora.Numero)
                    ganadora = cartasAComparar[i];
            }
            return ganadora;
        }

        private static List<Carta> MostrarCarta(List<Jugador> jugadores)
        {
            List<Carta> CartaComparar = new List<Carta>();
            Carta descarte;
            //Inicializo un objeto carta para asignar el valor de la carta optenida de cada jugador
            for (int i = 0; i < jugadores.Count; i++)
            {
                CartaComparar.Add(jugadores[i].Mano[0]);
                descarte = jugadores[i].Mano[0];

                Console.WriteLine("HOLAAAAAAA");
                descarte.escribeCarta();

                Console.WriteLine(jugadores[i].Descartes);
                jugadores[i].Descartes.Add(descarte);
                //jugadores[i].Mano.RemoveAt(0);
            }
            return CartaComparar;
        }

        private static List<Jugador> asignarCartas(Baraja baraja, List<Jugador> jugadores)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                jugadores[i].Mano = baraja.asignarManoJugador(jugadores.Count);
                jugadores[i].Descartes = null;
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
                    jugador = new Jugador(i + 1, null, null);
                    jugadores.Add(jugador);
                }
            }
            return jugadores;
        }
    }
}