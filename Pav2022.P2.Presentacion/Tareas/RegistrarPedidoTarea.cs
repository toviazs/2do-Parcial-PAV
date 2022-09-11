using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Presentacion.Tareas
{
    public class RegistrarPedidoTarea : TareaBase
    {
        public int ProductoId { get; set; }

        public RegistrarPedidoTarea()
        {

        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<RegistrarPedidoPresentador>(esDialogo: true);
        }
    }
}
