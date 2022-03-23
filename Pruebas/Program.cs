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

            baraja.escribeBaraja();
            baraja.numeroCartas();

            //Robo 10 cartas
            for (int i = 0; i < 10; i++)
            {
                baraja.robarCarta();
            }

            baraja.escribeBaraja();
            baraja.numeroCartas();

            baraja.Barajar();
            baraja.escribeBaraja();

            baraja.cogerCarta(4, false);
            baraja.cogerCartaAlAzar();
            baraja.numeroCartas();



        }

        

       
    }
}