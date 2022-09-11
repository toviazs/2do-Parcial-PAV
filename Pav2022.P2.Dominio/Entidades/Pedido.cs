using Pav2022.P2.Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Timers;

namespace Pav2022.P2.Dominio.Entidades
{
    public class Pedido : EntidadBase
    {
        public Estado EstadoActual { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroPedido { get; set; }
        public int TiempoPreparacion { get; set; }
        public virtual ICollection<LineaPedido> LineaPedidos { get; set; }

        public Pedido()
        {
            
        }

        public void CalcularTiempoPreparacion(List<LineaPedido> lineasPedido)
        {
            var SumaTiemposPreparacion = lineasPedido.Sum(p => p.Producto.TiempoDePreparacion);
            var MaxTiempoPreparacion = lineasPedido.Max(p => p.Producto.TiempoDePreparacion);

            if(SumaTiemposPreparacion <= 15)
            {
                TiempoPreparacion = MaxTiempoPreparacion;
            } 
            else if (SumaTiemposPreparacion <= 20)
            {
                TiempoPreparacion = MaxTiempoPreparacion + 7;
            }
            else
            {
                TiempoPreparacion = MaxTiempoPreparacion + 5 + (SumaTiemposPreparacion / 12) * 5;
            }
        }
        public void GenerarNumeroPedido(List<Pedido> pedidos)
        {
            if (pedidos.Count == 0)
            {
                NumeroPedido = 1;
            }
            else
            {
                NumeroPedido = pedidos.Max(p => p.NumeroPedido) + 1;
            }
        }
        public void CambiarEstado()
        {
            EstadoActual = Estado.Listo;
        }
        public void IniciarPedido()
        {
            EstadoActual = Estado.Pendiente;
            Fecha = DateTime.Now;
        }
    }
}
