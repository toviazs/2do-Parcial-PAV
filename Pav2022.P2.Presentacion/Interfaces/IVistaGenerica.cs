﻿using Pav2022.P2.Presentacion.Presentadores;
using Pav2022.P2.Presentacion.Vistas;

namespace Pav2022.P2.Presentacion.Interfaces
{
    /// <summary>
    /// Extensión genérica de la interfaz <see cref="IVista"/>.
    /// Tiene una asociación fuertemente tipada al presentador.
    /// <para>
    /// En vez de implementar esta interfaz directamente conviene heredar
    /// de la clase base <see cref="VistaBaseGenerica{T}"/> que implementa esta interfaz.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Tipo esperado del presentador asociado. Debe ser un subtipo
    /// de <see cref="IPresentador"/></typeparam>
    public interface IVista<T>: IVista
        where T: IPresentador
    {
        /// <summary>
        /// Propiedad para acceder al presentador asociado.
        /// <para>
        /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
        /// definido en la interfaz <see cref="IVista"/>
        /// </para>
        /// </summary>
        new T Presentador { get; set; }
    }
}
