using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class PrincipalPresentador: PresentadorBase<TareaBase, IPrincipalVista>
    {
        public PrincipalPresentador(IPrincipalVista vista): base(vista)
        {

        }

        public void IniciarProductos()
        {
            AdministradorDeTareas.Instance.Iniciar<ProductoTarea>(Vista);
        }
        public void IniciarPedidos()
        {
            AdministradorDeTareas.Instance.Iniciar<PedidoTarea>(Vista);
        }
    }
}
