using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;
using Pav2022.P2.InfraestructuraTransversal.IoC;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class PedidoPresentador : PresentadorBase<PedidoTarea, IPedidoVista>
    {
        private readonly IRepositorio<Pedido> _repositorio;
        private readonly IRepositorio<Producto> _repoProductos;

        private readonly IRegistrarPedidoVista _vistaRegistro;

        public List<LineaPedido> LineasPedidoActuales = new List<LineaPedido>();
        public Pedido PedidoActual;
        public List<Pedido> Pedidos = new List<Pedido>();
        public Producto ProdTemporal;
        public Stack<RelojPedido> Relojes = new Stack<RelojPedido>();

        public event EventHandler Hola;
        public PedidoPresentador(IPedidoVista vistaPedido, IRegistrarPedidoVista vistaRegistro,
            IRepositorio<Pedido> repositorio, IRepositorio<Producto> repoProductos) : base(vistaPedido)
        {
            _repositorio = repositorio;
            _vistaRegistro = vistaRegistro;
            _repoProductos = repoProductos;
            Pedidos = _repositorio.GetTodos().ToList();
        }
        public void InicializarVista()
        {
            var listos = _repositorio.GetConFiltro(p => p.EstadoActual == Estado.Listo).ToList();
            var pendientes = _repositorio.GetConFiltro(p => p.EstadoActual == Estado.Pendiente).ToList();

            Vista.CargarListaPedidosListos(listos);
            Vista.CargarListaPedidosPendientes(pendientes);
        }
        public void IniciarRegistroPedido()
        {
            //ProdTemporal = null;
            //LineasPedidoActuales = new List<LineaPedido>();

            //_vistaRegistro.Presentador = this;
            //_vistaRegistro.MostrarComoDialogo();
            AdministradorDeTareas.Instance.Iniciar<RegistrarPedidoPresentador>(Vista);
        }

        public void BuscarProducto(string codigoStr)
        {
            if (int.TryParse(codigoStr, out int codigo))
            {
                var productos = _repoProductos.GetConFiltro(p => p.Codigo == codigo);
                if (productos.Count() == 0) return;
                
                ProdTemporal = productos.First();
                

                if (ProdTemporal != null)
                {
                    _vistaRegistro.SetDescripcion(ProdTemporal.Descripcion);
                    _vistaRegistro.SetPrecio(ProdTemporal.Precio.ToString());
                }
            }
            else
            {
                ProdTemporal = null;
            }
        }

        public void AgregarLineaPedido(int cantidad)
        {
            if (ProdTemporal != null)
            {
                LineasPedidoActuales.Add(new LineaPedido(ProdTemporal, cantidad));
                _vistaRegistro.MostrarMensaje("Linea de pedido ingresada correctamente", "Linea agregada", TipoMensaje.Aviso);
                _vistaRegistro.ActualizarTablaLineasPedido(LineasPedidoActuales);
                _vistaRegistro.Limpiar();
            }
            else
            {
                _vistaRegistro.MostrarMensaje("Error al ingresar la linea de pedido, revise los campos",
                    "Error", TipoMensaje.Error);
            }
        }
        public void AgregarPedido()
        {
            if (LineasPedidoActuales.Count == 0)
            {
                _vistaRegistro.MostrarMensaje("Error al agregar el pedido, agregue lineas de pedido", "Error en el pedido", TipoMensaje.Error);
            }
            else
            {
                PedidoActual = new Pedido();
                PedidoActual.CalcularTiempoPreparacion(LineasPedidoActuales);
                PedidoActual.GenerarNumeroPedido(Pedidos);
                PedidoActual.IniciarPedido();

                _repositorio.Agregar(PedidoActual);
                _repositorio.UnidadDeTrabajo.Confirmar();
                PedidoActual.LineaPedidos = LineasPedidoActuales;
                _repositorio.Modificar(PedidoActual);
                _repositorio.UnidadDeTrabajo.Confirmar();

                Pedidos.Add(PedidoActual);

                _vistaRegistro.MostrarMensaje("Pedido ingresado correctamente", "Exito al ingresar pedido", TipoMensaje.Aviso);

                PrepararEvento();
                InicializarVista();
                ReiniciarRegistrarPedido();
            }
        }
        public void PrepararEvento()
        {
            var relojActual = new RelojPedido(PedidoActual.TiempoPreparacion * 1000, PedidoActual);
            Relojes.Push(relojActual);
            relojActual.Start();
            relojActual.Elapsed += OnElapsed;
        }
        public void OnElapsed(Object source, EventArgs e)
        {
            RelojPedido reloj = (RelojPedido)source;
            reloj.Pedido.EstadoActual = Estado.Listo;
            _repositorio.Modificar(reloj.Pedido);
            _repositorio.UnidadDeTrabajo.Confirmar();
            InicializarVista();
        }
        public void ActualizarMonto(int cantidad)
        {
            if (ProdTemporal != null)
            {
                var monto = cantidad * ProdTemporal.Precio;
                _vistaRegistro.SetMonto(monto.ToString());
            }
        }
        public void ReiniciarRegistrarPedido()
        {
            _vistaRegistro.Ocultar();
            _vistaRegistro.Limpiar();
            LineasPedidoActuales = new List<LineaPedido>();
            _vistaRegistro.ActualizarTablaLineasPedido(LineasPedidoActuales);
        }
    }
}
