using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Categoria
    {
        Datos.Categoria objDatos = new Datos.Categoria();

        public void Agregar(Entidades.Categoria categoria)
        {
            try
            {
                if (categoria.Rubro.Contains("0")|| categoria.Rubro.Contains("1"))
                {
                    throw new Exception("Marca no valida");
                }
                objDatos.Agregar(categoria);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void Modificar(Entidades.Categoria categoria)
        {
            objDatos.Modificar(categoria);
        }
        public void Borrar(int id)
        {
            objDatos.Borrar(id);
        }
        public List<Datos.Categoria.listaCategorias> Traer()
        {
            return objDatos.Traer();
        }
    }
}
