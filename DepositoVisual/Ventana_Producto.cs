using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace DepositoVisual
{
    public partial class Ventana_Producto : Form
    {
        Logica.Producto objLogica = new Logica.Producto();
        public Ventana_Producto()
        {
            InitializeComponent();
            TraerProdcutos();
            llenarComboBox();
        }
        void TraerProdcutos()
        {
            dvgProducto.DataSource = objLogica.Traer();
        }
    
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Ventana_Principal ventana_Principal = new Ventana_Principal();
            ventana_Principal.Show();
            Close();
        }
        public void llenarComboBox()
        {
            cboCategoria.DataSource = objLogica.TraerRubros();
            cboCategoria.DisplayMember = "NombreRubros";
            cboCategoria.ValueMember = "IdRubros";
        }

        //seleccionar un producto de la DataGridView
        private void dvgProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dvgProducto.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtMaterial.Text = row.Cells[2].Value.ToString();
                txtMedida.Text = row.Cells[3].Value.ToString();
                txtStock.Text = row.Cells[4].Value.ToString();
                cboCategoria.Text = row.Cells[5].Value.ToString();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Entidades.Producto entidad = new Entidades.Producto();

            entidad.Nombre = txtNombre.Text;
            entidad.Material = txtMaterial.Text;
            entidad.Medida = txtMedida.Text;
            entidad.Stock = Convert.ToInt32(txtStock.Text);
            entidad.CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);           
            try
            {
                objLogica.Agregar(entidad);
                MessageBox.Show("Producto agregado");
                TraerProdcutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Producto productoModificar = new Entidades.Producto();

            productoModificar.Id = Convert.ToInt32(txtId.Text);
            productoModificar.Nombre = txtNombre.Text;
            productoModificar.Material = txtMaterial.Text;
            productoModificar.Medida = txtMedida.Text;
            productoModificar.Stock = Convert.ToInt32(txtStock.Text);
            productoModificar.CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);//no lo modifica

            try
            {
                objLogica.Modificar(productoModificar);
                MessageBox.Show("Producto modificado");
                TraerProdcutos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int idBorrar = Convert.ToInt32(txtId.Text);
                objLogica.Borrar(idBorrar);
                MessageBox.Show("Producto borrado");
                TraerProdcutos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el Id del producto a borrar");
            }
        }
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtMaterial.Clear();
            txtMedida.Clear();
            txtStock.Clear();
            cboCategoria.Text = ("");
        }

        //Validaciones de los textbox
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <=64) || (e.KeyChar >=91 && e.KeyChar <=96) ||
                (e.KeyChar >=123 && e.KeyChar <=159) || (e.KeyChar >=164 && e.KeyChar <=255 ))
            {
                MessageBox.Show("Caracter no valido");
                e.Handled = true;
                return;
            }
        }

        private void txtMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
               (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 164 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no valido");
                e.Handled = true;
                return;
            }
        }

        private void txtMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >=58 && e.KeyChar <=64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
              (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 164 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no valido");
                e.Handled = true;
                return;
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <=47) || (e.KeyChar >=58 && e.KeyChar <=255))
            {
                MessageBox.Show("Caracter no valido");
                e.Handled = true;
                return;
            }
        }
    }
}
