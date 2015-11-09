using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Practices.Unity;
using Repositorio.Model;
using Repositorio.Repositorio;
using Repositorio.ViewModel;

namespace ApiTienda.Controllers
{
    public class ProductosController : ApiController
    {
        [Dependency]
        public IRepositorio<Producto, ProductoViewModel> repo { get; set; }

        public ICollection<ProductoViewModel> GetProductos()
        {
            return repo.Get();
        }

        [ResponseType(typeof(ProductoViewModel))]
        public IHttpActionResult GetProductos([FromUri]int id)
        {
            var data = repo.Get(id);
            //var data = repo.Get(o => o.id.Equals(id));
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [ResponseType(typeof(ProductoViewModel))]
        public IHttpActionResult PostProductos([FromBody]ProductoViewModel producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(producto);

            return Created("DefaultApi", producto);
        }

        [ResponseType(typeof(ProductoViewModel))]
        public IHttpActionResult PutProductos([FromUri]int id, [FromBody]ProductoViewModel producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.id)
            {
                return BadRequest();
            }

            if (repo.Get(id) == null)
                return NotFound();

            repo.Update(producto);

            return Created("DefaultApi", producto);
        }

        [ResponseType(typeof(ProductoViewModel))]
        public IHttpActionResult DeleteProductos([FromUri]int id)
        {
            var producto = repo.Get(id);
            if (producto == null)
            {
                return NotFound();
            }
            repo.Delete(producto);

            return Ok(producto);
        }
    }
}
