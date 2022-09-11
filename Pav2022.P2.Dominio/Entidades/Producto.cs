using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Dominio.Entidades
{
    public class Producto: EntidadBase
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int TiempoDePreparacion { get; set; }
        public virtual ICollection<LineaPedido> LineaPedidos { get; set; }
    }
}
