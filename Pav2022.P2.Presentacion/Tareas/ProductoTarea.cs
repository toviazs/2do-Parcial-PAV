using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Tareas
{
    public class ProductoTarea: TareaBase
    {
        public int ProductoId { get; set; }

        public ProductoTarea()
        {
            
        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<CrearProductoPresentador>(esMdiHijo: true);
        }
    }
}
