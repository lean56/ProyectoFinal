﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProyectoFinal.Entidades
{
   public class Cargos
    {

        [Key]
        public int CargoId { get; set; }
        public string Descripcion { get; set; }

        public Cargos()
        {
            CargoId = 0;
            Descripcion = string.Empty;  
        }
    }
}
