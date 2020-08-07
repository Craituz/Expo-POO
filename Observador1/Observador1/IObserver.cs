using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador1
{
    interface IObserver
    {
        void Update(string mensaje);
        //este metodo upsate se usa en el modelo de Push
        //void Updatepull();
        //en otro caso podriamos usar Updatepull del modelo de pull
    }
}
