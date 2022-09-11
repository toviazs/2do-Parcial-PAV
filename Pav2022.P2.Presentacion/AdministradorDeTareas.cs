using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav2022.P2.InfraestructuraTransversal.IoC;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;

namespace Pav2022.P2.Presentacion
{
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas _instance;
        private static readonly object _syncLock = new object();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdministradorDeTareas();
                    }
                }
                return _instance;
            }
        }
        #endregion

        public void Iniciar<TTarea>(IVista mdiPadre = null)
            where TTarea : ITarea
        {
            var tarea = IoCFabrica.Instancia.Crear<TTarea>();
            tarea.Iniciar(mdiPadre);
        }
    }
}
