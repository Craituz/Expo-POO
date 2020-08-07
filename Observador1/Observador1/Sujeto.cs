using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador1
{
    class Sujeto
    {
        public List<IObserver> observadores = new List<IObserver>();
        //usaremos IObservador para guardar a todos los que esten suscritos
        public string mensaje;
        public Random rnd = new Random();
        public int n;
        //con su propiedad correspondiente
        public int N { get => n; set => n = value; }

        public void suscribir(IObserver suscrito)
        {
            //lo introducimos a la lista
            observadores.Add(suscrito);
        }

        public void desuscribir(IObserver suscrito)
        {
            //lo quitamos de la lista
            observadores.Remove(suscrito);
        }

        public void Notificar()
        {
            //enviamos la notificacion a los que esten suscritos
            foreach (IObserver o in observadores)
            {
                o.Update(mensaje);
                //o.UpdatePull();
            }
        }
        //aqui vamos a simular el observador y los cambios de estado
        public void Trabajo()
        {
            //guardamos un numero aleatorio en n
            n = rnd.Next(10);
            //si n es par enviamos el mensaje nuevo estado
            if (n % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------Nuevo estado");
                mensaje = string.Format("el nuevo valor es {0}", n);
                Notificar();
            }
        }
    }
}
