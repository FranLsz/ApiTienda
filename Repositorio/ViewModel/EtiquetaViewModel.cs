using BaseRepositorio.ViewModel;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class EtiquetaViewModel : IViewModel<Etiqueta>
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Etiqueta ToBaseDatos()
        {
            return new Etiqueta()
            {
                id = id,
                nombre = nombre
            };
        }

        public void FromBaseDatos(Etiqueta model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateBaseDatos(Etiqueta model)
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
