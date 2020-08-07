using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador1
{
    class program
    {
        static void Main(string[] args)
        {
            //creamos el sujeto
            Sujeto sujetito = new Sujeto();
            //creamos los observer
            //pasamos la referencia a sujetito
            Observer x = new Observer("X", sujetito);
            Observer y = new Observer("Y", sujetito);
            Observer z = new Observer("Z", sujetito);

            //realizamos el trabajo
            //en caso de que la variable aleatoria sea par
            //se envia la informacion a todos que esten suscrito
            for (int n = 0; n < 5; n++)
                sujetito.Trabajo();

            //alguien sale de la lista
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------Desuscribir");

            sujetito.desuscribir(y);

            //realizamos el trabajo
            for (int n = 0; n < 5; n++)
                sujetito.Trabajo();
            Console.ReadKey();
        }
    }
}
