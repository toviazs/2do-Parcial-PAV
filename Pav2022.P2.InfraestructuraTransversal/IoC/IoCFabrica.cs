using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.InfraestructuraTransversal.IoC
{
    public class IoCFabrica
    {
        private static volatile IoCFabrica _instancia;
        private static readonly object _syncLock = new object();
        
        private IoCFabrica()
        {
            
        }

        private IContenedor _contenedor;

        public static IoCFabrica Instancia
        {
            get
            {
                if (_instancia != null) return _instancia;
                lock (_syncLock) 
                { 
                    if (_instancia == null)
                    {
                        _instancia = new IoCFabrica();
                    }
                }
                return _instancia;
            }
        }

        public IContenedor ContenedorActual
        {
            get
            {
                if (_contenedor == null)
                    throw new InvalidOperationException("Contenedor no configurado");
                return _contenedor;
            }
        }

        public void SetContenedor(IContenedor contenedor)
        {
            _contenedor = contenedor;
        }

        public T Crear<T>()
        {
            return _contenedor.Resolver<T>();
        }
    }
}
