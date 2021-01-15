using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        Datos.Producto objDatos = new Datos.Producto();

        public void Agregar(Entidades.Producto producto)
        {
            objDatos.Agregar(producto);
        }
        public void Modificar(Entidades.Producto producto)
        {
            objDatos.Modificar(producto);
        }
        public void Borrar(int id)
        {
            objDatos.Borrar(id);
        }

        public List<Datos.Producto.listaProductos> Traer()
        {
            return objDatos.Traer();
        }
        public List<Datos.Producto.Rubros> TraerRubros()
        {
            return objDatos.TraerRubros();
        }
    }
}
