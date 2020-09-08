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

namespace CasitaDeMadera
{
    /// <summary>
    /// Lógica de interacción para Historial.xaml
    /// </summary>
    public partial class Historial : Page
    {
        public Historial()
        {
            InitializeComponent();
        }

        //Buscar un cliente en espesifico con solo precionar la tecla enter
        private void Buscar_PreviewKeyDown(object sender, KeyEventArgs e)
        {
           if (e.Key == Key.Enter)
           {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                   s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }
                e.Handled = true;
           }

               
        }

        //Editar un clinete solo su nombre y número telefónico
        private void EditUs_Click(object sender, RoutedEventArgs e)
        {

        }

        //Eliminar un clinete inactivo
        private void EliminarUs_Click(object sender, RoutedEventArgs e)
        {

        }

        //Cuardar los cambios de editar y eliminar
        private void GuardarCam_Click(object sender, RoutedEventArgs e)
        {

        }

        //Ver el perfil del usuario
        private void VerUs_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
