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

namespace Deposito2
{
    /// <summary>
    /// Lógica de interacción para Producto.xaml
    /// </summary>
    public partial class Producto : Window
    {
        Logica.Producto objLogica = new Logica.Producto();
       
        public Producto()
        {
            InitializeComponent();
            ComboBoxRubros.ItemsSource = objLogica.TraerRubros();                       
        }
        
      

        void TraerProducto()
        {
            dgProdcutos.ItemsSource = objLogica.Traer();
            dgProdcutos.Columns[0].Width = 50;//id
            dgProdcutos.Columns[1].Width = 100;//Nombre
            dgProdcutos.Columns[2].Width = 100;//Material
            dgProdcutos.Columns[3].Width = 50;//Medida
            dgProdcutos.Columns[4].Width = 50;//Stock
            dgProdcutos.Columns[5].Width = 75;//Rubro                                       
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TraerProducto();
        }
       

        private void BotonesProductos(object sender, RoutedEventArgs e)
        {
            Button miBoton = sender as Button;
            switch (miBoton.Name)
            {
                case "btnNuevo":
                    Entidades.Producto entidad = new Entidades.Producto();
                    
                    
                    entidad.Nombre = txtNombre.Text;
                    entidad.Material = txtMaterial.Text;
                    entidad.Medida = txtMedida.Text;
                    entidad.Stock = Convert.ToInt32(txtStock.Text);
                    // entidad.CategoriaId = ComboBoxRubros.SelectedIndex+1;
                    //entidad.CategoriaId = Convert.ToInt32(ComboBoxRubros.SelectedItem.ToString());
                    ComboBoxRubros.SelectedValue = "id";
                    MessageBox.Show(ComboBoxRubros.SelectedValue.ToString());
                    //MessageBox.Show(ComboBoxRubros.Text.ToString());

                    try
                    {
                        objLogica.Agregar(entidad);
                        MessageBox.Show("Producto agregado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnModificar":
                    //Entidades.Producto productoModificar = new Entidades.Producto();
                    //productoModificar.Nombre = txtNombre.Text;
                    //productoModificar.Material = txtMaterial.Text;
                    //productoModificar.Medida = txtMedida.Text;
                    //productoModificar.Stock = Convert.ToInt32(txtStock.Text);
                    //objLogica.Modificar(productoModificar);
                    //MessageBox.Show("Producto modificado");

                    break;
                case "btnCerrar":
                    Close();
                    break;
                case "btnBorrar":
                    break;

            }
        }

        private void dgProdcutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow filaseleccionada = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            if (filaseleccionada != null)
            {
                DataGridCell columnaId = dataGrid.Columns[0].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtID.Text = ((TextBlock)columnaId.Content).Text;
                DataGridCell columnaNombre = dataGrid.Columns[1].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtNombre.Text = ((TextBlock)columnaNombre.Content).Text;
                DataGridCell columnaMaterial = dataGrid.Columns[2].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtMaterial.Text = ((TextBlock)columnaMaterial.Content).Text;
                DataGridCell columnaMedida = dataGrid.Columns[3].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtMedida.Text = ((TextBlock)columnaMedida.Content).Text;
                DataGridCell columnaStock = dataGrid.Columns[4].GetCellContent(filaseleccionada).Parent as DataGridCell;
                txtStock.Text = ((TextBlock)columnaStock.Content).Text;
                // DataGridCell columnaCategoriaID = dataGrid.Columns[5].GetCellContent(filaseleccionada).Parent as DataGridCell;
                //txtCategoriaID.Text = ((TextBlock)columnaCategoriaID.Content).Text;
                //DataGridCell columnaMarcaID = dataGrid.Columns[6].GetCellContent(filaseleccionada).Parent as DataGridCell;
                //txtMarcaID.Text = ((TextBlock)columnaMarcaID.Content).Text;
                //aca agregar el comboBox


            }

        }
    }
}
