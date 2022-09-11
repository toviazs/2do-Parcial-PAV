using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface IRegistrarPedidoVista : IVista
    {
        //void EnlazarControles();
        //void InicializarEnlaces();
        void SetDescripcion(string descripcion);
        void SetPrecio(string precio);
        void SetMonto(string monto);
        void Ocultar();
        void Limpiar();
        void MostrarMensaje(string mensaje, string titulo, TipoMensaje tipo);
        void ActualizarTablaLineasPedido(List<LineaPedido> lineasPedidos);
    }
}
