﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._2.O
{
    public class Repositorio
    {
        public string Tabla { get; set; }
        public int Id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public DateTime deleted_at { get; set; }
        public Repositorio() { }

        public int Guardar(Estudiante estudiante)
        {
            // codigo para guardar, insert into sjdlskdjflsdjfdsljf
            return this.Id;
        }

    }
}
