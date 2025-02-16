namespace SOLID_EXAMPLE
{
    public class Estudiante
    {
            public string Nombre { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

            public Estudiante()
            {

            }

            public void Guardar()
            {
                // Código para guardar el estudiante en la base de datos o repositorio.
            }

            public void NotificarCambioNombre(string nuevoNombre)
            {
                
               //Enviar("Cambio de nombre", $"Su nombre ha sido cambiado a {nuevoNombre}");
            }

            public void NotificarCambioEmail(string nuevoEmail)
            {
                //Enviar("Cambio de email", $"Su email ha sido cambiado a {nuevoEmail}");
            }
    }


    }
}
