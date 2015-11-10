using BaseRepositorio.ViewModel;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    class CategoriaViewModel : IViewModel<Categoria>
    {
        public int id { get; set; }
        public string nombre { get; set; }


        public Categoria ToBaseDatos()
        {
            return new Categoria()
            {
                id = id,
                nombre = nombre
            };
        }

        public void FromBaseDatos(Categoria model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateBaseDatos(Categoria model)
        {
            model.id = id;
            model.nombre = nombre;
        }

        public object[] GetKeys()
        {
            return new[] { (object)id };
        }
    }
}
