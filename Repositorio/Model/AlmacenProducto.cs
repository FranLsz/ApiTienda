//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlmacenProducto
    {
        public int idAlmacen { get; set; }
        public int idProducto { get; set; }
        public int existencias { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
