using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._4.I
{
    public class RepositorioEstudiante : IReporsitorio
    {
        int IReporsitorio.Editar(Persona editPersona, int Id)
        {
            //logica de bd
            return 1;
        }

        int IReporsitorio.Eliminar(int Id)
        {
            //logica de bd
            return 1;
        }

        int IReporsitorio.Guardar(Persona editPersona)
        {
            //logica de bd
            return 1;
        }

        int IReporsitorio.Obtener(int Id)
        {
            //logica de bd
            return 1;
        }
    }
}
