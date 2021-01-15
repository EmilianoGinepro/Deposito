using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepositoVisual
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            Ventana_Categoria _ventanaCategorias = new Ventana_Categoria();
            _ventanaCategorias.Show();
            Visible = false;
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Ventana_Producto _ventanaProducto = new Ventana_Producto();
            _ventanaProducto.Show();
            Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();          
        }

      
    }
}
