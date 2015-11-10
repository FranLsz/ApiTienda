using System;
using System.Collections.Generic;
using BaseRepositorio.ViewModel;
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
        public int idCategoria { get; set; }
        public String Categoria { get; set; }
        public List<EtiquetaViewModel> Etiquetas { get; set; }

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
                categoria = idCategoria
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
            idCategoria = model.categoria;

            try
            {
                Categoria = model.Categoria1.nombre;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                if (Etiquetas == null)
                    Etiquetas = new List<EtiquetaViewModel>();

                foreach (var etiqueta in model.Etiqueta)
                {
                    var et = new EtiquetaViewModel();
                    et.FromBaseDatos(etiqueta);
                    Etiquetas.Add(et);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateBaseDatos(Producto model)
        {
            model.id = id;
            model.nombre = nombre;
            model.fabricante = fabricante;
            model.precioVenta = precioVenta;
            model.precioCoste = precioCoste;
            model.descripcion = descripcion;
            model.categoria = idCategoria;
        }

        public object[] GetKeys()
        {
            return new[] { (object)id };
        }
    }
}
