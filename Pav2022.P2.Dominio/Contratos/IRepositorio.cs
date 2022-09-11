using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Pav2022.P2.Dominio.Contratos
{
    /// <summary>
    /// Contrato de Repositorio basado en el patrón Repository
    /// </summary>
    /// <example>Ver Guía de Arquitectura N-Capas Orientada al Dominio con .NET 4.0 - Pag. 102</example>
    /// <remarks>
    /// Implementación parcial del patrón
    /// </remarks>
    /// <typeparam name="T">Cualquier entidad del dominio que herede de EntityBase</typeparam>
    public interface IRepositorio<T> : IDisposable
        where T : EntidadBase
    {
        IUnidadDeTrabajo UnidadDeTrabajo { get; }
        void Agregar(T item);
        void AgregarVarios(List<T> items);
        void Quitar(T item);
        void Modificar(T item);
        void ModificarVarios(List<T> items);
        T Get(int id);
        IEnumerable<T> GetTodos();
        IEnumerable<T> GetConFiltro(Expression<Func<T, bool>> filtro);
        void DescartarCambios();
        void Refrescar(T item);
    }
}
