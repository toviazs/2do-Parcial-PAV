using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface ICrearProductoVista: IVista
    {
        void EnlazarControles();
        void InicializarEnlaces();
        void MostrarMensaje(string mensaje, string titulo, TipoMensaje tipo);
        void Cerrar();
        //void Mostrar();
        //void Cerrar();
        //void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo);
        //void SetCostoCITxt(string texto);
        //void SetPrecioFinalTxt(string texto);
        //void SetMargenGnancia(string texto);
    }
}
