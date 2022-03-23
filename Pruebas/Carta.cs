using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Carta
    {
        //Atributes
        private int numero;
        private int palo;
        string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

        //Getter y setter de numero
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value != null)
                    numero = value;
            }
        }

        //Constructor
        public Carta()
        {
            numero = 0;
            palo = 0;
        }

        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }
    



        //Funciones 
        public void escribeCarta()
        {
            Console.WriteLine(numero + " de " + palos[palo]);
        }
    }
}
