using ProyectoFinal23AM__Clase.Context;
using ProyectoFinal23AM__Clase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23AM__Clase.Services
// CRUD , Funcionalidades, Metodos, etc.

{
    public class UsuarioServices
    {
        public void AddUser(Usuario request)
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDBContext())
                    {
                        Usuario usuario = new();
                        
                        usuario.Nombre = request.Nombre;
                        usuario.Username = request.Username;
                        usuario.Password = request.Password;
                        //usuario.FkRol = request.FkRol;
                    
                        _context.Usuarios.Add(usuario);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("ERROR" + ex.Message);
            }
        }
    }
}
