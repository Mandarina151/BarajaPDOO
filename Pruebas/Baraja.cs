using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Baraja
    {
        //Miembros
        //Lista de cartas
        List<Carta> baraja = new List<Carta>();
        //Carta
        Carta carta;

        public Baraja()
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 12; j++)
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

        public void escribeBaraja()
        {
            for (int i = 0; i < baraja.Count; i++)
            {
                Console.Write((i+1)+". ");
                baraja[i].escribeCarta();
            }
        }

        public void robarCarta()
        {
            baraja[0].escribeCarta();
            baraja.RemoveAt(0);
        }


    }
}
