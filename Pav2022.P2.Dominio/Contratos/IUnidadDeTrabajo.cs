using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Dominio.Contratos
{
    /// <summary>
    /// Contrato para el patrón UnitOfWork 
    /// En esta solución la Unit of Work se implementa utilizando el motor de persistencia
    /// de Entity Framework.
    /// Pero para cumplir con el principio PI (Persistence Ignorant) en el dominio se
    /// debe implementar este contrato. Que debe ser cumplido por cualquier implementación
    /// de UoW que se utilice en este dominio.
    /// <see cref="http://martinfowler.com/eaaCatalog/unitOfWork.html"/>
    /// <seealso cref="http://msdn.microsoft.com/en-us/magazine/dd882510.aspx"/>
    /// <remarks>
    /// Implementación parcial del patrón
    /// </remarks>
    /// </summary>
    public interface IUnidadDeTrabajo
        : IDisposable
    {
        /// <summary>
        /// Confirmar todos los cambios realizados en el contexto.
        /// </summary>
        void Confirmar();

        /// <summary>
        /// Revertir los cambios registrados. Ver referencias del patrón UnitOfWork.
        /// </summary>
        void RevertirCambios();
    }
}
