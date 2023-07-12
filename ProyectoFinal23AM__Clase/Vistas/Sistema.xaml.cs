using ProyectoFinal23AM__Clase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProyectoFinal23AM__Clase.Services;

namespace ProyectoFinal23AM__Clase.Vistas
{
    /// <summary>
    /// Lógica de interacción para Sistema.xaml
    /// </summary>
    public partial class Sistema : Window
    {
        public Sistema()
        {
            InitializeComponent();
        }

        UsuarioServices services = new();

        
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new();

            // Los datos que ingresa el usuario

            usuario.Nombre = txtNombre.Text;
            usuario.Username = txtUserName.Text;
            usuario.Password = txtPassword.Text;

            // Agregar los datos a la BD
            services.AddUser(usuario); 

            // Limpiar el WPF donde se ingresan los datos
            txtNombre.Clear();
            txtUserName.Clear();
            txtPassword.Clear();

        }
    }
}
