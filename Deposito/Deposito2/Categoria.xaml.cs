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
using System.Windows.Navigation;

namespace Deposito2
{
    /// <summary>
    /// Lógica de interacción para Categoria.xaml
    /// </summary>
    public partial class Categoria : Window
    {
        Logica.Categoria objLogica = new Logica.Categoria();
        public Categoria()
        {
            InitializeComponent();
        }

        void TraerCategoria()
        {
            dgCategorias.ItemsSource = objLogica.Traer();
            dgCategorias.Columns[0].Width = 50; // Id
            dgCategorias.Columns[1].Width = 150;//Descripcion
            dgCategorias.Columns[2].Visibility = Visibility.Hidden;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TraerCategoria();
        }

        //Delegado de botones
        private void Botones(object sender, RoutedEventArgs e)
        {
            Button miBoton = sender as Button;
            switch (miBoton.Name)
            {
                case "btnNuevo":
                    Entidades.Categoria entidad = new Entidades.Categoria();
                    entidad.Rubro = txtNombre.Text;
                    try
                    {
                        objLogica.Agregar(entidad);
                        MessageBox.Show("Categoria agregada");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnModificar":
                    Entidades.Categoria categoriaModificar = new Entidades.Categoria();
                    categoriaModificar.Id = Convert.ToInt32(txtID.Text);
                    categoriaModificar.Rubro = txtNombre.Text;
                    objLogica.Modificar(categoriaModificar);
                    MessageBox.Show("Categoria modificada");
                    break;
                case "btnCerrar":
                    Close();
                    break;
                case "btnBorrar":
                    int idBorrar = Convert.ToInt32(txtID.Text);
                    objLogica.Borrar(idBorrar);
                    MessageBox.Show("Categoria borrada");
                    break;
            }
            TraerCategoria();
        }

        private void dgCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow filaseleccionada = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            if (filaseleccionada != null)
            {
                DataGridCell columnaID = dataGrid.Columns[0].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtID.Text = ((TextBlock)columnaID.Content).Text;
                DataGridCell columnaNombre = dataGrid.Columns[1].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtNombre.Text = ((TextBlock)columnaNombre.Content).Text;
            }


        }
    }
}
