using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Baraja
    {
        //Atributos de la clase
        int numPalos = 4;
        int numCartasXpalo = 12;
        //Lista de cartas
        List<Carta> baraja = new List<Carta>();
        //Carta
        Carta carta;

        public Baraja()
        {
            int i, j;
            for (i = 0; i < numPalos; i++)
            {
                for (j = 0; j < numCartasXpalo; j++)
                {
                    carta = new Carta(j + 1, i);
                    baraja.Add(carta);
                }
            }
        }

        //Metodos
        public void numeroCartas()
        {
            Console.WriteLine("En la baraja hay "+baraja.Count+" cartas");
        }

        public void robarCarta()
        {
            baraja[0].escribeCarta();
            baraja.RemoveAt(0);
        }

        public List<Carta> asignarManoJugador(int nJugadores)
        {
            int totalCartas = numCartasXpalo * numPalos;
            int totalRepartir = totalCartas / nJugadores;
            List<Carta> Mano = new List<Carta>();


            for (int i = 0; i < totalRepartir; i++)
            {
                Mano.Add(baraja[0]);
 
                baraja.RemoveAt(0);
            }
            return Mano;
        }

        public void cogerCarta(int n,bool rand)
        {
            if(rand)
                Console.WriteLine("Has cogido una carta random");
            else
                Console.WriteLine("Has codigo la carta de la posicion: "+n);

            baraja[n].escribeCarta();
            baraja.Remove(baraja[n]);
        }

        public void cogerCartaAlAzar()
        {
            Random r = new Random();
            int n = r.Next(0, baraja.Count);

            cogerCarta(n,true);
        }

        public void escribeBaraja()
        {
            for (int i = 0; i < baraja.Count; i++)
            {
                Console.Write((i+1)+". ");
                baraja[i].escribeCarta();
            }
        }

        public void Barajar()
        {
            Random r = new Random();
            int posicion;
            int totalCartas = baraja.Count;
            for (int i = 0; i < totalCartas; i++)
            {
                posicion = r.Next(0, totalCartas);
                baraja.Insert(posicion, baraja[0]);
                baraja.Remove(baraja[0]);
            }
        }




    }
}
