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
    /// Lógica de interacción para AgregarUsu.xaml
    /// </summary>
    public partial class AgregarUsu : Page
    {
        public AgregarUsu()
        {
            InitializeComponent();
        }

        private void TexNumerTel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TexNumerTel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(NumeroTel.Text.Length != 0)
            {
                Validar.PressEnter(e);
            }
        }
         
        //registramos el clinte al hacer clik al boton
        private void ButtonAgrUs_Click(object sender, RoutedEventArgs e)
        {
            NumeroTel.BorderBrush = Brushes.Black;
            NombreUs.BorderBrush = Brushes.Black;

            //verificamos que los campos esten corectamente llenado
            if (NumeroTel.Text.Length != 0 && NombreUs.Text.Length != 0)
            {
                if (NumeroTel.Text.Length <= 3 || NumeroTel.Text.Length == 10)
                {
                    //Espacio para registar todo la informacion a la BD
                    MessageBox.Show("Cliente registrado");
        
                }
            }
            else if (NumeroTel.Text.Length == 0 && NombreUs.Text.Length != 0)
            {
                NumeroTel.BorderBrush = Brushes.Red;
                MessageBox.Show("Rellene los datos corectamente");

            }
            else if (NumeroTel.Text.Length != 0 && NombreUs.Text.Length == 0)
            {
                NombreUs.BorderBrush = Brushes.Red;
                MessageBox.Show("Rellene los datos corectamente");

            }
            else
            {
                NumeroTel.BorderBrush = Brushes.Red;
                NombreUs.BorderBrush = Brushes.Red;
                MessageBox.Show("Rellene los datos corectamente");
            }
        }

        private void ButtonFoto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
