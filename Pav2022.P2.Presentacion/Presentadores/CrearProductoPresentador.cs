using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Vistas;
using Pav2022.P2.Dominio;
using Pav2022.P2.Presentacion.Tareas;
using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;
using Pav2022.P2.Datos;
using System.Linq;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class CrearProductoPresentador: PresentadorBase<TareaBase, ICrearProductoVista>
    {
        private readonly IRepositorio<Producto> _repositorio;

        public CrearProductoPresentador(ICrearProductoVista vista, 
            IRepositorio<Producto> repositorio): base(vista)
        {
            _repositorio = repositorio;
        }
        public void AgregarProducto(Producto producto)
        {
            if (ValidarCampos(producto))
            {
                _repositorio.Agregar(producto);
                Vista.MostrarMensaje("Producto ingresado correctamente",
                    "Alta exitosa", TipoMensaje.Aviso);
                _repositorio.UnidadDeTrabajo.Confirmar();
                Vista.EnlazarControles();
            }
            else
            {
                Vista.MostrarMensaje("Valor/es inválido/s en el/los campo/s",
                    "Error", TipoMensaje.Error);
            }
        }
        public bool ValidarCampos(Producto producto)
        {
            if (ComprobarDisponibilidadCodigo(producto.Codigo) &&
                producto.Descripcion != "" && producto.Precio > 0 &&
                producto.TiempoDePreparacion > 0 &&
                producto.Codigo > 0
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ComprobarDisponibilidadCodigo(int codigo)
        {
            var productos = _repositorio.GetConFiltro(p => p.Codigo == codigo);
            return productos.Count() == 0;
        }
    }
}
