using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoFinal23AM__Clase.Entities
{
    public class Rol
    {
        [Key] //Primary Key
        public int PkRol { get; set; }
        public string Nombre { get; set; }
    }
}
