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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
  
        }

        //al pasar de un ventana a otra solo podemos regresar a la anterior 
        //borramos el historial del navegador
        /*private void NavigationWindow_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
               if (this.NavigationService.CanGoForward)
               {
                   this.NavigationService.GoForward();

               }
               //this.NavigationService.RemoveBackEntry();
           }
            

        }*/
    }
}
