using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Pav2022.P2.Presentacion.Tareas;
using System.Linq;
using Pav2022.P2.Dominio.Enumeraciones;

namespace Pav2022.P2.Presentacion.Presentadores
{
    //public class RegistrarPedidoPresentador : PresentadorBase<RegistrarPedidoTarea, IRegistrarPedidoVista>
    //{
    //    public List<LineaPedido> LineasPedidoActuales = new List<LineaPedido>();
    //    public Pedido PedidoActual;
    //    public Producto ProdTemporal;

    //    private readonly IRepositorio<Pedido> _repositorio;
    //    private readonly IRepositorio<Producto> _repoProductos;
    //    public RegistrarPedidoPresentador(IRegistrarPedidoVista vista,
    //        IRepositorio<Pedido> repositorio, IRepositorio<Producto> repoProductos) : base(vista)
    //    {
    //        _repositorio = repositorio;
    //        _repoProductos = repoProductos;
    //    }
    //    public void BuscarProducto(string codigoStr)
    //    {
    //        if (int.TryParse(codigoStr, out int codigo))
    //        {
    //            ProdTemporal = _repoProductos.Get(codigo);
    //            ProdTemporal = _repoProductos.GetConFiltro(p => p.Codigo == codigo).First();

    //            if (ProdTemporal != null)
    //            {
    //                Vista.SetDescripcion(ProdTemporal.Descripcion);
    //                Vista.SetPrecio(ProdTemporal.Precio.ToString());
    //            }
    //        }
    //        else
    //        {
    //            ProdTemporal = null;
    //        }
    //    }

    //    public void AgregarLineaPedido(int cantidad)
    //    {
    //        if (ProdTemporal != null)
    //        {
    //            LineasPedidoActuales.Add(new LineaPedido(ProdTemporal, cantidad));
    //            Vista.MostrarMensaje("Linea de pedido ingresada correctamente", "Linea agregada", TipoMensaje.Aviso);
    //            Vista.ActualizarTablaLineasPedido(LineasPedidoActuales);
    //        }
    //        else
    //        {
    //            Vista.MostrarMensaje("Error al ingresar la linea de pedido, revise los campos",
    //                "Error", TipoMensaje.Error);
    //        }
    //    }
    //    public void AgregarPedido()
    //    {
    //        if (LineasPedidoActuales.Count == 0)
    //        {
    //            Vista.MostrarMensaje("Error al agregar el pedido", "Error en el pedido", TipoMensaje.Error);
    //        }
    //        else
    //        {
    //            PedidoActual = new Pedido(LineasPedidoActuales, _repositorio.GetTodos().ToList());
    //            Vista.MostrarMensaje("Pedido ingresado correctamente", "Exito al ingresar pedido", TipoMensaje.Aviso);
    //            Vista.Cerrar();
    //        }
    //    }
    //    public void ActualizarMonto(int cantidad)
    //    {
    //        if (ProdTemporal != null)
    //        {
    //            var monto = cantidad * ProdTemporal.Precio;
    //            Vista.SetMonto(monto.ToString());
    //        }
    //    }
    //}
    public class RegistrarPedidoPresentador : PresentadorBase<RegistrarPedidoTarea, IRegistrarPedidoVista>
    {
        private readonly IRepositorio<Pedido> _repositorio;
        private readonly IRepositorio<Producto> _repoProductos;

        private readonly IRegistrarPedidoVista _vistaRegistro;

        public List<LineaPedido> LineasPedidoActuales = new List<LineaPedido>();
        public Pedido PedidoActual;
        public Producto ProdTemporal = new Producto();
        public List<Pedido> Pedidos { get; set; }

        public event EventHandler Hola;
        public RegistrarPedidoPresentador(IRegistrarPedidoVista vista,  IRepositorio<Pedido> repositorio, 
            IRepositorio<Producto> repoProductos) : base(vista)
        {
            _repositorio = repositorio;
            _repoProductos = repoProductos;
            Pedidos = _repositorio.GetTodos().ToList();
        }
        public void IniciarRegistroPedido()
        {
            ProdTemporal = null;
            LineasPedidoActuales = new List<LineaPedido>();

            _vistaRegistro.Presentador = this;
            _vistaRegistro.MostrarComoDialogo();
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
                //InicializarVista();
                ReiniciarRegistrarPedido();
            }
        }
        public void PrepararEvento()
        {
            //var relojActual = new RelojPedido(PedidoActual.TiempoPreparacion * 1000, PedidoActual);
            //Relojes.Push(relojActual);
            //relojActual.Start();
            //relojActual.Elapsed += OnElapsed;
        }
        public void OnElapsed(Object source, EventArgs e)
        {
            RelojPedido reloj = (RelojPedido)source;
            reloj.Pedido.EstadoActual = Estado.Listo;
            _repositorio.Modificar(reloj.Pedido);
            _repositorio.UnidadDeTrabajo.Confirmar();
            //InicializarVista();
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
