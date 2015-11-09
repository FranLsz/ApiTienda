using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ProductoViewModel : IViewModel<Producto>
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string fabricante { get; set; }
        public decimal precioVenta { get; set; }
        public decimal precioCoste { get; set; }
        public string descripcion { get; set; }
        public int categoria { get; set; }

        public Producto ToBaseDatos()
        {
            return new Producto()
            {
                id = id,
                nombre = nombre,
                fabricante = fabricante,
                precioVenta = precioVenta,
                precioCoste = precioCoste,
                descripcion = descripcion,
                categoria = categoria
            };
        }

        public void FromBaseDatos(Producto model)
        {
            id = model.id;
            nombre = model.nombre;
            fabricante = model.fabricante;
            precioVenta = model.precioVenta;
            precioCoste = model.precioCoste;
            descripcion = model.descripcion;
            categoria = model.categoria;
        }

        public void UpdateBaseDatos(Producto model)
        {
            model.id = id;
            model.nombre = nombre;
            model.fabricante = fabricante;
            model.precioVenta = precioVenta;
            model.precioCoste = precioCoste;
            model.descripcion = descripcion;
            model.categoria = categoria;
        }

        public object[] GetKeys()
        {
            return new[] { (object)id };
        }
    }
}
