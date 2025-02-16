using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_EXAMPLE._2.O;

namespace SOLID_EXAMPLE._3.L
{
    public class EstudianteNotificaciones
    {
        public Estudiante _Estudiante { get; set; }

        public readonly INotificaciones _notificacionesService;

        public EstudianteNotificaciones(Estudiante estudiante, INotificaciones notificacionesService, string Texto)
        {
            _Estudiante = estudiante;
            _notificacionesService = notificacionesService;
            _notificacionesService.Enviar(_Estudiante, Texto);      
         }

    }
}
