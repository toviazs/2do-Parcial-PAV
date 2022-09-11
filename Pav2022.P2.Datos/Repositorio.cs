using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Pav2022.P2.Datos
{
    /// <summary>
    /// Implementación del patrón Repository de forma genérica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repositorio<T> : IRepositorio<T>
        where T : EntidadBase
    {
        #region Members
        private readonly IUnidadDeTrabajoMarco _unidadDeTrabajo;
        #endregion

        #region Constructor
        /// <summary>
        /// Crea una nueva instancia del repositorio
        /// </summary>
        /// <param name="unidadDeTrabajo">Unit of Work asociada</param>
        public Repositorio(IUnidadDeTrabajoMarco unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo ?? throw new ArgumentNullException("unitOfWork");
        }
        #endregion

        public IUnidadDeTrabajo UnidadDeTrabajo => _unidadDeTrabajo;

        public void Agregar(T item)
        {
            if (item != null)
            {
                GetSet().Add(item);
            }
        }
        public void AgregarVarios(List<T> items)
        {
            DbSet<T> set = GetSet();
            foreach(T item in items)
            {
                if(item != null)
                {
                    set.Add(item);
                }
            }
        }

        public void Quitar(T item)
        {
            if (item != null)
            {
                GetSet().Remove(item);
            }
        }

        public void Modificar(T item)
        {
            if (item != null)
            {
                _unidadDeTrabajo.SetModificado(item);
            }
        }
        public void ModificarVarios(List<T> items)
        {
            foreach(T item in items)
            {
                if(item != null)
                {
                    _unidadDeTrabajo.SetModificado(item);
                }
            }
        }

        public T Get(int id)
        {
            return id != 0 ? GetSet().Find(id) : null;
        }

        public IEnumerable<T> GetTodos()
        {
            return GetSet();
        }

        public IEnumerable<T> GetConFiltro(Expression<Func<T, bool>> filtro)
        {
            return GetSet().Where(filtro);
        }

        public void DescartarCambios()
        {
            _unidadDeTrabajo.RevertirCambios();
        }

        public void Refrescar(T item)
        {
            if (item != null)
            {
                _unidadDeTrabajo.Refrescar(item);
            }
        }

        #region IDisposable Miembros
        /// <summary>
        /// <see cref="M:System.IDisposable.Dispose"/>
        /// </summary>
        public void Dispose()
        {
            _unidadDeTrabajo?.Dispose();
        }
        #endregion

        #region Métodos Privados
        DbSet<T> GetSet()
        {
            return _unidadDeTrabajo.CrearSet<T>();
        }
        #endregion
    }
}
