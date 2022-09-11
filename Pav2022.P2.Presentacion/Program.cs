using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Datos;
using Pav2022.P2.InfraestructuraTransversal.IoC;
using Pav2022.P2.Presentacion.IoC;
using Pav2022.P2.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new IoCContenedorUnity();
            IoCFabrica.Instancia.SetContenedor(container);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AdministradorDeTareas.Instance.Iniciar<PrincipalTarea>();
            Application.Run(Application.OpenForms[0]);
        }
    }
}
