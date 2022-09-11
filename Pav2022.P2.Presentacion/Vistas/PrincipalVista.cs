using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Vistas
{
    public partial class PrincipalVista : PrincipalVistaConPresentador, IPrincipalVista
    {
        public PrincipalVista()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentador.IniciarProductos();
        }

        private void MostrarAdvertencia()
        {
            MessageBox.Show("", "ADVERTENCIA", MessageBoxButtons.OK);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentador.IniciarPedidos();
        }
    }

    public class PrincipalVistaConPresentador : VistaBaseGenerica<PrincipalPresentador> { }
}
