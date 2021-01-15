using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DepositoVisual
{
     
    public partial class Ventana_Categoria : Form
    {
        Logica.Categoria objLogica = new Logica.Categoria();
        public Ventana_Categoria()
        {
            InitializeComponent();
            TraerCategorias();
        }
        void TraerCategorias()
        {
            dvgVista.DataSource = objLogica.Traer();
        }

        //seleccionar un producto de la DataGridView
        private void dvgVista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgVista.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCategoria.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Entidades.Categoria entidad = new Entidades.Categoria();
            entidad.Rubro = txtCategoria.Text;
            try
            {
                objLogica.Agregar(entidad);
                MessageBox.Show("Categoria agregada");
                TraerCategorias();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Categoria categoriaModificar = new Entidades.Categoria();
            categoriaModificar.Id = Convert.ToInt32(txtId.Text);
            categoriaModificar.Rubro = txtCategoria.Text;
            try
            {
                objLogica.Modificar(categoriaModificar);
                MessageBox.Show("Categoria modificada");
                TraerCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {           
            try
            {
                int idBorrar = Convert.ToInt32(txtId.Text);
                objLogica.Borrar(idBorrar);
                MessageBox.Show("Categoria borrada");
                TraerCategorias();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese el Id de la categoria a borrar");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Ventana_Principal ventana_Principal = new Ventana_Principal();
            ventana_Principal.Show();
            Close();
        }

        private void dvgVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtCategoria.Clear();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
          (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 164 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no valido");
                e.Handled = true;
                return;
            }
        }
    }

}
