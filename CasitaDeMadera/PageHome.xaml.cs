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
    /// Lógica de interacción para PageHome.xaml
    /// </summary>
    public partial class PageHome : Page
    {
        
        public double totalcompra;
        public double puntos;
        private double rango = 0.5;
        

        public PageHome()
        {
            InitializeComponent();
          
        }

        //Permitir solo valores numericos en el textbox número telefónico
        private void Numero_Tel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        //Pasar al siguen textbox con solo presionando la tecla enter
        private void Numero_Tel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Validar.PressEnter(e);
        }
        //Permitir solo valores numericos en el textbox total de compras
        private void TotalComp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        //Pasar al siguente textbox y y mostarar los puntos a agregar presionando la tecla enter
        //solo se aceptan la un compra mayor o igual a 25
        private void TotalComp_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (TotalComp.Text.Length != 0)
            {
                totalcompra = float.Parse(TotalComp.Text);
                if (totalcompra >= 25)
                {
                    if (e.Key == Key.Enter)
                    {
                        TextBox s = e.Source as TextBox;
                        if (s != null)
                        {
                            puntos = totalcompra * rango / 25;
                            LbPuntos.Content = puntos.ToString() + " Puntos";
                            s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                        }
                        e.Handled = true;
                    }
                    
                }
                else
                {
                    LbPuntos.Content = "0 Puntos";
                }

            }
        }
       
        //Nos permite agregar los puntos al cliente y mostrar el total de puntos de este
        private void Butto_Agre_Punt_Click(object sender, RoutedEventArgs e)
        {
            NumeroTel.BorderBrush = Brushes.Black;
            TotalComp.BorderBrush = Brushes.Black;
            //Validamos que los campos esten corectamente rellenados
            //número telefónico cuente con los 10 digitos o el digito consecutivo
            if (NumeroTel.Text.Length != 0 && TotalComp.Text.Length != 0)
            {
                if (NumeroTel.Text.Length <= 3 || NumeroTel.Text.Length == 10)
                {
                    //Espacio para registar todo la informacion a la BD
                    //Mandamos el mensaje de puntos sumados y el total de puntos
                    MessageBox.Show("Número telefónico: " + NumeroTel.Text +
                "\n puntos totales: " + LbPuntos.Content);
                }
            }
            else if (NumeroTel.Text.Length == 0 && TotalComp.Text.Length != 0)
            {
                NumeroTel.BorderBrush = Brushes.Red;
                MessageBox.Show("Rellene los datos corectamente");

            }
            else if (NumeroTel.Text.Length != 0 && TotalComp.Text.Length == 0)
            {
                TotalComp.BorderBrush = Brushes.Red;
                MessageBox.Show("Rellene los datos corectamente");

            }
            else
            {
                NumeroTel.BorderBrush = Brushes.Red;
                TotalComp.BorderBrush = Brushes.Red;
                 MessageBox.Show("Rellene los datos corectamente");
            }
            

        }

        private void Button_Agregar_usu_Click(object sender, RoutedEventArgs e)
        {
            AgregarUsu agregarUsu = new AgregarUsu();
            this.NavigationService.Navigate(agregarUsu);
        }

        private void Canjear_puntos_Click(object sender, RoutedEventArgs e)
        {
            CanjeoPuntos canjeo = new CanjeoPuntos();
            this.NavigationService.Navigate(canjeo);
            
        }

        private void Button_Historial_Click(object sender, RoutedEventArgs e)
        {
            Historial historial = new Historial();
            this.NavigationService.Navigate(historial);
        }
    }
}
