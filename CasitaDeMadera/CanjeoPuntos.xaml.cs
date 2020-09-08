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
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CasitaDeMadera
{
    /// <summary>
    /// Lógica de interacción para CanjeoPuntos.xaml
    /// </summary>
    public partial class CanjeoPuntos : Page
    {
        public CanjeoPuntos()
        {
            InitializeComponent();
        }

        //Buscar un cliente en especifico con solo un enter
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
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

        //Camjear los puntos por producto
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
