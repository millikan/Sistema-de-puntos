using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CasitaDeMadera
{
    class Validar
    {
        //calidadmos que solo podemos escribir numero
        public static void SoloNumeros(TextCompositionEventArgs e)
        {
            if (!(int.TryParse(e.Text, out _) || e.Text == "."))
            {
                e.Handled = true;
            }
        }

        public static void PressEnter(KeyEventArgs e)
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

    }
}
