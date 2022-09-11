using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Dominio.Entidades
{
    public class LineaPedido : EntidadBase
    {
        public LineaPedido()
        {

        }
        public LineaPedido(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public int Cantidad { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual int ProductoId { get; set; }
    }
}
