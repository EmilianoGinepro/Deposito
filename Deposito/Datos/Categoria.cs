using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Categoria
    {
        Entidades.Deposito2Container contexto = new Entidades.Deposito2Container();

        public void Agregar(Entidades.Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }
        public void Modificar(Entidades.Categoria categoria)
        {
            var categoriaModi = contexto.Categorias.Find(categoria.Id);
            categoriaModi.Id = categoria.Id;
            categoriaModi.Rubro = categoria.Rubro;
            contexto.SaveChanges();
        }
        public void Borrar(int id)
        {
            var categoriaBorrar = contexto.Categorias.Find(id);
            contexto.Categorias.Remove(categoriaBorrar);
            contexto.SaveChanges();
        }

        public class listaCategorias
        {
            public int id { get; set; }
            public string nombre { get; set; }
        }
        public List<listaCategorias> Traer()
        {
            var listaCategorias = from c in contexto.Categorias
                                  select new listaCategorias
                                  {
                                      id = c.Id,
                                      nombre = c.Rubro,
                                  };
            return listaCategorias.ToList();
        }
    }
}
