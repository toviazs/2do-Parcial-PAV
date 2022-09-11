using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Pav2022.P2.Dominio.Entidades
{
    // Necesitaba un reloj que al mismo tiempo guarde la referencia a un Pedido
    public class RelojPedido : Timer
    {
        public Pedido Pedido { get; set; }
        public RelojPedido(int tiempo, Pedido pedido)
        {
            base.Interval = tiempo;
            Pedido = pedido;
        }
    }
}
