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

namespace Deposito2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }
    
        private void BotonesPrincipal(object sender, RoutedEventArgs e)
        {
            Button miBoton = sender as Button;
            switch (miBoton.Name)
            {
                case "btnCategorias":
                    Categoria VentanaCategoria = new Categoria();
                    VentanaCategoria.Owner = this;
                    VentanaCategoria.ShowDialog();
                    break;
                case "btnProductos":
                    Producto VentanaProducto = new Producto();
                    VentanaProducto.Owner = this;
                    VentanaProducto.ShowDialog();
                    break;
                case "btnCerrar":
                    Close();
                    break;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
