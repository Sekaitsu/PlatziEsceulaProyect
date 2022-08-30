using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    public interface ILugar
    {
        string Direccion { get; set; }
        void limpiarLugar();
    }
}
