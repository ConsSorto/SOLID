using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._2.O
{
    public interface INotificaciones
    {
        public void Enviar(Estudiante estudiante, string Texto);
    }
}
