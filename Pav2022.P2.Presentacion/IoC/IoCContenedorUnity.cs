using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Datos;
using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.InfraestructuraTransversal.IoC;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;
using Pav2022.P2.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Unity;
using Unity.Injection;

namespace Pav2022.P2.Presentacion.IoC
{
    public class IoCContenedorUnity : IContenedor
    {
        private readonly UnityContainer _contenedor;

        public IoCContenedorUnity()
        {
            _contenedor = new UnityContainer();
            Configurar();
        }

        private void Configurar()
        {
            var conexion = ConfigurationManager.ConnectionStrings["LosPedidosConexion"].ConnectionString;
            var options = new DbContextOptionsBuilder<LosPedidosContexto>()
               .UseSqlServer(conexion)
               .Options;
            _contenedor.RegisterType<IUnidadDeTrabajoMarco, LosPedidosContexto>(new InjectionConstructor(options));
            _contenedor.RegisterType(typeof(IRepositorio<>), typeof(Repositorio<>));
            _contenedor.RegisterType<IPrincipalVista, PrincipalVista>();
            _contenedor.RegisterType<ICrearProductoVista, CrearProductoVista>();
            _contenedor.RegisterType<IRegistrarPedidoVista, RegistrarPedidoVista>();
            _contenedor.RegisterType<IPedidoVista, PedidoVista>();
        }

        public void RegistrarTipo(Type tipo)
        {
            _contenedor.RegisterType(tipo);
        }

        public T Resolver<T>()
        {
            return _contenedor.Resolve<T>();
        }
    }
}
