using ProyectoFinal23AM__Clase.Vistas;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinal23AM__Clase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Abrir una nueva ventana

            Sistema sistema = new();    // Instanciar Ventana
            sistema.Show();             // Ver Ventana
            Close();                    // Se Cierra la Ventana -- Sistema.Close()= Se abre y cierra nuevamente [por eso puro Close().]
        }
    }
}
