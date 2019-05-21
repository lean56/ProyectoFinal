using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string NivelUsuario { get; set; }
        public string usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
