using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Dominio.Entidades
{
    /// <summary>
    /// Clase base para las entidades del dominio
    /// </summary>
    public abstract class EntidadBase
    {
        public virtual int Id { get; set; }

        public virtual bool EsNuevo()
        {
            return Id == 0;
        }
    }
}
