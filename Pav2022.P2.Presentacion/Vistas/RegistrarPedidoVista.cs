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
using static Pav2022.P2.Presentacion.Vistas.RegistrarPedidoVista;

namespace Pav2022.P2.Presentacion.Vistas
{
    public partial class RegistrarPedidoVista : RegistrarPedidoVistaConPresentador, IRegistrarPedidoVista
    {
        public RegistrarPedidoVista()
        {
            InitializeComponent();
        }

        public void SetDescripcion(string descripcion)
        {
            DescripcionTxt.Text = descripcion;
        }

        public void SetPrecio(string precio)
        {
            PrecioTxt.Text = precio;
        }

        //public void EnlazarControles()
        //{
        //    throw new NotImplementedException();
        //}

        //public void InicializarEnlaces()
        //{
        //    _lineaPedidoTemporal = new LineaPedido();
        //    bsLineaPedido.DataSource = _lineaPedidoTemporal;

        //    CantidadTxt.DataBindings.Add(new Binding("Text", bsLineaPedido, "Codigo"));
        //    MontoTxt.DataBindings.Add(new Binding("Text", bsLineaPedido, "Descripcion"));
        //    PrecioTxt.DataBindings.Add(new Binding("Text", bsProducto, "Precio", true, DataSourceUpdateMode.OnPropertyChanged));
        //    TiempoPrepTxt.DataBindings.Add(new Binding("Text", bsProducto, "TiempoDePreparacion"));
        //}

        private void CodigoTxt_Leave(object sender, EventArgs e)
        {
            Presentador.BuscarProducto(CodigoTxt.Text);
            Presentador.ActualizarMonto((int)CantidadTxt.Value);
        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            Presentador.AgregarLineaPedido((int)CantidadTxt.Value);
        }

        public void Cerrar()
        {
            Dispose();
        }

        public void MostrarMensaje(string mensaje, string titulo, TipoMensaje tipo)
        {
            MessageBoxIcon icono = (tipo == TipoMensaje.Aviso) ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            _ = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void ConfirmarPedidoBtn_Click(object sender, EventArgs e)
        {
            Presentador.AgregarPedido();
        }

        public void SetMonto(string monto)
        {
            MontoTxt.Text = monto;
        }

        private void CantidadTxt_ValueChanged(object sender, EventArgs e)
        {
            Presentador.ActualizarMonto((int)CantidadTxt.Value);
        }

        public void ActualizarTablaLineasPedido(List<LineaPedido> lineasPedidos)
        {
            PedidoActualDGV.DataSource = lineasPedidos;
        }

        public void Ocultar()
        {
            Hide();
        }

        public void Limpiar()
        {
            CodigoTxt.ResetText();
            PrecioTxt.ResetText();
            DescripcionTxt.ResetText();
            CantidadTxt.ResetText();
            MontoTxt.ResetText();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Presentador.ReiniciarRegistrarPedido();
        }
    }
    public class RegistrarPedidoVistaConPresentador : VistaBaseGenerica<RegistrarPedidoPresentador> { }
}
