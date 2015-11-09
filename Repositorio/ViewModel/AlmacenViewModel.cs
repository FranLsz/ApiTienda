using Repositorio.Model;

namespace Repositorio.ViewModel
{
    class AlmacenViewModel : IViewModel<Almacen>
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string cp { get; set; }

        public Almacen ToBaseDatos()
        {
            return new Almacen()
            {
                id = id,
                ciudad = ciudad,
                cp = cp
            };
        }

        public void FromBaseDatos(Almacen model)
        {
            id = model.id;
            ciudad = model.ciudad;
            cp = model.ciudad;
        }

        public void UpdateBaseDatos(Almacen model)
        {
            model.id = id;
            model.ciudad = ciudad;
            model.cp = cp;
        }

        public object[] GetKeys()
        {
            return new[] { (object)id };
        }
    }
}
