using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._2.O
{
    public class NotificacionesSMS : Notificaciones, INotificaciones
    {
        public string EndPoint { get; set; }
        void INotificaciones.Enviar(Estudiante estudiante, string Texto)
        {
            // codigo para conectarnos con un broker con un vendedor generico;
        }
    }
}
