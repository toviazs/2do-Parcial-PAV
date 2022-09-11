using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.InfraestructuraTransversal.IoC
{
    /// <summary>
    /// Contrato base para registrar y resolver dependencias
    /// </summary>
    public interface IContenedor
    {
        T Resolver<T>();
        void RegistrarTipo(Type tipo);
    }
}
