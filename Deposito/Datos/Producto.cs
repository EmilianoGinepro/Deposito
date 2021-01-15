using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        Entidades.Deposito2Container contexto = new Entidades.Deposito2Container();

        public void Agregar(Entidades.Producto producto)
        {
            contexto.Productos.Add(producto);
            contexto.SaveChanges();
        }

        public void Modificar(Entidades.Producto producto)
        {
            var productoModi = contexto.Productos.Find(producto.Id);
            productoModi.Nombre = producto.Nombre;
            productoModi.Material = producto.Material;
            productoModi.Medida = producto.Medida;
            productoModi.Stock = producto.Stock;
            productoModi.CategoriaId = producto.CategoriaId;
            contexto.SaveChanges();
        }
        public void Borrar(int id)
        {
            var productoBorrar = contexto.Productos.Find(id);
            contexto.Productos.Remove(productoBorrar);
            contexto.SaveChanges();
        }

        //objeto para mostrar los productos con el rubro
        public class listaProductos
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string material { get; set; }
            public string medida { get; set; }
            public int stock { get; set; }
            public string rubro { get; set; }
        }
        //armado de la vista para el DataGridView
        public List<listaProductos> Traer()
        {
            listaProductos listaProductos = new listaProductos();

            var listaProductos1 = from a in contexto.Productos
                                  join b in contexto.Categorias on a.CategoriaId equals b.Id
                                  select new listaProductos
                                  {
                                      id = a.Id,
                                      nombre = a.Nombre,
                                      material = a.Material,
                                      medida = a.Medida,
                                      stock = a.Stock,
                                      rubro = b.Rubro,
                                  };

            return listaProductos1.ToList();
        }

        public class Rubros
        {
            public int IdRubros { get; set; }
            public string NombreRubros { get; set; }
        }
        //query para llenar el combobox
        public List<Rubros> TraerRubros()
        {
            Rubros rubro = new Rubros();

            var ListaRubro = from a in contexto.Categorias
                             select new Rubros
                             {
                                 NombreRubros = a.Rubro,
                                 IdRubros = a.Id,
                             };
            return ListaRubro.ToList();
        }
    }
}
