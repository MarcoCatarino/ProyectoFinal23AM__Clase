using Microsoft.EntityFrameworkCore;
using ProyectoFinal23AM__Clase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23AM__Clase.Context
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server= localhost; database= ProyectoDb23Am; user= root; password=");
        }
        //

        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<Rol> Roles { get; set; }

    }
}
