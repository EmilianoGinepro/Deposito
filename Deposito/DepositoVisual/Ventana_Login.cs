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
    public partial class Login : Form
    {              
        public Login()
        {
            InitializeComponent();
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Entidades.Deposito2Container contexto = new Entidades.Deposito2Container();
            var Usuario = txtUsuario.Text.Trim().ToLower();
            var Clave = txtClave.Text.Trim().ToLower();

            var listalogin = from a in contexto.LoginSet
                             where a.Usuario == Usuario
                             && a.Clave == Clave
                             select a;
            if(listalogin.Count() >0)
            {
                Ventana_Principal ventana_Principal = new Ventana_Principal();
                ventana_Principal.Show();
                Visible = false;               
            }
            else
            {
                MessageBox.Show("Pruebe otro usuario y o clave");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
