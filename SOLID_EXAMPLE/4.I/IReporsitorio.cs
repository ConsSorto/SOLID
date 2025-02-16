using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_EXAMPLE._3.I;

namespace SOLID_EXAMPLE._4.I
{
    public interface IReporsitorio
    {
        public int Guardar(Persona editPersona);
        public int Editar(Persona editPersona, int Id);
        public int Eliminar(int Id);
        public int Obtener(int Id);
    }
}
