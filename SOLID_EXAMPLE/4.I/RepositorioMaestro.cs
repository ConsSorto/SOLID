﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._4.I
{
    public class RepositorioMaestro : IObtener
    {
        Persona IObtener.Obtener(int Id)
        {
            //Logica 
            return new Persona();
           
        }
    }
}
