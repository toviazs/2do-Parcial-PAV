﻿using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Tareas
{
    /// <summary>
    /// Interfaz para implementar en todas las tareas que se definan.
    /// </summary>
    public interface ITarea
    {
        IVista MdiPadre { get; set; }
        void Iniciar(IVista mdiPadre = null);
        void NavegarA<TPresentador>(bool esDialogo = false, bool esMdiHijo = false)
            where TPresentador : IPresentador;
    }
}
