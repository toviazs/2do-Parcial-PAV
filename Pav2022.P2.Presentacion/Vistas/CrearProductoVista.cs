using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion.Vistas
{
    public partial class CrearProductoVista : CrearProductoVistaConPresentador, ICrearProductoVista
    {
        private Producto _prodTemporal;
        public CrearProductoVista()
        {
            InitializeComponent();
            InicializarEnlaces();
        }

        public void Cerrar()
        {
            Dispose();
        }

        public void EnlazarControles()
        {
            _prodTemporal = new Producto();
            bsProducto.DataSource = _prodTemporal;
        }

        public void InicializarEnlaces()
        {
            _prodTemporal = new Producto();
            bsProducto.DataSource = _prodTemporal;

            CodigoTxt.DataBindings.Add(new Binding("Text", bsProducto, "Codigo"));
            DescripcionTxt.DataBindings.Add(new Binding("Text", bsProducto, "Descripcion"));
            PrecioTxt.DataBindings.Add(new Binding("Text", bsProducto, "Precio", true, DataSourceUpdateMode.OnPropertyChanged));
            TiempoPrepTxt.DataBindings.Add(new Binding("Text", bsProducto, "TiempoDePreparacion"));
        }

        public void MostrarMensaje(string mensaje, string titulo, TipoMensaje tipo)
        {
            MessageBoxIcon icono = (tipo == TipoMensaje.Aviso) ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            _ = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void AgregarProdBtn_Click(object sender, EventArgs e)
        {
            Presentador.AgregarProducto(_prodTemporal);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }

    public class CrearProductoVistaConPresentador : VistaBaseGenerica<CrearProductoPresentador> { }
}
