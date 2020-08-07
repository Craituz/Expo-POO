using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador1
{
    //implementamos IObserver
    class Observer : IObserver
    {
        public string nombre;
        //la variable sujeto es nuestra variable de referencia
        public Sujeto sujeto;
        //el constructor recibe el nombre y la referencia 
        public Observer(string Nombre1, Sujeto sujeto1)
        {
            nombre = Nombre1;
            sujeto = sujeto1;
            //se aprobecha a sujeto para suscribirnos y quedar dentro de la lista
            sujeto.suscribir(this);
        }
        //metodo Update para el modelo Push
        public void Update(string mensaje)
        {
            //colocamos el color amarillo oscuro e imprimimos 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //cuando el sujeto tiene un cambio dentro del estado se usa este metodo
            Console.WriteLine("push,{0}-{1}", nombre, mensaje);
        }
        //metodo Update para el modelo Pull
        public void Updatepull()
        {
            //obtenemos del sujeto un cambio de estado
            //se puede decidir si leer o no ese estado
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("push,{0}-{1}", nombre, n);
        }
    }
}
